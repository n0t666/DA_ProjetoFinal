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
using System.Windows.Forms.VisualStyles;

namespace DA_ProjetoFinal.Views
{
    public partial class FormReservas : Form
    {

        //-----------------Variáveis relacionadas com a paginação-----------------
        private int tamanhoPagina = 6;
        private int paginaAtualMenus = 1;
        private int paginaAtualUtilizadores = 1;
        private int paginaAtualReservas = 1;
        //------------------------------------------------------------------------


        private List<Menu> menus;
        private List<Menu> menusPaginados;

        private List<Cliente> clientes;
        private List<Cliente> clientesPaginados;

        private List<Reserva> reserva;
        private List<Reserva> reservaPaginados;

        private int numeroReservas;
        private int numeroMenus;
        private int numeroUtilizadores;


        private Dictionary<string, bool> checkboxStates = new Dictionary<string, bool>();

        private const string pPrefixCriar = "checkPcriar";
        private const string ePrefixCriar = "checkEcriar";

        private int rememberUser = -1;

        public event EventHandler<int> RememberMeSelected;

        public FormReservas(int utilizadorAtual, DateTime? diaEspecifico = null, int remmberMeUser = -1)
        {
            InitializeComponent();

            if (diaEspecifico != null)
            {
                if (MenuController.GetSpecificDay(diaEspecifico.Value) != null)
                {
                    menus = MenuController.GetSpecificDay(diaEspecifico.Value);
                }
                else
                {
                    MessageBox.Show("Não existem reservas para o dia selecionado");
                    menus = MenuController.Get();
                }
            }
            else
            {
                menus = MenuController.Get();
            }
            rememberUser = remmberMeUser;

            loadDados();
            obterDadosPaginados(true, true);
            obterSaldoCliente();
        }

        private void loadDados()
        {
            clientes = ClienteController.Get();
            if (rememberUser != -1) 
            {
                Cliente cliente = clientes.Find(c => c.Id == rememberUser);
                if (cliente != null)
                {
                    clientes.Remove(cliente);
                    clientes.Insert(0, cliente);
                }
            }


            numeroUtilizadores = clientes.Count;
            numeroMenus = menus.Count;
        }

        private void loadDetalhesReserva()
        {
            if (comboBoxReservas.SelectedItem != null)
            {
                pnlExtrasMenus.Controls.Clear();

                decimal total = 0;
                Reserva selectedReserva = (Reserva)comboBoxReservas.SelectedItem;
                lblDataMenu.Text = selectedReserva.Menu.DataHora.ToString();
                lblDataReserva.Text = selectedReserva.Data.ToString();
                total += selectedReserva.Cliente is Estudante ? selectedReserva.Menu.PrecoEstudante : selectedReserva.Menu.PrecoEstudante;


                foreach(Extra extra in selectedReserva.Extra)
                {
                    total += extra.Preco;
                }



                if(selectedReserva.Multa != null)
                {
                    lblTitleMulta.Visible = true;
                    lblTitleMulta.Text = "Multa" + "(" + selectedReserva.Multa.NumeroHoras + " horas)";
                    lblMulta.Text = selectedReserva.Multa.Valor.ToString() + "€";
                    total += selectedReserva.Multa.Valor;
                }
                else
                {
                    lblTitleMulta.Visible = false;
                    lblMulta.Text = "";
                }

                lblTotal.Text = total.ToString() + "€";

                DungeonHeaderLabel labelPratosTitle = new DungeonHeaderLabel();
                labelPratosTitle.Text = "Pratos:";
                labelPratosTitle.Font = new Font("Segoe UI", 13, FontStyle.Bold);
                labelPratosTitle.Padding = new Padding(0, 10, 0, 10);
                labelPratosTitle.AutoSize = true;

                DungeonHeaderLabel labelExtrasTitle = new DungeonHeaderLabel();
                labelExtrasTitle.Text = "Extras:";
                labelExtrasTitle.Font = new Font("Segoe UI", 13, FontStyle.Bold);
                labelExtrasTitle.Padding = new Padding(0, 10, 0, 10);
                labelExtrasTitle.AutoSize = true;

                pnlExtrasMenus.Controls.Add(labelPratosTitle);
                pnlExtrasMenus.SetFlowBreak(labelPratosTitle, true);

                foreach (Prato prato in selectedReserva.Prato)
                {
                    DungeonLabel labelPrato = new DungeonLabel();
                    labelPrato.Text = "\u2022" + prato.Descricao; // Unicode para bullet point
                    labelPrato.Font = new Font("Segoe UI", 11, FontStyle.Regular);
                    labelPrato.Padding = new Padding(0, 5, 0, 5);
                    labelPrato.AutoSize = true;

                    pnlExtrasMenus.Controls.Add(labelPrato);
                    pnlExtrasMenus.SetFlowBreak(labelPrato, true);                 
                }

                pnlExtrasMenus.Controls.Add(labelExtrasTitle);
                pnlExtrasMenus.SetFlowBreak(labelExtrasTitle, true);
                foreach (Extra extra in selectedReserva.Extra)
                {
                    DungeonLabel labelExtra = new DungeonLabel();
                    labelExtra.Text = "\u2022" + extra.Descricao + "  (" + extra.Preco + "€)"; // Unicode para bullet point
                    labelExtra.Font = new Font("Segoe UI", 11, FontStyle.Regular);
                    labelExtra.Padding = new Padding(0, 5, 0, 5);
                    labelExtra.AutoSize = true;

                    pnlExtrasMenus.Controls.Add(labelExtra);
                    pnlExtrasMenus.SetFlowBreak(labelExtra, true);
                }
            }
            else
            {
                pnlExtrasMenus.Controls.Clear();

            }
            pnlExtrasMenus.Refresh();
            this.Refresh();
        }

        private void populateChecks(List<Prato> pratos, List<Extra> extras, bool pratosUpdate = false, bool extrasUpdate = false)
        {
            if (pratosUpdate)
            {
                pnlPratos.Controls.Clear();
                foreach (Prato prato in pratos)
                {
                    string controlName = pPrefixCriar + prato.Id.ToString();
                    AloneCheckBox check = new AloneCheckBox();
                    check.Name = controlName;
                    check.Text = prato.Descricao;

                    if (checkboxStates.ContainsKey(controlName))
                    {
                        check.Checked = checkboxStates[controlName];
                    }
                    else
                    {
                        checkboxStates.Add(controlName, check.Checked);
                    }

                    check.CheckedChanged += Check_CheckedChanged;
                    pnlPratos.Controls.Add(check);
                }
            }

            if (extrasUpdate)
            {
                pnlExtras.Controls.Clear();
                foreach (Extra extra in extras)
                {
                    string controlName = ePrefixCriar + extra.Id.ToString();

                    AloneCheckBox check = new AloneCheckBox();
                    check.Name = controlName;
                    check.Text = extra.Descricao;

                    if (checkboxStates.ContainsKey(controlName))
                    {
                        check.Checked = checkboxStates[controlName];
                    }
                    else
                    {
                        checkboxStates.Add(controlName, check.Checked);
                    }
                    check.CheckedChanged += Check_CheckedChanged;
                    pnlExtras.Controls.Add(check);
                }
            }
            this.Refresh();
        }

        private void Check_CheckedChanged(object sender, EventArgs e)
        {
            AloneCheckBox checkBox = sender as AloneCheckBox;
            if (checkBox != null)
            {
                checkboxStates[checkBox.Name] = checkBox.Checked;
            }
        }

        private void updatePagination()
        {
            switch (foreverTabPage1.SelectedIndex)
            {
                case 0:
                    btnNextMenu.Enabled = paginaAtualMenus * tamanhoPagina < numeroMenus;
                    btnBackMenu.Enabled = paginaAtualMenus > 1;
                    btnNextCliente.Enabled = paginaAtualUtilizadores * tamanhoPagina < numeroUtilizadores;
                    btnBackCliente.Enabled = paginaAtualUtilizadores > 1;
                    break;
                case 1:
                    btnBackClienteM.Enabled = paginaAtualUtilizadores > 1;
                    btnNextClienteM.Enabled = paginaAtualUtilizadores * tamanhoPagina < numeroUtilizadores;
                    btnBackReserva.Enabled = paginaAtualReservas > 1;
                    btnNextReserva.Enabled = paginaAtualReservas * tamanhoPagina < numeroReservas;
                    break;


            }
        }

        private void obterDadosPaginados(bool updateMenus = false, bool updateClientes = false, bool updateReservas = false)
        {
            switch (foreverTabPage1.SelectedIndex)
            {
                case 0:
                    if (updateMenus)
                    {
                        menusPaginados = menus.Skip((paginaAtualMenus - 1) * tamanhoPagina).Take(tamanhoPagina).ToList();
                        comboBoxMenus.DataSource = menusPaginados;
                        comboBoxMenus.DisplayMember = "DataHora";
                        obterDadosDropdown();
                    }

                    if (updateClientes)
                    {
                        clientesPaginados = clientes.Skip((paginaAtualUtilizadores - 1) * tamanhoPagina).Take(tamanhoPagina).ToList();
                        comboBoxClientes.DataSource = clientesPaginados;
                        obterSaldoCliente();
                    }
                    updatePagination();
                    break;
                case 1:
                    if (updateClientes)
                    {
                        clientesPaginados = clientes.Skip((paginaAtualUtilizadores - 1) * tamanhoPagina).Take(tamanhoPagina).ToList();
                        comboBoxClientesM.DataSource = clientesPaginados;
                    }
                    if (updateReservas)
                    {
                        reservaPaginados = reserva.Skip((paginaAtualReservas - 1) * tamanhoPagina).Take(tamanhoPagina).ToList();
                        comboBoxReservas.DataSource = reservaPaginados;
                        comboBoxReservas.DisplayMember = "Menu.DataHora";
                        loadDetalhesReserva();
                    }
                    updatePagination();
                    break;
            }
        }

        private void btnNextCliente_Click(object sender, EventArgs e)
        {
            paginaAtualUtilizadores++;
            obterDadosPaginados(false, true);
        }

        private void btnBackCliente_Click(object sender, EventArgs e)
        {
            paginaAtualUtilizadores--;
            obterDadosPaginados(false, true);
        }

        private void btnBackMenu_Click(object sender, EventArgs e)
        {
            paginaAtualMenus--;
            obterDadosPaginados(true, false);

        }

        private void btnNextMenu_Click(object sender, EventArgs e)
        {
            paginaAtualMenus++;
            obterDadosPaginados(true, false);
        }

        public void obterDadosDropdown()
        {
            checkboxStates.Clear();
            if (comboBoxMenus.Items.Count > 0)
            {

                pnlExtras.Controls.Clear();
                pnlPratos.Controls.Clear();
                this.Refresh();


                Menu selectedMenu = (Menu)comboBoxMenus.SelectedItem;

                obterQuantidadeMenu();

                populateChecks(selectedMenu.Prato.ToList(), selectedMenu.Extra.ToList(), true, true);
            }
            else
            {
                checkboxStates.Clear();
                pnlExtras.Controls.Clear();
                pnlPratos.Controls.Clear();
                this.Refresh();
            }

        }

        private void obterSaldoCliente()
        {
            if (comboBoxClientes.SelectedItem != null)
            {
                Cliente selectedCliente = (Cliente)comboBoxClientes.SelectedItem;
                lblSaldo.Text = "Saldo: " + selectedCliente.Saldo.ToString() + "€";
                tabPageCriarReserva.Refresh();
            }
        }

        private void obterQuantidadeMenu()
        {
            if (comboBoxMenus.SelectedItem != null)
            {
                Menu selectedMenu = (Menu)comboBoxMenus.SelectedItem;
                lblQuantidadeMenu.Text = "Quantidade: " + selectedMenu.Quantidade.ToString();
                tabPageCriarReserva.Refresh();
            }
        }



        private void comboBoxMenus_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (comboBoxMenus.SelectedItem != null)
            {
                obterDadosDropdown();
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (comboBoxClientes.SelectedItem == null || comboBoxMenus.SelectedItem == null)
            {
                MessageBox.Show("Por favor selecione um cliente e um menu");
                return;
            }
            else
            {
                Menu selectedMenu = (Menu)comboBoxMenus.SelectedItem;

                if (!(selectedMenu.Quantidade > 0))
                {
                    MessageBox.Show("Não existe quantidade suficiente do menu selecionado");
                    return;
                }
                else
                {
                    Cliente selectedCliente = (Cliente)comboBoxClientes.SelectedItem;

                    List<int> pratosSelecionadosId = new List<int>();
                    List<int> extrasSelecionadosId = new List<int>();


                    foreach (KeyValuePair<string, bool> entry in checkboxStates)
                    {
                        if (entry.Key.Contains(pPrefixCriar) && entry.Value)
                        {
                            int id = int.Parse(entry.Key.Replace(pPrefixCriar, ""));
                            pratosSelecionadosId.Add(id);
                        }
                        else if (entry.Key.Contains(ePrefixCriar) && entry.Value)
                        {
                            int id = int.Parse(entry.Key.Replace(ePrefixCriar, ""));
                            extrasSelecionadosId.Add(id);
                        }
                    }
                    if (pratosSelecionadosId.Count < 0)
                    {
                        MessageBox.Show("Por favor selecione pelo menos um prato");
                        return;
                    }
                    else
                    {
                        if (ClienteController.PodeEfetuarReserva(selectedCliente.Id, selectedMenu.DataHora.Day))
                        {
                            int idMulta = MultaController.CheckMulta(selectedMenu.DataHora);
                            if (ReservaController.Adicionar(selectedCliente.Id, selectedMenu.Id, pratosSelecionadosId, extrasSelecionadosId, idMulta))
                            {
                                if (checkBoxRemeber.Checked)
                                {
                                    RememberMeSelected?.Invoke(this, selectedCliente.Id);
                                }
                                MessageBox.Show("Reserva efetuada com sucesso");
                                loadDados();
                                obterDadosPaginados(true, true);
                                obterSaldoCliente();
                                obterQuantidadeMenu();
                            }
                        }
                    }
                }
            }
        }

        private void comboBoxClientes_SelectionChangeCommitted(object sender, EventArgs e)
        {
            obterSaldoCliente();
        }

        private void foreverTabPage1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (foreverTabPage1.SelectedIndex)
            {
                case 0:
                    paginaAtualUtilizadores = 1;
                    loadDados();
                    obterDadosPaginados(true, true);
                    obterSaldoCliente();
                    break;
                case 1:
                    paginaAtualUtilizadores = 1;
                    loadDados();
                    if(comboBoxClientes.SelectedItem != null)
                    {
                        Cliente cliente = (Cliente)comboBoxClientes.SelectedItem;
                        reserva = ReservaController.GetUser(cliente.Id);
                        numeroReservas = reserva.Count;
                        obterDadosPaginados(false, true, true);
                    }
                    else
                    {
                        obterDadosPaginados(false, true, false);
                    }
                    break;
            }

        }

        private void btnNextReserva_Click(object sender, EventArgs e)
        {
            paginaAtualReservas++;
            obterDadosPaginados(true, true);
        }

        private void btnBackReserva_Click(object sender, EventArgs e)
        {
            paginaAtualReservas--;
            obterDadosPaginados(true, true);
        }

        private void comboBoxClientesM_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (comboBoxClientes.SelectedItem != null)
            {
                Cliente cliente = (Cliente)comboBoxClientesM.SelectedItem;
                reserva = ReservaController.GetUser(cliente.Id);
                numeroReservas = reserva.Count;
                obterDadosPaginados(false, false, true);
            }

        }

        private void btnNextClienteM_Click(object sender, EventArgs e)
        {
            paginaAtualUtilizadores++;
            obterDadosPaginados(false, true, true);
        }

        private void btnBackClienteM_Click(object sender, EventArgs e)
        {
            paginaAtualUtilizadores--;
            comboBoxClientesM.SelectedItem = 0;
            obterDadosPaginados(false, true, true);
        }

        private void btnBackReserva_Click_1(object sender, EventArgs e)
        {
            paginaAtualReservas--;
            obterDadosPaginados(false, true, true);
        }

        private void btnNextReserva_Click_1(object sender, EventArgs e)
        {
            paginaAtualReservas++;
            obterDadosPaginados(false, true, true);
        }



        private void checkReserva_CheckedChanged(object sender, EventArgs e)
        {
            if (checkReserva.Checked && comboBoxReservas.SelectedItem != null && MessageBox.Show("Deseja realmente marcar a reserva como concluída?", "Confirmação", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Reserva reservaSelecionada = (Reserva)comboBoxReservas.SelectedItem;

                if (ReservaController.MarcarReserva(reservaSelecionada.Id))
                {
                    MessageBox.Show("Reserva marcada com sucesso");
                    foreverTabPage1.SelectedIndex = 0;
                    comboBoxReservas.ResetText();
                    comboBoxClientes.ResetText();
                    pnlExtrasMenus.Controls.Clear();
                }else
                {
                    MessageBox.Show("Erro ao marcar a reserva");
                    checkReserva.Checked = false;
                }
            }
        }

        private void comboBoxClientesM_SelectedIndexChanged(object sender, EventArgs e)
        {
                        if (comboBoxClientes.SelectedItem != null)
            {
                Cliente cliente = (Cliente)comboBoxClientesM.SelectedItem;
                reserva = ReservaController.GetUser(cliente.Id);
                numeroReservas = reserva.Count;
                obterDadosPaginados(false, false, true);
            }
        }
    }
}
