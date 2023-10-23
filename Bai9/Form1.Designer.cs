namespace Bai9
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Nguyen Van A");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Nguyen Van B");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Nguyen Van C");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("TT01", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3});
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Nguyen Van D");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Nguyen Van E");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Nguyen Van F");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("TT02", new System.Windows.Forms.TreeNode[] {
            treeNode5,
            treeNode6,
            treeNode7});
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("Nguyen Van G");
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("Nguyen Van H");
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("Nguyen Van J");
            System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("TT03", new System.Windows.Forms.TreeNode[] {
            treeNode9,
            treeNode10,
            treeNode11});
            System.Windows.Forms.TreeNode treeNode13 = new System.Windows.Forms.TreeNode("Khoa Tin Hoc", new System.Windows.Forms.TreeNode[] {
            treeNode4,
            treeNode8,
            treeNode12});
            System.Windows.Forms.TreeNode treeNode14 = new System.Windows.Forms.TreeNode("Tran Van A");
            System.Windows.Forms.TreeNode treeNode15 = new System.Windows.Forms.TreeNode("Tran Van B");
            System.Windows.Forms.TreeNode treeNode16 = new System.Windows.Forms.TreeNode("Tran Van C");
            System.Windows.Forms.TreeNode treeNode17 = new System.Windows.Forms.TreeNode("DH01", new System.Windows.Forms.TreeNode[] {
            treeNode14,
            treeNode15,
            treeNode16});
            System.Windows.Forms.TreeNode treeNode18 = new System.Windows.Forms.TreeNode("Tran Van D");
            System.Windows.Forms.TreeNode treeNode19 = new System.Windows.Forms.TreeNode("Tran Van E");
            System.Windows.Forms.TreeNode treeNode20 = new System.Windows.Forms.TreeNode("Tran Van F");
            System.Windows.Forms.TreeNode treeNode21 = new System.Windows.Forms.TreeNode("DH02", new System.Windows.Forms.TreeNode[] {
            treeNode18,
            treeNode19,
            treeNode20});
            System.Windows.Forms.TreeNode treeNode22 = new System.Windows.Forms.TreeNode("Tran Van G");
            System.Windows.Forms.TreeNode treeNode23 = new System.Windows.Forms.TreeNode("Tran Van H");
            System.Windows.Forms.TreeNode treeNode24 = new System.Windows.Forms.TreeNode("Tran Van J");
            System.Windows.Forms.TreeNode treeNode25 = new System.Windows.Forms.TreeNode("DH03", new System.Windows.Forms.TreeNode[] {
            treeNode22,
            treeNode23,
            treeNode24});
            System.Windows.Forms.TreeNode treeNode26 = new System.Windows.Forms.TreeNode("Khoa Do Hoa", new System.Windows.Forms.TreeNode[] {
            treeNode17,
            treeNode21,
            treeNode25});
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tvShow = new System.Windows.Forms.TreeView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.btnTim = new System.Windows.Forms.Button();
            this.lvInfo = new System.Windows.Forms.ListView();
            this.clnTen = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clnLop = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.img = new System.Windows.Forms.ImageList(this.components);
            this.SuspendLayout();
            // 
            // tvShow
            // 
            this.tvShow.Location = new System.Drawing.Point(0, 51);
            this.tvShow.Name = "tvShow";
            treeNode1.Name = "Node6";
            treeNode1.Text = "Nguyen Van A";
            treeNode2.Name = "Node7";
            treeNode2.Text = "Nguyen Van B";
            treeNode3.Name = "Node8";
            treeNode3.Text = "Nguyen Van C";
            treeNode4.Name = "Node3";
            treeNode4.Text = "TT01";
            treeNode5.Name = "Node9";
            treeNode5.Text = "Nguyen Van D";
            treeNode6.Name = "Node10";
            treeNode6.Text = "Nguyen Van E";
            treeNode7.Name = "Node11";
            treeNode7.Text = "Nguyen Van F";
            treeNode8.Name = "Node4";
            treeNode8.Text = "TT02";
            treeNode9.Name = "Node12";
            treeNode9.Text = "Nguyen Van G";
            treeNode10.Name = "Node13";
            treeNode10.Text = "Nguyen Van H";
            treeNode11.Name = "Node14";
            treeNode11.Text = "Nguyen Van J";
            treeNode12.Name = "Node5";
            treeNode12.Text = "TT03";
            treeNode13.Name = "Node0";
            treeNode13.Text = "Khoa Tin Hoc";
            treeNode14.Name = "Node25";
            treeNode14.Text = "Tran Van A";
            treeNode15.Name = "Node26";
            treeNode15.Text = "Tran Van B";
            treeNode16.Name = "Node27";
            treeNode16.Text = "Tran Van C";
            treeNode17.Name = "Node22";
            treeNode17.Text = "DH01";
            treeNode18.Name = "Node28";
            treeNode18.Text = "Tran Van D";
            treeNode19.Name = "Node29";
            treeNode19.Text = "Tran Van E";
            treeNode20.Name = "Node30";
            treeNode20.Text = "Tran Van F";
            treeNode21.Name = "Node23";
            treeNode21.Text = "DH02";
            treeNode22.Name = "Node31";
            treeNode22.Text = "Tran Van G";
            treeNode23.Name = "Node32";
            treeNode23.Text = "Tran Van H";
            treeNode24.Name = "Node33";
            treeNode24.Text = "Tran Van J";
            treeNode25.Name = "Node24";
            treeNode25.Text = "DH03";
            treeNode26.Name = "Node21";
            treeNode26.Text = "Khoa Do Hoa";
            this.tvShow.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode13,
            treeNode26});
            this.tvShow.Size = new System.Drawing.Size(395, 404);
            this.tvShow.TabIndex = 0;
            this.tvShow.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tvShow_AfterSelect);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(403, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nhập tên: ";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(496, 18);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(193, 22);
            this.txtName.TabIndex = 2;
            this.txtName.Click += new System.EventHandler(this.txtName_Click);
            // 
            // btnTim
            // 
            this.btnTim.Location = new System.Drawing.Point(707, 11);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(81, 37);
            this.btnTim.TabIndex = 3;
            this.btnTim.Text = "Tìm";
            this.btnTim.UseVisualStyleBackColor = true;
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // lvInfo
            // 
            this.lvInfo.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clnTen,
            this.clnLop});
            this.lvInfo.FullRowSelect = true;
            this.lvInfo.GridLines = true;
            this.lvInfo.HideSelection = false;
            this.lvInfo.LargeImageList = this.img;
            this.lvInfo.Location = new System.Drawing.Point(407, 51);
            this.lvInfo.Name = "lvInfo";
            this.lvInfo.Size = new System.Drawing.Size(400, 407);
            this.lvInfo.TabIndex = 4;
            this.lvInfo.UseCompatibleStateImageBehavior = false;
            this.lvInfo.View = System.Windows.Forms.View.Details;
            // 
            // clnTen
            // 
            this.clnTen.Text = "Tên SV";
            this.clnTen.Width = 108;
            // 
            // clnLop
            // 
            this.clnLop.Text = "Lớp";
            this.clnLop.Width = 121;
            // 
            // img
            // 
            this.img.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("img.ImageStream")));
            this.img.TransparentColor = System.Drawing.Color.Transparent;
            this.img.Images.SetKeyName(0, "th.png");
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lvInfo);
            this.Controls.Add(this.btnTim);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tvShow);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView tvShow;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.ListView lvInfo;
        private System.Windows.Forms.ColumnHeader clnTen;
        private System.Windows.Forms.ColumnHeader clnLop;
        private System.Windows.Forms.ImageList img;
    }
}

