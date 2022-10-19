namespace WindowsFormsApp1
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
            this.btnMusteri = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.mTxtSicilNo = new System.Windows.Forms.MaskedTextBox();
            this.cboxPozisyon = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // btnMusteri
            // 
            this.btnMusteri.Font = new System.Drawing.Font("Noto Sans", 13.8F);
            this.btnMusteri.Location = new System.Drawing.Point(344, 319);
            this.btnMusteri.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnMusteri.Name = "btnMusteri";
            this.btnMusteri.Size = new System.Drawing.Size(195, 96);
            this.btnMusteri.TabIndex = 2;
            this.btnMusteri.Text = "Giriş";
            this.btnMusteri.UseVisualStyleBackColor = true;
            this.btnMusteri.Click += new System.EventHandler(this.btnMusteri_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Noto Sans", 13.8F);
            this.label2.Location = new System.Drawing.Point(282, 227);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 32);
            this.label2.TabIndex = 8;
            this.label2.Text = "Şifre :";
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Noto Sans", 13.8F);
            this.txtPassword.Location = new System.Drawing.Point(367, 224);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(277, 39);
            this.txtPassword.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Noto Sans", 13.8F);
            this.label1.Location = new System.Drawing.Point(249, 129);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 32);
            this.label1.TabIndex = 6;
            this.label1.Text = "Sicil NO :";
            // 
            // mTxtSicilNo
            // 
            this.mTxtSicilNo.Font = new System.Drawing.Font("Noto Sans", 13.8F);
            this.mTxtSicilNo.Location = new System.Drawing.Point(367, 126);
            this.mTxtSicilNo.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.mTxtSicilNo.Mask = "00000000000000000000000000";
            this.mTxtSicilNo.Name = "mTxtSicilNo";
            this.mTxtSicilNo.Size = new System.Drawing.Size(277, 39);
            this.mTxtSicilNo.TabIndex = 9;
            // 
            // cboxPozisyon
            // 
            this.cboxPozisyon.FormattingEnabled = true;
            this.cboxPozisyon.Items.AddRange(new object[] {
            "Personel",
            "Müdür"});
            this.cboxPozisyon.Location = new System.Drawing.Point(367, 62);
            this.cboxPozisyon.Name = "cboxPozisyon";
            this.cboxPozisyon.Size = new System.Drawing.Size(277, 40);
            this.cboxPozisyon.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Noto Sans", 13.8F);
            this.label3.Location = new System.Drawing.Point(212, 65);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(146, 32);
            this.label3.TabIndex = 11;
            this.label3.Text = "POZİSYON  :";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(578, 379);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(183, 36);
            this.checkBox1.TabIndex = 12;
            this.checkBox1.Text = "Şifreyi Göster";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(916, 560);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cboxPozisyon);
            this.Controls.Add(this.mTxtSicilNo);
            this.Controls.Add(this.btnMusteri);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Noto Sans", 13.8F);
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "Main";
            this.Text = "Giriş";
            this.Load += new System.EventHandler(this.Main_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnMusteri;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox mTxtSicilNo;
        private System.Windows.Forms.ComboBox cboxPozisyon;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}

