﻿namespace DA_ProjetoFinal.Views
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panelTop = new System.Windows.Forms.Panel();
            this.panelLoadingArea = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.timerSideBar = new System.Windows.Forms.Timer(this.components);
            this.panelSideBar = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnHomePage = new DA_ProjetoFinal.Components.SideBarCustomButton();
            this.sideBarCustomButton2 = new DA_ProjetoFinal.Components.SideBarCustomButton();
            this.sideBarCustomButton3 = new DA_ProjetoFinal.Components.SideBarCustomButton();
            this.sideBarCustomButton4 = new DA_ProjetoFinal.Components.SideBarCustomButton();
            this.btnReservas = new DA_ProjetoFinal.Components.SideBarCustomButton();
            this.sideBarCustomButton6 = new DA_ProjetoFinal.Components.SideBarCustomButton();
            this.sideBarCustomButton7 = new DA_ProjetoFinal.Components.SideBarCustomButton();
            this.sideBarCustomButton8 = new DA_ProjetoFinal.Components.SideBarCustomButton();
            this.pictureMinimizar = new System.Windows.Forms.PictureBox();
            this.btnSideBar = new System.Windows.Forms.PictureBox();
            this.pictureFechar = new System.Windows.Forms.PictureBox();
            this.panelTop.SuspendLayout();
            this.panelSideBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSideBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureFechar)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(22)))), ((int)(((byte)(25)))));
            this.panelTop.Controls.Add(this.pictureMinimizar);
            this.panelTop.Controls.Add(this.btnSideBar);
            this.panelTop.Controls.Add(this.pictureFechar);
            this.panelTop.Controls.Add(this.panel2);
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(803, 63);
            this.panelTop.TabIndex = 0;
            this.panelTop.Paint += new System.Windows.Forms.PaintEventHandler(this.panelTop_Paint);
            // 
            // panelLoadingArea
            // 
            this.panelLoadingArea.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panelLoadingArea.Location = new System.Drawing.Point(194, 63);
            this.panelLoadingArea.Name = "panelLoadingArea";
            this.panelLoadingArea.Size = new System.Drawing.Size(609, 555);
            this.panelLoadingArea.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(191, 63);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(597, 39);
            this.panel2.TabIndex = 11;
            // 
            // timerSideBar
            // 
            this.timerSideBar.Interval = 10;
            this.timerSideBar.Tick += new System.EventHandler(this.timerSideBar_Tick);
            // 
            // panelSideBar
            // 
            this.panelSideBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.panelSideBar.Controls.Add(this.panel1);
            this.panelSideBar.Controls.Add(this.btnHomePage);
            this.panelSideBar.Controls.Add(this.sideBarCustomButton2);
            this.panelSideBar.Controls.Add(this.sideBarCustomButton3);
            this.panelSideBar.Controls.Add(this.sideBarCustomButton4);
            this.panelSideBar.Controls.Add(this.btnReservas);
            this.panelSideBar.Controls.Add(this.sideBarCustomButton6);
            this.panelSideBar.Controls.Add(this.sideBarCustomButton7);
            this.panelSideBar.Controls.Add(this.sideBarCustomButton8);
            this.panelSideBar.Location = new System.Drawing.Point(0, 63);
            this.panelSideBar.MaximumSize = new System.Drawing.Size(202, 555);
            this.panelSideBar.MinimumSize = new System.Drawing.Size(44, 555);
            this.panelSideBar.Name = "panelSideBar";
            this.panelSideBar.Size = new System.Drawing.Size(202, 555);
            this.panelSideBar.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(197, 39);
            this.panel1.TabIndex = 10;
            // 
            // btnHomePage
            // 
            this.btnHomePage.FlatAppearance.BorderSize = 0;
            this.btnHomePage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHomePage.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btnHomePage.ForeColor = System.Drawing.Color.White;
            this.btnHomePage.HoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(221)))), ((int)(((byte)(51)))));
            this.btnHomePage.HoverImage = global::DA_ProjetoFinal.Properties.Resources.home_active_small;
            this.btnHomePage.Image = global::DA_ProjetoFinal.Properties.Resources.home_normal_small;
            this.btnHomePage.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHomePage.Location = new System.Drawing.Point(3, 48);
            this.btnHomePage.Name = "btnHomePage";
            this.btnHomePage.NormalForeColor = System.Drawing.Color.White;
            this.btnHomePage.NormalImage = global::DA_ProjetoFinal.Properties.Resources.home_normal_small;
            this.btnHomePage.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnHomePage.Size = new System.Drawing.Size(197, 47);
            this.btnHomePage.TabIndex = 11;
            this.btnHomePage.Text = "  Página principal";
            this.btnHomePage.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnHomePage.UseVisualStyleBackColor = true;
            this.btnHomePage.Click += new System.EventHandler(this.sideBarCustomButton1_Click);
            // 
            // sideBarCustomButton2
            // 
            this.sideBarCustomButton2.FlatAppearance.BorderSize = 0;
            this.sideBarCustomButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sideBarCustomButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.sideBarCustomButton2.ForeColor = System.Drawing.Color.White;
            this.sideBarCustomButton2.HoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(221)))), ((int)(((byte)(51)))));
            this.sideBarCustomButton2.HoverImage = global::DA_ProjetoFinal.Properties.Resources.home_active_small;
            this.sideBarCustomButton2.Image = global::DA_ProjetoFinal.Properties.Resources.home_normal_small;
            this.sideBarCustomButton2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.sideBarCustomButton2.Location = new System.Drawing.Point(3, 101);
            this.sideBarCustomButton2.Name = "sideBarCustomButton2";
            this.sideBarCustomButton2.NormalForeColor = System.Drawing.Color.White;
            this.sideBarCustomButton2.NormalImage = global::DA_ProjetoFinal.Properties.Resources.home_normal_small;
            this.sideBarCustomButton2.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.sideBarCustomButton2.Size = new System.Drawing.Size(197, 47);
            this.sideBarCustomButton2.TabIndex = 12;
            this.sideBarCustomButton2.Text = "  Menu";
            this.sideBarCustomButton2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.sideBarCustomButton2.UseVisualStyleBackColor = true;
            // 
            // sideBarCustomButton3
            // 
            this.sideBarCustomButton3.FlatAppearance.BorderSize = 0;
            this.sideBarCustomButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sideBarCustomButton3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.sideBarCustomButton3.ForeColor = System.Drawing.Color.White;
            this.sideBarCustomButton3.HoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(221)))), ((int)(((byte)(51)))));
            this.sideBarCustomButton3.HoverImage = global::DA_ProjetoFinal.Properties.Resources.home_active_small;
            this.sideBarCustomButton3.Image = global::DA_ProjetoFinal.Properties.Resources.home_normal_small;
            this.sideBarCustomButton3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.sideBarCustomButton3.Location = new System.Drawing.Point(3, 154);
            this.sideBarCustomButton3.Name = "sideBarCustomButton3";
            this.sideBarCustomButton3.NormalForeColor = System.Drawing.Color.White;
            this.sideBarCustomButton3.NormalImage = global::DA_ProjetoFinal.Properties.Resources.home_normal_small;
            this.sideBarCustomButton3.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.sideBarCustomButton3.Size = new System.Drawing.Size(197, 47);
            this.sideBarCustomButton3.TabIndex = 13;
            this.sideBarCustomButton3.Text = "  Pratos";
            this.sideBarCustomButton3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.sideBarCustomButton3.UseVisualStyleBackColor = true;
            // 
            // sideBarCustomButton4
            // 
            this.sideBarCustomButton4.FlatAppearance.BorderSize = 0;
            this.sideBarCustomButton4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sideBarCustomButton4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.sideBarCustomButton4.ForeColor = System.Drawing.Color.White;
            this.sideBarCustomButton4.HoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(221)))), ((int)(((byte)(51)))));
            this.sideBarCustomButton4.HoverImage = global::DA_ProjetoFinal.Properties.Resources.home_active_small;
            this.sideBarCustomButton4.Image = global::DA_ProjetoFinal.Properties.Resources.home_normal_small;
            this.sideBarCustomButton4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.sideBarCustomButton4.Location = new System.Drawing.Point(3, 207);
            this.sideBarCustomButton4.Name = "sideBarCustomButton4";
            this.sideBarCustomButton4.NormalForeColor = System.Drawing.Color.White;
            this.sideBarCustomButton4.NormalImage = global::DA_ProjetoFinal.Properties.Resources.home_normal_small;
            this.sideBarCustomButton4.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.sideBarCustomButton4.Size = new System.Drawing.Size(197, 47);
            this.sideBarCustomButton4.TabIndex = 14;
            this.sideBarCustomButton4.Text = "  Extras";
            this.sideBarCustomButton4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.sideBarCustomButton4.UseVisualStyleBackColor = true;
            // 
            // btnReservas
            // 
            this.btnReservas.FlatAppearance.BorderSize = 0;
            this.btnReservas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReservas.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btnReservas.ForeColor = System.Drawing.Color.White;
            this.btnReservas.HoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(221)))), ((int)(((byte)(51)))));
            this.btnReservas.HoverImage = global::DA_ProjetoFinal.Properties.Resources.home_active_small;
            this.btnReservas.Image = global::DA_ProjetoFinal.Properties.Resources.home_normal_small;
            this.btnReservas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReservas.Location = new System.Drawing.Point(3, 260);
            this.btnReservas.Name = "btnReservas";
            this.btnReservas.NormalForeColor = System.Drawing.Color.White;
            this.btnReservas.NormalImage = global::DA_ProjetoFinal.Properties.Resources.home_normal_small;
            this.btnReservas.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnReservas.Size = new System.Drawing.Size(197, 47);
            this.btnReservas.TabIndex = 15;
            this.btnReservas.Text = "  Reservas";
            this.btnReservas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnReservas.UseVisualStyleBackColor = true;
            this.btnReservas.Click += new System.EventHandler(this.btnReservas_Click);
            // 
            // sideBarCustomButton6
            // 
            this.sideBarCustomButton6.FlatAppearance.BorderSize = 0;
            this.sideBarCustomButton6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sideBarCustomButton6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.sideBarCustomButton6.ForeColor = System.Drawing.Color.White;
            this.sideBarCustomButton6.HoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(221)))), ((int)(((byte)(51)))));
            this.sideBarCustomButton6.HoverImage = global::DA_ProjetoFinal.Properties.Resources.home_active_small;
            this.sideBarCustomButton6.Image = global::DA_ProjetoFinal.Properties.Resources.home_normal_small;
            this.sideBarCustomButton6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.sideBarCustomButton6.Location = new System.Drawing.Point(3, 313);
            this.sideBarCustomButton6.Name = "sideBarCustomButton6";
            this.sideBarCustomButton6.NormalForeColor = System.Drawing.Color.White;
            this.sideBarCustomButton6.NormalImage = global::DA_ProjetoFinal.Properties.Resources.home_normal_small;
            this.sideBarCustomButton6.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.sideBarCustomButton6.Size = new System.Drawing.Size(197, 47);
            this.sideBarCustomButton6.TabIndex = 16;
            this.sideBarCustomButton6.Text = "  Multas";
            this.sideBarCustomButton6.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.sideBarCustomButton6.UseVisualStyleBackColor = true;
            // 
            // sideBarCustomButton7
            // 
            this.sideBarCustomButton7.FlatAppearance.BorderSize = 0;
            this.sideBarCustomButton7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sideBarCustomButton7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.sideBarCustomButton7.ForeColor = System.Drawing.Color.White;
            this.sideBarCustomButton7.HoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(221)))), ((int)(((byte)(51)))));
            this.sideBarCustomButton7.HoverImage = global::DA_ProjetoFinal.Properties.Resources.home_active_small;
            this.sideBarCustomButton7.Image = global::DA_ProjetoFinal.Properties.Resources.home_normal_small;
            this.sideBarCustomButton7.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.sideBarCustomButton7.Location = new System.Drawing.Point(3, 366);
            this.sideBarCustomButton7.Name = "sideBarCustomButton7";
            this.sideBarCustomButton7.NormalForeColor = System.Drawing.Color.White;
            this.sideBarCustomButton7.NormalImage = global::DA_ProjetoFinal.Properties.Resources.home_normal_small;
            this.sideBarCustomButton7.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.sideBarCustomButton7.Size = new System.Drawing.Size(197, 47);
            this.sideBarCustomButton7.TabIndex = 17;
            this.sideBarCustomButton7.Text = "  Funcionários";
            this.sideBarCustomButton7.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.sideBarCustomButton7.UseVisualStyleBackColor = true;
            // 
            // sideBarCustomButton8
            // 
            this.sideBarCustomButton8.FlatAppearance.BorderSize = 0;
            this.sideBarCustomButton8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sideBarCustomButton8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.sideBarCustomButton8.ForeColor = System.Drawing.Color.White;
            this.sideBarCustomButton8.HoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(221)))), ((int)(((byte)(51)))));
            this.sideBarCustomButton8.HoverImage = global::DA_ProjetoFinal.Properties.Resources.home_active_small;
            this.sideBarCustomButton8.Image = global::DA_ProjetoFinal.Properties.Resources.home_normal_small;
            this.sideBarCustomButton8.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.sideBarCustomButton8.Location = new System.Drawing.Point(3, 419);
            this.sideBarCustomButton8.Name = "sideBarCustomButton8";
            this.sideBarCustomButton8.NormalForeColor = System.Drawing.Color.White;
            this.sideBarCustomButton8.NormalImage = global::DA_ProjetoFinal.Properties.Resources.home_normal_small;
            this.sideBarCustomButton8.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.sideBarCustomButton8.Size = new System.Drawing.Size(197, 47);
            this.sideBarCustomButton8.TabIndex = 18;
            this.sideBarCustomButton8.Text = "  Clientes";
            this.sideBarCustomButton8.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.sideBarCustomButton8.UseVisualStyleBackColor = true;
            // 
            // pictureMinimizar
            // 
            this.pictureMinimizar.Image = global::DA_ProjetoFinal.Properties.Resources.minus;
            this.pictureMinimizar.Location = new System.Drawing.Point(732, 20);
            this.pictureMinimizar.Name = "pictureMinimizar";
            this.pictureMinimizar.Size = new System.Drawing.Size(25, 22);
            this.pictureMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureMinimizar.TabIndex = 3;
            this.pictureMinimizar.TabStop = false;
            // 
            // btnSideBar
            // 
            this.btnSideBar.Image = global::DA_ProjetoFinal.Properties.Resources.menu;
            this.btnSideBar.Location = new System.Drawing.Point(10, 20);
            this.btnSideBar.Name = "btnSideBar";
            this.btnSideBar.Size = new System.Drawing.Size(25, 22);
            this.btnSideBar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnSideBar.TabIndex = 2;
            this.btnSideBar.TabStop = false;
            this.btnSideBar.Click += new System.EventHandler(this.btnSideBar_Click);
            // 
            // pictureFechar
            // 
            this.pictureFechar.Image = global::DA_ProjetoFinal.Properties.Resources.x;
            this.pictureFechar.Location = new System.Drawing.Point(763, 20);
            this.pictureFechar.Name = "pictureFechar";
            this.pictureFechar.Size = new System.Drawing.Size(25, 22);
            this.pictureFechar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureFechar.TabIndex = 6;
            this.pictureFechar.TabStop = false;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 615);
            this.Controls.Add(this.panelLoadingArea);
            this.Controls.Add(this.panelSideBar);
            this.Controls.Add(this.panelTop);
            this.Name = "Main";
            this.Text = "Main";
            this.Load += new System.EventHandler(this.Main_Load);
            this.panelTop.ResumeLayout(false);
            this.panelSideBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSideBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureFechar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.PictureBox btnSideBar;
        private System.Windows.Forms.Timer timerSideBar;
        private System.Windows.Forms.FlowLayoutPanel panelSideBar;
        private System.Windows.Forms.Panel panel1;
        private Components.SideBarCustomButton btnHomePage;
        private Components.SideBarCustomButton sideBarCustomButton2;
        private Components.SideBarCustomButton sideBarCustomButton3;
        private Components.SideBarCustomButton sideBarCustomButton4;
        private Components.SideBarCustomButton btnReservas;
        private Components.SideBarCustomButton sideBarCustomButton6;
        private Components.SideBarCustomButton sideBarCustomButton7;
        private Components.SideBarCustomButton sideBarCustomButton8;
        private System.Windows.Forms.PictureBox pictureMinimizar;
        private System.Windows.Forms.PictureBox pictureFechar;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panelLoadingArea;
    }
}