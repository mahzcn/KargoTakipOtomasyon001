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
    public partial class FrmMudur : Form
    {
        FormView frm = new FormView();
        public FrmMudur()
        {
            InitializeComponent();
        }

        private void btnMusteri_Click(object sender, EventArgs e)
        {
            FrmMudurHead frm1 = new FrmMudurHead();
            frm.Form(frm1, this);

        }

        private void FrmMudur_FormClosing(object sender, FormClosingEventArgs e)
        {
            FormManager.FormClose(e);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Main frm1 = new Main();
            frm.Form(frm1,this);
        }
    }
}
