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
   
    public partial class FrmMudurHead : Form
    {
        FormView frm = new FormView();
        public FrmMudurHead()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmPersonelControler frm1 = new FrmPersonelControler();
            frm.Form(frm1, this);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmKargoOlustur frm1 = new FrmKargoOlustur();
            frm.Form(frm1, this);

        }

        private void FrmMudurHead_FormClosing(object sender, FormClosingEventArgs e)
        {
            FormManager.FormClose(e);
        }
    }
}
