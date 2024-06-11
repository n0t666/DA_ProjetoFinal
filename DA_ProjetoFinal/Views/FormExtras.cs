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
    public partial class FormExtras : Form
    {
        //-----------------Variáveis relacionadas com a paginação-----------------
        private int tamanhoPagina = 6;
        private int paginaAtual = 1;
        private List<Extra> extrasPaginados;
        private int numeroExtras;
        //------------------------------------------------------------------------


        private List<Extra> extras;
        private Extra selectedExtra;

        public FormExtras()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtDescricao.Text) || string.IsNullOrEmpty(txtPreco.Text)) // Verificar se os campos são inválidos, se forem, mostra uma mensagem de erro
            {
                MessageBox.Show("Preencha todos os campos", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (!(UtilityController.GetDecimal(txtPreco.Text, "preço") > 0))
            {
                MessageBox.Show("O preço tem de ser superior a 0", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                bool sucesso;
                decimal preco = UtilityController.GetDecimal(txtPreco.Text, "preço");
       
                    sucesso = ExtraController.Adicionar(txtDescricao.Text,preco ,checkBoxAtivo.Checked); // Adicionar o extra
                    if (sucesso) // Se o prato for adicionado com sucesso, mostra uma mensagem de sucesso e limpa os campos preenchidos
                    {
                        txtDescricao.Text = "";
                        txtPreco.Text = "";
                        checkBoxAtivo.Checked = false;
                        notificationExtra.Visible = true;
                        notificationExtra.Style = ReaLTaiizor.Controls.FoxNotification.Styles.Green;
                        notificationExtra.Text = "Extra adicionado com sucesso";
                        timerNotification.Start();
                    }
                    else // caso contrário, mostra uma mensagem de erro
                    {
                        notificationExtra.Visible = true;
                        notificationExtra.Style = ReaLTaiizor.Controls.FoxNotification.Styles.Red;
                        notificationExtra.Text = "Ocorreu um erro ao guardar o extra";
                        timerNotification.Start();

                    }


             
            }
        }

        private void timerNotification_Tick(object sender, EventArgs e)
        {
            timerNotification.Stop();
            notificationExtra.Visible = false;
        }

        private void tabPageExtras_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (tabPageExtras.SelectedIndex)
            {
                case 0:
                    txtDescricao.Focus();
                    break;
                case 1:
                    loadExtras();
                    obterDadosExtras();
                    break;
                case 2:
                    if (selectedExtra != null) // Se um prato estiver selecionado, mostra os campos para editar e preenche-os com os dados do prato selecionado
                    {
                        panelSelecionadoEdit.Visible = true;
                        panelSelecionadoEdit.Location = panel1.Location;
                        lblNotSelected.Visible = false;
                        txtEditDesc.Text = selectedExtra.Descricao;
                        txtEditPreco.Text = selectedExtra.Preco.ToString();
                        checkAtivoEdit.Checked = selectedExtra.Ativo;
                    }
                    else // Caso contrário, mostra uma label a dizer que é necessário selecionar um prato
                    {
                        lblNotSelected.Visible = true;
                        lblNotSelected.Text = "Selecione um extra para editar";
                        panelSelecionadoEdit.Visible = false;
                    } 
                    break;
            }
        }

        private void loadExtras()
        {
            extras = ExtraController.Get();
            numeroExtras = extras.Count();
        }

        private void obterDadosExtras()
        {
            extrasPaginados = extras.Skip((paginaAtual - 1) * tamanhoPagina).Take(tamanhoPagina).ToList();
            comboBoxExtras.DataSource = extrasPaginados;
            comboBoxExtras.DisplayMember = "Descricao";
            updatePagination();
            obterDadosDropDown(0);
        }

        private void updatePagination()
        {
            btnPaginateAvancar.Enabled = paginaAtual * tamanhoPagina < numeroExtras; // Verificar se é possível avançar para a próxima página
            btnPaginateVoltar.Enabled = paginaAtual > 1; // Verificar se é possível voltar para a página anterior
        }

        private void btnPaginateVoltar_Click(object sender, EventArgs e)
        {
            paginaAtual--;
            obterDadosExtras();

        }

        private void btnPaginateAvancar_Click(object sender, EventArgs e)
        {
            paginaAtual++;
            obterDadosExtras();
        }

        private void comboBoxExtras_SelectionChangeCommitted(object sender, EventArgs e)
        {
            obterDadosDropDown();
        }

        private void obterDadosDropDown(int indexEspecifico = -1)
        {
            if (comboBoxExtras.Items.Count > 0)
            {
                if (indexEspecifico >= 0)
                {
                    comboBoxExtras.SelectedItem = indexEspecifico;
                }
                Extra extra = (Extra)comboBoxExtras.SelectedItem;


                if (extra.Ativo)
                {
                    lblAtivo.Text = "Ativo";
                    lblAtivo.ForeColor = Color.Green;
                }
                else
                {
                    lblAtivo.Text = "Inativo";
                    lblAtivo.ForeColor = Color.Red;
                }


                if (selectedExtra != null && extra.Id == selectedExtra.Id) // Verificar se o prato selecionado é o mesmo que o prato que está a ser mostrado, com base no id
                {
                    lblSelecionado.Text = "Selecionado";
                }
                else
                {
                    lblSelecionado.Text = "";
                }

                lblDescricao.Text = extra.Descricao;
                lblPreco.Text = extra.Preco.ToString() + "€";
            }
            else
            {
                lblDescricao.Text = "";
                lblPreco.Text = "";
                lblAtivo.Text = "";
                lblSelecionado.Text = "";
            }
            tabPageListarExtra.Refresh(); // Necessário para atualizar os controlos, para certificar-se que os dados são mostrados corretamente
        }

        private void btnSelecionar_Click(object sender, EventArgs e)
        {
            if (comboBoxExtras.SelectedIndex >= 0)
            {
                if (selectedExtra != null && selectedExtra.Id == ((Extra)comboBoxExtras.SelectedItem).Id) // Se o extra já estiver selecionado, desseleciona o extra
                {
                    selectedExtra = null;
                    lblSelecionado.Text = "";
                }
                else // Caso contrário, seleciona o extra normalmente e armazena 
                {
                    selectedExtra = (Extra)comboBoxExtras.SelectedItem;
                    lblSelecionado.Text = "Selecionado";
                }

            }
        }

        private void btnApagar_Click(object sender, EventArgs e)
        {
            if (selectedExtra != null) // Se houver um extra selecionado, apaga o extra
            {
                bool sucesso = ExtraController.Apagar(selectedExtra.Id);
                if (sucesso)
                {
                    loadExtras();
                    obterDadosExtras();
                    MessageBox.Show("Extra apagado com sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Ocorreu um erro ao apagar o extra", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            selectedExtra = null;
        }

        private void btnSubmitEdit_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtEditDesc.Text) || string.IsNullOrEmpty(txtEditPreco.Text)) // Verificar se os campos são inválidos, se forem, mostra uma mensagem de erro
            {
                MessageBox.Show("Preencha todos os campos", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (!(UtilityController.GetDecimal(txtEditPreco.Text, "preço") > 0))
            {
                MessageBox.Show("O preço tem de ser superior a 0", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                bool sucesso;
                decimal preco = UtilityController.GetDecimal(txtEditPreco.Text, "preço");
       
                    sucesso = ExtraController.Editar(selectedExtra.Id,txtEditDesc.Text, preco, checkAtivoEdit.Checked); 
                    if (sucesso) 
                    {
                     selectedExtra = null;
                        tabPageExtras.SelectedIndex = 0;
                        notificationExtra.Visible = true;
                        notificationExtra.Style = ReaLTaiizor.Controls.FoxNotification.Styles.Green;
                        notificationExtra.Text = "Extra editado com sucesso";
                        timerNotification.Start();
                    }
                    else
                    {
                        notificationExtra.Visible = true;
                        notificationExtra.Style = ReaLTaiizor.Controls.FoxNotification.Styles.Red;
                        notificationExtra.Text = "Ocorreu um erro ao editar o extra";
                        timerNotification.Start();
                    }
                



            }


        }
    }
}
