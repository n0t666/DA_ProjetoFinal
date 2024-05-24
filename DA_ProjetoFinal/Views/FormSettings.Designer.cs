namespace DA_ProjetoFinal.Views
{
    partial class FormSettings
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
            this.panelTop = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.comboBoxPratos = new ReaLTaiizor.Controls.AloneComboBox();
            this.dungeonLabel1 = new ReaLTaiizor.Controls.DungeonLabel();
            this.dungeonLabel2 = new ReaLTaiizor.Controls.DungeonLabel();
            this.aloneComboBox1 = new ReaLTaiizor.Controls.AloneComboBox();
            this.dungeonLabel3 = new ReaLTaiizor.Controls.DungeonLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(22)))), ((int)(((byte)(25)))));
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(469, 77);
            this.panelTop.TabIndex = 1;
            this.panelTop.Paint += new System.Windows.Forms.PaintEventHandler(this.panelTop_Paint);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DA_ProjetoFinal.Properties.Resources.default_user;
            this.pictureBox1.Location = new System.Drawing.Point(127, 83);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(215, 157);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 39;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // comboBoxPratos
            // 
            this.comboBoxPratos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBoxPratos.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboBoxPratos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxPratos.EnabledCalc = true;
            this.comboBoxPratos.FormattingEnabled = true;
            this.comboBoxPratos.ItemHeight = 20;
            this.comboBoxPratos.Location = new System.Drawing.Point(95, 309);
            this.comboBoxPratos.Name = "comboBoxPratos";
            this.comboBoxPratos.Size = new System.Drawing.Size(280, 26);
            this.comboBoxPratos.TabIndex = 40;
            // 
            // dungeonLabel1
            // 
            this.dungeonLabel1.AutoSize = true;
            this.dungeonLabel1.BackColor = System.Drawing.Color.Transparent;
            this.dungeonLabel1.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.dungeonLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(77)))));
            this.dungeonLabel1.Location = new System.Drawing.Point(100, 286);
            this.dungeonLabel1.Name = "dungeonLabel1";
            this.dungeonLabel1.Size = new System.Drawing.Size(208, 20);
            this.dungeonLabel1.TabIndex = 41;
            this.dungeonLabel1.Text = "Selecione o tipo de utilizador:";
            // 
            // dungeonLabel2
            // 
            this.dungeonLabel2.AutoSize = true;
            this.dungeonLabel2.BackColor = System.Drawing.Color.Transparent;
            this.dungeonLabel2.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.dungeonLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(77)))));
            this.dungeonLabel2.Location = new System.Drawing.Point(100, 362);
            this.dungeonLabel2.Name = "dungeonLabel2";
            this.dungeonLabel2.Size = new System.Drawing.Size(156, 20);
            this.dungeonLabel2.TabIndex = 43;
            this.dungeonLabel2.Text = "Selecione o utilizador:";
            // 
            // aloneComboBox1
            // 
            this.aloneComboBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.aloneComboBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.aloneComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.aloneComboBox1.EnabledCalc = true;
            this.aloneComboBox1.FormattingEnabled = true;
            this.aloneComboBox1.ItemHeight = 20;
            this.aloneComboBox1.Location = new System.Drawing.Point(95, 385);
            this.aloneComboBox1.Name = "aloneComboBox1";
            this.aloneComboBox1.Size = new System.Drawing.Size(280, 26);
            this.aloneComboBox1.TabIndex = 42;
            // 
            // dungeonLabel3
            // 
            this.dungeonLabel3.AutoSize = true;
            this.dungeonLabel3.BackColor = System.Drawing.Color.Transparent;
            this.dungeonLabel3.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.dungeonLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(77)))));
            this.dungeonLabel3.Location = new System.Drawing.Point(73, 243);
            this.dungeonLabel3.Name = "dungeonLabel3";
            this.dungeonLabel3.Size = new System.Drawing.Size(323, 20);
            this.dungeonLabel3.TabIndex = 44;
            this.dungeonLabel3.Text = "(clique na imagem para alterar a foto de perfil)";
            // 
            // FormSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(468, 635);
            this.Controls.Add(this.dungeonLabel3);
            this.Controls.Add(this.dungeonLabel2);
            this.Controls.Add(this.aloneComboBox1);
            this.Controls.Add(this.dungeonLabel1);
            this.Controls.Add(this.comboBoxPratos);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panelTop);
            this.Name = "FormSettings";
            this.Text = "FormSettings";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.PictureBox pictureBox1;
        private ReaLTaiizor.Controls.AloneComboBox comboBoxPratos;
        private ReaLTaiizor.Controls.DungeonLabel dungeonLabel1;
        private ReaLTaiizor.Controls.DungeonLabel dungeonLabel2;
        private ReaLTaiizor.Controls.AloneComboBox aloneComboBox1;
        private ReaLTaiizor.Controls.DungeonLabel dungeonLabel3;
    }
}