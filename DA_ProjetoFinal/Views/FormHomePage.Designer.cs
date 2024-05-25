namespace DA_ProjetoFinal.Views
{
    partial class FormHomePage
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
            this.panelCenter = new System.Windows.Forms.Panel();
            this.datePickAtual = new ReaLTaiizor.Controls.PoisonDateTime();
            this.comboSemana = new ReaLTaiizor.Controls.PoisonComboBox();
            this.comboUtilizador = new ReaLTaiizor.Controls.PoisonComboBox();
            this.btnMenu = new ReaLTaiizor.Controls.PoisonButton();
            this.txtMenuDia = new ReaLTaiizor.Controls.HopeRichTextBox();
            this.comboTipoUtilizador = new ReaLTaiizor.Controls.PoisonComboBox();
            this.btnPaginateAvancar = new ReaLTaiizor.Controls.AloneButton();
            this.btnPaginateVoltar = new ReaLTaiizor.Controls.AloneButton();
            this.btnSelecionarUtilizador = new ReaLTaiizor.Controls.AloneButton();
            this.labelUtilizadorAtual = new ReaLTaiizor.Controls.DungeonLabel();
            this.dungeonLabel4 = new ReaLTaiizor.Controls.DungeonLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureInfoWeek = new ReaLTaiizor.Controls.HopePictureBox();
            this.picUtilizadorPfp = new System.Windows.Forms.PictureBox();
            this.spinnerLoading = new ReaLTaiizor.Controls.PoisonProgressSpinner();
            this.labelLoading = new ReaLTaiizor.Controls.BigLabel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureInfoWeek)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picUtilizadorPfp)).BeginInit();
            this.SuspendLayout();
            // 
            // panelCenter
            // 
            this.panelCenter.Location = new System.Drawing.Point(-1, 0);
            this.panelCenter.Name = "panelCenter";
            this.panelCenter.Size = new System.Drawing.Size(610, 29);
            this.panelCenter.TabIndex = 1;
            // 
            // datePickAtual
            // 
            this.datePickAtual.Location = new System.Drawing.Point(0, 293);
            this.datePickAtual.MinimumSize = new System.Drawing.Size(0, 29);
            this.datePickAtual.Name = "datePickAtual";
            this.datePickAtual.Size = new System.Drawing.Size(194, 29);
            this.datePickAtual.Style = ReaLTaiizor.Enum.Poison.ColorStyle.Black;
            this.datePickAtual.TabIndex = 54;
            this.datePickAtual.ValueChanged += new System.EventHandler(this.datePickAtual_ValueChanged);
            // 
            // comboSemana
            // 
            this.comboSemana.FormattingEnabled = true;
            this.comboSemana.ItemHeight = 23;
            this.comboSemana.Location = new System.Drawing.Point(286, 293);
            this.comboSemana.Name = "comboSemana";
            this.comboSemana.Size = new System.Drawing.Size(235, 29);
            this.comboSemana.TabIndex = 55;
            this.comboSemana.UseSelectable = true;
            // 
            // comboUtilizador
            // 
            this.comboUtilizador.FormattingEnabled = true;
            this.comboUtilizador.ItemHeight = 23;
            this.comboUtilizador.Location = new System.Drawing.Point(262, 223);
            this.comboUtilizador.Name = "comboUtilizador";
            this.comboUtilizador.PromptText = "Selecione o utilizador...";
            this.comboUtilizador.Size = new System.Drawing.Size(259, 29);
            this.comboUtilizador.TabIndex = 56;
            this.comboUtilizador.UseSelectable = true;
            this.comboUtilizador.SelectedIndexChanged += new System.EventHandler(this.comboUtilizador_SelectedIndexChanged);
            // 
            // btnMenu
            // 
            this.btnMenu.Location = new System.Drawing.Point(54, 471);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(425, 23);
            this.btnMenu.TabIndex = 57;
            this.btnMenu.Text = "poisonButton1";
            this.btnMenu.UseSelectable = true;
            // 
            // txtMenuDia
            // 
            this.txtMenuDia.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(223)))), ((int)(((byte)(230)))));
            this.txtMenuDia.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtMenuDia.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(49)))), ((int)(((byte)(51)))));
            this.txtMenuDia.Hint = "";
            this.txtMenuDia.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(158)))), ((int)(((byte)(255)))));
            this.txtMenuDia.Location = new System.Drawing.Point(3, 333);
            this.txtMenuDia.MaxLength = 32767;
            this.txtMenuDia.Multiline = true;
            this.txtMenuDia.Name = "txtMenuDia";
            this.txtMenuDia.PasswordChar = '\0';
            this.txtMenuDia.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtMenuDia.SelectedText = "";
            this.txtMenuDia.SelectionLength = 0;
            this.txtMenuDia.SelectionStart = 0;
            this.txtMenuDia.Size = new System.Drawing.Size(520, 132);
            this.txtMenuDia.TabIndex = 58;
            this.txtMenuDia.TabStop = false;
            this.txtMenuDia.Text = "hopeRichTextBox1";
            this.txtMenuDia.UseSystemPasswordChar = false;
            // 
            // comboTipoUtilizador
            // 
            this.comboTipoUtilizador.FormattingEnabled = true;
            this.comboTipoUtilizador.ItemHeight = 23;
            this.comboTipoUtilizador.Items.AddRange(new object[] {
            "Funcionário",
            "Cliente"});
            this.comboTipoUtilizador.Location = new System.Drawing.Point(0, 223);
            this.comboTipoUtilizador.Name = "comboTipoUtilizador";
            this.comboTipoUtilizador.PromptText = "Introduza o tipo de utilizador..";
            this.comboTipoUtilizador.Size = new System.Drawing.Size(232, 29);
            this.comboTipoUtilizador.TabIndex = 59;
            this.comboTipoUtilizador.UseSelectable = true;
            this.comboTipoUtilizador.SelectionChangeCommitted += new System.EventHandler(this.comboTipoUtilizador_SelectionChangeCommitted);
            // 
            // btnPaginateAvancar
            // 
            this.btnPaginateAvancar.BackColor = System.Drawing.Color.Transparent;
            this.btnPaginateAvancar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPaginateAvancar.EnabledCalc = true;
            this.btnPaginateAvancar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPaginateAvancar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(133)))), ((int)(((byte)(142)))));
            this.btnPaginateAvancar.Location = new System.Drawing.Point(478, 258);
            this.btnPaginateAvancar.Name = "btnPaginateAvancar";
            this.btnPaginateAvancar.Size = new System.Drawing.Size(43, 22);
            this.btnPaginateAvancar.TabIndex = 61;
            this.btnPaginateAvancar.Text = ">";
            this.btnPaginateAvancar.Click += new ReaLTaiizor.Controls.AloneButton.ClickEventHandler(this.btnPaginateAvancar_Click);
            // 
            // btnPaginateVoltar
            // 
            this.btnPaginateVoltar.BackColor = System.Drawing.Color.Transparent;
            this.btnPaginateVoltar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPaginateVoltar.EnabledCalc = true;
            this.btnPaginateVoltar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnPaginateVoltar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(133)))), ((int)(((byte)(142)))));
            this.btnPaginateVoltar.Location = new System.Drawing.Point(262, 258);
            this.btnPaginateVoltar.Name = "btnPaginateVoltar";
            this.btnPaginateVoltar.Size = new System.Drawing.Size(43, 22);
            this.btnPaginateVoltar.TabIndex = 60;
            this.btnPaginateVoltar.Text = "<";
            this.btnPaginateVoltar.Click += new ReaLTaiizor.Controls.AloneButton.ClickEventHandler(this.btnPaginateVoltar_Click);
            // 
            // btnSelecionarUtilizador
            // 
            this.btnSelecionarUtilizador.BackColor = System.Drawing.Color.Transparent;
            this.btnSelecionarUtilizador.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSelecionarUtilizador.EnabledCalc = true;
            this.btnSelecionarUtilizador.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnSelecionarUtilizador.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(133)))), ((int)(((byte)(142)))));
            this.btnSelecionarUtilizador.Location = new System.Drawing.Point(331, 258);
            this.btnSelecionarUtilizador.Name = "btnSelecionarUtilizador";
            this.btnSelecionarUtilizador.Size = new System.Drawing.Size(135, 22);
            this.btnSelecionarUtilizador.TabIndex = 62;
            this.btnSelecionarUtilizador.Text = "SELECIONAR";
            this.btnSelecionarUtilizador.Click += new ReaLTaiizor.Controls.AloneButton.ClickEventHandler(this.btnSelecionarUtilizador_Click);
            // 
            // labelUtilizadorAtual
            // 
            this.labelUtilizadorAtual.AutoSize = true;
            this.labelUtilizadorAtual.BackColor = System.Drawing.Color.Transparent;
            this.labelUtilizadorAtual.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.labelUtilizadorAtual.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(77)))));
            this.labelUtilizadorAtual.Location = new System.Drawing.Point(-4, 160);
            this.labelUtilizadorAtual.Name = "labelUtilizadorAtual";
            this.labelUtilizadorAtual.Size = new System.Drawing.Size(162, 30);
            this.labelUtilizadorAtual.TabIndex = 63;
            this.labelUtilizadorAtual.Text = "Utilizador atual:";
            // 
            // dungeonLabel4
            // 
            this.dungeonLabel4.AutoSize = true;
            this.dungeonLabel4.BackColor = System.Drawing.Color.Transparent;
            this.dungeonLabel4.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.dungeonLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(77)))));
            this.dungeonLabel4.Location = new System.Drawing.Point(-3, 200);
            this.dungeonLabel4.Name = "dungeonLabel4";
            this.dungeonLabel4.Size = new System.Drawing.Size(124, 20);
            this.dungeonLabel4.TabIndex = 66;
            this.dungeonLabel4.Text = "Alterar utilizador:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.labelLoading);
            this.panel1.Controls.Add(this.spinnerLoading);
            this.panel1.Controls.Add(this.pictureInfoWeek);
            this.panel1.Controls.Add(this.dungeonLabel4);
            this.panel1.Controls.Add(this.labelUtilizadorAtual);
            this.panel1.Controls.Add(this.btnSelecionarUtilizador);
            this.panel1.Controls.Add(this.btnPaginateVoltar);
            this.panel1.Controls.Add(this.btnPaginateAvancar);
            this.panel1.Controls.Add(this.comboTipoUtilizador);
            this.panel1.Controls.Add(this.txtMenuDia);
            this.panel1.Controls.Add(this.btnMenu);
            this.panel1.Controls.Add(this.comboUtilizador);
            this.panel1.Controls.Add(this.comboSemana);
            this.panel1.Controls.Add(this.datePickAtual);
            this.panel1.Controls.Add(this.picUtilizadorPfp);
            this.panel1.Location = new System.Drawing.Point(39, 51);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(531, 502);
            this.panel1.TabIndex = 0;
            // 
            // pictureInfoWeek
            // 
            this.pictureInfoWeek.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(196)))), ((int)(((byte)(204)))));
            this.pictureInfoWeek.Image = global::DA_ProjetoFinal.Properties.Resources.info;
            this.pictureInfoWeek.Location = new System.Drawing.Point(200, 293);
            this.pictureInfoWeek.Name = "pictureInfoWeek";
            this.pictureInfoWeek.PixelOffsetType = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
            this.pictureInfoWeek.Size = new System.Drawing.Size(32, 29);
            this.pictureInfoWeek.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureInfoWeek.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.pictureInfoWeek.TabIndex = 67;
            this.pictureInfoWeek.TabStop = false;
            this.pictureInfoWeek.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.pictureInfoWeek.Click += new System.EventHandler(this.pictureInfoWeek_Click);
            // 
            // picUtilizadorPfp
            // 
            this.picUtilizadorPfp.Image = global::DA_ProjetoFinal.Properties.Resources.default_user;
            this.picUtilizadorPfp.Location = new System.Drawing.Point(154, 0);
            this.picUtilizadorPfp.Name = "picUtilizadorPfp";
            this.picUtilizadorPfp.Size = new System.Drawing.Size(215, 157);
            this.picUtilizadorPfp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picUtilizadorPfp.TabIndex = 52;
            this.picUtilizadorPfp.TabStop = false;
            // 
            // spinnerLoading
            // 
            this.spinnerLoading.Location = new System.Drawing.Point(208, 177);
            this.spinnerLoading.Maximum = 100;
            this.spinnerLoading.Name = "spinnerLoading";
            this.spinnerLoading.Size = new System.Drawing.Size(106, 91);
            this.spinnerLoading.TabIndex = 72;
            this.spinnerLoading.UseCustomBackColor = true;
            this.spinnerLoading.UseSelectable = true;
            // 
            // labelLoading
            // 
            this.labelLoading.AutoSize = true;
            this.labelLoading.BackColor = System.Drawing.Color.Transparent;
            this.labelLoading.Font = new System.Drawing.Font("Segoe UI", 25F);
            this.labelLoading.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.labelLoading.Location = new System.Drawing.Point(90, 271);
            this.labelLoading.Name = "labelLoading";
            this.labelLoading.Size = new System.Drawing.Size(343, 46);
            this.labelLoading.TabIndex = 71;
            this.labelLoading.Text = "A carregador dados....";
            // 
            // FormHomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(609, 555);
            this.Controls.Add(this.panelCenter);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormHomePage";
            this.Text = "HomePage";
            this.Load += new System.EventHandler(this.FormHomePage_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureInfoWeek)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picUtilizadorPfp)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelCenter;
        private System.Windows.Forms.PictureBox picUtilizadorPfp;
        private ReaLTaiizor.Controls.PoisonDateTime datePickAtual;
        private ReaLTaiizor.Controls.PoisonComboBox comboSemana;
        private ReaLTaiizor.Controls.PoisonComboBox comboUtilizador;
        private ReaLTaiizor.Controls.PoisonButton btnMenu;
        private ReaLTaiizor.Controls.HopeRichTextBox txtMenuDia;
        private ReaLTaiizor.Controls.PoisonComboBox comboTipoUtilizador;
        private ReaLTaiizor.Controls.AloneButton btnPaginateAvancar;
        private ReaLTaiizor.Controls.AloneButton btnPaginateVoltar;
        private ReaLTaiizor.Controls.AloneButton btnSelecionarUtilizador;
        private ReaLTaiizor.Controls.DungeonLabel labelUtilizadorAtual;
        private ReaLTaiizor.Controls.DungeonLabel dungeonLabel4;
        private System.Windows.Forms.Panel panel1;
        private ReaLTaiizor.Controls.HopePictureBox pictureInfoWeek;
        private ReaLTaiizor.Controls.PoisonProgressSpinner spinnerLoading;
        private ReaLTaiizor.Controls.BigLabel labelLoading;
    }
}