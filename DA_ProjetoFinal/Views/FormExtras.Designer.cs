namespace DA_ProjetoFinal.Views
{
    partial class FormExtras
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
            this.tabPageExtras = new ReaLTaiizor.Controls.ForeverTabPage();
            this.tabPageCriarExtra = new System.Windows.Forms.TabPage();
            this.notificationExtra = new ReaLTaiizor.Controls.FoxNotification();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtPreco = new ReaLTaiizor.Controls.BigTextBox();
            this.bigLabel1 = new ReaLTaiizor.Controls.BigLabel();
            this.bigLabel2 = new ReaLTaiizor.Controls.BigLabel();
            this.txtDescricao = new ReaLTaiizor.Controls.BigTextBox();
            this.btnSubmit = new ReaLTaiizor.Controls.HopeRoundButton();
            this.bigLabel3 = new ReaLTaiizor.Controls.BigLabel();
            this.checkBoxAtivo = new ReaLTaiizor.Controls.HopeCheckBox();
            this.tabPageListarExtra = new System.Windows.Forms.TabPage();
            this.btnApagar = new ReaLTaiizor.Controls.LostButton();
            this.btnSelecionar = new ReaLTaiizor.Controls.LostButton();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.lblSelecionado = new ReaLTaiizor.Controls.DungeonLabel();
            this.dungeonHeaderLabel3 = new ReaLTaiizor.Controls.DungeonHeaderLabel();
            this.panelDescricao = new System.Windows.Forms.FlowLayoutPanel();
            this.dungeonHeaderLabel1 = new ReaLTaiizor.Controls.DungeonHeaderLabel();
            this.lblDescricao = new ReaLTaiizor.Controls.DungeonLabel();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.dungeonHeaderLabel4 = new ReaLTaiizor.Controls.DungeonHeaderLabel();
            this.lblAtivo = new ReaLTaiizor.Controls.DungeonLabel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.dungeonHeaderLabel2 = new ReaLTaiizor.Controls.DungeonHeaderLabel();
            this.lblPreco = new ReaLTaiizor.Controls.DungeonLabel();
            this.btnPaginateVoltar = new ReaLTaiizor.Controls.AloneButton();
            this.btnPaginateAvancar = new ReaLTaiizor.Controls.AloneButton();
            this.comboBoxExtras = new ReaLTaiizor.Controls.AloneComboBox();
            this.tabPageEditarExtra = new System.Windows.Forms.TabPage();
            this.lblNotSelected = new ReaLTaiizor.Controls.DungeonHeaderLabel();
            this.panelSelecionadoEdit = new System.Windows.Forms.Panel();
            this.txtEditPreco = new ReaLTaiizor.Controls.BigTextBox();
            this.bigLabel4 = new ReaLTaiizor.Controls.BigLabel();
            this.bigLabel5 = new ReaLTaiizor.Controls.BigLabel();
            this.txtEditDesc = new ReaLTaiizor.Controls.BigTextBox();
            this.btnSubmitEdit = new ReaLTaiizor.Controls.HopeRoundButton();
            this.bigLabel6 = new ReaLTaiizor.Controls.BigLabel();
            this.checkAtivoEdit = new ReaLTaiizor.Controls.HopeCheckBox();
            this.timerNotification = new System.Windows.Forms.Timer(this.components);
            this.tabPageExtras.SuspendLayout();
            this.tabPageCriarExtra.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tabPageListarExtra.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.panelDescricao.SuspendLayout();
            this.flowLayoutPanel3.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.tabPageEditarExtra.SuspendLayout();
            this.panelSelecionadoEdit.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPageExtras
            // 
            this.tabPageExtras.ActiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(168)))), ((int)(((byte)(109)))));
            this.tabPageExtras.ActiveFontColor = System.Drawing.Color.White;
            this.tabPageExtras.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.tabPageExtras.BGColor = System.Drawing.Color.WhiteSmoke;
            this.tabPageExtras.Controls.Add(this.tabPageCriarExtra);
            this.tabPageExtras.Controls.Add(this.tabPageListarExtra);
            this.tabPageExtras.Controls.Add(this.tabPageEditarExtra);
            this.tabPageExtras.DeactiveFontColor = System.Drawing.Color.White;
            this.tabPageExtras.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPageExtras.ItemSize = new System.Drawing.Size(120, 60);
            this.tabPageExtras.Location = new System.Drawing.Point(-2, 0);
            this.tabPageExtras.Name = "tabPageExtras";
            this.tabPageExtras.SelectedIndex = 0;
            this.tabPageExtras.Size = new System.Drawing.Size(614, 555);
            this.tabPageExtras.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabPageExtras.TabIndex = 1;
            this.tabPageExtras.SelectedIndexChanged += new System.EventHandler(this.tabPageExtras_SelectedIndexChanged);
            // 
            // tabPageCriarExtra
            // 
            this.tabPageCriarExtra.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabPageCriarExtra.Controls.Add(this.notificationExtra);
            this.tabPageCriarExtra.Controls.Add(this.panel1);
            this.tabPageCriarExtra.Location = new System.Drawing.Point(4, 64);
            this.tabPageCriarExtra.Name = "tabPageCriarExtra";
            this.tabPageCriarExtra.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageCriarExtra.Size = new System.Drawing.Size(606, 487);
            this.tabPageCriarExtra.TabIndex = 1;
            this.tabPageCriarExtra.Text = "Criar extra";
            this.tabPageCriarExtra.ToolTipText = "Adicionar prato";
            // 
            // notificationExtra
            // 
            this.notificationExtra.BackColor = System.Drawing.Color.Transparent;
            this.notificationExtra.BlueBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(237)))), ((int)(((byte)(248)))));
            this.notificationExtra.BlueBarColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(217)))), ((int)(((byte)(240)))));
            this.notificationExtra.BlueTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(143)))), ((int)(((byte)(184)))));
            this.notificationExtra.Cursor = System.Windows.Forms.Cursors.Default;
            this.notificationExtra.EnabledCalc = true;
            this.notificationExtra.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.notificationExtra.GreenBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(240)))), ((int)(((byte)(214)))));
            this.notificationExtra.GreenBarColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(229)))), ((int)(((byte)(182)))));
            this.notificationExtra.GreenTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(140)))), ((int)(((byte)(69)))));
            this.notificationExtra.Location = new System.Drawing.Point(362, 22);
            this.notificationExtra.Name = "notificationExtra";
            this.notificationExtra.RedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(222)))), ((int)(((byte)(222)))));
            this.notificationExtra.RedBarColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(204)))), ((int)(((byte)(209)))));
            this.notificationExtra.RedTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(99)))), ((int)(((byte)(94)))));
            this.notificationExtra.Size = new System.Drawing.Size(234, 40);
            this.notificationExtra.Style = ReaLTaiizor.Controls.FoxNotification.Styles.Red;
            this.notificationExtra.TabIndex = 8;
            this.notificationExtra.Text = "Prato adicionado com sucesso!";
            this.notificationExtra.Visible = false;
            this.notificationExtra.YellowBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(248)))), ((int)(((byte)(225)))));
            this.notificationExtra.YellowBarColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(235)))), ((int)(((byte)(200)))));
            this.notificationExtra.YellowTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(131)))), ((int)(((byte)(88)))));
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtPreco);
            this.panel1.Controls.Add(this.bigLabel1);
            this.panel1.Controls.Add(this.bigLabel2);
            this.panel1.Controls.Add(this.txtDescricao);
            this.panel1.Controls.Add(this.btnSubmit);
            this.panel1.Controls.Add(this.bigLabel3);
            this.panel1.Controls.Add(this.checkBoxAtivo);
            this.panel1.Location = new System.Drawing.Point(85, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(440, 430);
            this.panel1.TabIndex = 10;
            // 
            // txtPreco
            // 
            this.txtPreco.BackColor = System.Drawing.Color.Transparent;
            this.txtPreco.Font = new System.Drawing.Font("Tahoma", 11F);
            this.txtPreco.ForeColor = System.Drawing.Color.DimGray;
            this.txtPreco.Image = null;
            this.txtPreco.Location = new System.Drawing.Point(0, 211);
            this.txtPreco.MaxLength = 32767;
            this.txtPreco.Multiline = false;
            this.txtPreco.Name = "txtPreco";
            this.txtPreco.ReadOnly = false;
            this.txtPreco.Size = new System.Drawing.Size(440, 41);
            this.txtPreco.TabIndex = 8;
            this.txtPreco.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtPreco.UseSystemPasswordChar = false;
            // 
            // bigLabel1
            // 
            this.bigLabel1.AutoSize = true;
            this.bigLabel1.BackColor = System.Drawing.Color.Transparent;
            this.bigLabel1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bigLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.bigLabel1.Location = new System.Drawing.Point(3, 27);
            this.bigLabel1.Name = "bigLabel1";
            this.bigLabel1.Size = new System.Drawing.Size(121, 32);
            this.bigLabel1.TabIndex = 1;
            this.bigLabel1.Text = "Descrição:";
            // 
            // bigLabel2
            // 
            this.bigLabel2.AutoSize = true;
            this.bigLabel2.BackColor = System.Drawing.Color.Transparent;
            this.bigLabel2.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bigLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.bigLabel2.Location = new System.Drawing.Point(3, 176);
            this.bigLabel2.Name = "bigLabel2";
            this.bigLabel2.Size = new System.Drawing.Size(78, 32);
            this.bigLabel2.TabIndex = 2;
            this.bigLabel2.Text = "Preço:";
            // 
            // txtDescricao
            // 
            this.txtDescricao.BackColor = System.Drawing.Color.Transparent;
            this.txtDescricao.Font = new System.Drawing.Font("Tahoma", 11F);
            this.txtDescricao.ForeColor = System.Drawing.Color.DimGray;
            this.txtDescricao.Image = null;
            this.txtDescricao.Location = new System.Drawing.Point(0, 76);
            this.txtDescricao.MaxLength = 32767;
            this.txtDescricao.Multiline = true;
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.ReadOnly = false;
            this.txtDescricao.Size = new System.Drawing.Size(440, 83);
            this.txtDescricao.TabIndex = 0;
            this.txtDescricao.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtDescricao.UseSystemPasswordChar = false;
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
            this.btnSubmit.Location = new System.Drawing.Point(0, 354);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.PrimaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(158)))), ((int)(((byte)(255)))));
            this.btnSubmit.Size = new System.Drawing.Size(436, 40);
            this.btnSubmit.SuccessColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(194)))), ((int)(((byte)(58)))));
            this.btnSubmit.TabIndex = 6;
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
            this.bigLabel3.Location = new System.Drawing.Point(-2, 268);
            this.bigLabel3.Name = "bigLabel3";
            this.bigLabel3.Size = new System.Drawing.Size(74, 32);
            this.bigLabel3.TabIndex = 5;
            this.bigLabel3.Text = "Ativo:";
            // 
            // checkBoxAtivo
            // 
            this.checkBoxAtivo.AutoSize = true;
            this.checkBoxAtivo.CheckedColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(158)))), ((int)(((byte)(255)))));
            this.checkBoxAtivo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkBoxAtivo.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(198)))), ((int)(((byte)(202)))));
            this.checkBoxAtivo.DisabledStringColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(187)))), ((int)(((byte)(189)))));
            this.checkBoxAtivo.Enable = true;
            this.checkBoxAtivo.EnabledCheckedColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(158)))), ((int)(((byte)(255)))));
            this.checkBoxAtivo.EnabledStringColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.checkBoxAtivo.EnabledUncheckedColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(158)))), ((int)(((byte)(161)))));
            this.checkBoxAtivo.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxAtivo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(49)))), ((int)(((byte)(51)))));
            this.checkBoxAtivo.Location = new System.Drawing.Point(4, 317);
            this.checkBoxAtivo.Name = "checkBoxAtivo";
            this.checkBoxAtivo.Size = new System.Drawing.Size(80, 20);
            this.checkBoxAtivo.TabIndex = 4;
            this.checkBoxAtivo.Text = "Ativo";
            this.checkBoxAtivo.UseVisualStyleBackColor = true;
            // 
            // tabPageListarExtra
            // 
            this.tabPageListarExtra.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabPageListarExtra.Controls.Add(this.btnApagar);
            this.tabPageListarExtra.Controls.Add(this.btnSelecionar);
            this.tabPageListarExtra.Controls.Add(this.flowLayoutPanel1);
            this.tabPageListarExtra.Controls.Add(this.dungeonHeaderLabel3);
            this.tabPageListarExtra.Controls.Add(this.panelDescricao);
            this.tabPageListarExtra.Controls.Add(this.flowLayoutPanel3);
            this.tabPageListarExtra.Controls.Add(this.flowLayoutPanel2);
            this.tabPageListarExtra.Controls.Add(this.btnPaginateVoltar);
            this.tabPageListarExtra.Controls.Add(this.btnPaginateAvancar);
            this.tabPageListarExtra.Controls.Add(this.comboBoxExtras);
            this.tabPageListarExtra.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.tabPageListarExtra.Location = new System.Drawing.Point(4, 64);
            this.tabPageListarExtra.Name = "tabPageListarExtra";
            this.tabPageListarExtra.Size = new System.Drawing.Size(606, 487);
            this.tabPageListarExtra.TabIndex = 3;
            this.tabPageListarExtra.Text = "Listar extras";
            // 
            // btnApagar
            // 
            this.btnApagar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(20)))), ((int)(((byte)(21)))));
            this.btnApagar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnApagar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnApagar.ForeColor = System.Drawing.Color.White;
            this.btnApagar.HoverColor = System.Drawing.Color.LightCoral;
            this.btnApagar.Image = null;
            this.btnApagar.Location = new System.Drawing.Point(337, 380);
            this.btnApagar.Name = "btnApagar";
            this.btnApagar.Size = new System.Drawing.Size(182, 40);
            this.btnApagar.TabIndex = 19;
            this.btnApagar.Text = "APAGAR";
            this.btnApagar.Click += new System.EventHandler(this.btnApagar_Click);
            // 
            // btnSelecionar
            // 
            this.btnSelecionar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(168)))), ((int)(((byte)(109)))));
            this.btnSelecionar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSelecionar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnSelecionar.ForeColor = System.Drawing.Color.White;
            this.btnSelecionar.HoverColor = System.Drawing.Color.DarkSeaGreen;
            this.btnSelecionar.Image = null;
            this.btnSelecionar.Location = new System.Drawing.Point(83, 380);
            this.btnSelecionar.Name = "btnSelecionar";
            this.btnSelecionar.Size = new System.Drawing.Size(182, 40);
            this.btnSelecionar.TabIndex = 18;
            this.btnSelecionar.Text = "SELECIONAR";
            this.btnSelecionar.Click += new System.EventHandler(this.btnSelecionar_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.flowLayoutPanel1.Controls.Add(this.lblSelecionado);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(83, 344);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(436, 24);
            this.flowLayoutPanel1.TabIndex = 17;
            // 
            // lblSelecionado
            // 
            this.lblSelecionado.AutoSize = true;
            this.lblSelecionado.BackColor = System.Drawing.Color.Transparent;
            this.lblSelecionado.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblSelecionado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(77)))));
            this.lblSelecionado.Location = new System.Drawing.Point(3, 0);
            this.lblSelecionado.Name = "lblSelecionado";
            this.lblSelecionado.Size = new System.Drawing.Size(36, 20);
            this.lblSelecionado.TabIndex = 13;
            this.lblSelecionado.Text = "tipo";
            // 
            // dungeonHeaderLabel3
            // 
            this.dungeonHeaderLabel3.AutoSize = true;
            this.dungeonHeaderLabel3.BackColor = System.Drawing.Color.Transparent;
            this.dungeonHeaderLabel3.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dungeonHeaderLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(77)))));
            this.dungeonHeaderLabel3.Location = new System.Drawing.Point(76, 43);
            this.dungeonHeaderLabel3.Name = "dungeonHeaderLabel3";
            this.dungeonHeaderLabel3.Size = new System.Drawing.Size(258, 40);
            this.dungeonHeaderLabel3.TabIndex = 17;
            this.dungeonHeaderLabel3.Text = "Escolha um extra:";
            // 
            // panelDescricao
            // 
            this.panelDescricao.AutoScroll = true;
            this.panelDescricao.BackColor = System.Drawing.Color.Gainsboro;
            this.panelDescricao.Controls.Add(this.dungeonHeaderLabel1);
            this.panelDescricao.Controls.Add(this.lblDescricao);
            this.panelDescricao.Location = new System.Drawing.Point(83, 227);
            this.panelDescricao.Name = "panelDescricao";
            this.panelDescricao.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.panelDescricao.Size = new System.Drawing.Size(436, 111);
            this.panelDescricao.TabIndex = 15;
            // 
            // dungeonHeaderLabel1
            // 
            this.dungeonHeaderLabel1.AutoSize = true;
            this.dungeonHeaderLabel1.BackColor = System.Drawing.Color.Transparent;
            this.dungeonHeaderLabel1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.dungeonHeaderLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(77)))));
            this.dungeonHeaderLabel1.Location = new System.Drawing.Point(3, 0);
            this.dungeonHeaderLabel1.Name = "dungeonHeaderLabel1";
            this.dungeonHeaderLabel1.Size = new System.Drawing.Size(80, 20);
            this.dungeonHeaderLabel1.TabIndex = 14;
            this.dungeonHeaderLabel1.Text = "Descrição:";
            // 
            // lblDescricao
            // 
            this.lblDescricao.AutoSize = true;
            this.lblDescricao.BackColor = System.Drawing.Color.Transparent;
            this.panelDescricao.SetFlowBreak(this.lblDescricao, true);
            this.lblDescricao.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblDescricao.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(77)))));
            this.lblDescricao.Location = new System.Drawing.Point(89, 0);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new System.Drawing.Size(75, 20);
            this.lblDescricao.TabIndex = 13;
            this.lblDescricao.Text = "Welcome ";
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.BackColor = System.Drawing.Color.Transparent;
            this.flowLayoutPanel3.Controls.Add(this.dungeonHeaderLabel4);
            this.flowLayoutPanel3.Controls.Add(this.lblAtivo);
            this.flowLayoutPanel3.Location = new System.Drawing.Point(83, 194);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(436, 27);
            this.flowLayoutPanel3.TabIndex = 17;
            // 
            // dungeonHeaderLabel4
            // 
            this.dungeonHeaderLabel4.AutoSize = true;
            this.dungeonHeaderLabel4.BackColor = System.Drawing.Color.Transparent;
            this.dungeonHeaderLabel4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.dungeonHeaderLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(77)))));
            this.dungeonHeaderLabel4.Location = new System.Drawing.Point(3, 0);
            this.dungeonHeaderLabel4.Name = "dungeonHeaderLabel4";
            this.dungeonHeaderLabel4.Size = new System.Drawing.Size(51, 20);
            this.dungeonHeaderLabel4.TabIndex = 14;
            this.dungeonHeaderLabel4.Text = "Ativo:";
            // 
            // lblAtivo
            // 
            this.lblAtivo.AutoSize = true;
            this.lblAtivo.BackColor = System.Drawing.Color.Transparent;
            this.lblAtivo.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblAtivo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(77)))));
            this.lblAtivo.Location = new System.Drawing.Point(60, 0);
            this.lblAtivo.Name = "lblAtivo";
            this.lblAtivo.Size = new System.Drawing.Size(112, 20);
            this.lblAtivo.TabIndex = 13;
            this.lblAtivo.Text = "dungeonLabel2";
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.BackColor = System.Drawing.Color.Transparent;
            this.flowLayoutPanel2.Controls.Add(this.dungeonHeaderLabel2);
            this.flowLayoutPanel2.Controls.Add(this.lblPreco);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(83, 164);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(436, 24);
            this.flowLayoutPanel2.TabIndex = 16;
            // 
            // dungeonHeaderLabel2
            // 
            this.dungeonHeaderLabel2.AutoSize = true;
            this.dungeonHeaderLabel2.BackColor = System.Drawing.Color.Transparent;
            this.dungeonHeaderLabel2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.dungeonHeaderLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(77)))));
            this.dungeonHeaderLabel2.Location = new System.Drawing.Point(3, 0);
            this.dungeonHeaderLabel2.Name = "dungeonHeaderLabel2";
            this.dungeonHeaderLabel2.Size = new System.Drawing.Size(48, 20);
            this.dungeonHeaderLabel2.TabIndex = 14;
            this.dungeonHeaderLabel2.Text = "Preço";
            // 
            // lblPreco
            // 
            this.lblPreco.AutoSize = true;
            this.lblPreco.BackColor = System.Drawing.Color.Transparent;
            this.lblPreco.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblPreco.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(77)))));
            this.lblPreco.Location = new System.Drawing.Point(57, 0);
            this.lblPreco.Name = "lblPreco";
            this.lblPreco.Size = new System.Drawing.Size(36, 20);
            this.lblPreco.TabIndex = 13;
            this.lblPreco.Text = "tipo";
            // 
            // btnPaginateVoltar
            // 
            this.btnPaginateVoltar.BackColor = System.Drawing.Color.Transparent;
            this.btnPaginateVoltar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPaginateVoltar.EnabledCalc = true;
            this.btnPaginateVoltar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnPaginateVoltar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(133)))), ((int)(((byte)(142)))));
            this.btnPaginateVoltar.Location = new System.Drawing.Point(83, 118);
            this.btnPaginateVoltar.Name = "btnPaginateVoltar";
            this.btnPaginateVoltar.Size = new System.Drawing.Size(100, 29);
            this.btnPaginateVoltar.TabIndex = 11;
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
            this.btnPaginateAvancar.Location = new System.Drawing.Point(419, 118);
            this.btnPaginateAvancar.Name = "btnPaginateAvancar";
            this.btnPaginateAvancar.Size = new System.Drawing.Size(100, 29);
            this.btnPaginateAvancar.TabIndex = 12;
            this.btnPaginateAvancar.Text = ">";
            this.btnPaginateAvancar.Click += new ReaLTaiizor.Controls.AloneButton.ClickEventHandler(this.btnPaginateAvancar_Click);
            // 
            // comboBoxExtras
            // 
            this.comboBoxExtras.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBoxExtras.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboBoxExtras.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxExtras.EnabledCalc = true;
            this.comboBoxExtras.FormattingEnabled = true;
            this.comboBoxExtras.ItemHeight = 20;
            this.comboBoxExtras.Location = new System.Drawing.Point(83, 86);
            this.comboBoxExtras.Name = "comboBoxExtras";
            this.comboBoxExtras.Size = new System.Drawing.Size(436, 26);
            this.comboBoxExtras.TabIndex = 10;
            this.comboBoxExtras.SelectionChangeCommitted += new System.EventHandler(this.comboBoxExtras_SelectionChangeCommitted);
            // 
            // tabPageEditarExtra
            // 
            this.tabPageEditarExtra.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabPageEditarExtra.Controls.Add(this.lblNotSelected);
            this.tabPageEditarExtra.Controls.Add(this.panelSelecionadoEdit);
            this.tabPageEditarExtra.Location = new System.Drawing.Point(4, 64);
            this.tabPageEditarExtra.Name = "tabPageEditarExtra";
            this.tabPageEditarExtra.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageEditarExtra.Size = new System.Drawing.Size(606, 487);
            this.tabPageEditarExtra.TabIndex = 2;
            this.tabPageEditarExtra.Text = "Editar extra";
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
            // panelSelecionadoEdit
            // 
            this.panelSelecionadoEdit.Controls.Add(this.txtEditPreco);
            this.panelSelecionadoEdit.Controls.Add(this.bigLabel4);
            this.panelSelecionadoEdit.Controls.Add(this.bigLabel5);
            this.panelSelecionadoEdit.Controls.Add(this.txtEditDesc);
            this.panelSelecionadoEdit.Controls.Add(this.btnSubmitEdit);
            this.panelSelecionadoEdit.Controls.Add(this.bigLabel6);
            this.panelSelecionadoEdit.Controls.Add(this.checkAtivoEdit);
            this.panelSelecionadoEdit.Location = new System.Drawing.Point(85, 43);
            this.panelSelecionadoEdit.Name = "panelSelecionadoEdit";
            this.panelSelecionadoEdit.Size = new System.Drawing.Size(440, 430);
            this.panelSelecionadoEdit.TabIndex = 33;
            // 
            // txtEditPreco
            // 
            this.txtEditPreco.BackColor = System.Drawing.Color.Transparent;
            this.txtEditPreco.Font = new System.Drawing.Font("Tahoma", 11F);
            this.txtEditPreco.ForeColor = System.Drawing.Color.DimGray;
            this.txtEditPreco.Image = null;
            this.txtEditPreco.Location = new System.Drawing.Point(0, 210);
            this.txtEditPreco.MaxLength = 32767;
            this.txtEditPreco.Multiline = false;
            this.txtEditPreco.Name = "txtEditPreco";
            this.txtEditPreco.ReadOnly = false;
            this.txtEditPreco.Size = new System.Drawing.Size(440, 41);
            this.txtEditPreco.TabIndex = 9;
            this.txtEditPreco.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtEditPreco.UseSystemPasswordChar = false;
            // 
            // bigLabel4
            // 
            this.bigLabel4.AutoSize = true;
            this.bigLabel4.BackColor = System.Drawing.Color.Transparent;
            this.bigLabel4.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bigLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.bigLabel4.Location = new System.Drawing.Point(3, 27);
            this.bigLabel4.Name = "bigLabel4";
            this.bigLabel4.Size = new System.Drawing.Size(121, 32);
            this.bigLabel4.TabIndex = 1;
            this.bigLabel4.Text = "Descrição:";
            // 
            // bigLabel5
            // 
            this.bigLabel5.AutoSize = true;
            this.bigLabel5.BackColor = System.Drawing.Color.Transparent;
            this.bigLabel5.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bigLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.bigLabel5.Location = new System.Drawing.Point(3, 166);
            this.bigLabel5.Name = "bigLabel5";
            this.bigLabel5.Size = new System.Drawing.Size(78, 32);
            this.bigLabel5.TabIndex = 2;
            this.bigLabel5.Text = "Preço:";
            // 
            // txtEditDesc
            // 
            this.txtEditDesc.BackColor = System.Drawing.Color.Transparent;
            this.txtEditDesc.Font = new System.Drawing.Font("Tahoma", 11F);
            this.txtEditDesc.ForeColor = System.Drawing.Color.DimGray;
            this.txtEditDesc.Image = null;
            this.txtEditDesc.Location = new System.Drawing.Point(0, 71);
            this.txtEditDesc.MaxLength = 32767;
            this.txtEditDesc.Multiline = true;
            this.txtEditDesc.Name = "txtEditDesc";
            this.txtEditDesc.ReadOnly = false;
            this.txtEditDesc.Size = new System.Drawing.Size(440, 83);
            this.txtEditDesc.TabIndex = 0;
            this.txtEditDesc.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtEditDesc.UseSystemPasswordChar = false;
            // 
            // btnSubmitEdit
            // 
            this.btnSubmitEdit.BorderColor = System.Drawing.Color.Transparent;
            this.btnSubmitEdit.ButtonType = ReaLTaiizor.Util.HopeButtonType.Primary;
            this.btnSubmitEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSubmitEdit.DangerColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(108)))), ((int)(((byte)(108)))));
            this.btnSubmitEdit.DefaultColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnSubmitEdit.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnSubmitEdit.HoverTextColor = System.Drawing.Color.WhiteSmoke;
            this.btnSubmitEdit.InfoColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(147)))), ((int)(((byte)(153)))));
            this.btnSubmitEdit.Location = new System.Drawing.Point(0, 354);
            this.btnSubmitEdit.Name = "btnSubmitEdit";
            this.btnSubmitEdit.PrimaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(158)))), ((int)(((byte)(255)))));
            this.btnSubmitEdit.Size = new System.Drawing.Size(436, 40);
            this.btnSubmitEdit.SuccessColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(194)))), ((int)(((byte)(58)))));
            this.btnSubmitEdit.TabIndex = 6;
            this.btnSubmitEdit.Text = "SUBMETER";
            this.btnSubmitEdit.TextColor = System.Drawing.Color.White;
            this.btnSubmitEdit.WarningColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(162)))), ((int)(((byte)(60)))));
            this.btnSubmitEdit.Click += new System.EventHandler(this.btnSubmitEdit_Click);
            // 
            // bigLabel6
            // 
            this.bigLabel6.AutoSize = true;
            this.bigLabel6.BackColor = System.Drawing.Color.Transparent;
            this.bigLabel6.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bigLabel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.bigLabel6.Location = new System.Drawing.Point(-2, 268);
            this.bigLabel6.Name = "bigLabel6";
            this.bigLabel6.Size = new System.Drawing.Size(74, 32);
            this.bigLabel6.TabIndex = 5;
            this.bigLabel6.Text = "Ativo:";
            // 
            // checkAtivoEdit
            // 
            this.checkAtivoEdit.AutoSize = true;
            this.checkAtivoEdit.CheckedColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(158)))), ((int)(((byte)(255)))));
            this.checkAtivoEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkAtivoEdit.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(198)))), ((int)(((byte)(202)))));
            this.checkAtivoEdit.DisabledStringColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(187)))), ((int)(((byte)(189)))));
            this.checkAtivoEdit.Enable = true;
            this.checkAtivoEdit.EnabledCheckedColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(158)))), ((int)(((byte)(255)))));
            this.checkAtivoEdit.EnabledStringColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.checkAtivoEdit.EnabledUncheckedColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(158)))), ((int)(((byte)(161)))));
            this.checkAtivoEdit.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkAtivoEdit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(49)))), ((int)(((byte)(51)))));
            this.checkAtivoEdit.Location = new System.Drawing.Point(4, 317);
            this.checkAtivoEdit.Name = "checkAtivoEdit";
            this.checkAtivoEdit.Size = new System.Drawing.Size(80, 20);
            this.checkAtivoEdit.TabIndex = 4;
            this.checkAtivoEdit.Text = "Ativo";
            this.checkAtivoEdit.UseVisualStyleBackColor = true;
            // 
            // timerNotification
            // 
            this.timerNotification.Interval = 3000;
            this.timerNotification.Tick += new System.EventHandler(this.timerNotification_Tick);
            // 
            // FormExtras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(610, 555);
            this.Controls.Add(this.tabPageExtras);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormExtras";
            this.Text = "FormExtras";
            this.tabPageExtras.ResumeLayout(false);
            this.tabPageCriarExtra.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabPageListarExtra.ResumeLayout(false);
            this.tabPageListarExtra.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.panelDescricao.ResumeLayout(false);
            this.panelDescricao.PerformLayout();
            this.flowLayoutPanel3.ResumeLayout(false);
            this.flowLayoutPanel3.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.tabPageEditarExtra.ResumeLayout(false);
            this.tabPageEditarExtra.PerformLayout();
            this.panelSelecionadoEdit.ResumeLayout(false);
            this.panelSelecionadoEdit.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private ReaLTaiizor.Controls.ForeverTabPage tabPageExtras;
        private System.Windows.Forms.TabPage tabPageCriarExtra;
        private ReaLTaiizor.Controls.FoxNotification notificationExtra;
        private System.Windows.Forms.Panel panel1;
        private ReaLTaiizor.Controls.BigLabel bigLabel1;
        private ReaLTaiizor.Controls.BigLabel bigLabel2;
        private ReaLTaiizor.Controls.BigTextBox txtDescricao;
        private ReaLTaiizor.Controls.HopeRoundButton btnSubmit;
        private ReaLTaiizor.Controls.BigLabel bigLabel3;
        private ReaLTaiizor.Controls.HopeCheckBox checkBoxAtivo;
        private System.Windows.Forms.TabPage tabPageListarExtra;
        private ReaLTaiizor.Controls.LostButton btnApagar;
        private ReaLTaiizor.Controls.LostButton btnSelecionar;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private ReaLTaiizor.Controls.DungeonLabel lblSelecionado;
        private ReaLTaiizor.Controls.DungeonHeaderLabel dungeonHeaderLabel3;
        private System.Windows.Forms.FlowLayoutPanel panelDescricao;
        private ReaLTaiizor.Controls.DungeonHeaderLabel dungeonHeaderLabel1;
        private ReaLTaiizor.Controls.DungeonLabel lblDescricao;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private ReaLTaiizor.Controls.DungeonHeaderLabel dungeonHeaderLabel4;
        private ReaLTaiizor.Controls.DungeonLabel lblAtivo;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private ReaLTaiizor.Controls.DungeonHeaderLabel dungeonHeaderLabel2;
        private ReaLTaiizor.Controls.DungeonLabel lblPreco;
        private ReaLTaiizor.Controls.AloneButton btnPaginateVoltar;
        private ReaLTaiizor.Controls.AloneButton btnPaginateAvancar;
        private ReaLTaiizor.Controls.AloneComboBox comboBoxExtras;
        private System.Windows.Forms.TabPage tabPageEditarExtra;
        private ReaLTaiizor.Controls.DungeonHeaderLabel lblNotSelected;
        private System.Windows.Forms.Panel panelSelecionadoEdit;
        private ReaLTaiizor.Controls.BigLabel bigLabel4;
        private ReaLTaiizor.Controls.BigLabel bigLabel5;
        private ReaLTaiizor.Controls.BigTextBox txtEditDesc;
        private ReaLTaiizor.Controls.HopeRoundButton btnSubmitEdit;
        private ReaLTaiizor.Controls.BigLabel bigLabel6;
        private ReaLTaiizor.Controls.HopeCheckBox checkAtivoEdit;
        private ReaLTaiizor.Controls.BigTextBox txtPreco;
        private ReaLTaiizor.Controls.BigTextBox txtEditPreco;
        private System.Windows.Forms.Timer timerNotification;
    }
}