using DA_ProjetoFinal.Controllers;
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
    public partial class FormMultas : Form
    {

        //-----------------Variáveis relacionadas com a paginação-----------------
        private int tamanhoPagina = 10;
        private int paginaAtual = 1;
        //------------------------------------------------------------------------

        private List<Multa> multas;
        private List<Multa> multasPaginadas;
        private int numeroMultas;
        private Multa selectedMulta;


        public FormMultas()
        {
            InitializeComponent();
        }



        private void btnSubmit_Click(object sender, EventArgs e)
        {
            int numeroHoras = 0;
            try
            {
                numeroHoras = Convert.ToInt32(numHoras.Value);
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro ao ler o número de horas", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (numValor.Value <= 0)
            {
                MessageBox.Show("O valor da multa tem de ser superior a 0", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (numeroHoras <= 0)
            {
                MessageBox.Show("O número de horas tem de ser superior a 0", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (MultaController.Exists(numeroHoras))
            {
                MessageBox.Show("Já existe uma multa com o número de horas introduzido", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }
            else
            {
                if (MultaController.Adicionar(numValor.Value, numeroHoras))
                {
                    MessageBox.Show("Multa adicionada com sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Ocorreu um erro ao adicionar a multa", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

        }

        private void comboBoxMulta_SelectionChangeCommitted(object sender, EventArgs e)
        {
            obterDadosDropDown();
        }

        private void loadMulta()
        {
            multas = MultaController.Get();
            numeroMultas = multas.Count();
        }

        private void obterDadosMulta()
        {
            multasPaginadas = multas.Skip((paginaAtual - 1) * tamanhoPagina).Take(tamanhoPagina).ToList();
            comboBoxMulta.DataSource = multasPaginadas;
            comboBoxMulta.DisplayMember = "NumeroHorasDisplay";
            updatePagination();
            obterDadosDropDown(0);

        }

        private void updatePagination()
        {
            btnPaginateAvancar.Enabled = paginaAtual * tamanhoPagina < numeroMultas; // Verificar se é possível avançar para a próxima página
            btnPaginateVoltar.Enabled = paginaAtual > 1; // Verificar se é possível voltar para a página anterior
        }


        private void obterDadosDropDown(int indexEspecifico = -1)
        {
            if (comboBoxMulta.Items.Count > 0)
            {
                if (indexEspecifico >= 0)
                {
                    comboBoxMulta.SelectedItem = indexEspecifico;
                }
                Multa multa = (Multa)comboBoxMulta.SelectedItem;


                if (selectedMulta != null && multa.Id == selectedMulta.Id) // Verificar se o prato selecionado é o mesmo que o prato que está a ser mostrado, com base no id
                {
                    lblSelecionado.Text = "Selecionado";
                }
                else
                {
                    lblSelecionado.Text = "";
                }

                lblNumHoras.Text = multa.NumeroHoras.ToString() + "" + "Horas";
                lblValor.Text = multa.Valor.ToString() + "" + "€";

            }
            else
            {
                lblSelecionado.Text = "";
                lblNumHoras.Text = "";
                lblValor.Text = "";

                comboBoxMulta.DataSource = null;
                comboBoxMulta.SelectedItem = null;
                comboBoxMulta.ResetText();

            }
            tabPageListarMultas.Refresh(); // Necessário para atualizar os controlos, para certificar-se que os dados são mostrados corretamente
        }


        private void btnPaginateAvancar_Click_1(object sender, EventArgs e)
        {
            paginaAtual++;
            obterDadosMulta();
        }

        private void btnPaginateVoltar_Click_1(object sender, EventArgs e)
        {
            paginaAtual--;
            obterDadosMulta();

        }

        private void btnSelecionar_Click(object sender, EventArgs e)
        {
            if (comboBoxMulta.SelectedIndex >= 0)
            {
                if (selectedMulta != null && selectedMulta.Id == ((Multa)comboBoxMulta.SelectedItem).Id) // Se o extra já estiver selecionado, desseleciona o extra
                {
                    selectedMulta = null;
                    lblSelecionado.Text = "";
                }
                else // Caso contrário, seleciona o extra normalmente e armazena 
                {
                    selectedMulta = (Multa)comboBoxMulta.SelectedItem;
                    lblSelecionado.Text = "Selecionado";
                }

            }
        }

        private void btnApagar_Click(object sender, EventArgs e)
        {
            if (selectedMulta != null)
            {
                bool sucesso = MultaController.Apagar(selectedMulta.Id);
                if (sucesso)
                {
                    loadMulta();
                    obterDadosMulta();
                    MessageBox.Show("Funcionário apagado com sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Ocorreu um erro ao apagar o Funcionário", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            selectedMulta = null;
        }

        private void btnSubmitEdit_Click(object sender, EventArgs e)
        {
            int numeroHoras = 0;
            try
            {
                numeroHoras = Convert.ToInt32(numHorasEdit.Value);
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro ao ler o número de horas", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (numValorEdit.Value <= 0)
            {
                MessageBox.Show("O valor da multa tem de ser superior a 0", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (numeroHoras <= 0)
            {
                MessageBox.Show("O número de horas tem de ser superior a 0", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (MultaController.Exists(numeroHoras,selectedMulta.Id))
            {
                MessageBox.Show("Já existe uma multa com o número de horas introduzido", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                if (MultaController.Editar(selectedMulta.Id,numValorEdit.Value, numeroHoras))
                {
                    MessageBox.Show("Multa editada com sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    selectedMulta = null;
                    foreverTabPage1.SelectedIndex = 0;
                }
                else
                {
                    MessageBox.Show("Ocorreu um erro ao editar a multa", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

        }

        private void foreverTabPage1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (foreverTabPage1.SelectedIndex)
            {
                case 0:
                    break;
                case 1:
                    loadMulta();
                    obterDadosMulta();
                    break;
                case 2:
                    if (selectedMulta != null)
                    {
                        pnlSelecionadoEdit.Visible = true;
                        lblNotSelected.Visible = false;
                        numValorEdit.Value = selectedMulta.Valor;
                        numHorasEdit.Value = selectedMulta.NumeroHoras;
                    }
                    else
                    {
                        pnlSelecionadoEdit.Visible = false;
                        lblNotSelected.Visible = true;
                        lblNotSelected.Text = "Selecione uma multa para editar";
                    }
                    break;
            }

        }
    }
}

