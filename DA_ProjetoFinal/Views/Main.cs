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

        public Main()
        {
            InitializeComponent();
            criarEventosBtns(pictureFechar,pictureMinimizar);
            criarEventosPanel(panelTop);
            this.appName = BaseAppName + "Página inicial";
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
            form.Show();
            this.Text = appName;
        }

        private void Main_Load(object sender, EventArgs e)
        {
            loadForm(new FormPratos());
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

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
                }
            }
        }

        private void sideBarCustomButton1_Click(object sender, EventArgs e)
        {
            appName = BaseAppName + "Página inicial";
            FormHomePage form = new FormHomePage();
            form.Name = "FormHomePage";
            loadForm(form);
        }


        private void btnSideBar_Click(object sender, EventArgs e)
        {
            timerSideBar.Start();
        }


        private void btnReservas_Click(object sender, EventArgs e)
        {
            appName = BaseAppName + "Reservas";
            FormReservas form = new FormReservas();
            form.Name = "FormReservas";
            loadForm(form);
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            appName = BaseAppName + "Menus";
            Form form = new FormMenu();
            form.Name = "FormMenu";
            loadForm(form);
        }

        private void btnPlates_Click(object sender, EventArgs e)
        {
            appName = BaseAppName + "Pratos";
            Form form = new FormPratos();
            form.Name = "FormPratos";
            loadForm(form);
        }

        private void btnExtras_Click(object sender, EventArgs e)
        {
            appName = BaseAppName + "Extras";
            Form form = new FormExtras();
            form.Name = "FormExtras";
            loadForm(form);
        }

        private void btnTickets_Click(object sender, EventArgs e)
        {
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
            appName = BaseAppName + "Clientes";
            Form form = new FormClientes();
            form.Name = "FormClientes";
            loadForm(form);
        }
    }
}
