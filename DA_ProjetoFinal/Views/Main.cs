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

        public Main()
        {
            InitializeComponent();
            criarEventosBtns(pictureFechar,pictureMinimizar);
            criarEventosPanel(panelTop);
            initialPosLoading = panelLoadingArea.Location;



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
            FormHomePage form = new FormHomePage();
            loadForm(form);
        }

        private void panelTop_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnSideBar_Click(object sender, EventArgs e)
        {
            timerSideBar.Start();
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
        }

        private void btnReservas_Click(object sender, EventArgs e)
        {
            FormReservas form = new FormReservas();
            loadForm(form);
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            Form form = new FormMenu();
            loadForm(form);
        }

        private void btnPlates_Click(object sender, EventArgs e)
        {
            Form form = new FormPratos();
            loadForm(form);
        }

        private void btnExtras_Click(object sender, EventArgs e)
        {
            Form form = new FormExtras();
            loadForm(form);
        }

        private void btnTickets_Click(object sender, EventArgs e)
        {
            Form form = new FormMultas();
            loadForm(form);
        }

        private void btnFunct_Click(object sender, EventArgs e)
        {
            Form form = new FormFuncionarios();
            loadForm(form);
        }

        private void btnClients_Click(object sender, EventArgs e)
        {
            Form form = new FormClientes();
            loadForm(form);
        }
    }
}
