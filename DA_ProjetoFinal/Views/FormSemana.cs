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

        public event EventHandler<DateTime> SemanaDataSelected;


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
            labelNumeroSemana.Text = "Semana Nº " + UtilityController.GetWeekNumber(data).ToString();
            labelSemanaRange.Text = "(" + inicioSemanaAtual.ToShortDateString() + " - " + fimSemanaAtual.AddDays(-1).ToShortDateString() + ")";

            for (int i = 1; i < 6; i++)
            {
                AirButton airButton = this.Controls.Find("btnSelecionar" + i.ToString(), true).FirstOrDefault() as AirButton;
                FlowLayoutPanel panel = this.Controls.Find("pnl" + i.ToString(), true).FirstOrDefault() as FlowLayoutPanel;
                DungeonHeaderLabel label = this.Controls.Find("labelDia" + i.ToString(), true).FirstOrDefault() as DungeonHeaderLabel;
                label.Text = inicioSemanaAtual.ToShortDateString(); 
                airButton.Text = "Criar menu para " + inicioSemanaAtual.ToShortDateString();

                List<Menu> menusForCurrentDate = menus.Where(menu => menu.DataHora.Date == inicioSemanaAtual.Date).ToList();
                if (menusForCurrentDate.Count > 0)
                {
                    foreach (Menu menu in menusForCurrentDate)
                    {
                        PreencherPanel(panel, menu); 
                    }
                }
                else
                {
                    DungeonHeaderLabel labelEmpty = new DungeonHeaderLabel();
                    labelEmpty.Text = "Sem menus disponíveis";
                    labelEmpty.Font = new Font("Segoe UI", 11, FontStyle.Bold);
                    labelEmpty.ForeColor = Color.Red;
                    label.AutoSize = true;
                    panel.Controls.Add(labelEmpty);
      
                }

                inicioSemanaAtual = inicioSemanaAtual.AddDays(1); 
            }

        }


        private void btnPreviousWeek_Click(object sender, EventArgs e)
        {
            dataAtual = dataAtual.AddDays(-7);
            LimparSemanas();
            PreencherSemana(dataAtual);
        }

        private void btnNextWeek_Click(object sender, EventArgs e)
        {
            dataAtual = dataAtual.AddDays(7);
            LimparSemanas();
            PreencherSemana(dataAtual);
        }

        private void btnCurrentDate_Click(object sender, EventArgs e)
        {
            dataAtual = dataBase;
            LimparSemanas();
            PreencherSemana(dataAtual);
        }

        private void PreencherPanel(FlowLayoutPanel control, Menu menu)
        {
            if (menu != null)
            {
               
                DungeonHeaderLabel label = new DungeonHeaderLabel();
                DungeonHeaderLabel labelExtraTitle = new DungeonHeaderLabel();
                DungeonHeaderLabel labelPratoTitle = new DungeonHeaderLabel();
                DungeonHeaderLabel labelQuantidade = new DungeonHeaderLabel();
                DungeonHeaderLabel labelPrecoEstudante = new DungeonHeaderLabel();
                DungeonHeaderLabel labelPrecoProfessor = new DungeonHeaderLabel();
                DungeonHeaderLabel finalSpace = new DungeonHeaderLabel();

                label.Padding = new Padding(0, 5, 0, 0);
                labelExtraTitle.Padding = new Padding(0, 5, 0, 5);
                labelPratoTitle.Padding = new Padding(0, 5, 0, 5);
                labelQuantidade.Padding = new Padding(0, 5, 0, 5);
                labelPrecoEstudante.Padding = new Padding(0, 5, 0, 5);
                labelPrecoProfessor.Padding = new Padding(0, 5, 0, 5);
                label.Text = "Data/hora: " + menu.DataHora.ToShortTimeString();
                label.AutoSize = true;
                labelExtraTitle.Text = "Extras:";
                labelExtraTitle.AutoSize = true;
                labelPratoTitle.Text = "Pratos:";
                labelPratoTitle.AutoSize = true;
                labelQuantidade.Text = "Quantidade: " + menu.Quantidade.ToString();
                labelQuantidade.AutoSize = true;
                labelPrecoEstudante.Text = "Preço Estudante: " + menu.PrecoEstudante.ToString() + "€";
                labelPrecoEstudante.AutoSize = true;
                labelPrecoProfessor.Text = "Preço Professor: " + menu.PrecoProfessor.ToString() + "€";
                labelPrecoProfessor.AutoSize = true;
                finalSpace.Text = "";
                control.Controls.Add(label);
                control.SetFlowBreak(label, true);
                control.Controls.Add(labelQuantidade);
                control.SetFlowBreak(labelQuantidade, true);
                control.Controls.Add(labelPrecoEstudante);
                control.SetFlowBreak(labelPrecoEstudante, true);
                control.Controls.Add(labelPrecoProfessor);
                control.SetFlowBreak(labelPrecoProfessor, true);
                control.Controls.Add(labelPratoTitle);
                control.SetFlowBreak(labelPratoTitle, true);

                foreach (var prato in menu.Prato)
                {
                    DungeonHeaderLabel labelPrato = new DungeonHeaderLabel();
                    labelPrato.Padding = new Padding(0, 0, 0,5);
                    labelPrato.Font = new Font("Segoe UI", 11, FontStyle.Regular); 
                    labelPrato.Text = prato.Descricao;
                    labelPrato.AutoSize = true;
                    control.Controls.Add(labelPrato);
                    control.SetFlowBreak(labelPrato, true);
                }


                control.Controls.Add(labelExtraTitle);
                control.SetFlowBreak(labelExtraTitle, true);


                foreach (var extra in menu.Extra)
                {
                    DungeonHeaderLabel labelExtra = new DungeonHeaderLabel();
                    labelExtra.Padding = new Padding(0, 0, 0, 5);
                    labelExtra.Font = new Font("Segoe UI", 11, FontStyle.Regular);
                    labelExtra.Text = extra.Descricao;
                    labelExtra.AutoSize = true;
                    control.Controls.Add(labelExtra);
                    control.SetFlowBreak(labelExtra, true);
                }
                finalSpace.Padding = new Padding(0, 0, 0, 10);
                control.Controls.Add(finalSpace);
                control.SetFlowBreak(finalSpace, true);
                

            }
        }


        private void picClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            
        }

        private void LimparSemanas()
        {
            for (int i = 1; i < 6; i++)
            {
                FlowLayoutPanel panel = this.Controls.Find("pnl" + i.ToString(), true).FirstOrDefault() as FlowLayoutPanel;
                panel.Controls.Clear();
                panel.AutoScroll = false;
                panel.PerformLayout();
                panel.AutoScroll = true;  
            }
            this.Refresh();
        }

        private void btnSelecionar1_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(labelDia1.Text))
            {
                string diaString = labelDia1.Text;
                DateTime data = UtilityController.ConvertFromString(diaString).Value;
                if(data != null)
                {
                    MessageBox.Show("Data: " + diaString, "Data", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    SemanaDataSelected?.Invoke(this, data);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Ocorreu um erro ao tentar obter a data", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                    
                }
            }
            else
            {
                MessageBox.Show("Não foi possível obter a data", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

        }

        private void btnSelecionar2_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(labelDia2.Text))
            {
                string diaString = labelDia2.Text;
                DateTime data = UtilityController.ConvertFromString(diaString).Value;
                if (data != null)
                {
                    MessageBox.Show("Data: " + diaString, "Data", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    SemanaDataSelected?.Invoke(this, data);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Ocorreu um erro ao tentar obter a data", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;

                }
            }
            else
            {
                MessageBox.Show("Não foi possível obter a data", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void btnSelecionar3_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(labelDia3.Text))
            {
                string diaString = labelDia3.Text;
                DateTime data = UtilityController.ConvertFromString(diaString).Value;
                if (data != null)
                {
                    MessageBox.Show("Data: " + diaString, "Data", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    SemanaDataSelected?.Invoke(this, data);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Ocorreu um erro ao tentar obter a data", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;

                }
            }
            else
            {
                MessageBox.Show("Não foi possível obter a data", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void btnSelecionar4_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(labelDia4.Text))
            {
                string diaString = labelDia4.Text;
                DateTime data = UtilityController.ConvertFromString(diaString).Value;
                if (data != null)
                {
                    MessageBox.Show("Data: " + diaString, "Data", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    SemanaDataSelected?.Invoke(this, data);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Ocorreu um erro ao tentar obter a data", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;

                }
            }
            else
            {
                MessageBox.Show("Não foi possível obter a data", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void btnSelecionar5_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(labelDia5.Text))
            {
                string diaString = labelDia5.Text;
                DateTime data = UtilityController.ConvertFromString(diaString).Value;
                if (data != null)
                {
                    MessageBox.Show("Data: " + diaString, "Data", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    SemanaDataSelected?.Invoke(this, data);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Ocorreu um erro ao tentar obter a data", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;

                }
            }
            else
            {
                MessageBox.Show("Não foi possível obter a data", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
    }
}
