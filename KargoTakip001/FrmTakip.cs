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

    public partial class FrmTakip : Form
    {
        FormView frm = new FormView();
        public FrmTakip()
        {
            InitializeComponent();
        }

        private void FrmTakip_FormClosing(object sender, FormClosingEventArgs e)
        {
            FormManager.FormClose(e);
        }



        private void FrmTakip_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmMudurHead frm1 = new FrmMudurHead();
            frm.Form(frm1, this);
        }
    }
}
