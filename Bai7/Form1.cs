using System;
using System.Windows.Forms;

namespace Bai7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            cboArea.DropDownStyle = ComboBoxStyle.DropDownList;
        }
        int soCu;
        int soMoi;

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
            if (CheckInvalidValue(txtSoCu, errSoCu))
            {
                // Nếu giá trị của txtSoCu là 1 số nguyên hợp lệ, cập nhật biến soCu
                if (int.TryParse(txtSoCu.Text, out int value))
                {
                    soCu = value;
                    CheckSoMoi();
                }
            }
        }

        private void txtSoMoi_TextChanged(object sender, EventArgs e)
        {
            if (CheckInvalidValue(txtSoMoi, errSoMoi))
            {
                // Nếu giá trị của txtSoMoi là 1 số nguyên hợp lệ, cập nhật biến soMoi
                if (int.TryParse(txtSoMoi.Text, out int value))
                {
                    soMoi = value;
                    CheckSoMoi();
                }
            }
        }

        private void CheckSoMoi()
        {
            if (soCu > soMoi)
                errSoMoi.SetError(txtSoMoi, "Số mới phải lớn hơn số cũ");
            else
                errSoMoi.Clear();
        }

        private bool CheckInvalidValue(TextBox txt, ErrorProvider err)
        {
            if (!int.TryParse(txt.Text, out int value) && (txt.Text.Trim().Length > 0))
            {
                err.SetError(txt, "Giá trị không hợp lệ");
                return false;
            }
            else
            {
                err.Clear();
                return true;
            }
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
            ListViewItem lv = new ListViewItem(txtName.Text);
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
            ClearControl(new Control[] { txtName, cboArea, txtDinhMuc, txtSoCu, txtSoMoi, txtTieuThu, txtThanhTien });
            errSoCu.Clear();
            txtName.Focus();
        }

        private void ClearControl(Control[] controls)
        {
            foreach (Control ctrl in controls)
            {
                if (ctrl is TextBox txt)
                    txt.Clear();
                else if (ctrl is ComboBox cbo)
                    cbo.SelectedIndex = -1;
            }
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
            if (listView1.SelectedItems.Count > 0)
            {
                while (listView1.SelectedItems.Count > 0)
                {
                    ListViewItem lv = listView1.SelectedItems[0];
                    int thanhTien = Convert.ToInt32(lv.SubItems[4].Text);
                    int total = Convert.ToInt32(txtTotal.Text);
                    txtTotal.Text = (total - thanhTien).ToString();
                    listView1.Items.Remove(listView1.SelectedItems[0]);
                }
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                DialogResult result = MessageBox.Show("Xác nhận thoát?",
                "Xác nhận",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                    Close();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
