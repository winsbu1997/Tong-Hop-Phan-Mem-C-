namespace QuanLyKhachSan
{
    partial class frmThuePhong
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtGioiTinh = new System.Windows.Forms.TextBox();
            this.dtpNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.txtSoDienThoai = new System.Windows.Forms.TextBox();
            this.txtSochunminh = new System.Windows.Forms.TextBox();
            this.txtTenKhachHang = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lvPhong = new System.Windows.Forms.ListView();
            this.maphong = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tenphong = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.giaphong = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.songuoi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tenloaiphong = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtTimKiemKhach = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnThemKhachHang = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cmbTimKiemKhach = new System.Windows.Forms.ComboBox();
            this.dgvKhach = new System.Windows.Forms.DataGridView();
            this.makhachhang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenkhachhang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sochungminh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sodienthoai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gioitinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngaysinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diadiem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnThuePhong = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhach)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtGioiTinh);
            this.groupBox1.Controls.Add(this.dtpNgaySinh);
            this.groupBox1.Controls.Add(this.txtSoDienThoai);
            this.groupBox1.Controls.Add(this.txtSochunminh);
            this.groupBox1.Controls.Add(this.txtTenKhachHang);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(557, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(275, 216);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin khách hàng";
            // 
            // txtGioiTinh
            // 
            this.txtGioiTinh.Location = new System.Drawing.Point(112, 165);
            this.txtGioiTinh.Name = "txtGioiTinh";
            this.txtGioiTinh.ReadOnly = true;
            this.txtGioiTinh.Size = new System.Drawing.Size(153, 20);
            this.txtGioiTinh.TabIndex = 11;
            // 
            // dtpNgaySinh
            // 
            this.dtpNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgaySinh.Location = new System.Drawing.Point(112, 129);
            this.dtpNgaySinh.Name = "dtpNgaySinh";
            this.dtpNgaySinh.Size = new System.Drawing.Size(153, 20);
            this.dtpNgaySinh.TabIndex = 10;
            // 
            // txtSoDienThoai
            // 
            this.txtSoDienThoai.Location = new System.Drawing.Point(112, 90);
            this.txtSoDienThoai.Name = "txtSoDienThoai";
            this.txtSoDienThoai.ReadOnly = true;
            this.txtSoDienThoai.Size = new System.Drawing.Size(153, 20);
            this.txtSoDienThoai.TabIndex = 9;
            // 
            // txtSochunminh
            // 
            this.txtSochunminh.Location = new System.Drawing.Point(112, 64);
            this.txtSochunminh.Name = "txtSochunminh";
            this.txtSochunminh.ReadOnly = true;
            this.txtSochunminh.Size = new System.Drawing.Size(153, 20);
            this.txtSochunminh.TabIndex = 8;
            // 
            // txtTenKhachHang
            // 
            this.txtTenKhachHang.Location = new System.Drawing.Point(112, 29);
            this.txtTenKhachHang.Name = "txtTenKhachHang";
            this.txtTenKhachHang.ReadOnly = true;
            this.txtTenKhachHang.Size = new System.Drawing.Size(153, 20);
            this.txtTenKhachHang.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(24, 62);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Số chứng minh ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 165);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Giới tính";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Ngày sinh";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Số điện thoại";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tên khách hàng";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lvPhong);
            this.groupBox2.Location = new System.Drawing.Point(12, 252);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(650, 279);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin thuê phòng";
            // 
            // lvPhong
            // 
            this.lvPhong.CheckBoxes = true;
            this.lvPhong.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.maphong,
            this.tenphong,
            this.giaphong,
            this.songuoi,
            this.tenloaiphong});
            this.lvPhong.FullRowSelect = true;
            this.lvPhong.GridLines = true;
            this.lvPhong.HideSelection = false;
            this.lvPhong.Location = new System.Drawing.Point(9, 19);
            this.lvPhong.Name = "lvPhong";
            this.lvPhong.Size = new System.Drawing.Size(630, 254);
            this.lvPhong.TabIndex = 2;
            this.lvPhong.UseCompatibleStateImageBehavior = false;
            this.lvPhong.View = System.Windows.Forms.View.Details;
            // 
            // maphong
            // 
            this.maphong.Text = "Mã Phòng";
            this.maphong.Width = 88;
            // 
            // tenphong
            // 
            this.tenphong.Text = "Tên Phòng";
            this.tenphong.Width = 103;
            // 
            // giaphong
            // 
            this.giaphong.Text = "Giá Phòng";
            this.giaphong.Width = 100;
            // 
            // songuoi
            // 
            this.songuoi.Text = "Số người";
            this.songuoi.Width = 120;
            // 
            // tenloaiphong
            // 
            this.tenloaiphong.Text = "Loại Phòng";
            this.tenloaiphong.Width = 197;
            // 
            // txtTimKiemKhach
            // 
            this.txtTimKiemKhach.Location = new System.Drawing.Point(217, 19);
            this.txtTimKiemKhach.Name = "txtTimKiemKhach";
            this.txtTimKiemKhach.Size = new System.Drawing.Size(235, 20);
            this.txtTimKiemKhach.TabIndex = 0;
            this.txtTimKiemKhach.TextChanged += new System.EventHandler(this.txtTimKiemKhach_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tìm kiếm";
            // 
            // btnThemKhachHang
            // 
            this.btnThemKhachHang.Location = new System.Drawing.Point(458, 19);
            this.btnThemKhachHang.Name = "btnThemKhachHang";
            this.btnThemKhachHang.Size = new System.Drawing.Size(75, 23);
            this.btnThemKhachHang.TabIndex = 7;
            this.btnThemKhachHang.Text = "Thêm khách hàng";
            this.btnThemKhachHang.UseVisualStyleBackColor = true;
            this.btnThemKhachHang.Click += new System.EventHandler(this.btnThemKhachHang_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cmbTimKiemKhach);
            this.groupBox3.Controls.Add(this.btnThemKhachHang);
            this.groupBox3.Controls.Add(this.dgvKhach);
            this.groupBox3.Controls.Add(this.txtTimKiemKhach);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Location = new System.Drawing.Point(12, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(539, 216);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Tìm kiếm";
            // 
            // cmbTimKiemKhach
            // 
            this.cmbTimKiemKhach.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTimKiemKhach.FormattingEnabled = true;
            this.cmbTimKiemKhach.Items.AddRange(new object[] {
            "Tên khách hàng",
            "Mã khách hàng",
            "Số chứng minh",
            "Số điện thoại"});
            this.cmbTimKiemKhach.Location = new System.Drawing.Point(70, 19);
            this.cmbTimKiemKhach.Name = "cmbTimKiemKhach";
            this.cmbTimKiemKhach.Size = new System.Drawing.Size(127, 21);
            this.cmbTimKiemKhach.TabIndex = 8;
            // 
            // dgvKhach
            // 
            this.dgvKhach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKhach.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.makhachhang,
            this.tenkhachhang,
            this.sochungminh,
            this.sodienthoai,
            this.gioitinh,
            this.ngaysinh,
            this.diadiem});
            this.dgvKhach.Location = new System.Drawing.Point(6, 50);
            this.dgvKhach.MultiSelect = false;
            this.dgvKhach.Name = "dgvKhach";
            this.dgvKhach.ReadOnly = true;
            this.dgvKhach.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvKhach.Size = new System.Drawing.Size(527, 150);
            this.dgvKhach.TabIndex = 2;
            this.dgvKhach.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvKhach_CellClick);
            // 
            // makhachhang
            // 
            this.makhachhang.DataPropertyName = "Makhachhang";
            this.makhachhang.HeaderText = "Mã khách hàng";
            this.makhachhang.Name = "makhachhang";
            this.makhachhang.ReadOnly = true;
            // 
            // tenkhachhang
            // 
            this.tenkhachhang.DataPropertyName = "Tenkhachhang";
            this.tenkhachhang.HeaderText = "Tên khách hàng";
            this.tenkhachhang.Name = "tenkhachhang";
            this.tenkhachhang.ReadOnly = true;
            // 
            // sochungminh
            // 
            this.sochungminh.DataPropertyName = "Sochungminh";
            this.sochungminh.HeaderText = "Số chứng minh";
            this.sochungminh.Name = "sochungminh";
            this.sochungminh.ReadOnly = true;
            // 
            // sodienthoai
            // 
            this.sodienthoai.DataPropertyName = "Sodienthoai";
            this.sodienthoai.HeaderText = "Số điện thoại";
            this.sodienthoai.Name = "sodienthoai";
            this.sodienthoai.ReadOnly = true;
            // 
            // gioitinh
            // 
            this.gioitinh.DataPropertyName = "Gioitinh";
            this.gioitinh.HeaderText = "Giới tính";
            this.gioitinh.Name = "gioitinh";
            this.gioitinh.ReadOnly = true;
            // 
            // ngaysinh
            // 
            this.ngaysinh.DataPropertyName = "Ngaysinh";
            this.ngaysinh.HeaderText = "Ngày sinh";
            this.ngaysinh.Name = "ngaysinh";
            this.ngaysinh.ReadOnly = true;
            this.ngaysinh.Visible = false;
            // 
            // diadiem
            // 
            this.diadiem.DataPropertyName = "Diadiem";
            this.diadiem.HeaderText = "Nơi ở";
            this.diadiem.Name = "diadiem";
            this.diadiem.ReadOnly = true;
            this.diadiem.Visible = false;
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnThoat.Location = new System.Drawing.Point(702, 315);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(110, 50);
            this.btnThoat.TabIndex = 3;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnThuePhong
            // 
            this.btnThuePhong.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnThuePhong.Location = new System.Drawing.Point(702, 257);
            this.btnThuePhong.Name = "btnThuePhong";
            this.btnThuePhong.Size = new System.Drawing.Size(110, 44);
            this.btnThuePhong.TabIndex = 4;
            this.btnThuePhong.Text = "Thuê Phòng";
            this.btnThuePhong.UseVisualStyleBackColor = false;
            this.btnThuePhong.Click += new System.EventHandler(this.btnThuePhong_Click);
            // 
            // frmThuePhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 543);
            this.Controls.Add(this.btnThuePhong);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmThuePhong";
            this.Text = "Thuê phòng";
            this.Load += new System.EventHandler(this.frmThuePhong_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhach)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnThemKhachHang;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtTimKiemKhach;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dgvKhach;
        private System.Windows.Forms.ListView lvPhong;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnThuePhong;
        private System.Windows.Forms.ComboBox cmbTimKiemKhach;
        private System.Windows.Forms.DataGridViewTextBoxColumn makhachhang;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenkhachhang;
        private System.Windows.Forms.DataGridViewTextBoxColumn sochungminh;
        private System.Windows.Forms.DataGridViewTextBoxColumn sodienthoai;
        private System.Windows.Forms.DataGridViewTextBoxColumn gioitinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngaysinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn diadiem;
        private System.Windows.Forms.TextBox txtGioiTinh;
        private System.Windows.Forms.DateTimePicker dtpNgaySinh;
        private System.Windows.Forms.TextBox txtSoDienThoai;
        private System.Windows.Forms.TextBox txtSochunminh;
        private System.Windows.Forms.TextBox txtTenKhachHang;
        private System.Windows.Forms.ColumnHeader maphong;
        private System.Windows.Forms.ColumnHeader tenphong;
        private System.Windows.Forms.ColumnHeader giaphong;
        private System.Windows.Forms.ColumnHeader songuoi;
        private System.Windows.Forms.ColumnHeader tenloaiphong;
    }
}