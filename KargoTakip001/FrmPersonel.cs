﻿using System;
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
    
    public partial class FrmPersonel : Form
   
    {
        FormView frm = new FormView();
        public FrmPersonel()
        {
            InitializeComponent();
        }

        private void btnMusteri_Click(object sender, EventArgs e)
        {
            FrmPersonelHead frm1 = new FrmPersonelHead();
            frm.Form(frm1, this);

        }

        private void FrmPersonel_FormClosing(object sender, FormClosingEventArgs e)
        {
            FormManager.FormClose(e);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Main frm1 = new Main();
            frm.Form(frm1, this);
        }
    }
}
