using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace Bai7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            cboArea.DropDownStyle = ComboBoxStyle.DropDownList;
        }
        
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboArea.SelectedIndex == 0)
                txtDinhMuc.Text = "50";
            else if (cboArea.SelectedIndex == 1)
                txtDinhMuc.Text = "100";
            else if (cboArea.SelectedIndex == 2)
                txtDinhMuc.Text = "150";
        }

        private void txtSoCu_TextChanged(object sender, EventArgs e)
        {
            CheckInvalidValue(txtSoCu.Text, txtSoCu);
        }

        private void txtSoMoi_TextChanged(object sender, EventArgs e)
        {
            CheckInvalidValue(txtSoMoi.Text, txtSoMoi);

            // Lỗi: nếu như 1 trong 2 cái đúng thì errorprovider sẽ bị clear
            //if (Regex.IsMatch(txtSoMoi.Text, @"^[0-9]*(\.[0-9]+)?$") && Regex.IsMatch(txtSoCu.Text, @"^[0-9]*(\.[0-9]+)?$") && (txtSoMoi.Text.Trim().Length > 0))
            //{
            //    soCu = Convert.ToInt32(txtSoCu.Text);
            //    soMoi = Convert.ToInt32(txtSoMoi.Text);
            //    if (soCu > soMoi)
            //        errorProvider1.SetError(txtSoMoi, "Số mới phải lớn hoặc bằng hơn số cũ");
            //    else
            //        errorProvider1.Clear();
            //}
        }

        private void CheckInvalidValue(string text, TextBox textBox)
        {
            bool isValid = Regex.IsMatch(text, @"^[0-9]*(\.[0-9]+)?$") && (text.Trim().Length > 0);
            if (!isValid)
                errorProvider1.SetError(textBox, "Giá trị không hợp lệ");
            else
                errorProvider1.Clear();
        }

        private void btnTinhTien_Click(object sender, EventArgs e)
        {
            TinhTien();
            if (txtName.Text != "" && txtSoCu.Text != "" && txtSoMoi.Text != "" && cboArea.SelectedIndex != -1)
                AddToListView();
            TongTien();
        }

        private void TongTien()
        {
            int sum = 0;
            foreach (ListViewItem item in listView1.Items)
            {
                int thanhTien = Convert.ToInt32(item.SubItems[4].Text);
                sum += thanhTien;
            }
            txtTotal.Text = sum.ToString();
        }

        private void AddToListView()
        {
            ListViewItem lv = new ListViewItem();
            lv.Text = txtName.Text;
            lv.SubItems.Add(cboArea.SelectedItem.ToString());
            lv.SubItems.Add(txtDinhMuc.Text);
            lv.SubItems.Add(txtTieuThu.Text);
            lv.SubItems.Add(txtThanhTien.Text);
            listView1.Items.Add(lv);
        }

        private void TinhTien()
        {
            try
            {
                int soCu = Convert.ToInt32(txtSoCu.Text);
                int soMoi = Convert.ToInt32(txtSoMoi.Text);
                int dinhMuc = Convert.ToInt32(txtDinhMuc.Text);
                int tieuThu = soMoi - soCu;
                txtTieuThu.Text = tieuThu.ToString();
                int total = tieuThu * dinhMuc;
                txtThanhTien.Text = total.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Chưa nhập đủ thông tin");
            }
        }

        private void btnNhapMoi_Click(object sender, EventArgs e)
        {
            txtName.Clear();
            cboArea.SelectedIndex = -1;
            txtDinhMuc.Clear();
            txtSoCu.Clear();
            txtSoMoi.Clear();
            errorProvider1.Clear();
            txtTieuThu.Clear();
            txtThanhTien.Clear();
            txtName.Focus();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Xác nhận thoát?",
                "Xác nhận", 
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
                Close();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            while (listView1.SelectedItems.Count > 0)
                listView1.Items.Remove(listView1.SelectedItems[0]);
        }

        private void txtTotal_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
