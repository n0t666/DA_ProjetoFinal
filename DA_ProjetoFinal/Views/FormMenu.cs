using DA_ProjetoFinal.Controllers;
using ReaLTaiizor.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace DA_ProjetoFinal.Views
{
    public partial class FormMenu : Form
    {

        //-----------------Variáveis relacionadas com a paginação-----------------
        private int tamanhoPagina = 6;
        private int paginaAtualExtras = 1;
        private int paginaAtualPratos = 1;
        private int paginaAtualMenus = 1;
        //------------------------------------------------------------------------

        private List<Extra> extras;
        private List<Extra> extrasPaginados;

        private List<Prato> pratos;
        private List<Prato> pratosPaginados;

        private List<Menu> menus;
        private List<Menu> menusPaginados;

        private int numeroExtras;
        private int numeroPratos;
        private int numeroMenus;

        private Menu selectedMenu;

        private Dictionary<string, bool> checkboxStates = new Dictionary<string, bool>();


        private const int MINIMO_EXTRAS_MENU = 1;
        private const int MINIMO_PRATOS_MENU = 1;
        private const int MAXIMO_EXTRAS_MENU = 6;
        private const int MAXIMO_PRATOS_MENU = 3;

        private const string pPrefixCriar = "checkPcriar";
        private const string ePrefixCriar = "checkEcriar";
        private const string pPrefixEditar = "checkPeditar";
        private const string ePrefixEditar = "checkEeditar";
        private const string pPrefixVisualizar = "checkPvisualizar";
        private const string ePrefixVisualizar = "checkEvisualizar";



        public FormMenu()
        {
            InitializeComponent();
            loadDados();
            obterDadosPaginados(true, true);
            dateDataHoraCreate.CustomFormat = "dd/MM/yyyy HH:mm";
            dateDataHoraCreate.Format = DateTimePickerFormat.Custom;
            dateDataHoraEdit.CustomFormat = "dd/MM/yyyy HH:mm";
            dateDataHoraEdit.Format = DateTimePickerFormat.Custom;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {

        }

        private void foreverTabPage1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (foreverTabPage1.SelectedIndex)
            {
                case 0:
                    paginaAtualExtras = 1;
                    paginaAtualPratos = 1;
                    updatePagination();
                    break;
                case 1:
                    panelExtrasListar.Controls.Clear();
                    panelPratosListar.Controls.Clear();
                    this.Refresh();
                    paginaAtualExtras = 1;
                    paginaAtualPratos = 1;
                    loadMenus();
                    obterDadosPaginados();
                    break;
                case 2:
                    if (selectedMenu != null)
                    {
                        paginaAtualExtras = 1;
                        paginaAtualPratos = 1;
                        obterDadosPaginados(true, true);
                        updatePagination();
                        lblNotSelected.Visible = false;
                        pnlSelecionadoEdit.Visible = true;
                        dateDataHoraEdit.Value = selectedMenu.DataHora;
                        numPrecoEstudanteEdit.Value = selectedMenu.PrecoEstudante;
                        numPrecoProfEdit.Value = selectedMenu.PrecoProfessor;
                        numQuantidadeEditar.Value = selectedMenu.Quantidade;

                    }
                    else
                    {
                        lblNotSelected.Visible = true;
                        lblNotSelected.Text = "Selecione um menu para editar";
                        pnlSelecionadoEdit.Visible = false;
                    }
                    break;
            }

        }

        private void loadDados()
        {
            extras = ExtraController.GetAtivos();
            pratos = PratoController.GetAtivos();
            numeroExtras = extras.Count;
            numeroPratos = pratos.Count;
        }

        private void loadMenus()
        {
            menus = MenuController.Get();
            numeroMenus = menus.Count;

        }

        private void obterDadosPaginados(bool updatePratos = false, bool updateExtras = false)
        {
            updatePagination();
            switch (foreverTabPage1.SelectedIndex)
            {
                case 0:
                    extrasPaginados = extras.Skip((paginaAtualExtras - 1) * tamanhoPagina).Take(tamanhoPagina).ToList();
                    pratosPaginados = pratos.Skip((paginaAtualPratos - 1) * tamanhoPagina).Take(tamanhoPagina).ToList();
                    populateChecksCreate(updatePratos, updateExtras);
                    break;
                case 1:

                    menusPaginados = menus.Skip((paginaAtualMenus - 1) * tamanhoPagina).Take(tamanhoPagina).ToList();
                    comboBoxMenus.DataSource = menusPaginados;
                    comboBoxMenus.DisplayMember = "DataHora";
                    updatePagination();
                    obterDadosDropdown(0);
                    break;
                case 2:
                    extrasPaginados = extras.Skip((paginaAtualExtras - 1) * tamanhoPagina).Take(tamanhoPagina).ToList();
                    pratosPaginados = pratos.Skip((paginaAtualPratos - 1) * tamanhoPagina).Take(tamanhoPagina).ToList();
                    populateChecksEdit(updatePratos, updateExtras);
                    break;
            }
        }

        private void btnAvancarPrCriar_Click(object sender, EventArgs e)
        {
            paginaAtualPratos++;
            obterDadosPaginados(true);

        }

        private void btnRecuarPrCriar_Click(object sender, EventArgs e)
        {
            paginaAtualPratos--;
            obterDadosPaginados(true);

        }

        private void btnAvancarExCriar_Click(object sender, EventArgs e)
        {
            paginaAtualExtras++;
            obterDadosPaginados(false, true);

        }

        private void btnRecuarExCriar_Click(object sender, EventArgs e)
        {
            paginaAtualExtras--;
            obterDadosPaginados(false, true);

        }

        private void updatePagination()
        {
            switch (foreverTabPage1.SelectedIndex)
            {
                case 0:
                    btnAvancarExCriar.Enabled = extras.Count > (paginaAtualExtras * tamanhoPagina);
                    btnRecuarExCriar.Enabled = paginaAtualExtras > 1;
                    btnAvancarPrCriar.Enabled = pratos.Count > (paginaAtualPratos * tamanhoPagina);
                    btnRecuarPrCriar.Enabled = paginaAtualPratos > 1;
                    break;
                case 1:
                    btnPaginateAvancarListar.Enabled = menus.Count > (paginaAtualMenus * tamanhoPagina);
                    btnPaginateVoltarListar.Enabled = paginaAtualMenus > 1;
                    break;
                case 2:
                    btnAvancarEditE.Enabled = extras.Count > (paginaAtualExtras * tamanhoPagina);
                    btnRecuarExEditar.Enabled = paginaAtualExtras > 1;
                    btnAvancarPrEdit.Enabled = pratos.Count > (paginaAtualPratos * tamanhoPagina);
                    btnRecuarPrEdit.Enabled = paginaAtualPratos > 1;
                    break;
            }
        }

        private void populateChecksCreate(bool pratosUpdate = false, bool extrasUpdate = false)
        {

            if (pratosUpdate)
            {
                pnlPratosCriar.Controls.Clear();
                foreach (Prato prato in pratosPaginados)
                {
                    string controlName = pPrefixCriar + prato.Id.ToString();
                    AloneCheckBox check = new AloneCheckBox();
                    check.Name = controlName;
                    check.Text = prato.Descricao;
                    poisonToolTip1.SetToolTip(check, prato.Descricao);

                    if (checkboxStates.ContainsKey(controlName))
                    {
                        check.Checked = checkboxStates[controlName];
                    }
                    else
                    {
                        checkboxStates.Add(controlName, check.Checked);
                    }

                    check.CheckedChanged += Check_CheckedChangedCriar;
                    pnlPratosCriar.Controls.Add(check);
                }
            }

            if (extrasUpdate)
            {
                pnlExtrasCriar.Controls.Clear();
                foreach (Extra extra in extrasPaginados)
                {
                    string controlName = ePrefixCriar + extra.Id.ToString();

                    AloneCheckBox check = new AloneCheckBox();
                    check.Name = controlName;
                    check.Text = extra.Descricao;
                    poisonToolTip1.SetToolTip(check, extra.Descricao);

                    if (checkboxStates.ContainsKey(controlName))
                    {
                        check.Checked = checkboxStates[controlName];
                    }
                    else
                    {
                        checkboxStates.Add(controlName, check.Checked);
                    }
                    check.CheckedChanged += Check_CheckedChangedCriar;
                    pnlExtrasCriar.Controls.Add(check);
                }
            }

            this.Refresh();

            tabPageCriarMenu.Refresh();
        }

        private void populateChecksEdit(bool pratosUpdate = false, bool extrasUpdate = false)
        {
            if (selectedMenu != null)
            {
                if (pratosUpdate)
                {
                    pnlPratosEdit.Controls.Clear();
                    foreach (Prato prato in pratosPaginados)
                    {
                        string controlName = pPrefixEditar + prato.Id.ToString();
                        AloneCheckBox check = new AloneCheckBox();
                        check.Name = controlName;
                        check.Text = prato.Descricao;
                        poisonToolTip1.SetToolTip(check, prato.Descricao);




                        if (selectedMenu.Prato.Any(p => p.Id == prato.Id))
                        {
                            check.Checked = true;
                            checkboxStates[controlName] = true;
                        }
                        else if (checkboxStates.ContainsKey(controlName))
                        {
                            check.Checked = checkboxStates[controlName];
                        }
                        else
                        {
                            check.Checked = false;
                            checkboxStates.Add(controlName, false);
                        }

                        check.CheckedChanged += Check_CheckedChangedEditar;
                        pnlPratosEdit.Controls.Add(check);
                    }
                }

                if (extrasUpdate)
                {
                    pnlExtrasEdit.Controls.Clear();
                    foreach (Extra extra in extrasPaginados)
                    {
                        string controlName = ePrefixEditar + extra.Id.ToString();
                        AloneCheckBox check = new AloneCheckBox();
                        check.Name = controlName;
                        check.Text = extra.Descricao;
                        poisonToolTip1.SetToolTip(check, extra.Descricao);

                        if (selectedMenu.Extra.Any(p => p.Id == extra.Id))
                        {
                            check.Checked = true;
                            checkboxStates[controlName] = true;
                        }
                        else if (checkboxStates.ContainsKey(controlName))
                        {
                            check.Checked = checkboxStates[controlName];
                        }
                        else
                        {
                            check.Checked = false;
                            checkboxStates.Add(controlName, false);
                        }

                        check.CheckedChanged += Check_CheckedChangedEditar;
                        pnlExtrasEdit.Controls.Add(check);

                    }
                }


                this.Refresh();

                tabPageEditarMenu.Refresh();
            }
        }


        private void Check_CheckedChangedCriar(object sender, EventArgs e)
        {
            AloneCheckBox checkBox = sender as AloneCheckBox;
            if (checkBox != null)
            {
                checkboxStates[checkBox.Name] = checkBox.Checked;
            }
        }

        private void Check_CheckedChangedEditar(object sender, EventArgs e)
        {
            AloneCheckBox checkBox = sender as AloneCheckBox;
            if (checkBox != null)
            {
                checkboxStates[checkBox.Name] = checkBox.Checked;
            }
        }

        private void btnSubmitCreate_Click(object sender, EventArgs e)
        {

            List<int> pratosSelecionadosId = new List<int>();
            List<int> extrasSelecionadosId = new List<int>();
            int quantidade;

            foreach (KeyValuePair<string, bool> entry in checkboxStates)
            {
                if (entry.Key.Contains("checkPcriar") && entry.Value)
                {
                    int id = int.Parse(entry.Key.Replace("checkPcriar", ""));
                    pratosSelecionadosId.Add(id);
                }
                else if (entry.Key.Contains("checkEcriar") && entry.Value)
                {
                    int id = int.Parse(entry.Key.Replace("checkEcriar", ""));
                    extrasSelecionadosId.Add(id);
                }
            }

            if (pratosSelecionadosId.Count < MINIMO_PRATOS_MENU || pratosSelecionadosId.Count > MAXIMO_PRATOS_MENU)
            {
                MessageBox.Show("Selecione entre " + MINIMO_PRATOS_MENU + " e " + MAXIMO_PRATOS_MENU + " pratos", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (extrasSelecionadosId.Count < MINIMO_EXTRAS_MENU || extrasSelecionadosId.Count > MAXIMO_EXTRAS_MENU)
            {
                MessageBox.Show("Selecione entre " + MINIMO_EXTRAS_MENU + " e " + MAXIMO_EXTRAS_MENU + " extras", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            else if (numPrecoProfessorCreate.Value <= 0 || numPrecoEstudanteCreate.Value <= 0)
            {
                MessageBox.Show("Insira um preço para o menu", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (numQuantCreate.Value <= 0)
            {
                MessageBox.Show("Insira uma quantidade para o menu", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (!UtilityController.IsDayOfWeek(dateDataHoraCreate.Value))
            {
                MessageBox.Show("A data do menu tem de ser um dia útil", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                List<Extra> extrasSelecionados = ExtraController.GetAtivosByIds(extrasSelecionadosId);
                List<Prato> pratosSelecionados = PratoController.GetAtivosByIds(pratosSelecionadosId);
                int numeroPratosCarne = pratosSelecionados.Where(p => p.Tipo == TipoPrato.Carne).Count();
                int numeroPratosPeixe = pratosSelecionados.Where(p => p.Tipo == TipoPrato.Peixe).Count();
                int numeroPratosVegetariano = pratosSelecionados.Where(p => p.Tipo == TipoPrato.Vegetariano).Count();
                bool sucesso;



                try
                {
                    quantidade = Convert.ToInt32(numQuantCreate.Value);
                }
                catch (Exception)
                {
                    MessageBox.Show("Insira um valor inteiro válido para a quantidade", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (quantidade <= 0)
                {
                    MessageBox.Show("Insira um valor inteiro válido para a quantidade", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (extrasSelecionados == null || pratosSelecionados == null)
                {
                    MessageBox.Show("Erro ao obter os extras e pratos selecionados", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else if (numeroPratosCarne < 1 || numeroPratosPeixe < 1 || numeroPratosVegetariano < 1)
                {
                    MessageBox.Show("Selecione pelo menos um prato de carne, peixe e vegetariano", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    sucesso = MenuController.Adicionar(dateDataHoraCreate.Value, quantidade, numPrecoEstudanteCreate.Value, numPrecoProfessorCreate.Value, extrasSelecionados, pratosSelecionados);
                }


                if (sucesso)
                {
                    MessageBox.Show("Menu adicionado com sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    limparDados();
                }
                else
                {
                    MessageBox.Show("Erro ao adicionar o menu", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }


        private void limparDados()
        {
            switch (foreverTabPage1.SelectedIndex)
            {
                case 0:
                    checkboxStates.Clear();
                    foreach (Control control in pnlPratosCriar.Controls)
                    {
                        AloneCheckBox check = control as AloneCheckBox;
                        if (check != null)
                        {
                            check.Checked = false;
                        }
                    }
                    foreach (Control control in pnlExtrasCriar.Controls)
                    {
                        AloneCheckBox check = control as AloneCheckBox;
                        if (check != null)
                        {
                            check.Checked = false;
                        }
                    }
                    dateDataHoraCreate.Value = DateTime.Now;
                    numPrecoEstudanteCreate.Value = 0.1M;
                    numPrecoProfessorCreate.Value = 0.1M;
                    numQuantCreate.Value = 1;
                    paginaAtualExtras = 1;
                    paginaAtualPratos = 1;
                    loadDados();
                    obterDadosPaginados(true, true);

                    break;
            }
            this.Refresh();
        }

        private void btnPresetCriar_Click(object sender, EventArgs e)
        {
            var itens = checkboxStates
                .Where(kvp => kvp.Key.Contains(pPrefixCriar) && kvp.Value == true)
                .Select(kvp => kvp.Key)
                .ToList();
            foreach (var item in itens)
            {
                checkboxStates[item] = false;
            }
            if (itens.Count > 0)
            {
                populateChecksCreate(true, false);
            }

        }

        private void btnEresetCriar_Click(object sender, EventArgs e)
        {
            var itens = checkboxStates
                .Where(kvp => kvp.Key.Contains(ePrefixCriar) && kvp.Value == true)
                .Select(kvp => kvp.Key)
                .ToList();
            foreach (var item in itens)
            {
                checkboxStates[item] = false;

            }
            if (itens.Count > 0)
            {
                populateChecksCreate(false, true);
            }

        }

        private void btnPvoltarCriar_Click(object sender, EventArgs e)
        {
            if (paginaAtualPratos > 1)
            {
                paginaAtualPratos = 1;
                obterDadosPaginados(true);
                populateChecksCreate(true, false);
            }

        }

        private void btnEvoltarCriar_Click(object sender, EventArgs e)
        {
            if (paginaAtualExtras > 1)
            {
                paginaAtualExtras = 1;
                obterDadosPaginados(false, true);
                populateChecksCreate(false, true);
            }

        }

        public void obterDadosDropdown(int indexEspecifico = -1)
        {
            if (comboBoxMenus.Items.Count > 0)
            {
                panelExtrasListar.Controls.Clear();
                panelPratosListar.Controls.Clear();
                this.Refresh();
                if (indexEspecifico >= 0)
                {
                    comboBoxMenus.SelectedItem = indexEspecifico;
                }

                Menu menu = (Menu)comboBoxMenus.SelectedItem;

                if (selectedMenu != null && selectedMenu.Id == menu.Id)
                {
                    lblSelecionado.Text = "Selecionado";
                }
                else
                {
                    lblSelecionado.Text = "";
                }

                lblQuantidade.Text = menu.Quantidade.ToString();
                lblDataHora.Text = menu.DataHora.ToString();
                lblPrecoEst.Text = menu.PrecoEstudante.ToString() + "€";
                lblPrecoProf.Text = menu.PrecoProfessor.ToString() + "€";

                if (menu.Extra.Count > 0)
                {
                    foreach (Extra extra in menu.Extra)
                    {
                        panelExtrasListar.Controls.Add(new Label() { Text = extra.Descricao });
                    }
                }

                foreach (Prato prato in menu.Prato)
                {
                    panelPratosListar.Controls.Add(new Label() { Text = prato.Descricao });
                }
            }
            else
            {
                lblSelecionado.Text = "";
                lblQuantidade.Text = "";
                lblDataHora.Text = "";
                lblPrecoEst.Text = "";
                lblPrecoProf.Text = "";
                panelExtrasListar.Controls.Clear();
                panelPratosListar.Controls.Clear();
                this.Refresh();
            }

        }

        private void comboBoxMenus_SelectionChangeCommitted(object sender, EventArgs e)
        {
            panelExtrasListar.Controls.Clear();
            panelPratosListar.Controls.Clear();
            this.Refresh();
            obterDadosDropdown();
        }

        private void btnPaginateVoltarListar_Click(object sender, EventArgs e)
        {
            paginaAtualMenus--;
            obterDadosPaginados();

        }

        private void btnPaginateAvancarListar_Click(object sender, EventArgs e)
        {
            paginaAtualMenus++;
            obterDadosPaginados();
        }

        private void btnSelecionar_Click(object sender, EventArgs e)
        {
            if (comboBoxMenus.SelectedIndex >= 0)
            {
                if (selectedMenu != null && selectedMenu.Id == ((Menu)comboBoxMenus.SelectedItem).Id)
                {
                    selectedMenu = null;
                    lblSelecionado.Text = "";
                }
                else
                {
                    selectedMenu = (Menu)comboBoxMenus.SelectedItem;
                    lblSelecionado.Text = "Selecionado";
                }
            }
        }

        private void btnApagar_Click(object sender, EventArgs e)
        {
            if (selectedMenu != null)
            {
                bool sucesso = MenuController.Apagar(selectedMenu.Id);
                if (sucesso)
                {
                    loadMenus();
                    obterDadosPaginados();
                    MessageBox.Show("Menu apagado com sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    lblSelecionado.Text = "";
                    selectedMenu = null;
                }
                else
                {
                    MessageBox.Show("Erro ao apagar o menu", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnAvancarEditE_Click(object sender, EventArgs e)
        {
            paginaAtualExtras++;
            obterDadosPaginados(false, true);

        }

        private void btnRecuarExEditar_Click(object sender, EventArgs e)
        {
            paginaAtualExtras--;
            obterDadosPaginados(false, true);

        }

        private void btnAvancarPrEdit_Click(object sender, EventArgs e)
        {
            paginaAtualPratos++;
            obterDadosPaginados(true);

        }

        private void btnPvoltarEditar_Click(object sender, EventArgs e)
        {
            if (paginaAtualPratos > 1)
            {
                paginaAtualPratos = 1;
                obterDadosPaginados(true);
                populateChecksEdit(true, false);
            }


        }

        private void btnPresetEditar_Click(object sender, EventArgs e)
        {
            var itens = checkboxStates
                        .Where(kvp => kvp.Key.Contains(pPrefixEditar) && kvp.Value == true)
                        .Select(kvp => kvp.Key)
                        .ToList();
            foreach (var item in itens)
            {
                checkboxStates[item] = false;
            }
            if (itens.Count > 0)
            {
                populateChecksEdit(true, false);
            }

        }

        private void btnEresetEditar_Click(object sender, EventArgs e)
        {

            var itens = checkboxStates
                        .Where(kvp => kvp.Key.Contains(ePrefixEditar) && kvp.Value == true)
                        .Select(kvp => kvp.Key)
                        .ToList();
            foreach (var item in itens)
            {
                checkboxStates[item] = false;
            }
            if (itens.Count > 0)
            {
                populateChecksEdit(false, true);
            }
        }

        private void btnEvoltarEditar_Click(object sender, EventArgs e)
        {
            if (paginaAtualExtras > 1)
            {
                paginaAtualExtras = 1;
                obterDadosPaginados(false, true);
                populateChecksEdit(false, true);
            }
        }

        private void btnRecuarPrEdit_Click(object sender, EventArgs e)
        {
            paginaAtualPratos--;
            obterDadosPaginados(true);
        }

        private void btnSubmitEdit_Click(object sender, EventArgs e)
        {
            List<int> pratosSelecionadosId = new List<int>();
            List<int> extrasSelecionadosId = new List<int>();




            foreach (KeyValuePair<string, bool> entry in checkboxStates)
            {
                if (entry.Key.Contains(pPrefixEditar) && entry.Value)
                {
                    int id = int.Parse(entry.Key.Replace(pPrefixEditar, ""));
                    pratosSelecionadosId.Add(id);
                }
                else if (entry.Key.Contains(ePrefixEditar) && entry.Value)
                {
                    int id = int.Parse(entry.Key.Replace(ePrefixEditar, ""));
                    extrasSelecionadosId.Add(id);
                }
            }

            if (pratosSelecionadosId.Count < MINIMO_PRATOS_MENU || pratosSelecionadosId.Count > MAXIMO_PRATOS_MENU)
            {
                MessageBox.Show("Selecione entre " + MINIMO_PRATOS_MENU + " e " + MAXIMO_PRATOS_MENU + " pratos", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (extrasSelecionadosId.Count < MINIMO_EXTRAS_MENU || extrasSelecionadosId.Count > MAXIMO_EXTRAS_MENU)
            {
                MessageBox.Show("Selecione entre " + MINIMO_EXTRAS_MENU + " e " + MAXIMO_EXTRAS_MENU + " extras", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            else if (numPrecoProfEdit.Value <= 0 || numPrecoEstudanteEdit.Value <= 0)
            {
                MessageBox.Show("Insira um preço para o menu", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (numQuantidadeEditar.Value <= 0)
            {
                MessageBox.Show("Insira uma quantidade para o menu", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (!UtilityController.IsDayOfWeek(dateDataHoraEdit.Value))
            {
                MessageBox.Show("A data do menu tem de ser um dia útil", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {

                List<Extra> extrasSelecionados = ExtraController.GetAtivosByIds(extrasSelecionadosId);
                List<Prato> pratosSelecionados = PratoController.GetAtivosByIds(pratosSelecionadosId);

                int numeroPratosCarne = pratosSelecionados.Where(p => p.Tipo == TipoPrato.Carne).Count();
                int numeroPratosPeixe = pratosSelecionados.Where(p => p.Tipo == TipoPrato.Peixe).Count();
                int numeroPratosVegetariano = pratosSelecionados.Where(p => p.Tipo == TipoPrato.Vegetariano).Count();


                int quantidade;
                bool sucesso;

                try
                {
                    quantidade = Convert.ToInt32(numQuantidadeEditar.Value);
                }
                catch (Exception)
                {
                    MessageBox.Show("Insira um valor inteiro válido para a quantidade", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (quantidade <= 0)
                {
                    MessageBox.Show("Insira um valor inteiro válido para a quantidade", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (extrasSelecionados == null || pratosSelecionados == null)
                {
                    MessageBox.Show("Erro ao obter os extras e pratos selecionados", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else if (numeroPratosCarne < 1 || numeroPratosPeixe < 1 || numeroPratosVegetariano < 1)
                {
                    MessageBox.Show("Selecione pelo menos um prato de carne, peixe e vegetariano", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    sucesso = MenuController.Editar(selectedMenu.Id, dateDataHoraEdit.Value, quantidade, numPrecoEstudanteEdit.Value, numPrecoProfEdit.Value, extrasSelecionados, pratosSelecionados);
                    selectedMenu = null;
                    foreverTabPage1.SelectedIndex = 0;
                }


                if (sucesso)
                {
                    MessageBox.Show("Menu editado com sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    limparDados();
                }
                else
                {
                    MessageBox.Show("Erro ao editar o menu", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }



        }
    }
}
