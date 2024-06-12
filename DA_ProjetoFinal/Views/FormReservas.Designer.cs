namespace DA_ProjetoFinal.Views
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
            this.foreverTabPage1 = new ReaLTaiizor.Controls.ForeverTabPage();
            this.tabPageCriarReserva = new System.Windows.Forms.TabPage();
            this.tabPageListarMenus = new System.Windows.Forms.TabPage();
            this.tabPageEditarMenu = new System.Windows.Forms.TabPage();
            this.lblNotSelected = new ReaLTaiizor.Controls.DungeonHeaderLabel();
            this.pnlSelecionadoEdit = new System.Windows.Forms.Panel();
            this.bigLabel4 = new ReaLTaiizor.Controls.BigLabel();
            this.bigLabel5 = new ReaLTaiizor.Controls.BigLabel();
            this.pnlExtrasEdit = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlPratosEdit = new System.Windows.Forms.FlowLayoutPanel();
            this.btnEvoltarEditar = new ReaLTaiizor.Controls.AloneButton();
            this.btnEresetEditar = new ReaLTaiizor.Controls.AloneButton();
            this.btnSubmitEdit = new ReaLTaiizor.Controls.Button();
            this.btnAvancarEditE = new ReaLTaiizor.Controls.AloneButton();
            this.btnRecuarExEditar = new ReaLTaiizor.Controls.AloneButton();
            this.bigLabel6 = new ReaLTaiizor.Controls.BigLabel();
            this.btnRecuarPrEdit = new ReaLTaiizor.Controls.AloneButton();
            this.numPrecoProfEdit = new ReaLTaiizor.Controls.CrownNumeric();
            this.bigLabel10 = new ReaLTaiizor.Controls.BigLabel();
            this.btnPvoltarEditar = new ReaLTaiizor.Controls.AloneButton();
            this.btnPresetEditar = new ReaLTaiizor.Controls.AloneButton();
            this.btnAvancarPrEdit = new ReaLTaiizor.Controls.AloneButton();
            this.bigLabel11 = new ReaLTaiizor.Controls.BigLabel();
            this.numPrecoEstudanteEdit = new ReaLTaiizor.Controls.CrownNumeric();
            this.numQuantidadeEditar = new ReaLTaiizor.Controls.DungeonNumeric();
            this.bigLabel12 = new ReaLTaiizor.Controls.BigLabel();
            this.dateDataHoraEdit = new ReaLTaiizor.Controls.PoisonDateTime();
            this.foreverTabPage1.SuspendLayout();
            this.tabPageEditarMenu.SuspendLayout();
            this.pnlSelecionadoEdit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPrecoProfEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPrecoEstudanteEdit)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(-1, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(610, 24);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // foreverTabPage1
            // 
            this.foreverTabPage1.ActiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(168)))), ((int)(((byte)(109)))));
            this.foreverTabPage1.ActiveFontColor = System.Drawing.Color.White;
            this.foreverTabPage1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.foreverTabPage1.BGColor = System.Drawing.Color.WhiteSmoke;
            this.foreverTabPage1.Controls.Add(this.tabPageCriarReserva);
            this.foreverTabPage1.Controls.Add(this.tabPageListarMenus);
            this.foreverTabPage1.Controls.Add(this.tabPageEditarMenu);
            this.foreverTabPage1.DeactiveFontColor = System.Drawing.Color.White;
            this.foreverTabPage1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.foreverTabPage1.ItemSize = new System.Drawing.Size(120, 60);
            this.foreverTabPage1.Location = new System.Drawing.Point(-2, 0);
            this.foreverTabPage1.Name = "foreverTabPage1";
            this.foreverTabPage1.SelectedIndex = 0;
            this.foreverTabPage1.Size = new System.Drawing.Size(614, 555);
            this.foreverTabPage1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.foreverTabPage1.TabIndex = 2;
            // 
            // tabPageCriarReserva
            // 
            this.tabPageCriarReserva.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabPageCriarReserva.Location = new System.Drawing.Point(4, 64);
            this.tabPageCriarReserva.Name = "tabPageCriarReserva";
            this.tabPageCriarReserva.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageCriarReserva.Size = new System.Drawing.Size(606, 487);
            this.tabPageCriarReserva.TabIndex = 1;
            this.tabPageCriarReserva.Text = "Criar menu";
            this.tabPageCriarReserva.ToolTipText = "Adicionar prato";
            // 
            // tabPageListarMenus
            // 
            this.tabPageListarMenus.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabPageListarMenus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.tabPageListarMenus.Location = new System.Drawing.Point(4, 64);
            this.tabPageListarMenus.Name = "tabPageListarMenus";
            this.tabPageListarMenus.Size = new System.Drawing.Size(606, 487);
            this.tabPageListarMenus.TabIndex = 3;
            this.tabPageListarMenus.Text = "Listar menus";
            // 
            // tabPageEditarMenu
            // 
            this.tabPageEditarMenu.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabPageEditarMenu.Controls.Add(this.lblNotSelected);
            this.tabPageEditarMenu.Controls.Add(this.pnlSelecionadoEdit);
            this.tabPageEditarMenu.Location = new System.Drawing.Point(4, 64);
            this.tabPageEditarMenu.Name = "tabPageEditarMenu";
            this.tabPageEditarMenu.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageEditarMenu.Size = new System.Drawing.Size(606, 487);
            this.tabPageEditarMenu.TabIndex = 2;
            this.tabPageEditarMenu.Text = "Editar menu";
            // 
            // lblNotSelected
            // 
            this.lblNotSelected.AutoSize = true;
            this.lblNotSelected.BackColor = System.Drawing.Color.Transparent;
            this.lblNotSelected.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNotSelected.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(77)))));
            this.lblNotSelected.Location = new System.Drawing.Point(10, 0);
            this.lblNotSelected.Name = "lblNotSelected";
            this.lblNotSelected.Size = new System.Drawing.Size(331, 40);
            this.lblNotSelected.TabIndex = 32;
            this.lblNotSelected.Text = "dungeonHeaderLabel5";
            // 
            // pnlSelecionadoEdit
            // 
            this.pnlSelecionadoEdit.Controls.Add(this.bigLabel4);
            this.pnlSelecionadoEdit.Controls.Add(this.bigLabel5);
            this.pnlSelecionadoEdit.Controls.Add(this.pnlExtrasEdit);
            this.pnlSelecionadoEdit.Controls.Add(this.pnlPratosEdit);
            this.pnlSelecionadoEdit.Controls.Add(this.btnEvoltarEditar);
            this.pnlSelecionadoEdit.Controls.Add(this.btnEresetEditar);
            this.pnlSelecionadoEdit.Controls.Add(this.btnSubmitEdit);
            this.pnlSelecionadoEdit.Controls.Add(this.btnAvancarEditE);
            this.pnlSelecionadoEdit.Controls.Add(this.btnRecuarExEditar);
            this.pnlSelecionadoEdit.Controls.Add(this.bigLabel6);
            this.pnlSelecionadoEdit.Controls.Add(this.btnRecuarPrEdit);
            this.pnlSelecionadoEdit.Controls.Add(this.numPrecoProfEdit);
            this.pnlSelecionadoEdit.Controls.Add(this.bigLabel10);
            this.pnlSelecionadoEdit.Controls.Add(this.btnPvoltarEditar);
            this.pnlSelecionadoEdit.Controls.Add(this.btnPresetEditar);
            this.pnlSelecionadoEdit.Controls.Add(this.btnAvancarPrEdit);
            this.pnlSelecionadoEdit.Controls.Add(this.bigLabel11);
            this.pnlSelecionadoEdit.Controls.Add(this.numPrecoEstudanteEdit);
            this.pnlSelecionadoEdit.Controls.Add(this.numQuantidadeEditar);
            this.pnlSelecionadoEdit.Controls.Add(this.bigLabel12);
            this.pnlSelecionadoEdit.Controls.Add(this.dateDataHoraEdit);
            this.pnlSelecionadoEdit.Location = new System.Drawing.Point(0, 43);
            this.pnlSelecionadoEdit.Name = "pnlSelecionadoEdit";
            this.pnlSelecionadoEdit.Size = new System.Drawing.Size(606, 444);
            this.pnlSelecionadoEdit.TabIndex = 33;
            // 
            // bigLabel4
            // 
            this.bigLabel4.AutoSize = true;
            this.bigLabel4.BackColor = System.Drawing.Color.Transparent;
            this.bigLabel4.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bigLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.bigLabel4.Location = new System.Drawing.Point(265, 12);
            this.bigLabel4.Name = "bigLabel4";
            this.bigLabel4.Size = new System.Drawing.Size(84, 32);
            this.bigLabel4.TabIndex = 59;
            this.bigLabel4.Text = "Pratos:";
            // 
            // bigLabel5
            // 
            this.bigLabel5.AutoSize = true;
            this.bigLabel5.BackColor = System.Drawing.Color.Transparent;
            this.bigLabel5.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bigLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.bigLabel5.Location = new System.Drawing.Point(261, 188);
            this.bigLabel5.Name = "bigLabel5";
            this.bigLabel5.Size = new System.Drawing.Size(80, 32);
            this.bigLabel5.TabIndex = 60;
            this.bigLabel5.Text = "Extras:";
            // 
            // pnlExtrasEdit
            // 
            this.pnlExtrasEdit.Location = new System.Drawing.Point(267, 238);
            this.pnlExtrasEdit.Name = "pnlExtrasEdit";
            this.pnlExtrasEdit.Size = new System.Drawing.Size(318, 94);
            this.pnlExtrasEdit.TabIndex = 71;
            // 
            // pnlPratosEdit
            // 
            this.pnlPratosEdit.Location = new System.Drawing.Point(271, 58);
            this.pnlPratosEdit.Name = "pnlPratosEdit";
            this.pnlPratosEdit.Size = new System.Drawing.Size(318, 98);
            this.pnlPratosEdit.TabIndex = 70;
            // 
            // btnEvoltarEditar
            // 
            this.btnEvoltarEditar.BackColor = System.Drawing.Color.Transparent;
            this.btnEvoltarEditar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEvoltarEditar.EnabledCalc = true;
            this.btnEvoltarEditar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnEvoltarEditar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(133)))), ((int)(((byte)(142)))));
            this.btnEvoltarEditar.Location = new System.Drawing.Point(395, 338);
            this.btnEvoltarEditar.Name = "btnEvoltarEditar";
            this.btnEvoltarEditar.Size = new System.Drawing.Size(96, 18);
            this.btnEvoltarEditar.TabIndex = 67;
            this.btnEvoltarEditar.Text = "Voltar ao ínicio";
            // 
            // btnEresetEditar
            // 
            this.btnEresetEditar.BackColor = System.Drawing.Color.Transparent;
            this.btnEresetEditar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEresetEditar.EnabledCalc = true;
            this.btnEresetEditar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnEresetEditar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(133)))), ((int)(((byte)(142)))));
            this.btnEresetEditar.Location = new System.Drawing.Point(293, 338);
            this.btnEresetEditar.Name = "btnEresetEditar";
            this.btnEresetEditar.Size = new System.Drawing.Size(96, 18);
            this.btnEresetEditar.TabIndex = 65;
            this.btnEresetEditar.Text = "Reset";
            // 
            // btnSubmitEdit
            // 
            this.btnSubmitEdit.BackColor = System.Drawing.Color.Transparent;
            this.btnSubmitEdit.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.btnSubmitEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSubmitEdit.EnteredBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(168)))), ((int)(((byte)(109)))));
            this.btnSubmitEdit.EnteredColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.btnSubmitEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnSubmitEdit.Image = null;
            this.btnSubmitEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSubmitEdit.InactiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.btnSubmitEdit.Location = new System.Drawing.Point(23, 392);
            this.btnSubmitEdit.Name = "btnSubmitEdit";
            this.btnSubmitEdit.PressedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(168)))), ((int)(((byte)(109)))));
            this.btnSubmitEdit.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(168)))), ((int)(((byte)(109)))));
            this.btnSubmitEdit.Size = new System.Drawing.Size(562, 40);
            this.btnSubmitEdit.TabIndex = 69;
            this.btnSubmitEdit.Text = "button1";
            this.btnSubmitEdit.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // btnAvancarEditE
            // 
            this.btnAvancarEditE.BackColor = System.Drawing.Color.Transparent;
            this.btnAvancarEditE.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAvancarEditE.EnabledCalc = true;
            this.btnAvancarEditE.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnAvancarEditE.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(133)))), ((int)(((byte)(142)))));
            this.btnAvancarEditE.Location = new System.Drawing.Point(497, 338);
            this.btnAvancarEditE.Name = "btnAvancarEditE";
            this.btnAvancarEditE.Size = new System.Drawing.Size(16, 18);
            this.btnAvancarEditE.TabIndex = 61;
            this.btnAvancarEditE.Text = ">";
            // 
            // btnRecuarExEditar
            // 
            this.btnRecuarExEditar.BackColor = System.Drawing.Color.Transparent;
            this.btnRecuarExEditar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRecuarExEditar.EnabledCalc = true;
            this.btnRecuarExEditar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRecuarExEditar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(133)))), ((int)(((byte)(142)))));
            this.btnRecuarExEditar.Location = new System.Drawing.Point(271, 338);
            this.btnRecuarExEditar.Name = "btnRecuarExEditar";
            this.btnRecuarExEditar.Size = new System.Drawing.Size(16, 18);
            this.btnRecuarExEditar.TabIndex = 63;
            this.btnRecuarExEditar.Text = "<";
            // 
            // bigLabel6
            // 
            this.bigLabel6.AutoSize = true;
            this.bigLabel6.BackColor = System.Drawing.Color.Transparent;
            this.bigLabel6.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bigLabel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.bigLabel6.Location = new System.Drawing.Point(17, 276);
            this.bigLabel6.Name = "bigLabel6";
            this.bigLabel6.Size = new System.Drawing.Size(144, 32);
            this.bigLabel6.TabIndex = 58;
            this.bigLabel6.Text = "Quantidade:";
            // 
            // btnRecuarPrEdit
            // 
            this.btnRecuarPrEdit.BackColor = System.Drawing.Color.Transparent;
            this.btnRecuarPrEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRecuarPrEdit.EnabledCalc = true;
            this.btnRecuarPrEdit.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRecuarPrEdit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(133)))), ((int)(((byte)(142)))));
            this.btnRecuarPrEdit.Location = new System.Drawing.Point(271, 162);
            this.btnRecuarPrEdit.Name = "btnRecuarPrEdit";
            this.btnRecuarPrEdit.Size = new System.Drawing.Size(16, 18);
            this.btnRecuarPrEdit.TabIndex = 64;
            this.btnRecuarPrEdit.Text = "<";
            // 
            // numPrecoProfEdit
            // 
            this.numPrecoProfEdit.DecimalPlaces = 2;
            this.numPrecoProfEdit.Location = new System.Drawing.Point(23, 238);
            this.numPrecoProfEdit.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numPrecoProfEdit.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numPrecoProfEdit.Name = "numPrecoProfEdit";
            this.numPrecoProfEdit.Size = new System.Drawing.Size(200, 33);
            this.numPrecoProfEdit.TabIndex = 57;
            this.numPrecoProfEdit.Value = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            // 
            // bigLabel10
            // 
            this.bigLabel10.AutoSize = true;
            this.bigLabel10.BackColor = System.Drawing.Color.Transparent;
            this.bigLabel10.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bigLabel10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.bigLabel10.Location = new System.Drawing.Point(17, 188);
            this.bigLabel10.Name = "bigLabel10";
            this.bigLabel10.Size = new System.Drawing.Size(184, 32);
            this.bigLabel10.TabIndex = 56;
            this.bigLabel10.Text = "Preço professor:";
            // 
            // btnPvoltarEditar
            // 
            this.btnPvoltarEditar.BackColor = System.Drawing.Color.Transparent;
            this.btnPvoltarEditar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPvoltarEditar.EnabledCalc = true;
            this.btnPvoltarEditar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnPvoltarEditar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(133)))), ((int)(((byte)(142)))));
            this.btnPvoltarEditar.Location = new System.Drawing.Point(395, 162);
            this.btnPvoltarEditar.Name = "btnPvoltarEditar";
            this.btnPvoltarEditar.Size = new System.Drawing.Size(96, 18);
            this.btnPvoltarEditar.TabIndex = 68;
            this.btnPvoltarEditar.Text = "Voltar ao ínicio";
            // 
            // btnPresetEditar
            // 
            this.btnPresetEditar.BackColor = System.Drawing.Color.Transparent;
            this.btnPresetEditar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPresetEditar.EnabledCalc = true;
            this.btnPresetEditar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnPresetEditar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(133)))), ((int)(((byte)(142)))));
            this.btnPresetEditar.Location = new System.Drawing.Point(293, 162);
            this.btnPresetEditar.Name = "btnPresetEditar";
            this.btnPresetEditar.Size = new System.Drawing.Size(96, 18);
            this.btnPresetEditar.TabIndex = 66;
            this.btnPresetEditar.Text = "Reset";
            // 
            // btnAvancarPrEdit
            // 
            this.btnAvancarPrEdit.BackColor = System.Drawing.Color.Transparent;
            this.btnAvancarPrEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAvancarPrEdit.EnabledCalc = true;
            this.btnAvancarPrEdit.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnAvancarPrEdit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(133)))), ((int)(((byte)(142)))));
            this.btnAvancarPrEdit.Location = new System.Drawing.Point(497, 162);
            this.btnAvancarPrEdit.Name = "btnAvancarPrEdit";
            this.btnAvancarPrEdit.Size = new System.Drawing.Size(16, 18);
            this.btnAvancarPrEdit.TabIndex = 62;
            this.btnAvancarPrEdit.Text = ">";
            // 
            // bigLabel11
            // 
            this.bigLabel11.AutoSize = true;
            this.bigLabel11.BackColor = System.Drawing.Color.Transparent;
            this.bigLabel11.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bigLabel11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.bigLabel11.Location = new System.Drawing.Point(17, 100);
            this.bigLabel11.Name = "bigLabel11";
            this.bigLabel11.Size = new System.Drawing.Size(191, 32);
            this.bigLabel11.TabIndex = 55;
            this.bigLabel11.Text = "Preço estudante:";
            // 
            // numPrecoEstudanteEdit
            // 
            this.numPrecoEstudanteEdit.DecimalPlaces = 2;
            this.numPrecoEstudanteEdit.Location = new System.Drawing.Point(23, 148);
            this.numPrecoEstudanteEdit.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numPrecoEstudanteEdit.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numPrecoEstudanteEdit.Name = "numPrecoEstudanteEdit";
            this.numPrecoEstudanteEdit.Size = new System.Drawing.Size(200, 33);
            this.numPrecoEstudanteEdit.TabIndex = 54;
            this.numPrecoEstudanteEdit.Value = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            // 
            // numQuantidadeEditar
            // 
            this.numQuantidadeEditar.BackColor = System.Drawing.Color.Transparent;
            this.numQuantidadeEditar.BackColorA = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.numQuantidadeEditar.BackColorB = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(254)))), ((int)(((byte)(254)))));
            this.numQuantidadeEditar.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.numQuantidadeEditar.ButtonForeColorA = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.numQuantidadeEditar.ButtonForeColorB = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.numQuantidadeEditar.Font = new System.Drawing.Font("Tahoma", 11F);
            this.numQuantidadeEditar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(76)))));
            this.numQuantidadeEditar.Location = new System.Drawing.Point(23, 328);
            this.numQuantidadeEditar.Maximum = ((long)(20000));
            this.numQuantidadeEditar.Minimum = ((long)(1));
            this.numQuantidadeEditar.MinimumSize = new System.Drawing.Size(93, 28);
            this.numQuantidadeEditar.Name = "numQuantidadeEditar";
            this.numQuantidadeEditar.Size = new System.Drawing.Size(200, 28);
            this.numQuantidadeEditar.TabIndex = 53;
            this.numQuantidadeEditar.Text = "dungeonNumeric1";
            this.numQuantidadeEditar.TextAlignment = ReaLTaiizor.Controls.DungeonNumeric._TextAlignment.Near;
            this.numQuantidadeEditar.Value = ((long)(1));
            // 
            // bigLabel12
            // 
            this.bigLabel12.AutoSize = true;
            this.bigLabel12.BackColor = System.Drawing.Color.Transparent;
            this.bigLabel12.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bigLabel12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.bigLabel12.Location = new System.Drawing.Point(17, 12);
            this.bigLabel12.Name = "bigLabel12";
            this.bigLabel12.Size = new System.Drawing.Size(125, 32);
            this.bigLabel12.TabIndex = 52;
            this.bigLabel12.Text = "Data/hora:";
            // 
            // dateDataHoraEdit
            // 
            this.dateDataHoraEdit.CustomFormat = "MM/dd/yyyy hh:mm:ss tt";
            this.dateDataHoraEdit.Location = new System.Drawing.Point(23, 58);
            this.dateDataHoraEdit.MinimumSize = new System.Drawing.Size(4, 29);
            this.dateDataHoraEdit.Name = "dateDataHoraEdit";
            this.dateDataHoraEdit.Size = new System.Drawing.Size(200, 33);
            this.dateDataHoraEdit.TabIndex = 51;
            this.dateDataHoraEdit.Value = new System.DateTime(2024, 6, 11, 17, 40, 58, 0);
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
            this.foreverTabPage1.ResumeLayout(false);
            this.tabPageEditarMenu.ResumeLayout(false);
            this.tabPageEditarMenu.PerformLayout();
            this.pnlSelecionadoEdit.ResumeLayout(false);
            this.pnlSelecionadoEdit.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPrecoProfEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPrecoEstudanteEdit)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private ReaLTaiizor.Controls.ForeverTabPage foreverTabPage1;
        private System.Windows.Forms.TabPage tabPageCriarReserva;
        private System.Windows.Forms.TabPage tabPageListarMenus;
        private System.Windows.Forms.TabPage tabPageEditarMenu;
        private ReaLTaiizor.Controls.DungeonHeaderLabel lblNotSelected;
        private System.Windows.Forms.Panel pnlSelecionadoEdit;
        private ReaLTaiizor.Controls.BigLabel bigLabel4;
        private ReaLTaiizor.Controls.BigLabel bigLabel5;
        private System.Windows.Forms.FlowLayoutPanel pnlExtrasEdit;
        private System.Windows.Forms.FlowLayoutPanel pnlPratosEdit;
        private ReaLTaiizor.Controls.AloneButton btnEvoltarEditar;
        private ReaLTaiizor.Controls.AloneButton btnEresetEditar;
        private ReaLTaiizor.Controls.Button btnSubmitEdit;
        private ReaLTaiizor.Controls.AloneButton btnAvancarEditE;
        private ReaLTaiizor.Controls.AloneButton btnRecuarExEditar;
        private ReaLTaiizor.Controls.BigLabel bigLabel6;
        private ReaLTaiizor.Controls.AloneButton btnRecuarPrEdit;
        private ReaLTaiizor.Controls.CrownNumeric numPrecoProfEdit;
        private ReaLTaiizor.Controls.BigLabel bigLabel10;
        private ReaLTaiizor.Controls.AloneButton btnPvoltarEditar;
        private ReaLTaiizor.Controls.AloneButton btnPresetEditar;
        private ReaLTaiizor.Controls.AloneButton btnAvancarPrEdit;
        private ReaLTaiizor.Controls.BigLabel bigLabel11;
        private ReaLTaiizor.Controls.CrownNumeric numPrecoEstudanteEdit;
        private ReaLTaiizor.Controls.DungeonNumeric numQuantidadeEditar;
        private ReaLTaiizor.Controls.BigLabel bigLabel12;
        private ReaLTaiizor.Controls.PoisonDateTime dateDataHoraEdit;
    }
}