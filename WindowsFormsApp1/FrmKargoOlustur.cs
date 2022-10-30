using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KargoTakip001
{
    
    public partial class FrmKargoOlustur : Form
    {
        public string gecis { get; set; }
        public FrmKargoOlustur()
        {
            InitializeComponent();
        }

        private void btnKargoOlustur_Click(object sender, EventArgs e)
        {

        }

        private void FrmKargoOlustur_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }

        private void rBtnTuzel_CheckedChanged(object sender, EventArgs e)
        {
            if (rBtnTuzel.Checked == true)
            {
                txtKurumAdiGonderici.Enabled = true;
                txtVergiGonderici.Enabled = true;
                cBoxMahalleGonderici.Enabled = true;
                cBoxIlGonderici.Enabled = true;
                cboxSemt.Enabled = true;
                cBoxIlceGonderici.Enabled = true;
                mTxtTelefonGonderici.Enabled = true;
                txtMailGonderici.Enabled = true;
                txtAdGönderici.Enabled = false;
                txtSoyadGonderici.Enabled = false;
                txtTCNoGonderici.Enabled = false;
            }

        }

        private void rBtnTuzelAlici_CheckedChanged(object sender, EventArgs e)
        {
            if (rBtnTuzelAlici.Checked == true)
            {
                txtKurumAdiAlici.Enabled = true;
                txtVergiNoAlici.Enabled = true;
                cboxIl.Enabled = true;
                cboxIlce.Enabled = true;
                cboxSemt.Enabled = true;
                cBoxMahalle.Enabled = true;
                mTxtTelefonAlici.Enabled = true;
                txtMailAlici.Enabled = true;
                txtAdAlici.Enabled = false;
                txtSoyadAlici.Enabled = false;
                txtTCNoAlici.Enabled = false;
            }

        }


        
        private void FrmKargoOlustur_Load(object sender, EventArgs e)
        {


        }

        private void rBtnGercek_CheckedChanged(object sender, EventArgs e)
        {
            if(rBtnGercek.Checked == true)
            {
                txtKurumAdiGonderici.Enabled = false;
                txtVergiGonderici.Enabled = false;
                txtAdGönderici.Enabled = true;
                txtSoyadGonderici.Enabled = true;
                txtTCNoGonderici.Enabled = true;
                cBoxMahalleGonderici.Enabled = true;
                cBoxIlGonderici.Enabled = true;
                cBoxIlceGonderici.Enabled = true;
                cBoxSemtGonderici.Enabled = true;
                mTxtTelefonGonderici.Enabled = true;
                txtMailGonderici.Enabled = true;
            }
        }

        private void rBtnGercekAlici_CheckedChanged(object sender, EventArgs e)
        {
            if(rBtnGercekAlici.Checked == true)
            {
                txtKurumAdiAlici.Enabled = false;
                txtVergiNoAlici.Enabled = false;
                txtAdAlici.Enabled = true;
                txtSoyadAlici.Enabled = true;
                txtTCNoAlici.Enabled = true;
                cBoxMahalle.Enabled = true;
                cboxIl.Enabled = true;
                cboxIlce.Enabled = true;
                cboxSemt.Enabled = true;
                mTxtTelefonAlici.Enabled = true;
                txtMailAlici.Enabled = true;
            }
        }

        private void txtTCNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            if (e.KeyChar != (char)Keys.Back)
            {


                if (txtTCNoGonderici.Text.Length == 0)
                {
                    if (e.KeyChar == '0')
                    {
                        e.Handled = true;
                        errorProvider1.SetError(txtTCNoGonderici, "İlk sayi 0 olamaz");

                    }
                    else
                    {
                        errorProvider1.Clear();
                    }
                }
                else if (txtTCNoGonderici.Text.Length == 9)
                {
                    int[] dizi = new int[txtTCNoGonderici.Text.Length];
                    for (int i = 0; i < dizi.Length; i++)
                    {
                        dizi[i] = (int)Char.GetNumericValue(txtTCNoGonderici.Text[i]);
                    }
                    int tek = 0, cift = 0;
                    for (int i = 0; i < 9; i += 2)
                    {
                        tek += dizi[i];
                    }

                    for (int i = 1; i < 9; i += 2)
                    {
                        cift += dizi[i];
                    }
                    tek *= 7;
                    int onuncuHane = (tek - cift) % 10;
                    if (e.KeyChar.ToString() != onuncuHane.ToString())
                    {
                        e.Handled = true;
                        errorProvider1.SetError(txtTCNoGonderici, "10.Hanede Hatalı giriş");
                    }
                    else
                    {
                        e.Handled = false;
                        errorProvider1.Clear();
                    }


                }
                else if (txtTCNoGonderici.Text.Length == 10)
                {
                    int[] dizi = new int[txtTCNoGonderici.Text.Length];
                    for (int i = 0; i < dizi.Length; i++)
                    {
                        dizi[i] = (int)Char.GetNumericValue(txtTCNoGonderici.Text[i]);
                    }
                    int toplam = 0;
                    for (int i = 0; i < 10; i++)
                    {
                        toplam += dizi[i];
                    }



                    int onbirinciHane = toplam % 10;
                    if (e.KeyChar.ToString() != onbirinciHane.ToString())
                    {
                        e.Handled = true;
                        errorProvider1.SetError(txtTCNoGonderici, "11.Hanede Hatalı giriş");
                    }
                    else
                    {
                        e.Handled = false;
                        errorProvider1.Clear();
                    }
                }
            }
            else
            {
                e.Handled = false;
                errorProvider1.Clear();
            }
        }

        private void txtTCNo_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            if (e.KeyChar != (char)Keys.Back)
            {


                if (txtTCNoAlici.Text.Length == 0)
                {
                    if (e.KeyChar == '0')
                    {
                        e.Handled = true;
                        errorProvider1.SetError(txtTCNoAlici, "İlk sayi 0 olamaz");

                    }
                    else
                    {
                        errorProvider1.Clear();
                    }
                }
                else if (txtTCNoAlici.Text.Length == 9)
                {
                    int[] dizi = new int[txtTCNoAlici.Text.Length];
                    for (int i = 0; i < dizi.Length; i++)
                    {
                        dizi[i] = (int)Char.GetNumericValue(txtTCNoAlici.Text[i]);
                    }
                    int tek = 0, cift = 0;
                    for (int i = 0; i < 9; i += 2)
                    {
                        tek += dizi[i];
                    }

                    for (int i = 1; i < 9; i += 2)
                    {
                        cift += dizi[i];
                    }
                    tek *= 7;
                    int onuncuHane = (tek - cift) % 10;
                    if (e.KeyChar.ToString() != onuncuHane.ToString())
                    {
                        e.Handled = true;
                        errorProvider1.SetError(txtTCNoAlici, "10.Hanede Hatalı giriş");
                    }
                    else
                    {
                        e.Handled = false;
                        errorProvider1.Clear();
                    }


                }
                else if (txtTCNoAlici.Text.Length == 10)
                {
                    int[] dizi = new int[txtTCNoAlici.Text.Length];
                    for (int i = 0; i < dizi.Length; i++)
                    {
                        dizi[i] = (int)Char.GetNumericValue(txtTCNoAlici.Text[i]);
                    }
                    int toplam = 0;
                    for (int i = 0; i < 10; i++)
                    {
                        toplam += dizi[i];
                    }



                    int onbirinciHane = toplam % 10;
                    if (e.KeyChar.ToString() != onbirinciHane.ToString())
                    {
                        e.Handled = true;
                        errorProvider1.SetError(txtTCNoAlici, "11.Hanede Hatalı giriş");
                    }
                    else
                    {
                        e.Handled = false;
                        errorProvider1.Clear();
                    }
                }
            }
            else
            {
                e.Handled = false;
                errorProvider1.Clear();
            }
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

    }
}
