using System;
using System.Windows.Forms;

namespace Bai10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            foreach (TreeNode node in tvShow.Nodes)
            {
                node.ExpandAll();
            }
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            TreeNode selectedNode = tvShow.SelectedNode;
            if (selectedNode != null)
            {
                if (selectedNode.Tag != null && selectedNode.Tag.ToString() == "Class")
                {
                    if (txtMa.Text == "" || txtHoTen.Text == "" || txtDiaChi.Text == "")
                        MessageBox.Show("Chưa nhập đủ thông tin!");
                    else
                    {
                        string maSV = txtMa.Text;
                        string name = txtHoTen.Text;
                        string diaChi = txtDiaChi.Text;
                        if (!CheckIfMaSVIsExisted(selectedNode, maSV))
                        {
                            TreeNode svNode = new TreeNode($"{maSV} - {name}");
                            selectedNode.Nodes.Add(svNode);
                            svNode.Tag = "Student";
                            TreeNode diaChiNode = new TreeNode(diaChi);
                            svNode.Nodes.Add(diaChiNode);
                            diaChiNode.Tag = "Address";
                            txtMa.Text = "";
                            txtHoTen.Text = "";
                            txtDiaChi.Text = "";
                        }
                        else
                            MessageBox.Show("Mã sinh viên đã có trong lớp này!");
                    }
                }
                else
                    MessageBox.Show("Chưa chọn lớp!");
            }

        }

        private bool CheckIfMaSVIsExisted(TreeNode classNode, string maSV)
        {
            foreach (TreeNode svNode in classNode.Nodes)
            {
                string[] info = svNode.Text.Split('-');
                if (info[0].Trim() == maSV)
                    return true;
            }
            return false;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            TreeNode selectedNode = tvShow.SelectedNode;
            if (selectedNode != null)
            {
                if (IsStudentNode(selectedNode))
                {
                    DialogResult result = MessageBox.Show(
                        "Xác nhận xóa?",
                        "Confirm",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Warning);
                    if (result == DialogResult.Yes)
                        selectedNode.Remove();
                    else
                        return;
                }
            }
            else
                MessageBox.Show("Chưa chọn sinh viên để xóa");
        }

        private bool IsStudentNode(TreeNode selectedNode)
        {
            if (selectedNode.Tag.ToString() == "Student")
                return true;
            return false;
        }

        private void tvShow_AfterSelect(object sender, TreeViewEventArgs e)
        {
            TreeNode selectedNode = tvShow.SelectedNode;
            if (selectedNode != null)
            {
                if (selectedNode.Tag != null)
                {
                    if (selectedNode.Tag.ToString() == "Student")
                    {
                        foreach (TreeNode addressNode in selectedNode.Nodes)
                            PrintInfoToTexbox(selectedNode, addressNode);

                    }
                    else if (selectedNode.Tag.ToString() == "Address")
                    {
                        TreeNode studentNode = selectedNode.Parent;
                        PrintInfoToTexbox(studentNode, selectedNode);
                    }
                }
            }
        }

        private void PrintInfoToTexbox(TreeNode studentNode, TreeNode addressNode)
        {
            string[] info = studentNode.Text.Split('-');
            txtMa.Text = info[0].Trim().ToString();
            txtHoTen.Text = info[1].Trim().ToString();
            txtDiaChi.Text = addressNode.Text.ToString();
        }
    }
}
