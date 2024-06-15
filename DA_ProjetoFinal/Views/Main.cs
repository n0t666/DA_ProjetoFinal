using DA_ProjetoFinal;
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
    public partial class Main : Form_Borderless
    {
        private bool sideBarExpanded = false;
        private Point initialPosLoading = new Point();
        private string BaseAppName = "FoodFlow | ";
        private string appName;
        private Utilizador utilizadorAtual;
        private int utilizadorAtualId;
        private int reservaUtilizadorId =-1;
        private bool firstTimeHome = true;
        private string currentLoadedFormName;
        

        public Main()
        {
            InitializeComponent();
            criarEventosBtns(pictureFechar,pictureMinimizar);
            criarEventosPanel(panelTop);
            this.appName = BaseAppName + "Página inicial";
            initialPosLoading = panelLoadingArea.Location;
        }

        private void loadForm(Form form)
        {

            foreach (Control ctrl in panelLoadingArea.Controls)
            {
                if (ctrl.Name == form.Name)
                {
                    return;
                }
 
            }

            panelLoadingArea.Controls.Clear();
            form.TopLevel = false;
            panelLoadingArea.Controls.Add(form);
            form.Dock = DockStyle.Fill;
            currentLoadedFormName = form.Name;
            form.Show();
            this.Text = appName;
        }

        private void Main_Load(object sender, EventArgs e)
        {
            btnHomePage.PerformClick();
            changeSideState(false);
        }


     

        private void timerSideBar_Tick(object sender, EventArgs e)
        {
            if (sideBarExpanded)
            {
                panelSideBar.Width -= 20;
                if(panelSideBar.Width == panelSideBar.MinimumSize.Width)
                {
                    timerSideBar.Stop();
                    sideBarExpanded = false;
                    UtilityController.Center( panelLoadingArea);
                    if(currentLoadedFormName == "FormReservas" || currentLoadedFormName == "FormPratos " || currentLoadedFormName == "FormExtras")
                    {
                        this.BackColor = Color.FromArgb(33, 37, 41);
                    }                
                }
        
            }
            else
            {
                panelSideBar.Width += 20;
                if (panelSideBar.Width == panelSideBar.MaximumSize.Width)
                {
                    timerSideBar.Stop();
                    sideBarExpanded = true;
                    panelLoadingArea.Location = initialPosLoading;
                    this.BackColor = Color.FromName("Control");
                }
            }
            this.Refresh();
        }

        private void sideBarCustomButton1_Click(object sender, EventArgs e)
        {
            appName = BaseAppName + "Página inicial";
            FormHomePage form = new FormHomePage(firstTimeHome,utilizadorAtualId);
            form.Name = "FormHomePage";
            form.UtilizadorSelectedChanged +=  Utilizador_SelectedChanged;
            form.HomePage_FirsTimeLoad += HomePage_FirsTimeLoad;
            form.SemanaDataSelected += semanaSelected;
            loadForm(form);
        }


        private void btnSideBar_Click(object sender, EventArgs e)
        {
            timerSideBar.Start();
        }


        private void btnReservas_Click(object sender, EventArgs e)
        {
            if (utilizadorAtual == null || !(utilizadorAtual is Funcionario))
            {
                MessageBox.Show("Apenas funcionários podem aceder a esta funcionalidade", "Acesso negado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            appName = BaseAppName + "Reservas";
            FormReservas form = new FormReservas(utilizadorAtualId,null, reservaUtilizadorId);
            form.Name = "FormReservas";
            form.RememberMeSelected += Utilizador_ReservaSelected;
            loadForm(form);
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            if (utilizadorAtual == null || !(utilizadorAtual is Funcionario))
            {
                MessageBox.Show("Apenas funcionários podem aceder a esta funcionalidade", "Acesso negado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            appName = BaseAppName + "Menus";
            Form form = new FormMenu();
            form.Name = "FormMenu";
            loadForm(form);
        }

        private void btnPlates_Click(object sender, EventArgs e)
        {
            if(utilizadorAtual == null || !(utilizadorAtual is Funcionario))
            {
                MessageBox.Show("Apenas funcionários podem aceder a esta funcionalidade", "Acesso negado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            appName = BaseAppName + "Pratos";
            Form form = new FormPratos();
            form.Name = "FormPratos";
            loadForm(form);
        }

        private void btnExtras_Click(object sender, EventArgs e)
        {
            if (utilizadorAtual == null || !(utilizadorAtual is Funcionario))
            {
                MessageBox.Show("Apenas funcionários podem aceder a esta funcionalidade", "Acesso negado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            appName = BaseAppName + "Extras";
            Form form = new FormExtras();
            form.Name = "FormExtras";
            loadForm(form);
        }

        private void btnTickets_Click(object sender, EventArgs e)
        {
            if (utilizadorAtual == null || !(utilizadorAtual is Funcionario))
            {
                MessageBox.Show("Apenas funcionários podem aceder a esta funcionalidade", "Acesso negado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            appName = BaseAppName + "Multas";
            Form form = new FormMultas();
            form.Name = "FormMultas";
            loadForm(form);
        }

        private void btnFunct_Click(object sender, EventArgs e)
        {
            appName = BaseAppName + "Funcionários";
            Form form = new FormFuncionarios();
            form.Name = "FormFuncionarios";
            loadForm(form);
        }

        private void btnClients_Click(object sender, EventArgs e)
        {
            if (utilizadorAtual == null || !(utilizadorAtual is Funcionario))
            {
                MessageBox.Show("Apenas funcionários podem aceder a esta funcionalidade", "Acesso negado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            appName = BaseAppName + "Clientes";
            Form form = new FormClientes();
            form.Name = "FormClientes";
            loadForm(form);
        }

        private void Utilizador_SelectedChanged(object sender, int utilizador) // Evento que permite obter o id do utilizador selecionado, o trigger deste evento é feito no form FormHomePage
        {
            utilizadorAtualId = utilizador;
            utilizadorAtual=UtilizadorController.GetById(utilizadorAtualId);
        }

        private void HomePage_FirsTimeLoad(object sender, bool firstTime)
        {
            firstTimeHome = firstTime;
            changeSideState(true);
        }

        private void Utilizador_ReservaSelected(object sender, int id)
        {
            reservaUtilizadorId = id;
        }

        private void semanaSelected(object sender, DateTime data)
        {
            appName = BaseAppName + "Reservas";
            Form form = new FormReservas(utilizadorAtualId, data, reservaUtilizadorId);
            form.Name = "FormReservas";
            loadForm(form); 
        }

        private void changeSideState(bool state) 
        {

            foreach(Control ctrl in panelSideBar.Controls)
            {
                ctrl.Enabled = state;
            }
            btnSideBar.Enabled = state;
        }



    }
}
