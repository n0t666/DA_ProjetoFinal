using QuestPDF.Fluent;
using QuestPDF.Helpers;
using QuestPDF.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace DA_ProjetoFinal
{
    internal class DocumentoFatura : IDocument
    {
        public static Image LogoImage { get; } = Image.FromFile("logo.png");

        public Fatura Model { get; }

        public Multa Multa { get; }

        public DocumentoFatura(Fatura model, Multa multa = null)
        {
            Model = model;
            Multa = multa;
        }

        public DocumentMetadata GetMetadata() => DocumentMetadata.Default;
        public DocumentSettings GetSettings() => DocumentSettings.Default;

        public void Compose(IDocumentContainer container)
        {
            container
                .Page(page =>
                {
                    page.Margin(50);

                    page.Header().Element(ComposeHeader);
                    page.Content().Element(ComposeContent);

                    page.Footer().AlignCenter().Text(text =>
                    {
                        text.CurrentPageNumber();
                        text.Span(" / ");
                        text.TotalPages();
                    });
                });
        }

        void ComposeHeader(IContainer container)
        {
            container.Row(row =>
            {
                row.RelativeItem().Column(column =>
                {
                    column
                        .Item().Text($"Fatura #{Model.Id}")
                        .FontSize(20).SemiBold().FontColor(Colors.Blue.Medium);

                    column.Item().Text(text =>
                    {
                        text.Span("Data de emissão: ").SemiBold();
                        text.Span($"{Model.Data:d}"); 
                    });
                    column.Item().Text(text =>
                    {
                        text.Span("Nome do cliente: ").SemiBold();
                        text.Span($"{Model.Cliente.Nome}");
                    });

                    if (Model.Cliente is Estudante)
                    {
                        column.Item().Text(text =>
                        {
                            text.Span("Tipo de cliente: ").SemiBold();
                            text.Span("Estudante");
                        });
                        column.Item().Text(text =>
                        {
                            text.Span("Número de estudante: ").SemiBold();
                            text.Span($"{(Model.Cliente as Estudante).NumEstudante}"); 
                        });
                    }
                    else
                    {
                        column.Item().Text(text =>
                        {
                            text.Span("Tipo de cliente: ").SemiBold();
                            text.Span("Professor");
                        });
                        column.Item().Text(text =>
                        {
                            text.Span("Email: ").SemiBold();
                            text.Span($"{(Model.Cliente as Professor).Email}"); 
                        });
                    }
                    column.Item().Text(text =>
                    {
                        text.Span("Total da reserva: ").SemiBold();
                        text.Span($"{Model.Total} €");
                    });
                    if (Multa != null)
                    {
                        column.Item().Text(text =>
                        {
                            text.Span("Multa" + "(" + Multa.NumeroHoras.ToString() + " Horas" + "): ").SemiBold();
                            text.Span($"{Multa.Valor} €");
                        });
                    }
                });

                row.ConstantItem(175).Background(Colors.Grey.Lighten2).Image(LogoImage);
            });
        }


    void ComposeContent(IContainer container)
        {
            container.PaddingVertical(40).Column(column =>
            {
                column.Spacing(20);

                column.Item().Element(ComposeMenu);

                column.Item().Text("Pratos selecionados:").FontSize(15).Bold();
                column.Item().Element(ComposeTablePratos);

                column.Item().Text("Extras selecionados:").FontSize(15).Bold();
                column.Item().Element(ComposeTable);

                if(Model.ItemFatura.Count > 0)
                {
                   
                var precoSub = Model.ItemFatura.Sum(x => x.Preco);
                column.Item().PaddingRight(5).AlignRight().Text("Subtotal:" + precoSub.ToString() + "€").SemiBold();
                }

            });

        }

        void ComposeTable(IContainer container)
        {
            var headerStyle = TextStyle.Default.SemiBold();

            container.Table(table =>
            {
                if (Model.ItemFatura.Count > 0)
                {
                    table.ColumnsDefinition(columns =>
                    {
                        columns.ConstantColumn(25);
                        columns.RelativeColumn(3);
                        columns.RelativeColumn();
                    });
                }
                else
                {
                    table.ColumnsDefinition(columns =>
                    {
                        columns.RelativeColumn(); 
                        columns.RelativeColumn();
                        columns.RelativeColumn();
                    });

                }

                table.Header(header =>
                {
                    header.Cell().Element(HeaderStyle).Text("#");
                    header.Cell().Element(HeaderStyle).Text("Produto").Style(headerStyle);
                    header.Cell().Element(HeaderStyle).AlignRight().Text("Preço unitário").Style(headerStyle);

                });
                if(Model.ItemFatura.Count > 0)
                {


                foreach (var item in Model.ItemFatura)
                {
                    var index = Model.ItemFatura.ToList().IndexOf(item) + 1;

                    table.Cell().Element(CellStyle).Text($"{index}");
                    table.Cell().Element(CellStyle).Text(item.Descricao);
                    table.Cell().Element(CellStyle).AlignRight().Text(item.Preco.ToString() + "€");

                }
                }else
                {
                    table.Cell().RowSpan(3).Element(CellStyleEmpty).Text("Sem extras").Style(TextStyle.Default.Italic());
                }

                IContainer HeaderStyle(IContainer cellContainer) =>
                    cellContainer.DefaultTextStyle(x => x.SemiBold())
                 .PaddingVertical(5)
                 .BorderBottom(1)
                 .BorderColor(Colors.Black);

                IContainer CellStyle(IContainer cellContainer) =>
                    cellContainer.BorderBottom(1)
                                 .BorderColor(Colors.Grey.Lighten2)
                                 .PaddingVertical(5);

                IContainer CellStyleEmpty(IContainer cellContainer) =>
                    cellContainer.BorderBottom(0)
                                 .PaddingVertical(5);
            });
        }

        void ComposeTablePratos(IContainer container)
        {
            var headerStyle = TextStyle.Default.SemiBold();
            container.Table(table =>
            {
                table.ColumnsDefinition(columns =>
                             {
                                 columns.ConstantColumn(25);
                                 columns.RelativeColumn(20);
                                 columns.RelativeColumn(30);
                             });

                table.Header(header =>
                {
                    header.Cell().Element(HeaderStyle).Text("#");
                    header.Cell().Element(HeaderStyle).Text("Descrição").Style(headerStyle);
                    header.Cell().Element(HeaderStyle).Text("Tipo de prato").Style(headerStyle);
                });

                foreach (var prato in Model.Menu.Prato)
                {
                    var index = Model.Menu.Prato.ToList().IndexOf(prato) + 1;

                    table.Cell().Element(CellStyle).Text($"{index}");
                    table.Cell().Element(CellStyle).Text(prato.Descricao);
                    table.Cell().Element(CellStyle).Text(prato.Tipo.ToString());
                }


                IContainer HeaderStyle(IContainer cellContainer) =>
                    cellContainer.DefaultTextStyle(x => x.SemiBold())
                 .PaddingVertical(5)
                 .BorderBottom(1)
                 .BorderColor(Colors.Black);

                IContainer CellStyle(IContainer cellContainer) =>
                  cellContainer.BorderBottom(1)
                 .BorderColor(Colors.Grey.Lighten2)
                 .PaddingVertical(5);


            });
        }

        // Componente que mostra o menu selecionado com os respetivos extras e pratos
        void ComposeMenu(IContainer container)
        {
            container.Background(Colors.Grey.Lighten3).Padding(10).Column(column =>
            {
                column.Spacing(5);
                column.Item().Text("Menu selecionado").FontSize(14).Bold();
                column.Item().Text("Data/hora: " + Model.Menu.DataHora.ToString("g")).FontSize(12); //g -> data e hora sem segundos
                column.Item().Text("Preço para estudante: " + Model.Menu.PrecoEstudante.ToString() + "€").FontSize(12);
                column.Item().Text("Preço para professor: " + Model.Menu.PrecoProfessor.ToString() + "€").FontSize(12);
                column.Item().Text("Extras disponíveis:").FontSize(12).SemiBold();
                foreach (var extra in Model.Menu.Extra)
                {
                    column.Item().Text(extra.Descricao + " - " + extra.Preco.ToString() + "€").FontSize(10);
                }
                column.Item().Text("Pratos disponíveis:").FontSize(12).SemiBold();
                foreach (var prato in Model.Menu.Prato)
                {
                    column.Item().Text(prato.Descricao + " - " + prato.Tipo.ToString()).FontSize(10);
                }
            });
        }





    }
}
