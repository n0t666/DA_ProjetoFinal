using ReaLTaiizor.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DA_ProjetoFinal.Views
{
    public partial class FormSemana : Form_Borderless
    {

        private DateTime dataBase;
        private DateTime dataAtual;
        private DateTime inicioSemanaAtual;
        private DateTime fimSemanaAtual;
        private List<Menu> menus;

        public FormSemana(DateTime data)
        {
            InitializeComponent();
            PreencherSemana(data);
            criarEventosPanel(panelTop);
            dataBase = data;
            dataAtual = data;
        }

        private void PreencherSemana(DateTime data)
        {
            DateTime inicioSemanaAtual = UtilityController.GetWeeKStart(data);
            DateTime fimSemanaAtual = inicioSemanaAtual.AddDays(4);
            menus = MenuController.GetBetweenDates(inicioSemanaAtual, fimSemanaAtual);
            data = inicioSemanaAtual;
            for (int i = 1; i < 6; i++)
            {
                Label label = (Label)panelSemana.Controls.Find("labelDia" + i.ToString(), true)[0];
                HopeRichTextBox txt = (HopeRichTextBox)panelSemana.Controls.Find("txtDay" + i.ToString(), true)[0];
                label.Text = data.ToShortDateString();
                data = data.AddDays(1);
                if(menus.Count > 0 && menus[i] != null)
                {
                    PreencherTextBox(txt, menus[i]);
                }
                else
                {
                    txt.Text = "Não existem menus disponíveis para este dia.";
                }
             

            }
            labelNumeroSemana.Text = "Semana Nº " + UtilityController.GetWeekNumber(data).ToString();
            labelSemanaRange.Text = "(" + inicioSemanaAtual.ToShortDateString() + " - " + fimSemanaAtual.ToShortDateString() + ")";
        }

        private void btnPreviousWeek_Click(object sender, EventArgs e)
        {
            dataAtual = dataAtual.AddDays(-7);
            PreencherSemana(dataAtual);
        }

        private void btnNextWeek_Click(object sender, EventArgs e)
        {
            dataAtual = dataAtual.AddDays(7);
            PreencherSemana(dataAtual);
        }

        private void btnCurrentDate_Click(object sender, EventArgs e)
        {
            dataAtual = dataBase;
            PreencherSemana(dataAtual);
        }

        private void PreencherTextBox(HopeRichTextBox control, Menu menu)
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("===== Detalhes do Menu =====");
            sb.AppendLine($"ID: {menu.Id}");
            sb.AppendLine($"Data e Hora: {menu.DataHora:dd/MM/yyyy HH:mm}");
            sb.AppendLine($"Quantidade: {menu.Quantidade}");
            sb.AppendLine($"Preço Estudante: {menu.PrecoEstudante:C}");
            sb.AppendLine($"Preço Professor: {menu.PrecoProfessor:C}");
            sb.AppendLine();

            sb.AppendLine("Extras:");
            if (menu.Extra != null && menu.Extra.Any())
            {
                foreach (var extra in menu.Extra)
                {
                    sb.AppendLine($" - {extra.Descricao}: {extra.Preco:C}");
                }
            }
            else
            {
                sb.AppendLine(" Nenhum extra disponível.");
            }
            sb.AppendLine();


            sb.AppendLine("Pratos:");
            if (menu.Prato != null && menu.Prato.Any())
            {
                foreach (var prato in menu.Prato)
                {
                    sb.AppendLine($" - {prato.Descricao}: {prato.Descricao:C}");
                }
            }
            else
            {
                sb.AppendLine(" Nenhum prato disponível.");
            }

            sb.AppendLine("===========================");

            control.Text = sb.ToString();

        }

        private void picClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            
        }
    }
}
