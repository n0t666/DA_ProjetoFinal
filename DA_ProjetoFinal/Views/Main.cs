﻿using DA_ProjetoFinal;
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
        bool sideBarExpanded = false;

        public Main()
        {
            InitializeComponent();
            criarEventosBtns(pictureFechar,pictureMinimizar);
            criarEventosPanel(panelTop);

        }

        private void Main_Load(object sender, EventArgs e)
        {
            loadForm(new FormReservas());
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
                }
        
            }
            else
            {
                panelSideBar.Width += 20;
                if (panelSideBar.Width == panelSideBar.MaximumSize.Width)
                {
                    timerSideBar.Stop();
                    sideBarExpanded = true;
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
    }
}
