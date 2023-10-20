using Bai1;
using Bai2;
using Bai7;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai3
{
    public partial class frmAbout : Form
    {
        public frmAbout()
        {
            InitializeComponent();
        }

        private void mnuOpenModule2Bai1_Click_1(object sender, EventArgs e)
        {
            frmBai1 frm = new frmBai1();
            frm.MdiParent = this;
            frm.Show();
        }

        private void mnuOpenModule2Bai2_Click_1(object sender, EventArgs e)
        {
            frmPlash frm = new frmPlash();
            frm.MdiParent = this;
            frm.Show();
        }

        private void mnuOpenModule2Bai7_Click(object sender, EventArgs e)
        {
            frmBai7 frm = new frmBai7();
            frm.MdiParent = this;
            frm.Show();
        }

        private void mnuKetThuc_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
