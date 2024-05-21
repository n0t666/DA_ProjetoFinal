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
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.poisonDateTime1 = new ReaLTaiizor.Controls.PoisonDateTime();
            this.poisonComboBox1 = new ReaLTaiizor.Controls.PoisonComboBox();
            this.poisonComboBox2 = new ReaLTaiizor.Controls.PoisonComboBox();
            this.poisonButton1 = new ReaLTaiizor.Controls.PoisonButton();
            this.hopeRichTextBox1 = new ReaLTaiizor.Controls.HopeRichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(88, 249);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 25);
            this.label1.TabIndex = 19;
            this.label1.Text = "Utilizador atual:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DA_ProjetoFinal.Properties.Resources.default_user;
            this.pictureBox1.Location = new System.Drawing.Point(198, 76);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(215, 157);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // poisonDateTime1
            // 
            this.poisonDateTime1.Location = new System.Drawing.Point(96, 312);
            this.poisonDateTime1.MinimumSize = new System.Drawing.Size(0, 29);
            this.poisonDateTime1.Name = "poisonDateTime1";
            this.poisonDateTime1.Size = new System.Drawing.Size(200, 29);
            this.poisonDateTime1.Style = ReaLTaiizor.Enum.Poison.ColorStyle.Black;
            this.poisonDateTime1.TabIndex = 26;
            // 
            // poisonComboBox1
            // 
            this.poisonComboBox1.FormattingEnabled = true;
            this.poisonComboBox1.ItemHeight = 23;
            this.poisonComboBox1.Location = new System.Drawing.Point(302, 312);
            this.poisonComboBox1.Name = "poisonComboBox1";
            this.poisonComboBox1.Size = new System.Drawing.Size(216, 29);
            this.poisonComboBox1.TabIndex = 27;
            this.poisonComboBox1.UseSelectable = true;
            // 
            // poisonComboBox2
            // 
            this.poisonComboBox2.FormattingEnabled = true;
            this.poisonComboBox2.ItemHeight = 23;
            this.poisonComboBox2.Location = new System.Drawing.Point(302, 249);
            this.poisonComboBox2.Name = "poisonComboBox2";
            this.poisonComboBox2.Size = new System.Drawing.Size(216, 29);
            this.poisonComboBox2.TabIndex = 28;
            this.poisonComboBox2.UseSelectable = true;
            // 
            // poisonButton1
            // 
            this.poisonButton1.Location = new System.Drawing.Point(93, 515);
            this.poisonButton1.Name = "poisonButton1";
            this.poisonButton1.Size = new System.Drawing.Size(425, 23);
            this.poisonButton1.TabIndex = 29;
            this.poisonButton1.Text = "poisonButton1";
            this.poisonButton1.UseSelectable = true;
            // 
            // hopeRichTextBox1
            // 
            this.hopeRichTextBox1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(223)))), ((int)(((byte)(230)))));
            this.hopeRichTextBox1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.hopeRichTextBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(49)))), ((int)(((byte)(51)))));
            this.hopeRichTextBox1.Hint = "";
            this.hopeRichTextBox1.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(158)))), ((int)(((byte)(255)))));
            this.hopeRichTextBox1.Location = new System.Drawing.Point(96, 347);
            this.hopeRichTextBox1.MaxLength = 32767;
            this.hopeRichTextBox1.Multiline = true;
            this.hopeRichTextBox1.Name = "hopeRichTextBox1";
            this.hopeRichTextBox1.PasswordChar = '\0';
            this.hopeRichTextBox1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.hopeRichTextBox1.SelectedText = "";
            this.hopeRichTextBox1.SelectionLength = 0;
            this.hopeRichTextBox1.SelectionStart = 0;
            this.hopeRichTextBox1.Size = new System.Drawing.Size(422, 162);
            this.hopeRichTextBox1.TabIndex = 30;
            this.hopeRichTextBox1.TabStop = false;
            this.hopeRichTextBox1.Text = "hopeRichTextBox1";
            this.hopeRichTextBox1.UseSystemPasswordChar = false;
            // 
            // FormHomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(609, 555);
            this.Controls.Add(this.hopeRichTextBox1);
            this.Controls.Add(this.poisonButton1);
            this.Controls.Add(this.poisonComboBox2);
            this.Controls.Add(this.poisonComboBox1);
            this.Controls.Add(this.poisonDateTime1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormHomePage";
            this.Text = "HomePage";
            this.Load += new System.EventHandler(this.FormHomePage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private ReaLTaiizor.Controls.PoisonDateTime poisonDateTime1;
        private ReaLTaiizor.Controls.PoisonComboBox poisonComboBox1;
        private ReaLTaiizor.Controls.PoisonComboBox poisonComboBox2;
        private ReaLTaiizor.Controls.PoisonButton poisonButton1;
        private ReaLTaiizor.Controls.HopeRichTextBox hopeRichTextBox1;
    }
}