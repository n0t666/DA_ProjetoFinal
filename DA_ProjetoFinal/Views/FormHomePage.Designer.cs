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
            this.panel1 = new System.Windows.Forms.Panel();
            this.dungeonLabel4 = new ReaLTaiizor.Controls.DungeonLabel();
            this.labelUtilizadorAtual = new ReaLTaiizor.Controls.DungeonLabel();
            this.btnSelecionarUtilizador = new ReaLTaiizor.Controls.AloneButton();
            this.btnPaginateVoltar = new ReaLTaiizor.Controls.AloneButton();
            this.btnPaginateAvancar = new ReaLTaiizor.Controls.AloneButton();
            this.comboTipoUtilizador = new ReaLTaiizor.Controls.PoisonComboBox();
            this.txtMenuDia = new ReaLTaiizor.Controls.HopeRichTextBox();
            this.poisonButton1 = new ReaLTaiizor.Controls.PoisonButton();
            this.comboUtilizador = new ReaLTaiizor.Controls.PoisonComboBox();
            this.comboSemana = new ReaLTaiizor.Controls.PoisonComboBox();
            this.datePickAtual = new ReaLTaiizor.Controls.PoisonDateTime();
            this.picUtilizadorPfp = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picUtilizadorPfp)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dungeonLabel4);
            this.panel1.Controls.Add(this.labelUtilizadorAtual);
            this.panel1.Controls.Add(this.btnSelecionarUtilizador);
            this.panel1.Controls.Add(this.btnPaginateVoltar);
            this.panel1.Controls.Add(this.btnPaginateAvancar);
            this.panel1.Controls.Add(this.comboTipoUtilizador);
            this.panel1.Controls.Add(this.txtMenuDia);
            this.panel1.Controls.Add(this.poisonButton1);
            this.panel1.Controls.Add(this.comboUtilizador);
            this.panel1.Controls.Add(this.comboSemana);
            this.panel1.Controls.Add(this.datePickAtual);
            this.panel1.Controls.Add(this.picUtilizadorPfp);
            this.panel1.Location = new System.Drawing.Point(39, 51);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(531, 502);
            this.panel1.TabIndex = 0;
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
            this.comboTipoUtilizador.Size = new System.Drawing.Size(224, 29);
            this.comboTipoUtilizador.TabIndex = 59;
            this.comboTipoUtilizador.UseSelectable = true;
            this.comboTipoUtilizador.SelectionChangeCommitted += new System.EventHandler(this.comboTipoUtilizador_SelectionChangeCommitted);
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
            // poisonButton1
            // 
            this.poisonButton1.Location = new System.Drawing.Point(54, 471);
            this.poisonButton1.Name = "poisonButton1";
            this.poisonButton1.Size = new System.Drawing.Size(425, 23);
            this.poisonButton1.TabIndex = 57;
            this.poisonButton1.Text = "poisonButton1";
            this.poisonButton1.UseSelectable = true;
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
            // datePickAtual
            // 
            this.datePickAtual.Location = new System.Drawing.Point(0, 293);
            this.datePickAtual.MinimumSize = new System.Drawing.Size(0, 29);
            this.datePickAtual.Name = "datePickAtual";
            this.datePickAtual.Size = new System.Drawing.Size(194, 29);
            this.datePickAtual.Style = ReaLTaiizor.Enum.Poison.ColorStyle.Black;
            this.datePickAtual.TabIndex = 54;
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
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(-1, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(610, 29);
            this.panel2.TabIndex = 1;
            // 
            // FormHomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(609, 555);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormHomePage";
            this.Text = "HomePage";
            this.Load += new System.EventHandler(this.FormHomePage_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picUtilizadorPfp)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private ReaLTaiizor.Controls.HopeRichTextBox txtMenuDia;
        private ReaLTaiizor.Controls.PoisonButton poisonButton1;
        private ReaLTaiizor.Controls.PoisonComboBox comboUtilizador;
        private ReaLTaiizor.Controls.PoisonComboBox comboSemana;
        private ReaLTaiizor.Controls.PoisonDateTime datePickAtual;
        private System.Windows.Forms.PictureBox picUtilizadorPfp;
        private ReaLTaiizor.Controls.PoisonComboBox comboTipoUtilizador;
        private System.Windows.Forms.Panel panel2;
        private ReaLTaiizor.Controls.AloneButton btnPaginateVoltar;
        private ReaLTaiizor.Controls.AloneButton btnPaginateAvancar;
        private ReaLTaiizor.Controls.AloneButton btnSelecionarUtilizador;
        private ReaLTaiizor.Controls.DungeonLabel dungeonLabel4;
        private ReaLTaiizor.Controls.DungeonLabel labelUtilizadorAtual;
    }
}