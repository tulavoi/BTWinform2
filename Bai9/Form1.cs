using System;
using System.Drawing;
using System.Windows.Forms;

namespace Bai9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            ExpandAllNode();
            txtName.Focus();
        }

        private void ExpandAllNode()
        {
            foreach (TreeNode node in tvShow.Nodes)
                node.ExpandAll();
        }

        private void tvShow_AfterSelect(object sender, TreeViewEventArgs e)
        {
            lvInfo.Items.Clear();
            ResetNodeColors(tvShow.Nodes);


            // Kiểm tra node đang chọn có 1 node cha không, nếu không có node cha thì có nghĩa đây là node root (node Khoa)
            // ShowAllStudentsInDepartment() được gọi để hiển thị tất cả sinh viên trong node đang chọn
            if (e.Node.Parent == null)
                ShowAllStudentsInDepartment(e.Node);


            // Kiểm tra node đang chọn có 1 node cha và có node con không, nếu có thì có nghĩa đây là node Lớp
            // ShowAllStudentsInClass() được gọi để hiển thị tất cả học sinh trong node đang chọn (node Lớp)
            else if (e.Node.Parent != null && e.Node.Nodes.Count > 0)
                ShowAllStudentsInClass(e.Node);


            // Nếu các điều kiện trên không thỏa mãn, có nghĩa là node này không là node root, không có node con (có nghĩa đây là node SinhVien)
            // AddAndShowToListView() được gọi để hiển thị thông tin sinh viên của node đang chọn
            else
                AddAndShowToListView(e.Node.Text, e.Node.Parent.Text);
        }

        private void ResetNodeColors(TreeNodeCollection nodes)
        {
            foreach (TreeNode node in nodes)
            {
                node.BackColor = SystemColors.Window;
                node.ForeColor = SystemColors.WindowText;
                ResetNodeColors(node.Nodes);
            }
        }

        private void ShowAllStudentsInClass(TreeNode classNode)
        {
            foreach (TreeNode svNode in classNode.Nodes)
                AddAndShowToListView(svNode.Text, classNode.Text);
        }

        private void AddAndShowToListView(string sv, string lop)
        {
            ListViewItem lv = new ListViewItem(new[] { sv, lop });
            lvInfo.Items.Add(lv);
        }

        private void ShowAllStudentsInDepartment(TreeNode nodeParent)
        {
            foreach (TreeNode classNode in nodeParent.Nodes)
            {
                foreach (TreeNode svNode in classNode.Nodes)
                    AddAndShowToListView(svNode.Text, classNode.Text);
            }
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            ResetNodeColors(tvShow.Nodes);
            string svCanTim = txtName.Text.Trim();
            if (svCanTim.Length == 0)
                MessageBox.Show("Chưa nhập tên sao tìm ???");
            else
            {
                lvInfo.Items.Clear();
                TreeNode selectingNode = tvShow.SelectedNode;
                if (selectingNode != null)
                {
                    if (selectingNode.Parent == null)
                        SearchStudentsInDepartment(selectingNode, svCanTim);
                    else
                        SearchStudentsInClass(selectingNode, svCanTim);
                }
            }
        }

        private void ShowStudent(TreeNode svNode, TreeNode classNode)
        {
            svNode.BackColor = SystemColors.Highlight;
            svNode.ForeColor = SystemColors.HighlightText;
            AddAndShowToListView(svNode.Text, classNode.Text);
        }

        private void SearchStudentsInClass(TreeNode classNode, string svCanTim)
        {
            bool isFound = false;
            foreach (TreeNode svNode in classNode.Nodes)
            {
                if (svCanTim == svNode.Text)
                {
                    ShowStudent(svNode, classNode);
                    isFound = true;
                }
            }
            if (!isFound)
                MessageBox.Show("Không tìm thấy!");
        }

        private void SearchStudentsInDepartment(TreeNode departmentNode, string svCanTim)
        {
            bool isFound = false;
            foreach (TreeNode classNode in departmentNode.Nodes)
            {
                foreach (TreeNode svNode in classNode.Nodes)
                {
                    if (svCanTim == svNode.Text)
                    {
                        ShowStudent(svNode, classNode);
                        isFound = true;
                    }
                }
            }
            if (!isFound)
                MessageBox.Show("Không tìm thấy!");
        }

        private void txtName_Click(object sender, EventArgs e)
        {
            TreeNode seletedNode = tvShow.SelectedNode;
            seletedNode.BackColor = SystemColors.Highlight;
            seletedNode.ForeColor = SystemColors.HighlightText;
        }
    }
}
