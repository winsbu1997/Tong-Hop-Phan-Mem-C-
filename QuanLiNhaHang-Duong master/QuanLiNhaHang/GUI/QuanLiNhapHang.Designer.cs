namespace QuanLiNhaHang.GUI
{
    partial class QuanLiNhapHang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QuanLiNhapHang));
            this.dgvHoaDonNhapMain = new DevExpress.XtraGrid.GridControl();
            this.dgvHoaDonNhap = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.MaHDN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NgayNhap = new DevExpress.XtraGrid.Columns.GridColumn();
            this.MaNV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GhiChu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TongTien = new DevExpress.XtraGrid.Columns.GridColumn();
            this.dgvChiTietNhapMain = new DevExpress.XtraGrid.GridControl();
            this.dgvChiTietNhap = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.MaNL = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SoLuong = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DonGia = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ThanhTien = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnXoaChiTiet = new DevExpress.XtraEditors.SimpleButton();
            this.btnLuuChiTiet = new DevExpress.XtraEditors.SimpleButton();
            this.btnThemChiTiet = new DevExpress.XtraEditors.SimpleButton();
            this.btnXoa = new DevExpress.XtraEditors.SimpleButton();
            this.btnCapNhat = new DevExpress.XtraEditors.SimpleButton();
            this.btnThem = new DevExpress.XtraEditors.SimpleButton();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dtpNgayNhap = new System.Windows.Forms.DateTimePicker();
            this.label19 = new System.Windows.Forms.Label();
            this.txtGhiChu = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtTongTien = new System.Windows.Forms.Label();
            this.cbxTenNhanVien = new System.Windows.Forms.ComboBox();
            this.txtMaHDN = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.grbChiTietNhap = new DevExpress.XtraEditors.GroupControl();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbxDVTinh = new System.Windows.Forms.ComboBox();
            this.txtDonGia = new System.Windows.Forms.NumericUpDown();
            this.label20 = new System.Windows.Forms.Label();
            this.txtSoLuong = new System.Windows.Forms.NumericUpDown();
            this.label17 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtThanhTien = new System.Windows.Forms.Label();
            this.cbxTenNguyenLieu = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.btnChapNhan = new DevExpress.XtraEditors.SimpleButton();
            this.btnHuy = new DevExpress.XtraEditors.SimpleButton();
            this.btnSuaChiTiet = new DevExpress.XtraEditors.SimpleButton();
            this.btnHuyChiTiet = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoaDonNhapMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoaDonNhap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTietNhapMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTietNhap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grbChiTietNhap)).BeginInit();
            this.grbChiTietNhap.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDonGia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoLuong)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvHoaDonNhapMain
            // 
            this.dgvHoaDonNhapMain.Location = new System.Drawing.Point(37, 422);
            this.dgvHoaDonNhapMain.MainView = this.dgvHoaDonNhap;
            this.dgvHoaDonNhapMain.Name = "dgvHoaDonNhapMain";
            this.dgvHoaDonNhapMain.Size = new System.Drawing.Size(837, 359);
            this.dgvHoaDonNhapMain.TabIndex = 79;
            this.dgvHoaDonNhapMain.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.dgvHoaDonNhap});
            // 
            // dgvHoaDonNhap
            // 
            this.dgvHoaDonNhap.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.MaHDN,
            this.NgayNhap,
            this.MaNV,
            this.GhiChu,
            this.TongTien});
            this.dgvHoaDonNhap.GridControl = this.dgvHoaDonNhapMain;
            this.dgvHoaDonNhap.Name = "dgvHoaDonNhap";
            this.dgvHoaDonNhap.OptionsDetail.DetailMode = DevExpress.XtraGrid.Views.Grid.DetailMode.Default;
            this.dgvHoaDonNhap.OptionsFind.AlwaysVisible = true;
            this.dgvHoaDonNhap.OptionsView.ShowGroupPanel = false;
            this.dgvHoaDonNhap.InitNewRow += new DevExpress.XtraGrid.Views.Grid.InitNewRowEventHandler(this.dgvHoaDonNhap_InitNewRow);
            this.dgvHoaDonNhap.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.dgvHoaDonNhap_FocusedRowChanged);
            this.dgvHoaDonNhap.DataSourceChanged += new System.EventHandler(this.dgvHoaDonNhap_DataSourceChanged);
            // 
            // MaHDN
            // 
            this.MaHDN.Caption = "Mã HDN";
            this.MaHDN.FieldName = "MaHDN";
            this.MaHDN.Name = "MaHDN";
            this.MaHDN.Visible = true;
            this.MaHDN.VisibleIndex = 0;
            // 
            // NgayNhap
            // 
            this.NgayNhap.Caption = "Ngày Nhập";
            this.NgayNhap.FieldName = "NgayNhap";
            this.NgayNhap.Name = "NgayNhap";
            this.NgayNhap.Visible = true;
            this.NgayNhap.VisibleIndex = 1;
            this.NgayNhap.Width = 184;
            // 
            // MaNV
            // 
            this.MaNV.Caption = "Nhân Viên Nhập";
            this.MaNV.FieldName = "MaNV";
            this.MaNV.Name = "MaNV";
            this.MaNV.Visible = true;
            this.MaNV.VisibleIndex = 2;
            this.MaNV.Width = 190;
            // 
            // GhiChu
            // 
            this.GhiChu.Caption = "Ghi Chú";
            this.GhiChu.FieldName = "GhiChu";
            this.GhiChu.Name = "GhiChu";
            this.GhiChu.Visible = true;
            this.GhiChu.VisibleIndex = 3;
            this.GhiChu.Width = 237;
            // 
            // TongTien
            // 
            this.TongTien.Caption = "Tổng Tiền";
            this.TongTien.FieldName = "TongTien";
            this.TongTien.Name = "TongTien";
            this.TongTien.Visible = true;
            this.TongTien.VisibleIndex = 4;
            this.TongTien.Width = 131;
            // 
            // dgvChiTietNhapMain
            // 
            this.dgvChiTietNhapMain.Location = new System.Drawing.Point(928, 422);
            this.dgvChiTietNhapMain.MainView = this.dgvChiTietNhap;
            this.dgvChiTietNhapMain.Name = "dgvChiTietNhapMain";
            this.dgvChiTietNhapMain.Size = new System.Drawing.Size(845, 359);
            this.dgvChiTietNhapMain.TabIndex = 78;
            this.dgvChiTietNhapMain.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.dgvChiTietNhap});
            // 
            // dgvChiTietNhap
            // 
            this.dgvChiTietNhap.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.dgvChiTietNhap.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.MaNL,
            this.SoLuong,
            this.DonGia,
            this.ThanhTien});
            this.dgvChiTietNhap.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFullFocus;
            this.dgvChiTietNhap.GridControl = this.dgvChiTietNhapMain;
            this.dgvChiTietNhap.Name = "dgvChiTietNhap";
            this.dgvChiTietNhap.OptionsDetail.DetailMode = DevExpress.XtraGrid.Views.Grid.DetailMode.Default;
            this.dgvChiTietNhap.OptionsView.ShowGroupPanel = false;
            this.dgvChiTietNhap.PaintStyleName = "Flat";
            this.dgvChiTietNhap.InitNewRow += new DevExpress.XtraGrid.Views.Grid.InitNewRowEventHandler(this.dgvChiTietNhap_InitNewRow);
            this.dgvChiTietNhap.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.dgvChiTietNhap_FocusedRowChanged);
            // 
            // MaNL
            // 
            this.MaNL.Caption = "Tên Nguyên Liệu";
            this.MaNL.FieldName = "MaNL";
            this.MaNL.Name = "MaNL";
            this.MaNL.Visible = true;
            this.MaNL.VisibleIndex = 0;
            this.MaNL.Width = 268;
            // 
            // SoLuong
            // 
            this.SoLuong.Caption = "Số Lượng";
            this.SoLuong.FieldName = "SoLuong";
            this.SoLuong.Name = "SoLuong";
            this.SoLuong.Visible = true;
            this.SoLuong.VisibleIndex = 1;
            this.SoLuong.Width = 150;
            // 
            // DonGia
            // 
            this.DonGia.Caption = "Đơn Giá";
            this.DonGia.FieldName = "DonGia";
            this.DonGia.Name = "DonGia";
            this.DonGia.Visible = true;
            this.DonGia.VisibleIndex = 2;
            this.DonGia.Width = 164;
            // 
            // ThanhTien
            // 
            this.ThanhTien.Caption = "Thành Tiền";
            this.ThanhTien.FieldName = "ThanhTien";
            this.ThanhTien.Name = "ThanhTien";
            this.ThanhTien.Visible = true;
            this.ThanhTien.VisibleIndex = 3;
            this.ThanhTien.Width = 172;
            // 
            // btnXoaChiTiet
            // 
            this.btnXoaChiTiet.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.btnXoaChiTiet.Image = ((System.Drawing.Image)(resources.GetObject("btnXoaChiTiet.Image")));
            this.btnXoaChiTiet.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.btnXoaChiTiet.Location = new System.Drawing.Point(1526, 224);
            this.btnXoaChiTiet.Margin = new System.Windows.Forms.Padding(4);
            this.btnXoaChiTiet.Name = "btnXoaChiTiet";
            this.btnXoaChiTiet.Size = new System.Drawing.Size(247, 76);
            this.btnXoaChiTiet.TabIndex = 77;
            this.btnXoaChiTiet.Text = "Xóa";
            this.btnXoaChiTiet.Click += new System.EventHandler(this.btnXoaChiTiet_Click);
            // 
            // btnLuuChiTiet
            // 
            this.btnLuuChiTiet.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.btnLuuChiTiet.Image = ((System.Drawing.Image)(resources.GetObject("btnLuuChiTiet.Image")));
            this.btnLuuChiTiet.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.btnLuuChiTiet.Location = new System.Drawing.Point(1083, 322);
            this.btnLuuChiTiet.Margin = new System.Windows.Forms.Padding(4);
            this.btnLuuChiTiet.Name = "btnLuuChiTiet";
            this.btnLuuChiTiet.Size = new System.Drawing.Size(247, 76);
            this.btnLuuChiTiet.TabIndex = 76;
            this.btnLuuChiTiet.Text = "Lưu";
            this.btnLuuChiTiet.Click += new System.EventHandler(this.btnLuuChiTiet_Click);
            // 
            // btnThemChiTiet
            // 
            this.btnThemChiTiet.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.btnThemChiTiet.Image = ((System.Drawing.Image)(resources.GetObject("btnThemChiTiet.Image")));
            this.btnThemChiTiet.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.btnThemChiTiet.Location = new System.Drawing.Point(928, 224);
            this.btnThemChiTiet.Margin = new System.Windows.Forms.Padding(4);
            this.btnThemChiTiet.Name = "btnThemChiTiet";
            this.btnThemChiTiet.Size = new System.Drawing.Size(247, 76);
            this.btnThemChiTiet.TabIndex = 75;
            this.btnThemChiTiet.Text = "Thêm";
            this.btnThemChiTiet.Click += new System.EventHandler(this.btnThemChiTiet_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.btnXoa.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.Image")));
            this.btnXoa.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.btnXoa.Location = new System.Drawing.Point(627, 224);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(4);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(247, 76);
            this.btnXoa.TabIndex = 74;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.btnCapNhat.Image = ((System.Drawing.Image)(resources.GetObject("btnCapNhat.Image")));
            this.btnCapNhat.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.btnCapNhat.Location = new System.Drawing.Point(336, 224);
            this.btnCapNhat.Margin = new System.Windows.Forms.Padding(4);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(247, 76);
            this.btnCapNhat.TabIndex = 73;
            this.btnCapNhat.Text = "Lưu";
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
            // 
            // btnThem
            // 
            this.btnThem.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.btnThem.Image = ((System.Drawing.Image)(resources.GetObject("btnThem.Image")));
            this.btnThem.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.btnThem.Location = new System.Drawing.Point(37, 224);
            this.btnThem.Margin = new System.Windows.Forms.Padding(4);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(247, 76);
            this.btnThem.TabIndex = 72;
            this.btnThem.Text = "Thêm";
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // groupControl1
            // 
            this.groupControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.groupControl1.Controls.Add(this.pictureBox1);
            this.groupControl1.Controls.Add(this.dtpNgayNhap);
            this.groupControl1.Controls.Add(this.label19);
            this.groupControl1.Controls.Add(this.txtGhiChu);
            this.groupControl1.Controls.Add(this.label10);
            this.groupControl1.Controls.Add(this.label9);
            this.groupControl1.Controls.Add(this.txtTongTien);
            this.groupControl1.Controls.Add(this.cbxTenNhanVien);
            this.groupControl1.Controls.Add(this.txtMaHDN);
            this.groupControl1.Controls.Add(this.label6);
            this.groupControl1.Controls.Add(this.label5);
            this.groupControl1.Controls.Add(this.label4);
            this.groupControl1.Controls.Add(this.label3);
            this.groupControl1.Location = new System.Drawing.Point(29, 6);
            this.groupControl1.Margin = new System.Windows.Forms.Padding(4);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(845, 210);
            this.groupControl1.TabIndex = 70;
            this.groupControl1.Text = "Thông tin phiếu nhập";
            // 
            // pictureBox1
            // 
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(559, 32);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(271, 173);
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // dtpNgayNhap
            // 
            this.dtpNgayNhap.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgayNhap.Location = new System.Drawing.Point(339, 27);
            this.dtpNgayNhap.Name = "dtpNgayNhap";
            this.dtpNgayNhap.Size = new System.Drawing.Size(200, 23);
            this.dtpNgayNhap.TabIndex = 12;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(47, 162);
            this.label19.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(458, 17);
            this.label19.TabIndex = 11;
            this.label19.Text = "---------------------------------------------------------------------------------" +
    "---------";
            // 
            // txtGhiChu
            // 
            this.txtGhiChu.Location = new System.Drawing.Point(164, 116);
            this.txtGhiChu.Margin = new System.Windows.Forms.Padding(4);
            this.txtGhiChu.Multiline = true;
            this.txtGhiChu.Name = "txtGhiChu";
            this.txtGhiChu.Size = new System.Drawing.Size(375, 28);
            this.txtGhiChu.TabIndex = 10;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(47, 119);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(56, 17);
            this.label10.TabIndex = 9;
            this.label10.Text = "Ghi Chú";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(358, 179);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 17);
            this.label9.TabIndex = 8;
            this.label9.Text = "VNĐ";
            // 
            // txtTongTien
            // 
            this.txtTongTien.AutoSize = true;
            this.txtTongTien.Location = new System.Drawing.Point(286, 179);
            this.txtTongTien.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtTongTien.Name = "txtTongTien";
            this.txtTongTien.Size = new System.Drawing.Size(64, 17);
            this.txtTongTien.TabIndex = 7;
            this.txtTongTien.Text = "_ _ _ _ _";
            // 
            // cbxTenNhanVien
            // 
            this.cbxTenNhanVien.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxTenNhanVien.FormattingEnabled = true;
            this.cbxTenNhanVien.Location = new System.Drawing.Point(164, 74);
            this.cbxTenNhanVien.Margin = new System.Windows.Forms.Padding(4);
            this.cbxTenNhanVien.Name = "cbxTenNhanVien";
            this.cbxTenNhanVien.Size = new System.Drawing.Size(215, 24);
            this.cbxTenNhanVien.TabIndex = 6;
            // 
            // txtMaHDN
            // 
            this.txtMaHDN.AutoSize = true;
            this.txtMaHDN.Location = new System.Drawing.Point(164, 31);
            this.txtMaHDN.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtMaHDN.Name = "txtMaHDN";
            this.txtMaHDN.Size = new System.Drawing.Size(44, 17);
            this.txtMaHDN.TabIndex = 4;
            this.txtMaHDN.Text = "_ _ _ ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(47, 179);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 17);
            this.label6.TabIndex = 3;
            this.label6.Text = "Tổng tiền";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(47, 74);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 17);
            this.label5.TabIndex = 2;
            this.label5.Text = "Nhân viên nhập";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(242, 31);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 17);
            this.label4.TabIndex = 1;
            this.label4.Text = "Ngày nhập";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(47, 31);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Mã phiếu nhập";
            // 
            // grbChiTietNhap
            // 
            this.grbChiTietNhap.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.grbChiTietNhap.Controls.Add(this.pictureBox2);
            this.grbChiTietNhap.Controls.Add(this.label1);
            this.grbChiTietNhap.Controls.Add(this.cbxDVTinh);
            this.grbChiTietNhap.Controls.Add(this.txtDonGia);
            this.grbChiTietNhap.Controls.Add(this.label20);
            this.grbChiTietNhap.Controls.Add(this.txtSoLuong);
            this.grbChiTietNhap.Controls.Add(this.label17);
            this.grbChiTietNhap.Controls.Add(this.label7);
            this.grbChiTietNhap.Controls.Add(this.label8);
            this.grbChiTietNhap.Controls.Add(this.txtThanhTien);
            this.grbChiTietNhap.Controls.Add(this.cbxTenNguyenLieu);
            this.grbChiTietNhap.Controls.Add(this.label13);
            this.grbChiTietNhap.Controls.Add(this.label14);
            this.grbChiTietNhap.Location = new System.Drawing.Point(928, 6);
            this.grbChiTietNhap.Margin = new System.Windows.Forms.Padding(4);
            this.grbChiTietNhap.Name = "grbChiTietNhap";
            this.grbChiTietNhap.Size = new System.Drawing.Size(845, 210);
            this.grbChiTietNhap.TabIndex = 71;
            this.grbChiTietNhap.Text = "Thông tin chi tiết nhập";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(558, 28);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(271, 173);
            this.pictureBox2.TabIndex = 21;
            this.pictureBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(324, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 17);
            this.label1.TabIndex = 20;
            this.label1.Text = "Đơn Vị Tính";
            // 
            // cbxDVTinh
            // 
            this.cbxDVTinh.FormattingEnabled = true;
            this.cbxDVTinh.Location = new System.Drawing.Point(422, 73);
            this.cbxDVTinh.Name = "cbxDVTinh";
            this.cbxDVTinh.Size = new System.Drawing.Size(74, 24);
            this.cbxDVTinh.TabIndex = 19;
            // 
            // txtDonGia
            // 
            this.txtDonGia.Enabled = false;
            this.txtDonGia.Location = new System.Drawing.Point(187, 117);
            this.txtDonGia.Margin = new System.Windows.Forms.Padding(4);
            this.txtDonGia.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.txtDonGia.Name = "txtDonGia";
            this.txtDonGia.Size = new System.Drawing.Size(147, 23);
            this.txtDonGia.TabIndex = 18;
            this.txtDonGia.ThousandsSeparator = true;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(71, 162);
            this.label20.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(458, 17);
            this.label20.TabIndex = 17;
            this.label20.Text = "---------------------------------------------------------------------------------" +
    "---------";
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Location = new System.Drawing.Point(187, 75);
            this.txtSoLuong.Margin = new System.Windows.Forms.Padding(4);
            this.txtSoLuong.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(97, 23);
            this.txtSoLuong.TabIndex = 16;
            this.txtSoLuong.ValueChanged += new System.EventHandler(this.txtSoLuong_ValueChanged);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(73, 116);
            this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(55, 17);
            this.label17.TabIndex = 11;
            this.label17.Text = "Đơn giá";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(73, 77);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 17);
            this.label7.TabIndex = 9;
            this.label7.Text = "Số lượng";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(256, 179);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 17);
            this.label8.TabIndex = 8;
            this.label8.Text = "VNĐ";
            // 
            // txtThanhTien
            // 
            this.txtThanhTien.AutoSize = true;
            this.txtThanhTien.Location = new System.Drawing.Point(184, 179);
            this.txtThanhTien.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtThanhTien.Name = "txtThanhTien";
            this.txtThanhTien.Size = new System.Drawing.Size(64, 17);
            this.txtThanhTien.TabIndex = 7;
            this.txtThanhTien.Text = "_ _ _ _ _";
            // 
            // cbxTenNguyenLieu
            // 
            this.cbxTenNguyenLieu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxTenNguyenLieu.FormattingEnabled = true;
            this.cbxTenNguyenLieu.Location = new System.Drawing.Point(187, 32);
            this.cbxTenNguyenLieu.Margin = new System.Windows.Forms.Padding(4);
            this.cbxTenNguyenLieu.Name = "cbxTenNguyenLieu";
            this.cbxTenNguyenLieu.Size = new System.Drawing.Size(215, 24);
            this.cbxTenNguyenLieu.TabIndex = 6;
            this.cbxTenNguyenLieu.SelectedValueChanged += new System.EventHandler(this.cbxTenNguyenLieu_SelectedValueChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(73, 179);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(73, 17);
            this.label13.TabIndex = 3;
            this.label13.Text = "Thành tiền";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(71, 35);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(84, 17);
            this.label14.TabIndex = 2;
            this.label14.Text = "Nguyên Liệu";
            // 
            // btnChapNhan
            // 
            this.btnChapNhan.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.btnChapNhan.Image = ((System.Drawing.Image)(resources.GetObject("btnChapNhan.Image")));
            this.btnChapNhan.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.btnChapNhan.Location = new System.Drawing.Point(196, 330);
            this.btnChapNhan.Margin = new System.Windows.Forms.Padding(4);
            this.btnChapNhan.Name = "btnChapNhan";
            this.btnChapNhan.Size = new System.Drawing.Size(247, 76);
            this.btnChapNhan.TabIndex = 81;
            this.btnChapNhan.Text = "Chấp Nhận";
            this.btnChapNhan.Click += new System.EventHandler(this.btnChapNhan_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.btnHuy.Image = ((System.Drawing.Image)(resources.GetObject("btnHuy.Image")));
            this.btnHuy.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.btnHuy.Location = new System.Drawing.Point(519, 330);
            this.btnHuy.Margin = new System.Windows.Forms.Padding(4);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(247, 76);
            this.btnHuy.TabIndex = 80;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnSuaChiTiet
            // 
            this.btnSuaChiTiet.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.btnSuaChiTiet.Image = ((System.Drawing.Image)(resources.GetObject("btnSuaChiTiet.Image")));
            this.btnSuaChiTiet.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.btnSuaChiTiet.Location = new System.Drawing.Point(1236, 224);
            this.btnSuaChiTiet.Margin = new System.Windows.Forms.Padding(4);
            this.btnSuaChiTiet.Name = "btnSuaChiTiet";
            this.btnSuaChiTiet.Size = new System.Drawing.Size(247, 76);
            this.btnSuaChiTiet.TabIndex = 83;
            this.btnSuaChiTiet.Text = "Sửa";
            this.btnSuaChiTiet.Click += new System.EventHandler(this.btnSuaChiTiet_Click);
            // 
            // btnHuyChiTiet
            // 
            this.btnHuyChiTiet.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.btnHuyChiTiet.Image = ((System.Drawing.Image)(resources.GetObject("btnHuyChiTiet.Image")));
            this.btnHuyChiTiet.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.btnHuyChiTiet.Location = new System.Drawing.Point(1416, 322);
            this.btnHuyChiTiet.Margin = new System.Windows.Forms.Padding(4);
            this.btnHuyChiTiet.Name = "btnHuyChiTiet";
            this.btnHuyChiTiet.Size = new System.Drawing.Size(247, 76);
            this.btnHuyChiTiet.TabIndex = 82;
            this.btnHuyChiTiet.Text = "Hủy";
            this.btnHuyChiTiet.Click += new System.EventHandler(this.btnHuyChiTiet_Click);
            // 
            // QuanLiNhapHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.Controls.Add(this.btnSuaChiTiet);
            this.Controls.Add(this.btnHuyChiTiet);
            this.Controls.Add(this.btnChapNhan);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.dgvHoaDonNhapMain);
            this.Controls.Add(this.dgvChiTietNhapMain);
            this.Controls.Add(this.btnXoaChiTiet);
            this.Controls.Add(this.btnLuuChiTiet);
            this.Controls.Add(this.btnThemChiTiet);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnCapNhat);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.grbChiTietNhap);
            this.Name = "QuanLiNhapHang";
            this.Size = new System.Drawing.Size(1799, 790);
            this.Load += new System.EventHandler(this.QuanLiNhapHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoaDonNhapMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoaDonNhap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTietNhapMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTietNhap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grbChiTietNhap)).EndInit();
            this.grbChiTietNhap.ResumeLayout(false);
            this.grbChiTietNhap.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDonGia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoLuong)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl dgvHoaDonNhapMain;
        private DevExpress.XtraGrid.Views.Grid.GridView dgvHoaDonNhap;
        private DevExpress.XtraGrid.Columns.GridColumn MaHDN;
        private DevExpress.XtraGrid.Columns.GridColumn NgayNhap;
        private DevExpress.XtraGrid.Columns.GridColumn MaNV;
        private DevExpress.XtraGrid.Columns.GridColumn GhiChu;
        private DevExpress.XtraGrid.Columns.GridColumn TongTien;
        private DevExpress.XtraGrid.GridControl dgvChiTietNhapMain;
        private DevExpress.XtraGrid.Views.Grid.GridView dgvChiTietNhap;
        private DevExpress.XtraGrid.Columns.GridColumn MaNL;
        private DevExpress.XtraGrid.Columns.GridColumn SoLuong;
        private DevExpress.XtraGrid.Columns.GridColumn DonGia;
        private DevExpress.XtraGrid.Columns.GridColumn ThanhTien;
        private DevExpress.XtraEditors.SimpleButton btnXoaChiTiet;
        private DevExpress.XtraEditors.SimpleButton btnLuuChiTiet;
        private DevExpress.XtraEditors.SimpleButton btnThemChiTiet;
        private DevExpress.XtraEditors.SimpleButton btnXoa;
        private DevExpress.XtraEditors.SimpleButton btnCapNhat;
        private DevExpress.XtraEditors.SimpleButton btnThem;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.DateTimePicker dtpNgayNhap;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox txtGhiChu;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label txtTongTien;
        private System.Windows.Forms.ComboBox cbxTenNhanVien;
        private System.Windows.Forms.Label txtMaHDN;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraEditors.GroupControl grbChiTietNhap;
        private System.Windows.Forms.NumericUpDown txtDonGia;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.NumericUpDown txtSoLuong;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label txtThanhTien;
        private System.Windows.Forms.ComboBox cbxTenNguyenLieu;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private DevExpress.XtraEditors.SimpleButton btnChapNhan;
        private DevExpress.XtraEditors.SimpleButton btnHuy;
        private DevExpress.XtraEditors.SimpleButton btnSuaChiTiet;
        private DevExpress.XtraEditors.SimpleButton btnHuyChiTiet;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbxDVTinh;
    }
}
