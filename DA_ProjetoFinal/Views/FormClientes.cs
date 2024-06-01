using DA_ProjetoFinal.Controllers;
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
    public partial class FormClientes : Form
    {

        //-----------------Variáveis relacionadas com a paginação-----------------
        private int tamanhoPagina = 10;
        private int paginaAtual = 2;
        //------------------------------------------------------------------------

        private List<Cliente> clientes;
        private int numeroEstudantes;
        private int numeroProfessores;
        private string selectedTipoCliente;
        private Cliente selectedCliente;
        private int selectedClienteIndex;


        public FormClientes()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (comboTipoUtilizador.SelectedItem != null)
            {
                string tipoCliente = comboTipoUtilizador.SelectedItem.ToString();


                if (string.IsNullOrEmpty(txtNif.Text) || string.IsNullOrEmpty(txtNome.Text))
                {
                    MessageBox.Show("Preencha todos os campos!");
                    return;
                }
                else
                {
                    bool sucesso;

                    if (!txtNif.Text.All(char.IsDigit))
                    {
                        MessageBox.Show("O NIF apenas pode conter números", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }


                    if (tipoCliente == "Estudante")
                    {
                        if(string.IsNullOrEmpty(txtNumEstudante.Text))
                        {
                            MessageBox.Show("Preencha todos os campos!");
                            return;
                        }
                        else
                        {
                            if (!txtNumEstudante.Text.All(char.IsDigit)) 
                            {
                                MessageBox.Show("O número de estudante apenas pode conter números", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }
                            try
                            {
                                sucesso =  EstudanteController.Adicionar(txtNome.Text, txtNif.Text, txtNumEstudante.Text);
                                if (sucesso)
                                {
                                  criarNotificacao("Estudante criado com sucesso!", ReaLTaiizor.Controls.FoxNotification.Styles.Green);
                                    txtNif.Text = "";
                                    txtNome.Text = "";
                                    txtNumEstudante.Text = "";
                                    txtEmail.Text = "";
                                    comboTipoUtilizador.SelectedIndex = 0;
                                }
                                else
                                {
                                    criarNotificacao("Ocorreu um erro ao criar o estudante", ReaLTaiizor.Controls.FoxNotification.Styles.Red);
                                }
                            }
                            catch (ArgumentNullException)
                            {
                                MessageBox.Show("Preencha todos os campos", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            catch (ArgumentException)
                            {
                                MessageBox.Show("Os dados que introduziu não são válidos", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            catch (Exception)
                            {
                                MessageBox.Show("Ocorreu um erro inesperado", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }

                    }
                    else if (tipoCliente == "Professor")
                    {
                        if (string.IsNullOrEmpty(txtEmail.Text))
                        {
                            MessageBox.Show("Preencha todos os campos!");
                            return;
                        }
                        else
                        {
                            if (!UtilityController.IsEmailValid(txtEmail.Text))
                            {
                                return;
                            }
                            try
                            {
                                sucesso = ProfessorController.Adicionar(txtNome.Text, txtNif.Text, txtEmail.Text);
                                if (sucesso)
                                {
                                    criarNotificacao("Professor criado com sucesso!", ReaLTaiizor.Controls.FoxNotification.Styles.Green);
                                    txtNif.Text = "";
                                    txtNome.Text = "";
                                    txtEmail.Text = "";
                                    comboTipoUtilizador.SelectedIndex = 0;
                                }else
                                {
                                    criarNotificacao("Ocorreu um erro ao criar o professor", ReaLTaiizor.Controls.FoxNotification.Styles.Red);
                                }
                            }
                            catch (FormatException)
                            {
                                MessageBox.Show("O NIF apenas pode conter números", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            catch (ArgumentNullException)
                            {
                                MessageBox.Show("Preencha todos os campos", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            catch (ArgumentException)
                            {
                                MessageBox.Show("Os dados que introduziu não são válidos", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("Ocorreu um erro inesperado " + ex.Message , "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Selecione um tipo de utilizador!");
                        return;
                    }
                }

            }
            else
            {
                MessageBox.Show("Selecione um tipo de utilizador!");
                return;
            }
        }

        private void comboTipoUtilizador_SelectionChangeCommitted(object sender, EventArgs e)
        {
            string tipoCliente = comboTipoUtilizador.SelectedItem.ToString();
            if (tipoCliente == "Estudante")
            {
                txtEmail.Enabled = false;
                txtEmail.Text = "";
                txtNumEstudante.Enabled = true;
            }
            else if (tipoCliente == "Professor")
            {
                txtEmail.Enabled = true;
                txtNumEstudante.Text = "";
                txtNumEstudante.Enabled = false;
            }
            this.Refresh();
        }

        private void timerNotification_Tick(object sender, EventArgs e)
        {
            timerNotification.Stop();
            notificationCliente.Visible = false;
        }

        private void criarNotificacao(string texto, ReaLTaiizor.Controls.FoxNotification.Styles estilo)
        {
            notificationCliente.Visible = true;
            notificationCliente.Style = estilo;
            notificationCliente.Text = texto;
            timerNotification.Start();
        }

        private void tabPageClientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (tabPageClientes.SelectedIndex)
            {
                case 0:
                    break;
                case 1:
                    loadClientes();
                    obterDadosClientes();
                    break;
                case 2:
                    if (selectedCliente != null) // Se um prato estiver selecionado, mostra os campos para editar e preenche-os com os dados do prato selecionado
                    {
                        panelSelecionadoEdit.Visible = true;
                        panelSelecionadoEdit.Location = panel1.Location;
                        lblNotSelected.Visible = false;
                        txtNomeEdit.Text = selectedCliente.Nome;
                        txtNifEdit.Text = selectedCliente.Nif;
                        if (selectedCliente is Estudante)
                        {
                            txtNumEstudante.Text = ((Estudante)selectedCliente).NumEstudante;
                            txtNumEstudEdit.Text = "";
                            txtNumEstudEdit.Enabled = true;
                            txtEmailEdit.Enabled = false;
                        }
                        else
                        {
                            txtEmailEdit.Text = ((Professor)selectedCliente).Email;
                            txtNumEstudEdit.Text = "";
                            txtEmailEdit.Enabled = true;
                            txtNumEstudEdit.Enabled = false;
                        }
                    }
                    else // Caso contrário, mostra uma label a dizer que é necessário selecionar um prato
                    {
                        lblNotSelected.Visible = true;
                        lblNotSelected.Text = "Selecione um cliente para editar";
                        panelSelecionadoEdit.Visible = false;
                    }
                    break;
            }
        }

        private void btnCarregar_Click(object sender, EventArgs e)
        {
            if(selectedCliente != null)
            {
                if(numSaldo.Value > 0) { 
                try
                {
                    decimal valor = numSaldo.Value;
                    bool sucesso = ClienteController.CarregarSaldo(selectedCliente.Id, valor);
                    if (sucesso)
                    {
                        MessageBox.Show("Foi feito um carregamento de " + valor.ToString() + "€ " , "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        loadClientes();
                        obterDadosClientes(true);
                        }
                    else
                    {
                        MessageBox.Show("Ocorreu um erro ao carregar o saldo", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Ocorreu um erro ao carregar o saldo: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                }
                else {                    
                    MessageBox.Show("O valor a carregar tem de ser superior a 0", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                               }
            }
            else
            {
                MessageBox.Show("Selecione um cliente para carregar o saldo", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


       
        private void numSaldo_KeyPress(object sender, KeyPressEventArgs e) // Quando uma tecla é pressionada no campo de saldo, verifica se é um número ou um ponto (para permitir valores decimais)
        {
            if (!(char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == '.')) // Permite também a tecla de backspace
            {
                e.Handled = true; // Se não for um número ou um ponto, ignora a tecla pressionada
            }
        }

        private void loadClientes()
        {
            clientes = ClienteController.Get();
            numeroEstudantes = clientes.Where(c => c is Estudante).Count();
            numeroProfessores = clientes.Where(c => c is Professor).Count();
        }

        private void obterDadosClientes(bool startOnSelected = false)
        {
            if (selectedTipoCliente == "Estudante" || selectedTipoCliente == "Professor")
            {
                var clientesFiltrados = clientes.Where(c => selectedTipoCliente == "Estudante" ? c is Estudante : c is Professor)
                                                .Skip((paginaAtual - 1) * tamanhoPagina)
                                                .Take(tamanhoPagina)
                                                .ToList();
                comboBoxClientes.DataSource = clientesFiltrados;
                comboBoxClientes.DisplayMember = "Nome";
                comboBoxClientes.AutoCompleteMode = AutoCompleteMode.Suggest;
                comboBoxClientes.AutoCompleteSource = AutoCompleteSource.ListItems;

                updatePagination();
                if(startOnSelected && selectedCliente != null)
                {
                    if (selectedClienteIndex >= 0)
                    {
                        comboBoxClientes.SelectedIndex = selectedClienteIndex;
                        obterDadosDropDown(selectedClienteIndex);
                    }
                    else
                    {
                        obterDadosDropDown(0);
                    }
                }
                else
                {
                    obterDadosDropDown(0);
                }
            }

        }

        private void btnPaginateVoltar_Click(object sender, EventArgs e)
        {
            if (paginaAtual > 1)
            {
                paginaAtual--;
                obterDadosClientes();
            }
        }

        private void btnPaginateAvancar_Click(object sender, EventArgs e)
        {
            paginaAtual++;
            obterDadosClientes();

        }
        private void updatePagination()
        {
            int numero = selectedTipoCliente == "Estudante" ? numeroEstudantes : numeroProfessores;
            btnPaginateAvancar.Enabled = paginaAtual * tamanhoPagina < numero;
            btnPaginateVoltar.Enabled = paginaAtual > 1;
        }

        private void obterDadosDropDown(int indexEspecifico = -1)
        {
            if (comboBoxClientes.Items.Count > 0)
            {
                if (indexEspecifico >= 0)
                {
                    comboBoxClientes.SelectedItem = indexEspecifico;
                }
                Cliente cliente = (Cliente)comboBoxClientes.SelectedItem;



                if (selectedCliente != null && cliente.Id == selectedCliente.Id) // Verificar se o prato selecionado é o mesmo que o prato que está a ser mostrado, com base no id
                {
                    lblSelecionado.Text = "Selecionado";
                }
                else
                {
                    lblSelecionado.Text = "";
                }
                lblNome.Text = cliente.Nome;
                lblNif.Text = cliente.Nif;
                if (cliente is Estudante)
                {
                    lblEmailNumEs.Text = "Número de Estudante:";
                    lblEmailNumValue.Text = ((Estudante)cliente).NumEstudante;
                }
                else
                {
                    lblEmailNumEs.Text = "Email:";
                    lblEmailNumValue.Text = ((Professor)cliente).Email;
                }
                
                lblSaldo.Text = cliente.Saldo.ToString() + "€";
            }
            else
            {
                lblEmailNumValue.Text = "";
                lblNome.Text = "";
                lblNif.Text = "";
                lblSelecionado.Text = "";
                lblSaldo.Text = "";

            }
            tabPageListarCliente.Refresh(); // Necessário para atualizar os controlos, para certificar-se que os dados são mostrados corretamente
        }



        private void comboBoxClientes_SelectionChangeCommitted_1(object sender, EventArgs e)
        {
            obterDadosDropDown();
        }


        private void picSearch_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Pesquisar");
            int index = comboBoxClientes.FindString(comboBoxClientes.Text);
            if (index != -1)
            {
                comboBoxClientes.SelectedIndex = index;
                obterDadosDropDown();
            }

        }

        private void comboBoxClientes_SelectionChangeCommitted(object sender, EventArgs e)
        {
            obterDadosDropDown();
        }

        private void btnSelecionar_Click(object sender, EventArgs e)
        {
            if (comboBoxClientes.SelectedIndex >= 0)
            {
                if (selectedCliente != null && selectedCliente.Id == ((Cliente)comboBoxClientes.SelectedItem).Id) // Se o extra já estiver selecionado, desseleciona o extra
                {
                    selectedCliente = null;
                    selectedClienteIndex = -1;
                    lblSelecionado.Text = "";
                }
                else // Caso contrário, seleciona o extra normalmente e armazena 
                {
                    selectedCliente = (Cliente)comboBoxClientes.SelectedItem;
                    selectedClienteIndex = comboBoxClientes.SelectedIndex;
                    lblSelecionado.Text = "Selecionado";
                }

            }
        }

        private void btnApagar_Click(object sender, EventArgs e)
        {
            if (selectedCliente != null) // Se houver um extra selecionado, apaga o extra
            {
                bool sucesso = ClienteController.Apagar(selectedCliente.Id);
                if (sucesso)
                {
                    loadClientes();
                    obterDadosClientes();
                    MessageBox.Show("Cliente apagado com sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Ocorreu um erro ao apagar o cliente", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            selectedCliente = null;
        }

        private void comboTipoUtilizadorList_SelectionChangeCommitted_1(object sender, EventArgs e)
        {
            if (comboTipoUtilizadorList.SelectedItem != null)
            {
                string tipoCliente = comboTipoUtilizadorList.SelectedItem.ToString();
                if (tipoCliente == "Estudante")
                {
                    selectedTipoCliente = "Estudante";
                    paginaAtual = 1;
                    obterDadosClientes();
                }
                else if (tipoCliente == "Professor")
                {
                    selectedTipoCliente = "Professor";
                    paginaAtual = 1;
                    obterDadosClientes();

                }
            }
        }

        private int procurarIndiceClientes(Cliente cliente)
        { 
            foreach (Cliente c in comboBoxClientes.Items)
            {
                if (c.Id == cliente.Id)
                {
                    return comboBoxClientes.Items.IndexOf(c);
                }
            }
            return -1;
        }

        private void btnSubmitEdit_Click(object sender, EventArgs e)
        {
                 
                if (string.IsNullOrEmpty(txtNifEdit.Text) || string.IsNullOrEmpty(txtNomeEdit.Text))
                {
                    MessageBox.Show("Preencha todos os campos!");
                    return;
                }
                else
                {
                    bool sucesso;

                    if (!txtNifEdit.Text.All(char.IsDigit))
                    {
                        MessageBox.Show("O NIF apenas pode conter números", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }


                    if (selectedCliente is Estudante)
                    {
                        if (string.IsNullOrEmpty(txtNumEstudEdit.Text))
                        {
                            MessageBox.Show("Preencha todos os campos!");
                            return;
                        }
                        else
                        {
                            if (!txtNumEstudEdit.Text.All(char.IsDigit))
                            {
                                MessageBox.Show("O número de estudante apenas pode conter números", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }
                            try
                            {
                                sucesso = EstudanteController.Editar(selectedCliente.Id,txtNomeEdit.Text, txtNifEdit.Text, txtNumEstudEdit.Text);
                                if (sucesso)
                                {
                                    selectedCliente = null;
                                    selectedClienteIndex = -1;
                                    tabPageClientes.SelectedIndex = 0;
                                    criarNotificacao("Estudante editado com sucesso!", ReaLTaiizor.Controls.FoxNotification.Styles.Green);
                                   
                                }
                                else
                                {
                                selectedCliente = null;
                                selectedClienteIndex = -1;
                                tabPageClientes.SelectedIndex = 0;
                                criarNotificacao("Ocorreu um erro ao editar o estudante", ReaLTaiizor.Controls.FoxNotification.Styles.Red);
                                }
                            }
                            catch (ArgumentNullException)
                            {
                                MessageBox.Show("Preencha todos os campos", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            catch (ArgumentException)
                            {
                                MessageBox.Show("Os dados que introduziu não são válidos", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            catch (Exception)
                            {
                                MessageBox.Show("Ocorreu um erro inesperado", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }

                    }
                    else if (selectedCliente is Professor)
                    {
                        if (string.IsNullOrEmpty(txtEmailEdit.Text))
                        {
                            MessageBox.Show("Preencha todos os campos!");
                            return;
                        }
                        else
                        {
                            if (!UtilityController.IsEmailValid(txtEmailEdit.Text))
                            {
                                return;
                            }
                            try
                            {
                                sucesso = ProfessorController.Editar(selectedCliente.Id,txtNomeEdit.Text, txtNifEdit.Text, txtEmailEdit.Text);
                                if (sucesso)
                                {
                                selectedCliente = null;
                                selectedClienteIndex = -1;
                                tabPageClientes.SelectedIndex = 0;
                                criarNotificacao("Professor editado com sucesso!", ReaLTaiizor.Controls.FoxNotification.Styles.Green);
                                }
                                else
                                {
                                selectedCliente = null;
                                selectedClienteIndex = -1;
                                tabPageClientes.SelectedIndex = 0;
                                criarNotificacao("Ocorreu um erro ao editar o professor", ReaLTaiizor.Controls.FoxNotification.Styles.Red);
                                }
                            }
                            catch (FormatException)
                            {
                                MessageBox.Show("O NIF apenas pode conter números", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            catch (ArgumentNullException)
                            {
                                MessageBox.Show("Preencha todos os campos", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            catch (ArgumentException)
                            {
                                MessageBox.Show("Os dados que introduziu não são válidos", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("Ocorreu um erro inesperado " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Não foi possível editar o cliente selecionado!");
                        return;
                    }
                }

            }
        }
}
