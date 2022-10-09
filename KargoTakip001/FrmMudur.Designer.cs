namespace KargoTakip001
{
    partial class FrmMudur
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
            this.txtSicil = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnMusteri
            // 
            this.btnMusteri.Font = new System.Drawing.Font("Noto Sans", 13.8F);
            this.btnMusteri.Location = new System.Drawing.Point(153, 258);
            this.btnMusteri.Name = "btnMusteri";
            this.btnMusteri.Size = new System.Drawing.Size(120, 48);
            this.btnMusteri.TabIndex = 9;
            this.btnMusteri.Text = "Giriş";
            this.btnMusteri.UseVisualStyleBackColor = true;
            this.btnMusteri.Click += new System.EventHandler(this.btnMusteri_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Noto Sans", 13.8F);
            this.label2.Location = new System.Drawing.Point(93, 162);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 32);
            this.label2.TabIndex = 8;
            this.label2.Text = "Şifre :";
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Noto Sans", 13.8F);
            this.txtPassword.Location = new System.Drawing.Point(191, 161);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(199, 39);
            this.txtPassword.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Noto Sans", 13.8F);
            this.label1.Location = new System.Drawing.Point(60, 119);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 32);
            this.label1.TabIndex = 6;
            this.label1.Text = "Sicil NO :";
            // 
            // txtSicil
            // 
            this.txtSicil.Font = new System.Drawing.Font("Noto Sans", 13.8F);
            this.txtSicil.Location = new System.Drawing.Point(191, 116);
            this.txtSicil.Name = "txtSicil";
            this.txtSicil.Size = new System.Drawing.Size(199, 39);
            this.txtSicil.TabIndex = 5;
            // 
            // FrmMudur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 423);
            this.Controls.Add(this.btnMusteri);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSicil);
            this.Name = "FrmMudur";
            this.Text = "FrmMudur";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmMudur_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnMusteri;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSicil;
    }
}