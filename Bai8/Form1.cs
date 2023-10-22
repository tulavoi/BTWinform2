using System;
using System.Drawing;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Bai8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Are you sure to exit?",
                "Confirm",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
                Close();
            
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtFN.Text) && !string.IsNullOrEmpty(txtLN.Text))
            {
                TreeNode selectedNode = tvShow.SelectedNode;
                if (selectedNode != null)
                {
                    TreeNode childNode = new TreeNode(txtFN.Text.Trim() + ", " + txtLN.Text.Trim());
                    selectedNode.Nodes.Add(childNode);
                    txtFN.Text = "";
                    txtLN.Text = "";
                    txtFN.Focus();
                }
                else
                    MessageBox.Show("Bạn chưa chọn file để thêm");
            }
            else
                MessageBox.Show("Chưa nhập đủ thông tin");
            foreach (TreeNode node in tvShow.Nodes)
            {
                node.BackColor = SystemColors.Window;
                node.ForeColor = SystemColors.WindowText;
            }
            tvShow.SelectedNode = null;
        }

        private void txtFN_TextChanged(object sender, EventArgs e)
        {
            string name = txtFN.Text.Trim();
            if (!string.IsNullOrEmpty(name) && char.IsLetter(name[0]))
            {
                char firstChar = char.ToUpper(name[0]);
                foreach (TreeNode node in tvShow.Nodes) 
                {
                    char nodeFitstChar = Convert.ToChar(node.Text);
                    if (nodeFitstChar == firstChar)
                    {
                        node.BackColor = SystemColors.Highlight;
                        node.ForeColor = SystemColors.HighlightText;
                        tvShow.SelectedNode = node;
                    }
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (char letter = 'A'; letter <= 'Z'; letter++)
            {
                tvShow.Nodes.Add(letter.ToString());
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            tvShow.SelectedNode.Remove();
        }
    }
}
