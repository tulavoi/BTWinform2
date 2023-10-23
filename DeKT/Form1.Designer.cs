namespace DeKiemTra
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
            this.label1 = new System.Windows.Forms.Label();
            this.grbInfo = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radNam = new System.Windows.Forms.RadioButton();
            this.radNu = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpDOB = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.cboKhoa = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPhi = new System.Windows.Forms.TextBox();
            this.lvwInfo = new System.Windows.Forms.ListView();
            this.clnHoTen = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clnGioiTinh = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clnDOB = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clnKhoa = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clnPhi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnThem = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnCapNhat = new System.Windows.Forms.Button();
            this.btnMo = new System.Windows.Forms.Button();
            this.grbInfo.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(209, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(364, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "QUAN LY DOAN VIEN";
            // 
            // grbInfo
            // 
            this.grbInfo.Controls.Add(this.txtPhi);
            this.grbInfo.Controls.Add(this.label5);
            this.grbInfo.Controls.Add(this.cboKhoa);
            this.grbInfo.Controls.Add(this.label4);
            this.grbInfo.Controls.Add(this.dtpDOB);
            this.grbInfo.Controls.Add(this.label3);
            this.grbInfo.Controls.Add(this.groupBox1);
            this.grbInfo.Controls.Add(this.txtName);
            this.grbInfo.Controls.Add(this.label2);
            this.grbInfo.Location = new System.Drawing.Point(12, 80);
            this.grbInfo.Name = "grbInfo";
            this.grbInfo.Size = new System.Drawing.Size(352, 302);
            this.grbInfo.TabIndex = 1;
            this.grbInfo.TabStop = false;
            this.grbInfo.Text = "Thong tin doan vien";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Ho va ten:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(102, 25);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(236, 22);
            this.txtName.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radNu);
            this.groupBox1.Controls.Add(this.radNam);
            this.groupBox1.Location = new System.Drawing.Point(20, 78);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(318, 64);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Gioi tinh";
            // 
            // radNam
            // 
            this.radNam.AutoSize = true;
            this.radNam.Location = new System.Drawing.Point(55, 32);
            this.radNam.Name = "radNam";
            this.radNam.Size = new System.Drawing.Size(57, 20);
            this.radNam.TabIndex = 0;
            this.radNam.TabStop = true;
            this.radNam.Text = "Nam";
            this.radNam.UseVisualStyleBackColor = true;
            // 
            // radNu
            // 
            this.radNu.AutoSize = true;
            this.radNu.Location = new System.Drawing.Point(184, 32);
            this.radNu.Name = "radNu";
            this.radNu.Size = new System.Drawing.Size(45, 20);
            this.radNu.TabIndex = 1;
            this.radNu.TabStop = true;
            this.radNu.Text = "Nu";
            this.radNu.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 166);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Ngay sinh:";
            // 
            // dtpDOB
            // 
            this.dtpDOB.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDOB.Location = new System.Drawing.Point(128, 166);
            this.dtpDOB.Name = "dtpDOB";
            this.dtpDOB.Size = new System.Drawing.Size(193, 22);
            this.dtpDOB.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 208);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "Khoa dang hoc:";
            // 
            // cboKhoa
            // 
            this.cboKhoa.FormattingEnabled = true;
            this.cboKhoa.Items.AddRange(new object[] {
            "CNTT",
            "Ke Toan",
            "Ngon Ngu Anh"});
            this.cboKhoa.Location = new System.Drawing.Point(128, 205);
            this.cboKhoa.Name = "cboKhoa";
            this.cboKhoa.Size = new System.Drawing.Size(193, 24);
            this.cboKhoa.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 257);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 16);
            this.label5.TabIndex = 7;
            this.label5.Text = "Le phi dong:";
            // 
            // txtPhi
            // 
            this.txtPhi.Location = new System.Drawing.Point(128, 254);
            this.txtPhi.Name = "txtPhi";
            this.txtPhi.Size = new System.Drawing.Size(193, 22);
            this.txtPhi.TabIndex = 8;
            // 
            // lvwInfo
            // 
            this.lvwInfo.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clnHoTen,
            this.clnGioiTinh,
            this.clnDOB,
            this.clnKhoa,
            this.clnPhi});
            this.lvwInfo.FullRowSelect = true;
            this.lvwInfo.GridLines = true;
            this.lvwInfo.HideSelection = false;
            this.lvwInfo.Location = new System.Drawing.Point(382, 88);
            this.lvwInfo.Name = "lvwInfo";
            this.lvwInfo.Size = new System.Drawing.Size(503, 293);
            this.lvwInfo.TabIndex = 2;
            this.lvwInfo.UseCompatibleStateImageBehavior = false;
            this.lvwInfo.View = System.Windows.Forms.View.Details;
            this.lvwInfo.SelectedIndexChanged += new System.EventHandler(this.lvwInfo_SelectedIndexChanged);
            // 
            // clnHoTen
            // 
            this.clnHoTen.Text = "Ho ten";
            this.clnHoTen.Width = 83;
            // 
            // clnGioiTinh
            // 
            this.clnGioiTinh.Text = "Gioi Tinh";
            this.clnGioiTinh.Width = 84;
            // 
            // clnDOB
            // 
            this.clnDOB.Text = "Ngay sinh";
            this.clnDOB.Width = 80;
            // 
            // clnKhoa
            // 
            this.clnKhoa.Text = "Khoa";
            this.clnKhoa.Width = 52;
            // 
            // clnPhi
            // 
            this.clnPhi.Text = "Le phi";
            this.clnPhi.Width = 70;
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(12, 402);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(84, 36);
            this.btnThem.TabIndex = 3;
            this.btnThem.Text = "Them";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(114, 402);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(84, 36);
            this.btnXoa.TabIndex = 4;
            this.btnXoa.Text = "Xoa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(530, 402);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(84, 36);
            this.btnThoat.TabIndex = 5;
            this.btnThoat.Text = "Thoat";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(426, 402);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(84, 36);
            this.btnLuu.TabIndex = 6;
            this.btnLuu.Text = "Luu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.Location = new System.Drawing.Point(216, 402);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(84, 36);
            this.btnCapNhat.TabIndex = 7;
            this.btnCapNhat.Text = "Cap Nhat";
            this.btnCapNhat.UseVisualStyleBackColor = true;
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
            // 
            // btnMo
            // 
            this.btnMo.Location = new System.Drawing.Point(318, 402);
            this.btnMo.Name = "btnMo";
            this.btnMo.Size = new System.Drawing.Size(84, 36);
            this.btnMo.TabIndex = 8;
            this.btnMo.Text = "Mo ";
            this.btnMo.UseVisualStyleBackColor = true;
            this.btnMo.Click += new System.EventHandler(this.btnMo_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(926, 450);
            this.Controls.Add(this.btnMo);
            this.Controls.Add(this.btnCapNhat);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.lvwInfo);
            this.Controls.Add(this.grbInfo);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.grbInfo.ResumeLayout(false);
            this.grbInfo.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grbInfo;
        private System.Windows.Forms.DateTimePicker dtpDOB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radNu;
        private System.Windows.Forms.RadioButton radNam;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboKhoa;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPhi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListView lvwInfo;
        private System.Windows.Forms.ColumnHeader clnHoTen;
        private System.Windows.Forms.ColumnHeader clnGioiTinh;
        private System.Windows.Forms.ColumnHeader clnDOB;
        private System.Windows.Forms.ColumnHeader clnKhoa;
        private System.Windows.Forms.ColumnHeader clnPhi;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnCapNhat;
        private System.Windows.Forms.Button btnMo;
    }
}

