using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{


    public partial class Main : Form
    {
        FrmPersonel fr = new FrmPersonel()
        {

        };

        public Main()
        {
            InitializeComponent();

        }

        private void btnMusteri_Click(object sender, EventArgs e)
        {
            ErrorProvider provider = new ErrorProvider();
            if (Manager.TcDogrulaV2(mTxtSicilNo.Text) == true)
            {
                mTxtSicilNo.BackColor = Color.White;
                if (cboxPozisyon.Text == "Personel" || cboxPozisyon.Text == "Müdür")

                {
                    if (cboxPozisyon.Text == "Personel")
                    {

                        var frm = new FrmPersonel();
                        frm.Location = this.Location;
                        frm.StartPosition = FormStartPosition.Manual;
                        frm.FormClosing += delegate { this.Close(); };
                        frm.pozisyon = cboxPozisyon.Text;
                        frm.Show();
                        this.Hide();

                    }
                    if (cboxPozisyon.Text == "Müdür")
                    {
                        var frm = new Mudur();
                        frm.Location = this.Location;
                        frm.StartPosition = FormStartPosition.Manual;
                        frm.FormClosing += delegate { this.Close(); };
                        frm.pozisyon = cboxPozisyon.Text;
                        frm.Show();
                        this.Hide();

                    }
                }
                else
                {
                    provider.SetError(cboxPozisyon, "Eksik veya yanlış girdiniz");
                }

            }


        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                txtPassword.PasswordChar = '\0';
            }
            else if (checkBox1.Checked == false)
            {
                txtPassword.PasswordChar = '*';
            }
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }
    }
}
