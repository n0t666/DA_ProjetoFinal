﻿namespace DA_ProjetoFinal.Views
{
    partial class FormReservas
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.tabPageListarMenus = new System.Windows.Forms.TabPage();
            this.tabPageCriarReserva = new System.Windows.Forms.TabPage();
            this.btnBackCliente = new ReaLTaiizor.Controls.AloneButton();
            this.btnNextCliente = new ReaLTaiizor.Controls.AloneButton();
            this.btnNextMenu = new ReaLTaiizor.Controls.AloneButton();
            this.btnBackMenu = new ReaLTaiizor.Controls.AloneButton();
            this.hopeCheckBox1 = new ReaLTaiizor.Controls.HopeCheckBox();
            this.btnSubmit = new ReaLTaiizor.Controls.HopeRoundButton();
            this.bigLabel3 = new ReaLTaiizor.Controls.BigLabel();
            this.comboBoxMenus = new ReaLTaiizor.Controls.PoisonComboBox();
            this.bigLabel2 = new ReaLTaiizor.Controls.BigLabel();
            this.bigLabel1 = new ReaLTaiizor.Controls.BigLabel();
            this.comboBoxClientes = new ReaLTaiizor.Controls.PoisonComboBox();
            this.bigLabel8 = new ReaLTaiizor.Controls.BigLabel();
            this.pnlExtras = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlPratos = new System.Windows.Forms.FlowLayoutPanel();
            this.foreverTabPage1 = new ReaLTaiizor.Controls.ForeverTabPage();
            this.lblSaldo = new ReaLTaiizor.Controls.DungeonHeaderLabel();
            this.lblQuantidadeMenu = new ReaLTaiizor.Controls.DungeonHeaderLabel();
            this.tabPageCriarReserva.SuspendLayout();
            this.foreverTabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(-1, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(610, 24);
            this.panel1.TabIndex = 1;
            // 
            // tabPageListarMenus
            // 
            this.tabPageListarMenus.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabPageListarMenus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.tabPageListarMenus.Location = new System.Drawing.Point(4, 64);
            this.tabPageListarMenus.Name = "tabPageListarMenus";
            this.tabPageListarMenus.Size = new System.Drawing.Size(606, 487);
            this.tabPageListarMenus.TabIndex = 3;
            this.tabPageListarMenus.Text = "Marcar reserva";
            // 
            // tabPageCriarReserva
            // 
            this.tabPageCriarReserva.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabPageCriarReserva.Controls.Add(this.lblQuantidadeMenu);
            this.tabPageCriarReserva.Controls.Add(this.lblSaldo);
            this.tabPageCriarReserva.Controls.Add(this.btnBackCliente);
            this.tabPageCriarReserva.Controls.Add(this.btnNextCliente);
            this.tabPageCriarReserva.Controls.Add(this.btnNextMenu);
            this.tabPageCriarReserva.Controls.Add(this.btnBackMenu);
            this.tabPageCriarReserva.Controls.Add(this.hopeCheckBox1);
            this.tabPageCriarReserva.Controls.Add(this.btnSubmit);
            this.tabPageCriarReserva.Controls.Add(this.bigLabel3);
            this.tabPageCriarReserva.Controls.Add(this.comboBoxMenus);
            this.tabPageCriarReserva.Controls.Add(this.bigLabel2);
            this.tabPageCriarReserva.Controls.Add(this.bigLabel1);
            this.tabPageCriarReserva.Controls.Add(this.comboBoxClientes);
            this.tabPageCriarReserva.Controls.Add(this.bigLabel8);
            this.tabPageCriarReserva.Controls.Add(this.pnlExtras);
            this.tabPageCriarReserva.Controls.Add(this.pnlPratos);
            this.tabPageCriarReserva.Location = new System.Drawing.Point(4, 64);
            this.tabPageCriarReserva.Name = "tabPageCriarReserva";
            this.tabPageCriarReserva.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageCriarReserva.Size = new System.Drawing.Size(606, 487);
            this.tabPageCriarReserva.TabIndex = 1;
            this.tabPageCriarReserva.Text = "Efetuar reserva";
            this.tabPageCriarReserva.ToolTipText = "Adicionar prato";
            // 
            // btnBackCliente
            // 
            this.btnBackCliente.BackColor = System.Drawing.Color.Transparent;
            this.btnBackCliente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBackCliente.EnabledCalc = true;
            this.btnBackCliente.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBackCliente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(133)))), ((int)(((byte)(142)))));
            this.btnBackCliente.Location = new System.Drawing.Point(146, 51);
            this.btnBackCliente.Name = "btnBackCliente";
            this.btnBackCliente.Size = new System.Drawing.Size(16, 18);
            this.btnBackCliente.TabIndex = 79;
            this.btnBackCliente.Text = "<";
            this.btnBackCliente.Click += new ReaLTaiizor.Controls.AloneButton.ClickEventHandler(this.btnBackCliente_Click);
            // 
            // btnNextCliente
            // 
            this.btnNextCliente.BackColor = System.Drawing.Color.Transparent;
            this.btnNextCliente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNextCliente.EnabledCalc = true;
            this.btnNextCliente.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnNextCliente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(133)))), ((int)(((byte)(142)))));
            this.btnNextCliente.Location = new System.Drawing.Point(448, 51);
            this.btnNextCliente.Name = "btnNextCliente";
            this.btnNextCliente.Size = new System.Drawing.Size(16, 18);
            this.btnNextCliente.TabIndex = 78;
            this.btnNextCliente.Text = ">";
            this.btnNextCliente.Click += new ReaLTaiizor.Controls.AloneButton.ClickEventHandler(this.btnNextCliente_Click);
            // 
            // btnNextMenu
            // 
            this.btnNextMenu.BackColor = System.Drawing.Color.Transparent;
            this.btnNextMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNextMenu.EnabledCalc = true;
            this.btnNextMenu.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnNextMenu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(133)))), ((int)(((byte)(142)))));
            this.btnNextMenu.Location = new System.Drawing.Point(445, 146);
            this.btnNextMenu.Name = "btnNextMenu";
            this.btnNextMenu.Size = new System.Drawing.Size(16, 18);
            this.btnNextMenu.TabIndex = 76;
            this.btnNextMenu.Text = ">";
            this.btnNextMenu.Click += new ReaLTaiizor.Controls.AloneButton.ClickEventHandler(this.btnNextMenu_Click);
            // 
            // btnBackMenu
            // 
            this.btnBackMenu.BackColor = System.Drawing.Color.Transparent;
            this.btnBackMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBackMenu.EnabledCalc = true;
            this.btnBackMenu.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBackMenu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(133)))), ((int)(((byte)(142)))));
            this.btnBackMenu.Location = new System.Drawing.Point(143, 146);
            this.btnBackMenu.Name = "btnBackMenu";
            this.btnBackMenu.Size = new System.Drawing.Size(16, 18);
            this.btnBackMenu.TabIndex = 77;
            this.btnBackMenu.Text = "<";
            this.btnBackMenu.Click += new ReaLTaiizor.Controls.AloneButton.ClickEventHandler(this.btnBackMenu_Click);
            // 
            // hopeCheckBox1
            // 
            this.hopeCheckBox1.AutoSize = true;
            this.hopeCheckBox1.CheckedColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(158)))), ((int)(((byte)(255)))));
            this.hopeCheckBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.hopeCheckBox1.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(198)))), ((int)(((byte)(202)))));
            this.hopeCheckBox1.DisabledStringColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(187)))), ((int)(((byte)(189)))));
            this.hopeCheckBox1.Enable = true;
            this.hopeCheckBox1.EnabledCheckedColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(158)))), ((int)(((byte)(255)))));
            this.hopeCheckBox1.EnabledStringColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.hopeCheckBox1.EnabledUncheckedColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(158)))), ((int)(((byte)(161)))));
            this.hopeCheckBox1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.hopeCheckBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(49)))), ((int)(((byte)(51)))));
            this.hopeCheckBox1.Location = new System.Drawing.Point(142, 412);
            this.hopeCheckBox1.Name = "hopeCheckBox1";
            this.hopeCheckBox1.Size = new System.Drawing.Size(138, 20);
            this.hopeCheckBox1.TabIndex = 75;
            this.hopeCheckBox1.Text = "Remember me";
            this.hopeCheckBox1.UseVisualStyleBackColor = true;
            // 
            // btnSubmit
            // 
            this.btnSubmit.BorderColor = System.Drawing.Color.Transparent;
            this.btnSubmit.ButtonType = ReaLTaiizor.Util.HopeButtonType.Primary;
            this.btnSubmit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSubmit.DangerColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(108)))), ((int)(((byte)(108)))));
            this.btnSubmit.DefaultColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnSubmit.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnSubmit.HoverTextColor = System.Drawing.Color.WhiteSmoke;
            this.btnSubmit.InfoColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(147)))), ((int)(((byte)(153)))));
            this.btnSubmit.Location = new System.Drawing.Point(142, 438);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.PrimaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(158)))), ((int)(((byte)(255)))));
            this.btnSubmit.Size = new System.Drawing.Size(321, 31);
            this.btnSubmit.SuccessColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(194)))), ((int)(((byte)(58)))));
            this.btnSubmit.TabIndex = 74;
            this.btnSubmit.Text = "SUBMETER";
            this.btnSubmit.TextColor = System.Drawing.Color.White;
            this.btnSubmit.WarningColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(162)))), ((int)(((byte)(60)))));
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // bigLabel3
            // 
            this.bigLabel3.AutoSize = true;
            this.bigLabel3.BackColor = System.Drawing.Color.Transparent;
            this.bigLabel3.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bigLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.bigLabel3.Location = new System.Drawing.Point(36, 107);
            this.bigLabel3.Name = "bigLabel3";
            this.bigLabel3.Size = new System.Drawing.Size(92, 32);
            this.bigLabel3.TabIndex = 73;
            this.bigLabel3.Text = "Menus:";
            // 
            // comboBoxMenus
            // 
            this.comboBoxMenus.FormattingEnabled = true;
            this.comboBoxMenus.ItemHeight = 23;
            this.comboBoxMenus.Location = new System.Drawing.Point(143, 110);
            this.comboBoxMenus.Name = "comboBoxMenus";
            this.comboBoxMenus.Size = new System.Drawing.Size(318, 29);
            this.comboBoxMenus.TabIndex = 72;
            this.comboBoxMenus.UseSelectable = true;
            this.comboBoxMenus.SelectionChangeCommitted += new System.EventHandler(this.comboBoxMenus_SelectionChangeCommitted);
            // 
            // bigLabel2
            // 
            this.bigLabel2.AutoSize = true;
            this.bigLabel2.BackColor = System.Drawing.Color.Transparent;
            this.bigLabel2.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bigLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.bigLabel2.Location = new System.Drawing.Point(34, 13);
            this.bigLabel2.Name = "bigLabel2";
            this.bigLabel2.Size = new System.Drawing.Size(94, 32);
            this.bigLabel2.TabIndex = 69;
            this.bigLabel2.Text = "Cliente:";
            // 
            // bigLabel1
            // 
            this.bigLabel1.AutoSize = true;
            this.bigLabel1.BackColor = System.Drawing.Color.Transparent;
            this.bigLabel1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bigLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.bigLabel1.Location = new System.Drawing.Point(43, 204);
            this.bigLabel1.Name = "bigLabel1";
            this.bigLabel1.Size = new System.Drawing.Size(84, 32);
            this.bigLabel1.TabIndex = 65;
            this.bigLabel1.Text = "Pratos:";
            // 
            // comboBoxClientes
            // 
            this.comboBoxClientes.FormattingEnabled = true;
            this.comboBoxClientes.ItemHeight = 23;
            this.comboBoxClientes.Location = new System.Drawing.Point(146, 16);
            this.comboBoxClientes.Name = "comboBoxClientes";
            this.comboBoxClientes.Size = new System.Drawing.Size(318, 29);
            this.comboBoxClientes.TabIndex = 63;
            this.comboBoxClientes.UseSelectable = true;
            this.comboBoxClientes.SelectionChangeCommitted += new System.EventHandler(this.comboBoxClientes_SelectionChangeCommitted);
            // 
            // bigLabel8
            // 
            this.bigLabel8.AutoSize = true;
            this.bigLabel8.BackColor = System.Drawing.Color.Transparent;
            this.bigLabel8.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bigLabel8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.bigLabel8.Location = new System.Drawing.Point(45, 308);
            this.bigLabel8.Name = "bigLabel8";
            this.bigLabel8.Size = new System.Drawing.Size(80, 32);
            this.bigLabel8.TabIndex = 52;
            this.bigLabel8.Text = "Extras:";
            // 
            // pnlExtras
            // 
            this.pnlExtras.Location = new System.Drawing.Point(140, 308);
            this.pnlExtras.Name = "pnlExtras";
            this.pnlExtras.Size = new System.Drawing.Size(321, 94);
            this.pnlExtras.TabIndex = 62;
            // 
            // pnlPratos
            // 
            this.pnlPratos.Location = new System.Drawing.Point(140, 204);
            this.pnlPratos.Name = "pnlPratos";
            this.pnlPratos.Size = new System.Drawing.Size(321, 98);
            this.pnlPratos.TabIndex = 61;
            // 
            // foreverTabPage1
            // 
            this.foreverTabPage1.ActiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(168)))), ((int)(((byte)(109)))));
            this.foreverTabPage1.ActiveFontColor = System.Drawing.Color.White;
            this.foreverTabPage1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.foreverTabPage1.BGColor = System.Drawing.Color.WhiteSmoke;
            this.foreverTabPage1.Controls.Add(this.tabPageCriarReserva);
            this.foreverTabPage1.Controls.Add(this.tabPageListarMenus);
            this.foreverTabPage1.DeactiveFontColor = System.Drawing.Color.White;
            this.foreverTabPage1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.foreverTabPage1.ItemSize = new System.Drawing.Size(140, 60);
            this.foreverTabPage1.Location = new System.Drawing.Point(-2, 0);
            this.foreverTabPage1.Name = "foreverTabPage1";
            this.foreverTabPage1.SelectedIndex = 0;
            this.foreverTabPage1.Size = new System.Drawing.Size(614, 555);
            this.foreverTabPage1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.foreverTabPage1.TabIndex = 2;
            // 
            // lblSaldo
            // 
            this.lblSaldo.AutoSize = true;
            this.lblSaldo.BackColor = System.Drawing.Color.Transparent;
            this.lblSaldo.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblSaldo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(77)))));
            this.lblSaldo.Location = new System.Drawing.Point(142, 76);
            this.lblSaldo.Name = "lblSaldo";
            this.lblSaldo.Size = new System.Drawing.Size(51, 20);
            this.lblSaldo.TabIndex = 80;
            this.lblSaldo.Text = "Saldo:";
            // 
            // lblQuantidadeMenu
            // 
            this.lblQuantidadeMenu.AutoSize = true;
            this.lblQuantidadeMenu.BackColor = System.Drawing.Color.Transparent;
            this.lblQuantidadeMenu.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblQuantidadeMenu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(77)))));
            this.lblQuantidadeMenu.Location = new System.Drawing.Point(139, 173);
            this.lblQuantidadeMenu.Name = "lblQuantidadeMenu";
            this.lblQuantidadeMenu.Size = new System.Drawing.Size(94, 20);
            this.lblQuantidadeMenu.TabIndex = 81;
            this.lblQuantidadeMenu.Text = "Quantidade:";
            // 
            // FormReservas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(610, 555);
            this.Controls.Add(this.foreverTabPage1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormReservas";
            this.Text = "FormReservas";
            this.tabPageCriarReserva.ResumeLayout(false);
            this.tabPageCriarReserva.PerformLayout();
            this.foreverTabPage1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TabPage tabPageListarMenus;
        private System.Windows.Forms.TabPage tabPageCriarReserva;
        private ReaLTaiizor.Controls.BigLabel bigLabel1;
        private ReaLTaiizor.Controls.PoisonComboBox comboBoxClientes;
        private ReaLTaiizor.Controls.BigLabel bigLabel8;
        private System.Windows.Forms.FlowLayoutPanel pnlExtras;
        private System.Windows.Forms.FlowLayoutPanel pnlPratos;
        private ReaLTaiizor.Controls.ForeverTabPage foreverTabPage1;
        private ReaLTaiizor.Controls.BigLabel bigLabel2;
        private ReaLTaiizor.Controls.BigLabel bigLabel3;
        private ReaLTaiizor.Controls.PoisonComboBox comboBoxMenus;
        private ReaLTaiizor.Controls.AloneButton btnBackCliente;
        private ReaLTaiizor.Controls.AloneButton btnNextCliente;
        private ReaLTaiizor.Controls.AloneButton btnNextMenu;
        private ReaLTaiizor.Controls.AloneButton btnBackMenu;
        private ReaLTaiizor.Controls.HopeCheckBox hopeCheckBox1;
        private ReaLTaiizor.Controls.HopeRoundButton btnSubmit;
        private ReaLTaiizor.Controls.DungeonHeaderLabel lblSaldo;
        private ReaLTaiizor.Controls.DungeonHeaderLabel lblQuantidadeMenu;
    }
}