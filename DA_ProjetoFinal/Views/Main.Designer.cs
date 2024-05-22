namespace DA_ProjetoFinal.Views
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.panelTop = new System.Windows.Forms.Panel();
            this.pictureMinimizar = new System.Windows.Forms.PictureBox();
            this.btnSideBar = new System.Windows.Forms.PictureBox();
            this.pictureFechar = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panelLoadingArea = new System.Windows.Forms.Panel();
            this.timerSideBar = new System.Windows.Forms.Timer(this.components);
            this.panelSideBar = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnHomePage = new DA_ProjetoFinal.Components.SideBarCustomButton();
            this.btnMenu = new DA_ProjetoFinal.Components.SideBarCustomButton();
            this.btnPlates = new DA_ProjetoFinal.Components.SideBarCustomButton();
            this.btnExtras = new DA_ProjetoFinal.Components.SideBarCustomButton();
            this.btnReservas = new DA_ProjetoFinal.Components.SideBarCustomButton();
            this.btnTickets = new DA_ProjetoFinal.Components.SideBarCustomButton();
            this.btnFunct = new DA_ProjetoFinal.Components.SideBarCustomButton();
            this.btnClients = new DA_ProjetoFinal.Components.SideBarCustomButton();
            this.panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSideBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureFechar)).BeginInit();
            this.panelSideBar.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(191, 63);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(597, 39);
            this.panel2.TabIndex = 11;
            // 
            // panelLoadingArea
            // 
            this.panelLoadingArea.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelLoadingArea.Location = new System.Drawing.Point(194, 63);
            this.panelLoadingArea.Name = "panelLoadingArea";
            this.panelLoadingArea.Size = new System.Drawing.Size(609, 555);
            this.panelLoadingArea.TabIndex = 2;
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
            this.panelSideBar.Controls.Add(this.btnMenu);
            this.panelSideBar.Controls.Add(this.btnPlates);
            this.panelSideBar.Controls.Add(this.btnExtras);
            this.panelSideBar.Controls.Add(this.btnReservas);
            this.panelSideBar.Controls.Add(this.btnTickets);
            this.panelSideBar.Controls.Add(this.btnFunct);
            this.panelSideBar.Controls.Add(this.btnClients);
            this.panelSideBar.Location = new System.Drawing.Point(0, 63);
            this.panelSideBar.MaximumSize = new System.Drawing.Size(202, 555);
            this.panelSideBar.MinimumSize = new System.Drawing.Size(44, 555);
            this.panelSideBar.Name = "panelSideBar";
            this.panelSideBar.Size = new System.Drawing.Size(202, 555);
            this.panelSideBar.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(3, 10);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(197, 83);
            this.panel1.TabIndex = 10;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DA_ProjetoFinal.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(0, -3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(194, 86);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
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
            this.btnHomePage.Location = new System.Drawing.Point(3, 99);
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
            // btnMenu
            // 
            this.btnMenu.FlatAppearance.BorderSize = 0;
            this.btnMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btnMenu.ForeColor = System.Drawing.Color.White;
            this.btnMenu.HoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(221)))), ((int)(((byte)(51)))));
            this.btnMenu.HoverImage = global::DA_ProjetoFinal.Properties.Resources.wine_active_small;
            this.btnMenu.Image = global::DA_ProjetoFinal.Properties.Resources.wine_normal_small;
            this.btnMenu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMenu.Location = new System.Drawing.Point(3, 152);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.NormalForeColor = System.Drawing.Color.White;
            this.btnMenu.NormalImage = global::DA_ProjetoFinal.Properties.Resources.wine_normal_small;
            this.btnMenu.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnMenu.Size = new System.Drawing.Size(197, 47);
            this.btnMenu.TabIndex = 12;
            this.btnMenu.Text = "  Menu";
            this.btnMenu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMenu.UseVisualStyleBackColor = true;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // btnPlates
            // 
            this.btnPlates.FlatAppearance.BorderSize = 0;
            this.btnPlates.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlates.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btnPlates.ForeColor = System.Drawing.Color.White;
            this.btnPlates.HoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(221)))), ((int)(((byte)(51)))));
            this.btnPlates.HoverImage = global::DA_ProjetoFinal.Properties.Resources.dinner_active_small;
            this.btnPlates.Image = global::DA_ProjetoFinal.Properties.Resources.dinner_normal_small;
            this.btnPlates.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPlates.Location = new System.Drawing.Point(3, 205);
            this.btnPlates.Name = "btnPlates";
            this.btnPlates.NormalForeColor = System.Drawing.Color.White;
            this.btnPlates.NormalImage = global::DA_ProjetoFinal.Properties.Resources.dinner_normal_small;
            this.btnPlates.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnPlates.Size = new System.Drawing.Size(197, 47);
            this.btnPlates.TabIndex = 13;
            this.btnPlates.Text = "  Pratos";
            this.btnPlates.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPlates.UseVisualStyleBackColor = true;
            this.btnPlates.Click += new System.EventHandler(this.btnPlates_Click);
            // 
            // btnExtras
            // 
            this.btnExtras.FlatAppearance.BorderSize = 0;
            this.btnExtras.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExtras.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btnExtras.ForeColor = System.Drawing.Color.White;
            this.btnExtras.HoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(221)))), ((int)(((byte)(51)))));
            this.btnExtras.HoverImage = global::DA_ProjetoFinal.Properties.Resources.expansion_active_small;
            this.btnExtras.Image = global::DA_ProjetoFinal.Properties.Resources.expansion_normal_small;
            this.btnExtras.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExtras.Location = new System.Drawing.Point(3, 258);
            this.btnExtras.Name = "btnExtras";
            this.btnExtras.NormalForeColor = System.Drawing.Color.White;
            this.btnExtras.NormalImage = global::DA_ProjetoFinal.Properties.Resources.expansion_normal_small;
            this.btnExtras.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnExtras.Size = new System.Drawing.Size(197, 47);
            this.btnExtras.TabIndex = 14;
            this.btnExtras.Text = "  Extras";
            this.btnExtras.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnExtras.UseVisualStyleBackColor = true;
            this.btnExtras.Click += new System.EventHandler(this.btnExtras_Click);
            // 
            // btnReservas
            // 
            this.btnReservas.FlatAppearance.BorderSize = 0;
            this.btnReservas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReservas.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btnReservas.ForeColor = System.Drawing.Color.White;
            this.btnReservas.HoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(221)))), ((int)(((byte)(51)))));
            this.btnReservas.HoverImage = global::DA_ProjetoFinal.Properties.Resources.reception_active_small;
            this.btnReservas.Image = global::DA_ProjetoFinal.Properties.Resources.reception_normal_small;
            this.btnReservas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReservas.Location = new System.Drawing.Point(3, 311);
            this.btnReservas.Name = "btnReservas";
            this.btnReservas.NormalForeColor = System.Drawing.Color.White;
            this.btnReservas.NormalImage = global::DA_ProjetoFinal.Properties.Resources.reception_normal_small;
            this.btnReservas.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnReservas.Size = new System.Drawing.Size(197, 47);
            this.btnReservas.TabIndex = 15;
            this.btnReservas.Text = "  Reservas";
            this.btnReservas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnReservas.UseVisualStyleBackColor = true;
            this.btnReservas.Click += new System.EventHandler(this.btnReservas_Click);
            // 
            // btnTickets
            // 
            this.btnTickets.FlatAppearance.BorderSize = 0;
            this.btnTickets.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTickets.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btnTickets.ForeColor = System.Drawing.Color.White;
            this.btnTickets.HoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(221)))), ((int)(((byte)(51)))));
            this.btnTickets.HoverImage = global::DA_ProjetoFinal.Properties.Resources.penalties_active_small;
            this.btnTickets.Image = global::DA_ProjetoFinal.Properties.Resources.penalties_normal_small_png;
            this.btnTickets.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTickets.Location = new System.Drawing.Point(3, 364);
            this.btnTickets.Name = "btnTickets";
            this.btnTickets.NormalForeColor = System.Drawing.Color.White;
            this.btnTickets.NormalImage = global::DA_ProjetoFinal.Properties.Resources.penalties_normal_small_png;
            this.btnTickets.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnTickets.Size = new System.Drawing.Size(197, 47);
            this.btnTickets.TabIndex = 16;
            this.btnTickets.Text = "  Multas";
            this.btnTickets.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTickets.UseVisualStyleBackColor = true;
            this.btnTickets.Click += new System.EventHandler(this.btnTickets_Click);
            // 
            // btnFunct
            // 
            this.btnFunct.FlatAppearance.BorderSize = 0;
            this.btnFunct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFunct.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btnFunct.ForeColor = System.Drawing.Color.White;
            this.btnFunct.HoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(221)))), ((int)(((byte)(51)))));
            this.btnFunct.HoverImage = global::DA_ProjetoFinal.Properties.Resources.employee_active_small;
            this.btnFunct.Image = global::DA_ProjetoFinal.Properties.Resources.employee_normal_small;
            this.btnFunct.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFunct.Location = new System.Drawing.Point(3, 417);
            this.btnFunct.Name = "btnFunct";
            this.btnFunct.NormalForeColor = System.Drawing.Color.White;
            this.btnFunct.NormalImage = global::DA_ProjetoFinal.Properties.Resources.employee_normal_small;
            this.btnFunct.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnFunct.Size = new System.Drawing.Size(197, 47);
            this.btnFunct.TabIndex = 17;
            this.btnFunct.Text = "  Funcionários";
            this.btnFunct.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnFunct.UseVisualStyleBackColor = true;
            this.btnFunct.Click += new System.EventHandler(this.btnFunct_Click);
            // 
            // btnClients
            // 
            this.btnClients.FlatAppearance.BorderSize = 0;
            this.btnClients.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClients.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btnClients.ForeColor = System.Drawing.Color.White;
            this.btnClients.HoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(221)))), ((int)(((byte)(51)))));
            this.btnClients.HoverImage = global::DA_ProjetoFinal.Properties.Resources.customer_active_small;
            this.btnClients.Image = global::DA_ProjetoFinal.Properties.Resources.customer_normal_small;
            this.btnClients.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClients.Location = new System.Drawing.Point(3, 470);
            this.btnClients.Name = "btnClients";
            this.btnClients.NormalForeColor = System.Drawing.Color.White;
            this.btnClients.NormalImage = global::DA_ProjetoFinal.Properties.Resources.customer_normal_small;
            this.btnClients.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnClients.Size = new System.Drawing.Size(197, 47);
            this.btnClients.TabIndex = 18;
            this.btnClients.Text = "  Clientes";
            this.btnClients.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnClients.UseVisualStyleBackColor = true;
            this.btnClients.Click += new System.EventHandler(this.btnClients_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 615);
            this.Controls.Add(this.panelLoadingArea);
            this.Controls.Add(this.panelSideBar);
            this.Controls.Add(this.panelTop);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main";
            this.Load += new System.EventHandler(this.Main_Load);
            this.panelTop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSideBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureFechar)).EndInit();
            this.panelSideBar.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.PictureBox btnSideBar;
        private System.Windows.Forms.Timer timerSideBar;
        private System.Windows.Forms.FlowLayoutPanel panelSideBar;
        private System.Windows.Forms.Panel panel1;
        private Components.SideBarCustomButton btnHomePage;
        private Components.SideBarCustomButton btnMenu;
        private Components.SideBarCustomButton btnPlates;
        private Components.SideBarCustomButton btnExtras;
        private Components.SideBarCustomButton btnReservas;
        private Components.SideBarCustomButton btnTickets;
        private Components.SideBarCustomButton btnFunct;
        private Components.SideBarCustomButton btnClients;
        private System.Windows.Forms.PictureBox pictureMinimizar;
        private System.Windows.Forms.PictureBox pictureFechar;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panelLoadingArea;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}