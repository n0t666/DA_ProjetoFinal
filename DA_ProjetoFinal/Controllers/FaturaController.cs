using QuestPDF.Fluent;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;

namespace DA_ProjetoFinal
{
    internal class FaturaController
    {
        public static bool Adicionar(decimal total, int menuId, DateTime data, int clienteId, List<Extra>Extras,int multaId = -1)
        {
            try
            {
                using (var context = new CantinaContext())
                {
                    Multa multa = context.Multas.Find(multaId);
                    List<ItemFatura> items = new List<ItemFatura>();
                    Cliente cliente = context.Clientes.Find(clienteId);
                    Menu menu = context.Menus
                        .Include(m => m.Prato)
                        .Include(m => m.Extra)
                        .FirstOrDefault(m => m.Id == menuId);
                    foreach (var extra in Extras)
                    {
                        ItemFatura item = new ItemFatura()
                        {
                            Descricao = extra.Descricao,
                            Preco = extra.Preco
                        };
                        items.Add(item);
                    }

                    Fatura fatura = new Fatura()
                    {
                        Total = total,
                        Menu = menu,
                        Data = data,
                        Cliente = cliente,
                        ItemFatura = items
                    };

                    DocumentoFatura documento;


                    if (multa != null)
                    {
                        documento = new DocumentoFatura(fatura, multa);
                    }
                    else
                    {
                         documento = new DocumentoFatura(fatura);
                    }
                    
                    var pdf = documento.GeneratePdf();

                    FileDialog fileDialog = new SaveFileDialog();
                    fileDialog.Filter = "PDF files (*.pdf)|*.pdf";
                    fileDialog.Title = "Guardar Fatura";
                    fileDialog.ShowDialog();
                    if (fileDialog.FileName != "")
                    {
                        File.WriteAllBytes(fileDialog.FileName, pdf);
                    }

                    context.Faturas.Add(fatura);
                    context.SaveChanges();

                    return true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return false;

        }
    }
}
