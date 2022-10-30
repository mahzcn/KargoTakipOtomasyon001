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
    public partial class FrmPersonelControler : Form
    {
        
        public FrmPersonelControler()
        {
            InitializeComponent();
        }

        private void FrmPersonelControler_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
        }

        private void txtTCNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            if (e.KeyChar != (char)Keys.Back)
            {


                if (txtTCNo.Text.Length == 0)
                {
                    if (e.KeyChar == '0')
                    {
                        e.Handled = true;
                        errorProvider1.SetError(txtTCNo, "İlk sayi 0 olamaz");

                    }
                    else
                    {
                        errorProvider1.Clear();
                    }
                }
                else if (txtTCNo.Text.Length == 9)
                {
                    int[] dizi = new int[txtTCNo.Text.Length];
                    for (int i = 0; i < dizi.Length; i++)
                    {
                        dizi[i] = (int)Char.GetNumericValue(txtTCNo.Text[i]);
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
                        errorProvider1.SetError(txtTCNo, "10.Hanede Hatalı giriş");
                    }
                    else
                    {
                        e.Handled = false;
                        errorProvider1.Clear();
                    }


                }
                else if (txtTCNo.Text.Length == 10)
                {
                    int[] dizi = new int[txtTCNo.Text.Length];
                    for (int i = 0; i < dizi.Length; i++)
                    {
                        dizi[i] = (int)Char.GetNumericValue(txtTCNo.Text[i]);
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
                        errorProvider1.SetError(txtTCNo, "11.Hanede Hatalı giriş");
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
    }
}
