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
    public partial class Main : Form
    {
        FormView frm = new FormView();
        public Main()
        {
            InitializeComponent();
        }

        private void btnPersonel_Click(object sender, EventArgs e)
        {
            FrmPersonel frm1 = new FrmPersonel();
            frm.Form(frm1, this);

        }

        private void btnMudur_Click(object sender, EventArgs e)
        {
            FrmMudur frm1 = new FrmMudur();
            frm.Form(frm1, this);

        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            FormManager.FormClose(e);
        }
    }
}
