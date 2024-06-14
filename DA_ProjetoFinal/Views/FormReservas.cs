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
        private int paginaAtualExtras = 1;
        private int paginaAtualPratos = 1;
        private int paginaAtualMenus = 1;
        private int paginaAtualUtilizadores = 1;
        //------------------------------------------------------------------------

        private List<Extra> extras;
        private List<Extra> extrasPaginados;

        private List<Prato> pratos;
        private List<Prato> pratosPaginados;

        private List<Menu> menus;
        private List<Menu> menusPaginados;

        private List<Cliente> clientes;
        private List<Cliente> clientesPaginados;

        private int numeroExtras;
        private int numeroPratos;
        private int numeroMenus;
        private int numeroUtilizadores;

        private Menu selectedMenu;

        private Dictionary<string, bool> checkboxStates = new Dictionary<string, bool>();

        private const string pPrefixCriar = "checkPcriar";
        private const string ePrefixCriar = "checkEcriar";

        public event EventHandler<int> RememberMeSelected;

        public FormReservas(int utilizadorAtual, DateTime? diaEspecifico = null)
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
            loadDados();
            obterDadosPaginados(true, true);
            obterSaldoCliente();
        }

        private void loadDados()
        {
            clientes = ClienteController.Get();
            numeroUtilizadores = clientes.Count;
            numeroMenus = menus.Count;
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
            }
        }

        private void obterDadosPaginados(bool updateMenus = false, bool updateClientes = false)
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

                    if (ClienteController.PodeEfetuarReserva(selectedCliente.Id, selectedMenu.DataHora.Day))
                    {
                        if (ReservaController.Adicionar(selectedCliente.Id, selectedMenu.Id, pratosSelecionadosId, extrasSelecionadosId))
                        {
                            MessageBox.Show("Reserva efetuada com sucesso");
                            loadDados();
                            obterDadosPaginados(true, true);
                            obterSaldoCliente();
                            obterQuantidadeMenu();
                            this.Refresh();
                        }
                    }
                }
            }
        }

        private void comboBoxClientes_SelectionChangeCommitted(object sender, EventArgs e)
        {
            obterSaldoCliente();
        }


    }
}
