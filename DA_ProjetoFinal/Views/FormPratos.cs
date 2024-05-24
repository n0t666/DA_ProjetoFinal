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
    public partial class FormPratos : Form
    {
        //-----------------Variáveis relacionadas com a paginação-----------------
        private int tamanhoPagina = 5;
        private int paginaAtual = 1;
        //------------------------------------------------------------------------

        //-----------------Variáveis relacionadas com a seleção de pratos-----------------
        private List<Prato> pratos;
        private Prato pratoSelecionado; 
        //------------------------------------------------------------------------

        public FormPratos()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtDescricao.Text)) // Verificar se os campos são inválidos, se forem, mostra uma mensagem de erro
            {
                MessageBox.Show("Preencha todos os campos", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            } else
            {
                bool sucesso;
                try
                {
                    TipoPrato tipoPrato = (TipoPrato)comboBoxTipos.SelectedItem; // Obter o tipo de prato selecionado na combobox
                    sucesso = PratoController.AdicionarPrato(txtDescricao.Text, tipoPrato, checkBoxAtivo.Checked);
                    if (sucesso) // Se o prato for adicionado com sucesso, mostra uma mensagem de sucesso e limpa os campos preenchidos
                    {
                        txtDescricao.Text = "";
                        comboBoxTipos.SelectedIndex = 0;
                        checkBoxAtivo.Checked = false;
                        notificationPrato.Visible = true;
                        notificationPrato.Style = ReaLTaiizor.Controls.FoxNotification.Styles.Green;
                        notificationPrato.Text = "Prato adicionado com sucesso";
                        timerNotification.Start();
                    }
                    else // caso contrário, mostra uma mensagem de erro
                    {
                        notificationPrato.Visible = true;
                        notificationPrato.Style = ReaLTaiizor.Controls.FoxNotification.Styles.Red;
                        notificationPrato.Text = "Ocorreu um erro ao guardar o prato";
                        timerNotification.Start();

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


        private void FormPratos_Load(object sender, EventArgs e)
        {
            List<TipoPrato> tipos = new List<TipoPrato>(); 
            tipos = PratoController.ObterTiposPrato(); // Ao carregar o forms, obtem-se todos os tipos de prato


            foreach (TipoPrato tipo in tipos) // Popular as comboboxes(da página de edição e criação) com os tipos de prato
            {
                comboBoxTipos.Items.Add(tipo);
                comboBoxEditTipo.Items.Add(tipo);
            }

            comboBoxTipos.SelectedIndex = 0; // Automaticamente selecionar o primeiro item da combobox, para evitar que seja selecionado o indice -1
        }

        private void timerNotification_Tick(object sender, EventArgs e) // Após 3 segundos, a notificação criada é escondida
        {
            timerNotification.Stop();
            notificationPrato.Visible = false;
        }

        private void foreverTabPage1_SelectedIndexChanged(object sender, EventArgs e) // Evento que é chamado sempre que a tabpage é alterada
        {
            switch(foreverTabPage1.SelectedIndex)
            {
                case 0: // Adicionar prato
                    break;
                case 1: // Listar pratos
                    loadPratos();
                    break;
                case 2: // Editar prato
                    if(pratoSelecionado != null) // Se um prato estiver selecionado, mostra os campos para editar e preenche-os com os dados do prato selecionado
                    {
                        panelSelecionadoEdit.Visible = true;
                        panelSelecionadoEdit.Location = panel1.Location;
                        lblNotSelected.Visible = false;
                        txtEditDesc.Text = pratoSelecionado.Descricao;
                        comboBoxEditTipo.SelectedItem = pratoSelecionado.Tipo;
                        checkAtivoEdit.Checked = pratoSelecionado.Ativo;
                    }
                    else // Caso contrário, mostra uma label a dizer que é necessário selecionar um prato
                    {
                        lblNotSelected.Visible = true;
                        lblNotSelected.Text = "Selecione um prato para editar";
                        panelSelecionadoEdit.Visible = false;
                    }
                    break;
            }

        }

        // Função que permite carregar os pratos existentes, na combobox
        private void loadPratos()
        {
                pratos = PratoController.PaginacaoPratos(paginaAtual, tamanhoPagina);
                comboBoxPratos.DataSource = pratos;
                comboBoxPratos.DisplayMember = "Descricao"; // Mostrar a descrição do prato na combobox
                updatePagination(); // Atualizar os botões de paginação,ou seja,  se existe mais pratos que possam ser mostrados
                obterDadosDropDown(0); // Automaticamente obter os dados do primeiro prato da lista
        }


        private void updatePagination()
        {
            btnPaginateAvancar.Enabled = paginaAtual * tamanhoPagina < PratoController.ObterNumeroPratos(); // Verificar se é possível avançar para a próxima página
            btnPaginateVoltar.Enabled = paginaAtual  > 1; // Verificar se é possível voltar para a página anterior
        }


        private void aloneComboBox1_SelectionChangeCommitted(object sender, EventArgs e) // Evento que é chamado sempre que um item é selecionado na combobox
        {
            obterDadosDropDown();
        }

        // Função que permite mostrar os dados do prato selecionado na combobox
        private void obterDadosDropDown(int indexEspecifico = -1)
        {
            if(comboBoxPratos.Items.Count > 0) { 
            if (indexEspecifico >=0)
            {
                comboBoxPratos.SelectedItem = indexEspecifico;
            }
            Prato prato = (Prato)comboBoxPratos.SelectedItem;


            if (prato.Ativo)
            {
                lblAtivo.Text = "Ativo";
                lblAtivo.ForeColor = Color.Green;
            }
            else
            {
                lblAtivo.Text = "Inativo";
                lblAtivo.ForeColor = Color.Red;
            }


            if (pratoSelecionado != null && prato.Id == pratoSelecionado.Id) // Verificar se o prato selecionado é o mesmo que o prato que está a ser mostrado, com base no id
            {
                lblSelecionado.Text = "Selecionado";
            }
            else
            {
                lblSelecionado.Text = "";
            }

            lblDescricao.Text = prato.Descricao;
            lblTipo.Text = prato.Tipo.ToString();
            }
            else
            {
                lblDescricao.Text = "";
                lblTipo.Text = "";
                lblAtivo.Text = "";
                lblSelecionado.Text = "";
            }
            tabPageListarPratos.Refresh(); // Necessário para atualizar os controlos, para certificar-se que os dados são mostrados corretamente
        }


        private void btnPaginateAvancar_Click(object sender, EventArgs e)
        {
            paginaAtual++;
            comboBoxPratos.SelectedIndex = -1;
            loadPratos();
            obterDadosDropDown(0);
        }

        
        private void btnSelecionar_Click(object sender, EventArgs e)
        {
            if(comboBoxPratos.SelectedIndex >= 0) 
            {
                if(pratoSelecionado != null && pratoSelecionado.Id == ((Prato)comboBoxPratos.SelectedItem).Id) // Se o prato já estiver selecionado, desseleciona o prato
                {
                    pratoSelecionado = null;
                    lblSelecionado.Text = "";
                }
                else // Caso contrário, seleciona o prato normalmente e armazena 
                {
                    pratoSelecionado = (Prato)comboBoxPratos.SelectedItem;
                    lblSelecionado.Text = "Selecionado";
                }
                
            }

        }

        private void btnApagar_Click(object sender, EventArgs e)
        {
            if (pratoSelecionado !=null) // Se houver um prato selecionado, apaga o prato
            {
                bool sucesso = PratoController.ApagarPrato(pratoSelecionado.Id);
                if (sucesso)
                {
                    loadPratos();
                    MessageBox.Show("Prato apagado com sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Ocorreu um erro ao apagar o prato", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            pratoSelecionado = null;
        }

        private void btnPaginateVoltar_Click_1(object sender, EventArgs e)
        {
            paginaAtual--;
            loadPratos();
            obterDadosDropDown(0);
        }

        private void btnEditSubmit_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtEditDesc.Text))
            {
                MessageBox.Show("Preencha todos os campos", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if(pratoSelecionado == null)
            {
                MessageBox.Show("Selecione um prato", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                bool sucesso;
                try
                {
                    TipoPrato tipoPrato = (TipoPrato)comboBoxEditTipo.SelectedItem;
                    sucesso = PratoController.EditarPrato(pratoSelecionado.Id, txtEditDesc.Text, tipoPrato, checkAtivoEdit.Checked);
                    if (sucesso)
                    {
                        pratoSelecionado = null;
                        foreverTabPage1.SelectedIndex = 0;
                        notificationPrato.Visible = true;
                        notificationPrato.Style = ReaLTaiizor.Controls.FoxNotification.Styles.Green;
                        notificationPrato.Text = "Prato editado com sucesso";
                        timerNotification.Start();
                    }
                    else
                    {
                        foreverTabPage1.SelectedIndex = 0;
                        notificationPrato.Visible = true;
                        notificationPrato.Style = ReaLTaiizor.Controls.FoxNotification.Styles.Red;
                        notificationPrato.Text = "Ocorreu um erro ao guardar o prato";
                        timerNotification.Start();
                       

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

    }
    }
   
