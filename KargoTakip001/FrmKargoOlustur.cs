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
    public partial class FrmKargoOlustur : Form
    {
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
    }
}
