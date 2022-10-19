using KargoTakip001;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class FrmPersonel : Form
    {
        public FrmPersonel()
        {
            InitializeComponent();
        }
        public string pozisyon { get; set; }
        private void FrmPersonel_Load(object sender, EventArgs e)
        {
            label1.Text = pozisyon;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var frm = new FrmKargoOlustur();
            frm.Location = this.Location;
            frm.StartPosition = FormStartPosition.Manual;
            frm.FormClosing += delegate { this.Show(); };
            frm.gecis = label1.Text;
            frm.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var frm = new FrmTakip();
            frm.Location = this.Location;
            frm.StartPosition = FormStartPosition.Manual;
            frm.FormClosing += delegate { this.Show(); };

            frm.Show();
            this.Hide();
        }
    }
}
