using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai5
{
    public partial class frmBai5 : Form
    {
        public frmBai5()
        {
            InitializeComponent();
            //LoadListView();
        }
        ImageList imgListSmall;
        ImageList imgListLarge;

        // Code ví dụ
        private void LoadImageList()
        {
            imgListLarge = new ImageList() { ImageSize = new Size(60, 60)};
            imgListLarge.Images.Add(new Bitmap("E:\\person.jpg"));
            imgListLarge.Images.Add(new Bitmap("E:\\person.jpg"));
            imgListLarge.Images.Add(new Bitmap("E:\\person.jpg"));

            imgListSmall = new ImageList() { ImageSize = new Size(20, 20) };
            imgListSmall.Images.Add(new Bitmap("E:\\person.jpg"));
            imgListSmall.Images.Add(new Bitmap("E:\\person.jpg"));
            imgListSmall.Images.Add(new Bitmap("E:\\person.jpg"));
        }

        // Code ví dụ
        private void LoadListView()
        {
            LoadImageList();

            lvThongTin.LargeImageList = imgListLarge;
            lvThongTin.SmallImageList = imgListSmall;

            lvThongTin.Columns.Add("Last Name");
            lvThongTin.Columns.Add("First Name");
            lvThongTin.Columns.Add("Phone");

            ListViewItem lvItem1 = new ListViewItem("item1");
            lvItem1.ImageIndex = 0;
            lvItem1.SubItems.Add("item1");
            lvItem1.SubItems.Add("item1");

            ListViewItem lvItem2 = new ListViewItem("item2");
            lvItem2.ImageIndex = 1;
            lvItem2.SubItems.Add("item2");
            lvItem2.SubItems.Add("item2");

            ListViewItem lvItem3 = new ListViewItem("item3");
            lvItem3.ImageIndex = 2;
            lvItem3.SubItems.Add("item3");
            lvItem3.SubItems.Add("item3");

            lvThongTin.Items.Add(lvItem1);
            lvThongTin.Items.Add(lvItem2);
            lvThongTin.Items.Add(lvItem3);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            ListViewItem lv = new ListViewItem(txtLastName.Text);
            lv.ImageIndex = 0;
            lv.SubItems.Add(txtFirstName.Text);
            lv.SubItems.Add(txtPhone.Text);
            lvThongTin.Items.Add(lv);
        }

        private void btnLargeIcon_Click(object sender, EventArgs e)
        {
            lvThongTin.View = View.LargeIcon;
        }

        private void btnDetails_Click(object sender, EventArgs e)
        {
            lvThongTin.View = View.Details;
        }

        private void btnSmallIcon_Click(object sender, EventArgs e)
        {
            lvThongTin.View = View.SmallIcon;
        }

        private void lvThongTin_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListView lv = sender as ListView;
            if (lv.SelectedItems.Count > 0)
            {
                foreach (ListViewItem item in lv.SelectedItems)
                {
                    MessageBox.Show(item.Text);
                }
            }
        }
    }
}
