﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KargoTakip001
{
    internal class FormManager
    {
        public static void FormClose(FormClosingEventArgs e)
        {
            if (MessageBox.Show("Çıkmak istediğinize emin misiniz?", "Dikkat", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
                Environment.Exit(1);
            else
            {
                e.Cancel = true; // to don't close form is user change his mind
            }
        
        }
    }
}
