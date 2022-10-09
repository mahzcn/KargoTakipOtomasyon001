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
    public partial class FrmPersonelHead : Form
    {
        
        FormView frm = new FormView();
        public FrmPersonelHead()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FrmTakip frm1 = new FrmTakip();
            frm.Form(frm1, this);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmKargoOlustur frm1 = new FrmKargoOlustur();
            frm.Form(frm1, this);
        }

        private void FrmPersonelHead_FormClosing(object sender, FormClosingEventArgs e)
        {
            FormManager.FormClose(e);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmPersonel frm1 = new FrmPersonel();
            frm.Form(frm1, this);
        }
    }
}
