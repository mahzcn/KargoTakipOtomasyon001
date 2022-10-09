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
            FormManager.FormClose(e);
        }
    }
}
