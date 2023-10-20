using Bai1;
using System;
using System.Windows.Forms;

namespace Bai2
{
    public partial class frmPlash : Form
    {
        public frmPlash()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            frmBai1 frm = new frmBai1();
            frm.Show();
            this.Hide();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // Cách 1
            if (prgLoadForm.Value < 100)
            {
                prgLoadForm.Value += 1;
                lblPercent.Text = prgLoadForm.Value.ToString() + "%";
            }
            else
            {
                timer1.Stop();
                frmBai1 frm = new frmBai1();
                frm.Show();
                this.Hide();
            }

            // Cách 2
            //panel2.Width += 3;
            //if (panel2.Width >= 599)
            //{
            //    timer1.Stop();
            //    frmBai1 frm = new frmBai1();
            //    frm.Show();
            //    this.Hide();
            //}
        }
    }
}
