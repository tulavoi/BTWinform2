using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DeKiemTra
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            dtpDOB.CustomFormat = "dd-MM-yyyy";
            cboKhoa.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Xac nhan thoat?",
                "Xac nhan",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
                Close();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string gender = radNam.Checked ? "Nam" : radNu.Checked ? "Nu" : "";
            DateTime dob = dtpDOB.Value;
            string khoa = cboKhoa.SelectedItem.ToString();
            ListViewItem lv = new ListViewItem(txtName.Text);
            lv.SubItems.Add(gender);
            lv.SubItems.Add(dob.ToString("dd-MM-yyyy"));
            lv.SubItems.Add(khoa);
            lv.SubItems.Add(txtPhi.Text);
            lvwInfo.Items.Add(lv);

            ResetControl();
        }

        private void ResetControl()
        {
            txtName.Text = "";
            radNam.Checked = false;
            radNu.Checked = false;
            dtpDOB.Value = DateTime.Now;
            cboKhoa.SelectedIndex = -1;
            txtPhi.Text = "";
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (lvwInfo.SelectedItems.Count > 0)
            {
                while (lvwInfo.SelectedItems.Count > 0)
                    lvwInfo.Items.Remove(lvwInfo.SelectedItems[0]);
            }
            ResetControl();
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if (lvwInfo.SelectedItems.Count > 0)
            {
                ListViewItem lv = lvwInfo.SelectedItems[0];
                string gender = radNam.Checked ? "Nam" : radNu.Checked ? "Nu" : "";
                DateTime dob = dtpDOB.Value;
                string khoa = cboKhoa.SelectedItem.ToString();
                lv.SubItems[0].Text = txtName.Text;
                lv.SubItems[1].Text = gender;
                lv.SubItems[2].Text = dob.ToString("dd-MM-yyyy");
                lv.SubItems[3].Text = khoa;
                lv.SubItems[4].Text = txtPhi.Text;
            }
        }

        private void lvwInfo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvwInfo.SelectedItems.Count > 0)
            {
                ListViewItem lv = lvwInfo.SelectedItems[0];
                txtName.Text = lv.SubItems[0].Text;
                string gender = lv.SubItems[1].Text;
                if (gender == "Nam")
                    radNam.Checked = true;
                else
                    radNu.Checked = true;
                string dob = lv.SubItems[2].Text;
                DateTime selectedDate;
                if (DateTime.TryParse(dob, out selectedDate))
                    dtpDOB.Value = selectedDate;
                string khoa = lv.SubItems[3].Text;
                if (khoa == "CNTT")
                    cboKhoa.SelectedItem = "CNTT";
                else if (khoa == "Ke Toan")
                    cboKhoa.SelectedItem = "Ke Toan";
                else if (khoa == "Ngon Ngu Anh")
                    cboKhoa.SelectedItem = "Ngon Ngu Anh";
                txtPhi.Text = lv.SubItems[4].Text;
            }
        }

        string path = "E:\\ThongTinDoanVien\\DoanVien.txt";

        private void btnLuu_Click(object sender, EventArgs e)
        {
            bool isSaved = false;
            using (StreamWriter streamWriter = new StreamWriter(path))
            {
                foreach (ListViewItem item in lvwInfo.Items)
                {
                    string line = "";
                    line += item.Text;
                    for (int i = 1; i < item.SubItems.Count; i++)
                        line += "|" + item.SubItems[i].Text;

                    streamWriter.WriteLine(line);
                    isSaved = true;
                }
                if (isSaved)
                    MessageBox.Show("Luu file thanh cong");
                else
                    MessageBox.Show("Luu file khong thanh cong");
            }
        }

        private void btnMo_Click(object sender, EventArgs e)
        {
            lvwInfo.Items.Clear();
            using (StreamReader streamReader = new StreamReader(path))
            {
                while (!streamReader.EndOfStream)
                {
                    string[] part = streamReader.ReadLine().Split('|');
                    ListViewItem lv = new ListViewItem(part[0]);    
                    for (int i = 1; i < part.Length; i++)
                        lv.SubItems.Add(part[i]);
                    lvwInfo.Items.Add(lv);
                }
            }
        }
    }
}
