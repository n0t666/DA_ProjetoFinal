using DA_ProjetoFinal.Controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Validation;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DA_ProjetoFinal.Views
{
    public partial class FormFuncionarios : Form
    {

        //-----------------Variáveis relacionadas com a paginação-----------------
        private int tamanhoPagina = 10;
        private int paginaAtual = 1;
        //------------------------------------------------------------------------

        private List<Funcionario> funcionarios;
        private List<Funcionario> funcPaginados;
        private int numeroFuncionarios;
        private Funcionario selectedFunc;

        public FormFuncionarios()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNif.Text) || string.IsNullOrEmpty(txtNome.Text) || string.IsNullOrEmpty(txtUsername.Text))
            {
                MessageBox.Show("Preencha todos os campos!");
                return;
            }
            else
            {

                if (!txtNif.Text.All(char.IsDigit))
                {
                    MessageBox.Show("O NIF apenas pode conter números", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (!FuncionarioController.Unique(txtUsername.Text))
                {
                    MessageBox.Show("O username inserido já se encontra registado,por favor escolha outro", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;

                }


                bool sucesso = FuncionarioController.Adicionar(txtNome.Text, txtUsername.Text, txtNif.Text);
                if (sucesso)
                {
                    criarNotificacao("Funcionário criado com sucesso!", ReaLTaiizor.Controls.FoxNotification.Styles.Green);
                    txtNif.Text = "";
                    txtNome.Text = "";
                    txtUsername.Text = "";
                }
                else
                {
                    criarNotificacao("Ocorreu um erro ao criar o funcionário", ReaLTaiizor.Controls.FoxNotification.Styles.Red);
                }


            }
        }

        private void criarNotificacao(string texto, ReaLTaiizor.Controls.FoxNotification.Styles estilo)
        {
            notificationFunc.Visible = true;
            notificationFunc.Style = estilo;
            notificationFunc.Text = texto;
            timerNotification.Start();
        }

        private void timerNotification_Tick(object sender, EventArgs e)
        {
            timerNotification.Stop();
            notificationFunc.Visible = false;
        }

        private void comboBoxFunc_SelectionChangeCommitted(object sender, EventArgs e)
        {
            obterDadosDropDown();
        }

        private void btnPaginateVoltar_Click(object sender, EventArgs e)
        {
            paginaAtual--;
            obterDadosFunc();
        }

        private void btnPaginateAvancar_Click(object sender, EventArgs e)
        {
            paginaAtual++;
            obterDadosFunc();
        }

        private void tabPageFuncionarios_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (tabPageFuncionarios.SelectedIndex)
            {
                case 0:
                    break;
                case 1:
                    loadFunc();
                    obterDadosFunc();
                    break;
                case 2:
                    if (selectedFunc != null) // Se um prato estiver selecionado, mostra os campos para editar e preenche-os com os dados do prato selecionado
                    {
                        panelSelecionadoEdit.Visible = true;
                        panelSelecionadoEdit.Location = panel1.Location;
                        lblNotSelected.Visible = false;
                        txtNomeEdit.Text = selectedFunc.Nome;
                        txtNifEdit.Text = selectedFunc.Nif;
                        txtUsernameEdit.Text = selectedFunc.Username;
                    }
                    else // Caso contrário, mostra uma label a dizer que é necessário selecionar um prato
                    {
                        lblNotSelected.Visible = true;
                        lblNotSelected.Text = "Selecione um funcionário para editar";
                        panelSelecionadoEdit.Visible = false;
                    }
                    break;
            }
        }

        private void btnSelecionar_Click(object sender, EventArgs e)
        {
            if (comboBoxFunc.SelectedIndex >= 0)
            {
                if (selectedFunc != null && selectedFunc.Id == ((Funcionario)comboBoxFunc.SelectedItem).Id) // Se o extra já estiver selecionado, desseleciona o extra
                {
                    selectedFunc = null;
                    lblSelecionado.Text = "";
                }
                else // Caso contrário, seleciona o extra normalmente e armazena 
                {
                    selectedFunc = (Funcionario)comboBoxFunc.SelectedItem;
                    lblSelecionado.Text = "Selecionado";
                }

            }
        }

        private void btnApagar_Click(object sender, EventArgs e)
        {
            if (selectedFunc != null)
            {
                bool sucesso = FuncionarioController.Apagar(selectedFunc.Id);
                if (sucesso)
                {
                    loadFunc();
                    obterDadosFunc();
                    MessageBox.Show("Funcionário apagado com sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Ocorreu um erro ao apagar o Funcionário", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            selectedFunc = null;
        }

        private void loadFunc()
        {
            funcionarios = FuncionarioController.Get();
            numeroFuncionarios = funcionarios.Count();
        }

        private void obterDadosFunc()
        {
            funcPaginados = funcionarios.Skip((paginaAtual - 1) * tamanhoPagina).Take(tamanhoPagina).ToList();
            comboBoxFunc.DataSource = funcPaginados;
            comboBoxFunc.DisplayMember = "Username";
            updatePagination();
            obterDadosDropDown(0);
        }

        private void updatePagination()
        {
            btnPaginateAvancar.Enabled = paginaAtual * tamanhoPagina < numeroFuncionarios; // Verificar se é possível avançar para a próxima página
            btnPaginateVoltar.Enabled = paginaAtual > 1; // Verificar se é possível voltar para a página anterior
        }

        private void obterDadosDropDown(int indexEspecifico = -1)
        {
            if (comboBoxFunc.Items.Count > 0)
            {
                if (indexEspecifico >= 0)
                {
                    comboBoxFunc.SelectedItem = indexEspecifico;
                }
                Funcionario funcionario = (Funcionario)comboBoxFunc.SelectedItem;


                if (selectedFunc != null && funcionario.Id == selectedFunc.Id) // Verificar se o prato selecionado é o mesmo que o prato que está a ser mostrado, com base no id
                {
                    lblSelecionado.Text = "Selecionado";
                }
                else
                {
                    lblSelecionado.Text = "";
                }

                lblNome.Text = funcionario.Nome;
                lblUsernameVal.Text = funcionario.Username;
                lblNif.Text = funcionario.Nif;
            }
            else
            {
                lblSelecionado.Text = "";
                lblNome.Text = "";
                lblUsernameVal.Text = "";
                lblNif.Text = "";
                comboBoxFunc.DataSource = null;
                comboBoxFunc.SelectedItem = null;
                comboBoxFunc.ResetText();

            }
            tabPageListarFunc.Refresh(); // Necessário para atualizar os controlos, para certificar-se que os dados são mostrados corretamente
        }

        private void btnSubmitEdit_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNifEdit.Text) || string.IsNullOrEmpty(txtNomeEdit.Text) || string.IsNullOrEmpty(txtUsernameEdit.Text))
            {
                MessageBox.Show("Preencha todos os campos!");
                return;
            }
            else
            {

                if (!txtNifEdit.Text.All(char.IsDigit))
                {
                    MessageBox.Show("O NIF apenas pode conter números", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (!FuncionarioController.Unique(txtUsernameEdit.Text, selectedFunc.Id))
                {
                    MessageBox.Show("O username inserido já se encontra registado,por favor escolha outro", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;

                }


                bool sucesso = FuncionarioController.Editar(selectedFunc.Id, txtNomeEdit.Text, txtNifEdit.Text, txtUsernameEdit.Text);
                if (sucesso)
                {
                    selectedFunc = null;
                    tabPageFuncionarios.SelectedIndex = 0;
                    criarNotificacao("Funcionário editado com sucesso!", ReaLTaiizor.Controls.FoxNotification.Styles.Green);

                }
                else
                {
                    selectedFunc = null;
                    tabPageFuncionarios.SelectedIndex = 0;
                    criarNotificacao("Ocorreu um erro ao editar o Funcionário", ReaLTaiizor.Controls.FoxNotification.Styles.Red);
                }


            }
        }
    }
}
