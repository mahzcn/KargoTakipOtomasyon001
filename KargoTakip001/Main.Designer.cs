namespace KargoTakip001
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
            this.btnPersonel = new System.Windows.Forms.Button();
            this.btnMudur = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnPersonel
            // 
            this.btnPersonel.Location = new System.Drawing.Point(12, 12);
            this.btnPersonel.Name = "btnPersonel";
            this.btnPersonel.Size = new System.Drawing.Size(267, 267);
            this.btnPersonel.TabIndex = 0;
            this.btnPersonel.Text = "Personel";
            this.btnPersonel.UseVisualStyleBackColor = true;
            this.btnPersonel.Click += new System.EventHandler(this.btnPersonel_Click);
            // 
            // btnMudur
            // 
            this.btnMudur.Location = new System.Drawing.Point(285, 12);
            this.btnMudur.Name = "btnMudur";
            this.btnMudur.Size = new System.Drawing.Size(267, 267);
            this.btnMudur.TabIndex = 1;
            this.btnMudur.Text = "Müdür";
            this.btnMudur.UseVisualStyleBackColor = true;
            this.btnMudur.Click += new System.EventHandler(this.btnMudur_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(588, 434);
            this.Controls.Add(this.btnMudur);
            this.Controls.Add(this.btnPersonel);
            this.Name = "Main";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnPersonel;
        private System.Windows.Forms.Button btnMudur;
    }
}

