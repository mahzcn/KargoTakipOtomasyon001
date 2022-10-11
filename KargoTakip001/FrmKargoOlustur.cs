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
        FormView frm = new FormView();
        public FrmKargoOlustur()
        {
            InitializeComponent();
        }

        private void btnKargoOlustur_Click(object sender, EventArgs e)
        {

        }

        private void FrmKargoOlustur_FormClosing(object sender, FormClosingEventArgs e)
        {
            FormManager.FormClose(e);
        }

        private void rBtnTuzel_CheckedChanged(object sender, EventArgs e)
        {
            if (rBtnTuzel.Checked == true)
            {
                txtKurumAdiGonderici.Enabled = true;
                txtVergiGonderici.Enabled = true;
                txtMahalleGonderici.Enabled = true;
                txtIlGonderici.Enabled = true;
                txtIlceGonderici.Enabled = true;
                txtCaddeGonderici.Enabled = true;
                mTxtTelefonGonderici.Enabled = true;
                txtMailGonderici.Enabled = true;
                txtAdGönderici.Enabled = false;
                txtSoyadGonderici.Enabled = false;
                mTxtTcGonderici.Enabled = false;
            }
            else
            {
                txtKurumAdiGonderici.Enabled = false;
                txtVergiGonderici.Enabled = false;
                txtAdGönderici.Enabled = true;
                txtSoyadGonderici.Enabled = true;
                mTxtTcGonderici.Enabled = true;
                txtMahalleGonderici.Enabled = true;
                txtIlGonderici.Enabled = true;
                txtIlceGonderici.Enabled = true;
                txtCaddeGonderici.Enabled = true;
                mTxtTelefonGonderici.Enabled = true;
                txtMailGonderici.Enabled = true;
            }
        }

        private void rBtnTuzelAlici_CheckedChanged(object sender, EventArgs e)
        {
            if (rBtnTuzelAlici.Checked == true)
            {
                txtKurumAdiAlici.Enabled = true;
                txtVergiNoAlici.Enabled = true;
                txtMahalleAlici.Enabled = true;
                txtIlAlici.Enabled = true;
                txtIlceAlici.Enabled = true;
                txtCaddeAlici.Enabled = true;
                mTxtTelefonAlici.Enabled = true;
                txtMailAlici.Enabled = true;
                txtAdAlici.Enabled = false;
                txtSoyadAlici.Enabled = false;
                mTxtTcAlici.Enabled = false;
            }
            else
            {
                txtKurumAdiAlici.Enabled = false;
                txtVergiNoAlici.Enabled = false;
                txtAdAlici.Enabled = true;
                txtSoyadAlici.Enabled = true;
                mTxtTcAlici.Enabled = true;
                txtMahalleAlici.Enabled = true;
                txtIlAlici.Enabled = true;
                txtIlceAlici.Enabled = true;
                txtCaddeAlici.Enabled = true;
                mTxtTelefonAlici.Enabled = true;
                txtMailAlici.Enabled = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
        
        private void FrmKargoOlustur_Load(object sender, EventArgs e)
        {


        }


    }
}
