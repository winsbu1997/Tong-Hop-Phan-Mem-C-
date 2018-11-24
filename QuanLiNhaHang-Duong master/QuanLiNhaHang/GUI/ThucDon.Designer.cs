namespace QuanLiNhaHang.GUI
{
    partial class ThucDon
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ThucDon));
            this.btnSuaMA = new DevExpress.XtraEditors.SimpleButton();
            this.grcMonAn = new DevExpress.XtraEditors.GroupControl();
            this.ptbMonAn = new DevExpress.XtraEditors.PictureEdit();
            this.btnXoaAnh = new System.Windows.Forms.Button();
            this.btnThayDoiAnh = new System.Windows.Forms.Button();
            this.txtDonViTnh = new System.Windows.Forms.TextBox();
            this.txtTenMA = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDonGia = new System.Windows.Forms.NumericUpDown();
            this.label17 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtMaMA = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.btnSua = new DevExpress.XtraEditors.SimpleButton();
            this.btnHuy = new DevExpress.XtraEditors.SimpleButton();
            this.btnHuyMA = new DevExpress.XtraEditors.SimpleButton();
            this.dgvNhomMonMain = new DevExpress.XtraGrid.GridControl();
            this.dgvNhomMon = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.MaNM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TenNM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grcNhomMon = new DevExpress.XtraEditors.GroupControl();
            this.txtTenNM = new System.Windows.Forms.TextBox();
            this.txtMaNM = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnLuuMA = new DevExpress.XtraEditors.SimpleButton();
            this.btnThemMA = new DevExpress.XtraEditors.SimpleButton();
            this.btnXoa = new DevExpress.XtraEditors.SimpleButton();
            this.btnLuu = new DevExpress.XtraEditors.SimpleButton();
            this.btnXoaMA = new DevExpress.XtraEditors.SimpleButton();
            this.btnThem = new DevExpress.XtraEditors.SimpleButton();
            this.dgvMonAnMain = new DevExpress.XtraGrid.GridControl();
            this.dgvMonAn = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.STTMA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TenMA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DonViTinh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DonGia = new DevExpress.XtraGrid.Columns.GridColumn();
            this.HinhAnh = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grcMonAn)).BeginInit();
            this.grcMonAn.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbMonAn.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDonGia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhomMonMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhomMon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grcNhomMon)).BeginInit();
            this.grcNhomMon.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMonAnMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMonAn)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSuaMA
            // 
            this.btnSuaMA.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.btnSuaMA.Image = global::QuanLiNhaHang.Properties.Resources._48px_Crystal_Clear_app_package_settings;
            this.btnSuaMA.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.btnSuaMA.Location = new System.Drawing.Point(849, 278);
            this.btnSuaMA.Margin = new System.Windows.Forms.Padding(4);
            this.btnSuaMA.Name = "btnSuaMA";
            this.btnSuaMA.Size = new System.Drawing.Size(156, 83);
            this.btnSuaMA.TabIndex = 97;
            this.btnSuaMA.Text = "Sửa";
            this.btnSuaMA.Click += new System.EventHandler(this.btnSuaMA_Click);
            // 
            // grcMonAn
            // 
            this.grcMonAn.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.grcMonAn.Controls.Add(this.ptbMonAn);
            this.grcMonAn.Controls.Add(this.btnXoaAnh);
            this.grcMonAn.Controls.Add(this.btnThayDoiAnh);
            this.grcMonAn.Controls.Add(this.txtDonViTnh);
            this.grcMonAn.Controls.Add(this.txtTenMA);
            this.grcMonAn.Controls.Add(this.label1);
            this.grcMonAn.Controls.Add(this.txtDonGia);
            this.grcMonAn.Controls.Add(this.label17);
            this.grcMonAn.Controls.Add(this.label7);
            this.grcMonAn.Controls.Add(this.txtMaMA);
            this.grcMonAn.Controls.Add(this.label14);
            this.grcMonAn.Location = new System.Drawing.Point(669, 15);
            this.grcMonAn.Margin = new System.Windows.Forms.Padding(4);
            this.grcMonAn.Name = "grcMonAn";
            this.grcMonAn.Size = new System.Drawing.Size(874, 243);
            this.grcMonAn.TabIndex = 85;
            this.grcMonAn.Text = "Thông tin chi tiết món ăn";
            // 
            // ptbMonAn
            // 
            this.ptbMonAn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ptbMonAn.Location = new System.Drawing.Point(594, 52);
            this.ptbMonAn.Name = "ptbMonAn";
            this.ptbMonAn.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.ptbMonAn.Properties.ZoomAccelerationFactor = 1D;
            this.ptbMonAn.Size = new System.Drawing.Size(232, 161);
            this.ptbMonAn.TabIndex = 26;
            // 
            // btnXoaAnh
            // 
            this.btnXoaAnh.Location = new System.Drawing.Point(382, 142);
            this.btnXoaAnh.Name = "btnXoaAnh";
            this.btnXoaAnh.Size = new System.Drawing.Size(120, 47);
            this.btnXoaAnh.TabIndex = 25;
            this.btnXoaAnh.Text = "Xóa Ảnh";
            this.btnXoaAnh.UseVisualStyleBackColor = true;
            this.btnXoaAnh.Click += new System.EventHandler(this.btnXoaAnh_Click);
            // 
            // btnThayDoiAnh
            // 
            this.btnThayDoiAnh.Location = new System.Drawing.Point(382, 64);
            this.btnThayDoiAnh.Name = "btnThayDoiAnh";
            this.btnThayDoiAnh.Size = new System.Drawing.Size(120, 47);
            this.btnThayDoiAnh.TabIndex = 24;
            this.btnThayDoiAnh.Text = "Thay Đổi Ảnh";
            this.btnThayDoiAnh.UseVisualStyleBackColor = true;
            this.btnThayDoiAnh.Click += new System.EventHandler(this.btnThayDoiAnh_Click);
            // 
            // txtDonViTnh
            // 
            this.txtDonViTnh.Location = new System.Drawing.Point(134, 124);
            this.txtDonViTnh.Name = "txtDonViTnh";
            this.txtDonViTnh.Size = new System.Drawing.Size(190, 23);
            this.txtDonViTnh.TabIndex = 23;
            // 
            // txtTenMA
            // 
            this.txtTenMA.Location = new System.Drawing.Point(134, 79);
            this.txtTenMA.Name = "txtTenMA";
            this.txtTenMA.Size = new System.Drawing.Size(190, 23);
            this.txtTenMA.TabIndex = 22;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 184);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 17);
            this.label1.TabIndex = 20;
            this.label1.Text = "Đơn Giá";
            // 
            // txtDonGia
            // 
            this.txtDonGia.Location = new System.Drawing.Point(134, 178);
            this.txtDonGia.Margin = new System.Windows.Forms.Padding(4);
            this.txtDonGia.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.txtDonGia.Name = "txtDonGia";
            this.txtDonGia.Size = new System.Drawing.Size(84, 23);
            this.txtDonGia.TabIndex = 16;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(24, 124);
            this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(78, 17);
            this.label17.TabIndex = 11;
            this.label17.Text = "Đơn Vị Tính";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(24, 42);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 17);
            this.label7.TabIndex = 9;
            this.label7.Text = "Mã Món Ăn";
            // 
            // txtMaMA
            // 
            this.txtMaMA.AutoSize = true;
            this.txtMaMA.Location = new System.Drawing.Point(131, 42);
            this.txtMaMA.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtMaMA.Name = "txtMaMA";
            this.txtMaMA.Size = new System.Drawing.Size(64, 17);
            this.txtMaMA.TabIndex = 7;
            this.txtMaMA.Text = "_ _ _ _ _";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(24, 85);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(81, 17);
            this.label14.TabIndex = 2;
            this.label14.Text = "Tên Món Ăn";
            // 
            // btnSua
            // 
            this.btnSua.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.btnSua.Image = ((System.Drawing.Image)(resources.GetObject("btnSua.Image")));
            this.btnSua.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.btnSua.Location = new System.Drawing.Point(211, 182);
            this.btnSua.Margin = new System.Windows.Forms.Padding(4);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(156, 76);
            this.btnSua.TabIndex = 95;
            this.btnSua.Text = "Sửa ";
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.btnHuy.Image = ((System.Drawing.Image)(resources.GetObject("btnHuy.Image")));
            this.btnHuy.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.btnHuy.Location = new System.Drawing.Point(309, 285);
            this.btnHuy.Margin = new System.Windows.Forms.Padding(4);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(156, 76);
            this.btnHuy.TabIndex = 94;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnHuyMA
            // 
            this.btnHuyMA.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.btnHuyMA.Image = ((System.Drawing.Image)(resources.GetObject("btnHuyMA.Image")));
            this.btnHuyMA.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.btnHuyMA.Location = new System.Drawing.Point(1387, 278);
            this.btnHuyMA.Margin = new System.Windows.Forms.Padding(4);
            this.btnHuyMA.Name = "btnHuyMA";
            this.btnHuyMA.Size = new System.Drawing.Size(156, 83);
            this.btnHuyMA.TabIndex = 96;
            this.btnHuyMA.Text = "Hủy";
            this.btnHuyMA.Click += new System.EventHandler(this.btnHuyMA_Click);
            // 
            // dgvNhomMonMain
            // 
            this.dgvNhomMonMain.Location = new System.Drawing.Point(13, 388);
            this.dgvNhomMonMain.MainView = this.dgvNhomMon;
            this.dgvNhomMonMain.Name = "dgvNhomMonMain";
            this.dgvNhomMonMain.Size = new System.Drawing.Size(556, 382);
            this.dgvNhomMonMain.TabIndex = 93;
            this.dgvNhomMonMain.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.dgvNhomMon});
            // 
            // dgvNhomMon
            // 
            this.dgvNhomMon.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.MaNM,
            this.TenNM});
            this.dgvNhomMon.GridControl = this.dgvNhomMonMain;
            this.dgvNhomMon.Name = "dgvNhomMon";
            this.dgvNhomMon.OptionsDetail.DetailMode = DevExpress.XtraGrid.Views.Grid.DetailMode.Default;
            this.dgvNhomMon.OptionsView.ShowGroupPanel = false;
            this.dgvNhomMon.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.dgvNhomMon_FocusedRowChanged);
            this.dgvNhomMon.RowLoaded += new DevExpress.XtraGrid.Views.Base.RowEventHandler(this.dgvNhomMon_RowLoaded);
            this.dgvNhomMon.DataSourceChanged += new System.EventHandler(this.dgvNhomMon_DataSourceChanged);
            // 
            // MaNM
            // 
            this.MaNM.Caption = "Mã Nhóm Món";
            this.MaNM.FieldName = "MaNM";
            this.MaNM.Name = "MaNM";
            this.MaNM.Visible = true;
            this.MaNM.VisibleIndex = 0;
            // 
            // TenNM
            // 
            this.TenNM.Caption = "Tên Nhóm Món";
            this.TenNM.FieldName = "TenNM";
            this.TenNM.Name = "TenNM";
            this.TenNM.Visible = true;
            this.TenNM.VisibleIndex = 1;
            this.TenNM.Width = 184;
            // 
            // grcNhomMon
            // 
            this.grcNhomMon.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.grcNhomMon.Controls.Add(this.txtTenNM);
            this.grcNhomMon.Controls.Add(this.txtMaNM);
            this.grcNhomMon.Controls.Add(this.label5);
            this.grcNhomMon.Controls.Add(this.label3);
            this.grcNhomMon.Location = new System.Drawing.Point(13, 26);
            this.grcNhomMon.Margin = new System.Windows.Forms.Padding(4);
            this.grcNhomMon.Name = "grcNhomMon";
            this.grcNhomMon.Size = new System.Drawing.Size(556, 133);
            this.grcNhomMon.TabIndex = 84;
            this.grcNhomMon.Text = "Thông tin chi tiết nhóm món";
            // 
            // txtTenNM
            // 
            this.txtTenNM.Location = new System.Drawing.Point(164, 80);
            this.txtTenNM.Name = "txtTenNM";
            this.txtTenNM.Size = new System.Drawing.Size(190, 23);
            this.txtTenNM.TabIndex = 24;
            // 
            // txtMaNM
            // 
            this.txtMaNM.AutoSize = true;
            this.txtMaNM.Location = new System.Drawing.Point(164, 41);
            this.txtMaNM.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtMaNM.Name = "txtMaNM";
            this.txtMaNM.Size = new System.Drawing.Size(44, 17);
            this.txtMaNM.TabIndex = 4;
            this.txtMaNM.Text = "_ _ _ ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 83);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 17);
            this.label5.TabIndex = 2;
            this.label5.Text = "Tên Nhóm Món";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 41);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Mã Nhóm Món";
            // 
            // btnLuuMA
            // 
            this.btnLuuMA.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.btnLuuMA.Image = ((System.Drawing.Image)(resources.GetObject("btnLuuMA.Image")));
            this.btnLuuMA.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.btnLuuMA.Location = new System.Drawing.Point(1207, 278);
            this.btnLuuMA.Margin = new System.Windows.Forms.Padding(4);
            this.btnLuuMA.Name = "btnLuuMA";
            this.btnLuuMA.Size = new System.Drawing.Size(156, 83);
            this.btnLuuMA.TabIndex = 90;
            this.btnLuuMA.Text = "Lưu";
            this.btnLuuMA.Click += new System.EventHandler(this.btnLuuMA_Click);
            // 
            // btnThemMA
            // 
            this.btnThemMA.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.btnThemMA.Image = ((System.Drawing.Image)(resources.GetObject("btnThemMA.Image")));
            this.btnThemMA.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.btnThemMA.Location = new System.Drawing.Point(669, 278);
            this.btnThemMA.Margin = new System.Windows.Forms.Padding(4);
            this.btnThemMA.Name = "btnThemMA";
            this.btnThemMA.Size = new System.Drawing.Size(156, 83);
            this.btnThemMA.TabIndex = 89;
            this.btnThemMA.Text = "Thêm";
            this.btnThemMA.Click += new System.EventHandler(this.btnThemMA_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.btnXoa.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.Image")));
            this.btnXoa.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.btnXoa.Location = new System.Drawing.Point(413, 182);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(4);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(156, 76);
            this.btnXoa.TabIndex = 88;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.btnLuu.Image = ((System.Drawing.Image)(resources.GetObject("btnLuu.Image")));
            this.btnLuu.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.btnLuu.Location = new System.Drawing.Point(110, 289);
            this.btnLuu.Margin = new System.Windows.Forms.Padding(4);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(156, 76);
            this.btnLuu.TabIndex = 87;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnXoaMA
            // 
            this.btnXoaMA.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.btnXoaMA.Image = ((System.Drawing.Image)(resources.GetObject("btnXoaMA.Image")));
            this.btnXoaMA.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.btnXoaMA.Location = new System.Drawing.Point(1027, 278);
            this.btnXoaMA.Margin = new System.Windows.Forms.Padding(4);
            this.btnXoaMA.Name = "btnXoaMA";
            this.btnXoaMA.Size = new System.Drawing.Size(156, 83);
            this.btnXoaMA.TabIndex = 91;
            this.btnXoaMA.Text = "Xóa";
            this.btnXoaMA.Click += new System.EventHandler(this.btnXoaMA_Click);
            // 
            // btnThem
            // 
            this.btnThem.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.btnThem.Image = ((System.Drawing.Image)(resources.GetObject("btnThem.Image")));
            this.btnThem.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.btnThem.Location = new System.Drawing.Point(13, 182);
            this.btnThem.Margin = new System.Windows.Forms.Padding(4);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(156, 76);
            this.btnThem.TabIndex = 86;
            this.btnThem.Text = "Thêm";
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // dgvMonAnMain
            // 
            this.dgvMonAnMain.Location = new System.Drawing.Point(669, 388);
            this.dgvMonAnMain.MainView = this.dgvMonAn;
            this.dgvMonAnMain.Name = "dgvMonAnMain";
            this.dgvMonAnMain.Size = new System.Drawing.Size(874, 382);
            this.dgvMonAnMain.TabIndex = 98;
            this.dgvMonAnMain.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.dgvMonAn});
            // 
            // dgvMonAn
            // 
            this.dgvMonAn.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.STTMA,
            this.TenMA,
            this.DonViTinh,
            this.DonGia,
            this.HinhAnh});
            this.dgvMonAn.GridControl = this.dgvMonAnMain;
            this.dgvMonAn.Name = "dgvMonAn";
            this.dgvMonAn.OptionsDetail.DetailMode = DevExpress.XtraGrid.Views.Grid.DetailMode.Default;
            this.dgvMonAn.OptionsView.ShowGroupPanel = false;
            // 
            // STTMA
            // 
            this.STTMA.Caption = "Mã Món Ăn";
            this.STTMA.FieldName = "STTMA";
            this.STTMA.Name = "STTMA";
            this.STTMA.Visible = true;
            this.STTMA.VisibleIndex = 0;
            // 
            // TenMA
            // 
            this.TenMA.Caption = "Tên Món Ăn";
            this.TenMA.FieldName = "TenMA";
            this.TenMA.Name = "TenMA";
            this.TenMA.Visible = true;
            this.TenMA.VisibleIndex = 1;
            // 
            // DonViTinh
            // 
            this.DonViTinh.Caption = "Đơn Vị Tính";
            this.DonViTinh.FieldName = "DonViTinh";
            this.DonViTinh.Name = "DonViTinh";
            this.DonViTinh.Visible = true;
            this.DonViTinh.VisibleIndex = 2;
            // 
            // DonGia
            // 
            this.DonGia.Caption = "Đơn Giá";
            this.DonGia.FieldName = "DonGia";
            this.DonGia.Name = "DonGia";
            this.DonGia.Visible = true;
            this.DonGia.VisibleIndex = 3;
            // 
            // HinhAnh
            // 
            this.HinhAnh.Caption = "Hình Ảnh";
            this.HinhAnh.FieldName = "HinhAnh";
            this.HinhAnh.Name = "HinhAnh";
            this.HinhAnh.Visible = true;
            this.HinhAnh.VisibleIndex = 4;
            // 
            // ThucDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.Controls.Add(this.dgvMonAnMain);
            this.Controls.Add(this.btnSuaMA);
            this.Controls.Add(this.grcMonAn);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnHuyMA);
            this.Controls.Add(this.dgvNhomMonMain);
            this.Controls.Add(this.grcNhomMon);
            this.Controls.Add(this.btnLuuMA);
            this.Controls.Add(this.btnThemMA);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnXoaMA);
            this.Controls.Add(this.btnThem);
            this.Name = "ThucDon";
            this.Size = new System.Drawing.Size(1785, 804);
            this.Load += new System.EventHandler(this.ThucDon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grcMonAn)).EndInit();
            this.grcMonAn.ResumeLayout(false);
            this.grcMonAn.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbMonAn.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDonGia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhomMonMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhomMon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grcNhomMon)).EndInit();
            this.grcNhomMon.ResumeLayout(false);
            this.grcNhomMon.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMonAnMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMonAn)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraEditors.SimpleButton btnSuaMA;
        private DevExpress.XtraEditors.GroupControl grcMonAn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown txtDonGia;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label txtMaMA;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private DevExpress.XtraEditors.SimpleButton btnSua;
        private DevExpress.XtraEditors.SimpleButton btnHuy;
        private DevExpress.XtraEditors.SimpleButton btnHuyMA;
        private DevExpress.XtraGrid.GridControl dgvNhomMonMain;
        private DevExpress.XtraGrid.Views.Grid.GridView dgvNhomMon;
        private DevExpress.XtraGrid.Columns.GridColumn MaNM;
        private DevExpress.XtraGrid.Columns.GridColumn TenNM;
        private DevExpress.XtraEditors.GroupControl grcNhomMon;
        private System.Windows.Forms.Label txtMaNM;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraEditors.SimpleButton btnLuuMA;
        private DevExpress.XtraEditors.SimpleButton btnThemMA;
        private DevExpress.XtraEditors.SimpleButton btnXoa;
        private DevExpress.XtraEditors.SimpleButton btnLuu;
        private DevExpress.XtraEditors.SimpleButton btnXoaMA;
        private DevExpress.XtraEditors.SimpleButton btnThem;
        private System.Windows.Forms.TextBox txtDonViTnh;
        private System.Windows.Forms.TextBox txtTenMA;
        private System.Windows.Forms.Button btnXoaAnh;
        private System.Windows.Forms.Button btnThayDoiAnh;
        private System.Windows.Forms.TextBox txtTenNM;
        private DevExpress.XtraGrid.GridControl dgvMonAnMain;
        private DevExpress.XtraGrid.Views.Grid.GridView dgvMonAn;
        private DevExpress.XtraGrid.Columns.GridColumn STTMA;
        private DevExpress.XtraGrid.Columns.GridColumn TenMA;
        private DevExpress.XtraGrid.Columns.GridColumn DonViTinh;
        private DevExpress.XtraGrid.Columns.GridColumn DonGia;
        private DevExpress.XtraGrid.Columns.GridColumn HinhAnh;
        private DevExpress.XtraEditors.PictureEdit ptbMonAn;
    }
}
