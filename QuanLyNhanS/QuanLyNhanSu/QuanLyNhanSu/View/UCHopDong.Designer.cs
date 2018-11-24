namespace QuanLyNhanSu.View
{
    partial class UCHopDong
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.lblTimKiem = new System.Windows.Forms.Label();
            this.dgvSach = new System.Windows.Forms.DataGridView();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaHD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenHD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LoaiHD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayBatDau = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayKetThuc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BacLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtLoaiHD = new System.Windows.Forms.TextBox();
            this.llbLoaiHD = new System.Windows.Forms.Label();
            this.txtTenHD = new System.Windows.Forms.TextBox();
            this.lblTenHD = new System.Windows.Forms.Label();
            this.txtMaHD = new System.Windows.Forms.TextBox();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblMaHD = new System.Windows.Forms.Label();
            this.btnThoat = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbBacLuong = new System.Windows.Forms.ComboBox();
            this.dtpNgayKT = new System.Windows.Forms.DateTimePicker();
            this.dtpNgayBD = new System.Windows.Forms.DateTimePicker();
            this.lblBacLuong = new System.Windows.Forms.Label();
            this.lblNgayKT = new System.Windows.Forms.Label();
            this.lblNgayBD = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSach)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(354, 193);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(305, 24);
            this.txtTimKiem.TabIndex = 10;
            this.txtTimKiem.TextChanged += new System.EventHandler(this.txtTimKiem_TextChanged);
            // 
            // lblTimKiem
            // 
            this.lblTimKiem.AutoSize = true;
            this.lblTimKiem.Location = new System.Drawing.Point(263, 193);
            this.lblTimKiem.Name = "lblTimKiem";
            this.lblTimKiem.Size = new System.Drawing.Size(71, 18);
            this.lblTimKiem.TabIndex = 16;
            this.lblTimKiem.Text = "Tìm Kiếm";
            // 
            // dgvSach
            // 
            this.dgvSach.AllowUserToAddRows = false;
            this.dgvSach.AllowUserToDeleteRows = false;
            this.dgvSach.BackgroundColor = System.Drawing.Color.Honeydew;
            this.dgvSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSach.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT,
            this.MaHD,
            this.TenHD,
            this.LoaiHD,
            this.NgayBatDau,
            this.NgayKetThuc,
            this.BacLuong});
            this.dgvSach.Location = new System.Drawing.Point(34, 286);
            this.dgvSach.Name = "dgvSach";
            this.dgvSach.ReadOnly = true;
            this.dgvSach.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSach.Size = new System.Drawing.Size(943, 262);
            this.dgvSach.TabIndex = 18;
            this.dgvSach.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSach_CellClick);
            this.dgvSach.RowPrePaint += new System.Windows.Forms.DataGridViewRowPrePaintEventHandler(this.dgvSach_RowPrePaint);
            // 
            // STT
            // 
            this.STT.HeaderText = "STT";
            this.STT.Name = "STT";
            this.STT.ReadOnly = true;
            this.STT.Width = 50;
            // 
            // MaHD
            // 
            this.MaHD.DataPropertyName = "MaHD";
            this.MaHD.HeaderText = "Mã Hợp Đồng";
            this.MaHD.Name = "MaHD";
            this.MaHD.ReadOnly = true;
            this.MaHD.Width = 150;
            // 
            // TenHD
            // 
            this.TenHD.DataPropertyName = "TenHD";
            this.TenHD.HeaderText = "Tên Hợp Đồng";
            this.TenHD.Name = "TenHD";
            this.TenHD.ReadOnly = true;
            this.TenHD.Width = 150;
            // 
            // LoaiHD
            // 
            this.LoaiHD.DataPropertyName = "LoaiHD";
            this.LoaiHD.HeaderText = "Loại Hợp Đồng";
            this.LoaiHD.Name = "LoaiHD";
            this.LoaiHD.ReadOnly = true;
            this.LoaiHD.Width = 150;
            // 
            // NgayBatDau
            // 
            this.NgayBatDau.DataPropertyName = "NgayBatDau";
            this.NgayBatDau.HeaderText = "Ngày Bắt Đầu";
            this.NgayBatDau.Name = "NgayBatDau";
            this.NgayBatDau.ReadOnly = true;
            this.NgayBatDau.Width = 130;
            // 
            // NgayKetThuc
            // 
            this.NgayKetThuc.DataPropertyName = "NgayKetThuc";
            this.NgayKetThuc.HeaderText = "Ngày Kết Thúc";
            this.NgayKetThuc.Name = "NgayKetThuc";
            this.NgayKetThuc.ReadOnly = true;
            this.NgayKetThuc.Width = 130;
            // 
            // BacLuong
            // 
            this.BacLuong.DataPropertyName = "BacLuong";
            this.BacLuong.HeaderText = "Bậc Lương";
            this.BacLuong.Name = "BacLuong";
            this.BacLuong.ReadOnly = true;
            this.BacLuong.Width = 150;
            // 
            // txtLoaiHD
            // 
            this.txtLoaiHD.Location = new System.Drawing.Point(145, 129);
            this.txtLoaiHD.Name = "txtLoaiHD";
            this.txtLoaiHD.Size = new System.Drawing.Size(202, 24);
            this.txtLoaiHD.TabIndex = 3;
            // 
            // llbLoaiHD
            // 
            this.llbLoaiHD.AutoSize = true;
            this.llbLoaiHD.Location = new System.Drawing.Point(16, 132);
            this.llbLoaiHD.Name = "llbLoaiHD";
            this.llbLoaiHD.Size = new System.Drawing.Size(108, 18);
            this.llbLoaiHD.TabIndex = 4;
            this.llbLoaiHD.Text = "Loại Hợp Đồng";
            // 
            // txtTenHD
            // 
            this.txtTenHD.Location = new System.Drawing.Point(145, 75);
            this.txtTenHD.Name = "txtTenHD";
            this.txtTenHD.Size = new System.Drawing.Size(202, 24);
            this.txtTenHD.TabIndex = 2;
            // 
            // lblTenHD
            // 
            this.lblTenHD.AutoSize = true;
            this.lblTenHD.Location = new System.Drawing.Point(16, 81);
            this.lblTenHD.Name = "lblTenHD";
            this.lblTenHD.Size = new System.Drawing.Size(105, 18);
            this.lblTenHD.TabIndex = 2;
            this.lblTenHD.Text = "Tên Hợp Đồng";
            // 
            // txtMaHD
            // 
            this.txtMaHD.Location = new System.Drawing.Point(145, 27);
            this.txtMaHD.Name = "txtMaHD";
            this.txtMaHD.Size = new System.Drawing.Size(99, 24);
            this.txtMaHD.TabIndex = 1;
            // 
            // btnHuy
            // 
            this.btnHuy.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnHuy.Location = new System.Drawing.Point(1002, 419);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(86, 43);
            this.btnHuy.TabIndex = 16;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = false;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnLuu.Location = new System.Drawing.Point(1002, 315);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(86, 43);
            this.btnLuu.TabIndex = 15;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = false;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnXoa.Location = new System.Drawing.Point(1002, 216);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(86, 43);
            this.btnXoa.TabIndex = 14;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnSua.Location = new System.Drawing.Point(1002, 115);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(86, 43);
            this.btnSua.TabIndex = 13;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnThem.Location = new System.Drawing.Point(1002, 23);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(86, 43);
            this.btnThem.TabIndex = 12;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // groupBox2
            // 
            this.groupBox2.Location = new System.Drawing.Point(321, 454);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(8, 8);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // lblMaHD
            // 
            this.lblMaHD.AutoSize = true;
            this.lblMaHD.Location = new System.Drawing.Point(16, 30);
            this.lblMaHD.Name = "lblMaHD";
            this.lblMaHD.Size = new System.Drawing.Size(101, 18);
            this.lblMaHD.TabIndex = 0;
            this.lblMaHD.Text = "Mã Hợp Đồng";
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnThoat.Location = new System.Drawing.Point(1002, 505);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(86, 43);
            this.btnThoat.TabIndex = 17;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.LightGray;
            this.groupBox1.Controls.Add(this.cmbBacLuong);
            this.groupBox1.Controls.Add(this.dtpNgayKT);
            this.groupBox1.Controls.Add(this.dtpNgayBD);
            this.groupBox1.Controls.Add(this.lblBacLuong);
            this.groupBox1.Controls.Add(this.lblNgayKT);
            this.groupBox1.Controls.Add(this.txtTimKiem);
            this.groupBox1.Controls.Add(this.lblTimKiem);
            this.groupBox1.Controls.Add(this.lblNgayBD);
            this.groupBox1.Controls.Add(this.txtLoaiHD);
            this.groupBox1.Controls.Add(this.llbLoaiHD);
            this.groupBox1.Controls.Add(this.txtTenHD);
            this.groupBox1.Controls.Add(this.lblTenHD);
            this.groupBox1.Controls.Add(this.txtMaHD);
            this.groupBox1.Controls.Add(this.lblMaHD);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(34, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(943, 236);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            // 
            // cmbBacLuong
            // 
            this.cmbBacLuong.FormattingEnabled = true;
            this.cmbBacLuong.Location = new System.Drawing.Point(668, 126);
            this.cmbBacLuong.Name = "cmbBacLuong";
            this.cmbBacLuong.Size = new System.Drawing.Size(173, 26);
            this.cmbBacLuong.TabIndex = 23;
            // 
            // dtpNgayKT
            // 
            this.dtpNgayKT.Location = new System.Drawing.Point(668, 73);
            this.dtpNgayKT.Name = "dtpNgayKT";
            this.dtpNgayKT.Size = new System.Drawing.Size(239, 24);
            this.dtpNgayKT.TabIndex = 22;
            // 
            // dtpNgayBD
            // 
            this.dtpNgayBD.Location = new System.Drawing.Point(668, 30);
            this.dtpNgayBD.Name = "dtpNgayBD";
            this.dtpNgayBD.Size = new System.Drawing.Size(239, 24);
            this.dtpNgayBD.TabIndex = 21;
            // 
            // lblBacLuong
            // 
            this.lblBacLuong.AutoSize = true;
            this.lblBacLuong.Location = new System.Drawing.Point(539, 129);
            this.lblBacLuong.Name = "lblBacLuong";
            this.lblBacLuong.Size = new System.Drawing.Size(79, 18);
            this.lblBacLuong.TabIndex = 20;
            this.lblBacLuong.Text = "Bậc Lương";
            // 
            // lblNgayKT
            // 
            this.lblNgayKT.AutoSize = true;
            this.lblNgayKT.Location = new System.Drawing.Point(539, 78);
            this.lblNgayKT.Name = "lblNgayKT";
            this.lblNgayKT.Size = new System.Drawing.Size(105, 18);
            this.lblNgayKT.TabIndex = 18;
            this.lblNgayKT.Text = "Ngày Kết Thúc";
            // 
            // lblNgayBD
            // 
            this.lblNgayBD.AutoSize = true;
            this.lblNgayBD.Location = new System.Drawing.Point(539, 33);
            this.lblNgayBD.Name = "lblNgayBD";
            this.lblNgayBD.Size = new System.Drawing.Size(99, 18);
            this.lblNgayBD.TabIndex = 6;
            this.lblNgayBD.Text = "Ngày Bắt Đầu";
            // 
            // UCHopDong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgvSach);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.groupBox1);
            this.Name = "UCHopDong";
            this.Size = new System.Drawing.Size(1234, 716);
            this.Load += new System.EventHandler(this.UCHopDong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSach)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Label lblTimKiem;
        private System.Windows.Forms.DataGridView dgvSach;
        private System.Windows.Forms.TextBox txtLoaiHD;
        private System.Windows.Forms.Label llbLoaiHD;
        private System.Windows.Forms.TextBox txtTenHD;
        private System.Windows.Forms.Label lblTenHD;
        private System.Windows.Forms.TextBox txtMaHD;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblMaHD;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblBacLuong;
        private System.Windows.Forms.Label lblNgayKT;
        private System.Windows.Forms.Label lblNgayBD;
        private System.Windows.Forms.ComboBox cmbBacLuong;
        private System.Windows.Forms.DateTimePicker dtpNgayKT;
        private System.Windows.Forms.DateTimePicker dtpNgayBD;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaHD;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenHD;
        private System.Windows.Forms.DataGridViewTextBoxColumn LoaiHD;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayBatDau;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayKetThuc;
        private System.Windows.Forms.DataGridViewTextBoxColumn BacLuong;
    }
}
