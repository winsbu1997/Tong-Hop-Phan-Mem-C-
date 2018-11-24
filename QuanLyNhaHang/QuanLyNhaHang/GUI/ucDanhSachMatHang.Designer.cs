namespace BTL_CNPM.GUI
{
    partial class ucDanhSachMatHang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucDanhSachMatHang));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnThem = new DevExpress.XtraEditors.SimpleButton();
            this.btnXoa = new DevExpress.XtraEditors.SimpleButton();
            this.btnSua = new DevExpress.XtraEditors.SimpleButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cbxLoaiMatHang = new DevExpress.XtraEditors.LookUpEdit();
            this.label6 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.txtTitleDonViTinh = new System.Windows.Forms.Label();
            this.imgAnh = new System.Windows.Forms.PictureBox();
            this.txtTitleTen = new System.Windows.Forms.Label();
            this.txtThanhPhan = new DevExpress.XtraEditors.MemoEdit();
            this.txtGiaBan = new System.Windows.Forms.TextBox();
            this.txtDonViTinh = new System.Windows.Forms.TextBox();
            this.txtTenMatHang = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvMATHANGMain = new DevExpress.XtraGrid.GridControl();
            this.dgvMATHANG = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.STT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Ten = new DevExpress.XtraGrid.Columns.GridColumn();
            this.LoaiMatHang = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DonViTinh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GiaBan = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbxLoaiMatHang.Properties)).BeginInit();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgAnh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtThanhPhan.Properties)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMATHANGMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMATHANG)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.groupBox3);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1744, 674);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.btnThem);
            this.panel2.Controls.Add(this.btnXoa);
            this.panel2.Controls.Add(this.btnSua);
            this.panel2.Location = new System.Drawing.Point(1059, 521);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(657, 128);
            this.panel2.TabIndex = 3;
            // 
            // btnThem
            // 
            this.btnThem.Appearance.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Appearance.Options.UseFont = true;
            this.btnThem.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.btnThem.Image = ((System.Drawing.Image)(resources.GetObject("btnThem.Image")));
            this.btnThem.Location = new System.Drawing.Point(4, 4);
            this.btnThem.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(319, 54);
            this.btnThem.TabIndex = 13;
            this.btnThem.Text = "Thêm";
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Appearance.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Appearance.Options.UseFont = true;
            this.btnXoa.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.btnXoa.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.Image")));
            this.btnXoa.Location = new System.Drawing.Point(4, 65);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(649, 54);
            this.btnXoa.TabIndex = 15;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Appearance.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.Appearance.Options.UseFont = true;
            this.btnSua.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.btnSua.Image = ((System.Drawing.Image)(resources.GetObject("btnSua.Image")));
            this.btnSua.Location = new System.Drawing.Point(331, 4);
            this.btnSua.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(323, 54);
            this.btnSua.TabIndex = 14;
            this.btnSua.Text = "Sửa";
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.cbxLoaiMatHang);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.panel5);
            this.groupBox3.Controls.Add(this.txtThanhPhan);
            this.groupBox3.Controls.Add(this.txtGiaBan);
            this.groupBox3.Controls.Add(this.txtDonViTinh);
            this.groupBox3.Controls.Add(this.txtTenMatHang);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Location = new System.Drawing.Point(1059, 12);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox3.Size = new System.Drawing.Size(657, 505);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Chi tiết mặt hàng";
            // 
            // cbxLoaiMatHang
            // 
            this.cbxLoaiMatHang.Location = new System.Drawing.Point(172, 204);
            this.cbxLoaiMatHang.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbxLoaiMatHang.Name = "cbxLoaiMatHang";
            this.cbxLoaiMatHang.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.cbxLoaiMatHang.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 11F);
            this.cbxLoaiMatHang.Properties.Appearance.Options.UseFont = true;
            this.cbxLoaiMatHang.Properties.AppearanceDropDown.Font = new System.Drawing.Font("Times New Roman", 11F);
            this.cbxLoaiMatHang.Properties.AppearanceDropDown.Options.UseFont = true;
            this.cbxLoaiMatHang.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.cbxLoaiMatHang.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbxLoaiMatHang.Properties.ButtonsStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.cbxLoaiMatHang.Properties.ShowHeader = false;
            this.cbxLoaiMatHang.Size = new System.Drawing.Size(368, 28);
            this.cbxLoaiMatHang.TabIndex = 36;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(31, 209);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(119, 21);
            this.label6.TabIndex = 20;
            this.label6.Text = "Loại mặt hàng:";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.LightGray;
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.txtTitleDonViTinh);
            this.panel5.Controls.Add(this.imgAnh);
            this.panel5.Controls.Add(this.txtTitleTen);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(4, 26);
            this.panel5.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(649, 156);
            this.panel5.TabIndex = 19;
            // 
            // txtTitleDonViTinh
            // 
            this.txtTitleDonViTinh.AutoSize = true;
            this.txtTitleDonViTinh.ForeColor = System.Drawing.Color.Black;
            this.txtTitleDonViTinh.Location = new System.Drawing.Point(291, 92);
            this.txtTitleDonViTinh.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtTitleDonViTinh.Name = "txtTitleDonViTinh";
            this.txtTitleDonViTinh.Size = new System.Drawing.Size(43, 21);
            this.txtTitleDonViTinh.TabIndex = 2;
            this.txtTitleDonViTinh.Text = "Suất";
            // 
            // imgAnh
            // 
            this.imgAnh.BackColor = System.Drawing.Color.White;
            this.imgAnh.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.imgAnh.Location = new System.Drawing.Point(17, 6);
            this.imgAnh.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.imgAnh.Name = "imgAnh";
            this.imgAnh.Size = new System.Drawing.Size(247, 137);
            this.imgAnh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgAnh.TabIndex = 18;
            this.imgAnh.TabStop = false;
            this.imgAnh.WaitOnLoad = true;
            this.imgAnh.Click += new System.EventHandler(this.imgAnh_Click);
            // 
            // txtTitleTen
            // 
            this.txtTitleTen.AutoSize = true;
            this.txtTitleTen.Font = new System.Drawing.Font("Sitka Text", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTitleTen.ForeColor = System.Drawing.Color.Black;
            this.txtTitleTen.Location = new System.Drawing.Point(285, 44);
            this.txtTitleTen.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtTitleTen.Name = "txtTitleTen";
            this.txtTitleTen.Size = new System.Drawing.Size(176, 49);
            this.txtTitleTen.TabIndex = 1;
            this.txtTitleTen.Text = "Bánh xèo";
            // 
            // txtThanhPhan
            // 
            this.txtThanhPhan.Location = new System.Drawing.Point(172, 452);
            this.txtThanhPhan.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtThanhPhan.Name = "txtThanhPhan";
            this.txtThanhPhan.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 11F);
            this.txtThanhPhan.Properties.Appearance.Options.UseFont = true;
            this.txtThanhPhan.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.txtThanhPhan.Size = new System.Drawing.Size(461, 34);
            this.txtThanhPhan.TabIndex = 16;
            // 
            // txtGiaBan
            // 
            this.txtGiaBan.Location = new System.Drawing.Point(172, 390);
            this.txtGiaBan.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtGiaBan.Name = "txtGiaBan";
            this.txtGiaBan.Size = new System.Drawing.Size(268, 29);
            this.txtGiaBan.TabIndex = 8;
            // 
            // txtDonViTinh
            // 
            this.txtDonViTinh.Location = new System.Drawing.Point(172, 324);
            this.txtDonViTinh.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDonViTinh.Name = "txtDonViTinh";
            this.txtDonViTinh.Size = new System.Drawing.Size(268, 29);
            this.txtDonViTinh.TabIndex = 7;
            // 
            // txtTenMatHang
            // 
            this.txtTenMatHang.Location = new System.Drawing.Point(172, 257);
            this.txtTenMatHang.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTenMatHang.Name = "txtTenMatHang";
            this.txtTenMatHang.Size = new System.Drawing.Size(268, 29);
            this.txtTenMatHang.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(31, 455);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 21);
            this.label5.TabIndex = 5;
            this.label5.Text = "Thành phần :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 394);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 21);
            this.label4.TabIndex = 4;
            this.label4.Text = "Giá bán : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 327);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 21);
            this.label3.TabIndex = 3;
            this.label3.Text = "Đơn vị tính :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 261);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tên mặt hàng : ";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.dgvMATHANGMain);
            this.groupBox2.Location = new System.Drawing.Point(27, 106);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Size = new System.Drawing.Size(1005, 543);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách mặt hàng";
            // 
            // dgvMATHANGMain
            // 
            this.dgvMATHANGMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvMATHANGMain.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvMATHANGMain.Location = new System.Drawing.Point(4, 26);
            this.dgvMATHANGMain.MainView = this.dgvMATHANG;
            this.dgvMATHANGMain.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvMATHANGMain.Name = "dgvMATHANGMain";
            this.dgvMATHANGMain.Size = new System.Drawing.Size(997, 513);
            this.dgvMATHANGMain.TabIndex = 1;
            this.dgvMATHANGMain.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.dgvMATHANG});
            // 
            // dgvMATHANG
            // 
            this.dgvMATHANG.Appearance.HeaderPanel.Font = new System.Drawing.Font("Times New Roman", 11.25F);
            this.dgvMATHANG.Appearance.HeaderPanel.Options.UseFont = true;
            this.dgvMATHANG.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.dgvMATHANG.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.dgvMATHANG.Appearance.Row.Font = new System.Drawing.Font("Times New Roman", 11.25F);
            this.dgvMATHANG.Appearance.Row.Options.UseFont = true;
            this.dgvMATHANG.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.dgvMATHANG.ColumnPanelRowHeight = 30;
            this.dgvMATHANG.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.STT,
            this.Ten,
            this.LoaiMatHang,
            this.DonViTinh,
            this.GiaBan});
            this.dgvMATHANG.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFullFocus;
            this.dgvMATHANG.GridControl = this.dgvMATHANGMain;
            this.dgvMATHANG.Name = "dgvMATHANG";
            this.dgvMATHANG.OptionsBehavior.Editable = false;
            this.dgvMATHANG.OptionsBehavior.ReadOnly = true;
            this.dgvMATHANG.OptionsCustomization.AllowColumnMoving = false;
            this.dgvMATHANG.OptionsCustomization.AllowColumnResizing = false;
            this.dgvMATHANG.OptionsCustomization.AllowFilter = false;
            this.dgvMATHANG.OptionsCustomization.AllowGroup = false;
            this.dgvMATHANG.OptionsDetail.DetailMode = DevExpress.XtraGrid.Views.Grid.DetailMode.Default;
            this.dgvMATHANG.OptionsFind.AllowFindPanel = false;
            this.dgvMATHANG.OptionsView.ShowGroupPanel = false;
            this.dgvMATHANG.PaintStyleName = "UltraFlat";
            this.dgvMATHANG.RowHeight = 30;
            this.dgvMATHANG.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.dgvMatHang_FocusedRowChanged);
            // 
            // STT
            // 
            this.STT.AppearanceCell.Options.UseTextOptions = true;
            this.STT.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.STT.Caption = "STT";
            this.STT.FieldName = "STT";
            this.STT.Name = "STT";
            this.STT.Visible = true;
            this.STT.VisibleIndex = 0;
            this.STT.Width = 61;
            // 
            // Ten
            // 
            this.Ten.Caption = "Tên mặt hàng";
            this.Ten.FieldName = "Ten";
            this.Ten.Name = "Ten";
            this.Ten.Visible = true;
            this.Ten.VisibleIndex = 1;
            this.Ten.Width = 308;
            // 
            // LoaiMatHang
            // 
            this.LoaiMatHang.Caption = "Loại mặt hàng";
            this.LoaiMatHang.FieldName = "LoaiMatHang";
            this.LoaiMatHang.Name = "LoaiMatHang";
            this.LoaiMatHang.Visible = true;
            this.LoaiMatHang.VisibleIndex = 2;
            this.LoaiMatHang.Width = 322;
            // 
            // DonViTinh
            // 
            this.DonViTinh.AppearanceCell.Options.UseTextOptions = true;
            this.DonViTinh.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.DonViTinh.Caption = "Đơn vị tính";
            this.DonViTinh.FieldName = "DonViTinh";
            this.DonViTinh.Name = "DonViTinh";
            this.DonViTinh.Visible = true;
            this.DonViTinh.VisibleIndex = 3;
            this.DonViTinh.Width = 186;
            // 
            // GiaBan
            // 
            this.GiaBan.AppearanceCell.Options.UseTextOptions = true;
            this.GiaBan.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.GiaBan.Caption = "Giá bán";
            this.GiaBan.FieldName = "GiaBan";
            this.GiaBan.Name = "GiaBan";
            this.GiaBan.Visible = true;
            this.GiaBan.VisibleIndex = 4;
            this.GiaBan.Width = 156;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtTimKiem);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(27, 12);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(749, 86);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tìm kiếm";
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(248, 32);
            this.txtTimKiem.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(437, 29);
            this.txtTimKiem.TabIndex = 1;
            this.txtTimKiem.TextChanged += new System.EventHandler(this.txtTimKiem_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 36);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tìm kiếm tên mặt hàng";
            // 
            // ucDanhSachMatHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ucDanhSachMatHang";
            this.Size = new System.Drawing.Size(1744, 674);
            this.Load += new System.EventHandler(this.ucDanhSachMatHang_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbxLoaiMatHang.Properties)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgAnh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtThanhPhan.Properties)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMATHANGMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMATHANG)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Panel panel2;
        private DevExpress.XtraEditors.SimpleButton btnXoa;
        private DevExpress.XtraEditors.SimpleButton btnSua;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtGiaBan;
        private System.Windows.Forms.TextBox txtDonViTinh;
        private System.Windows.Forms.TextBox txtTenMatHang;
        private DevExpress.XtraEditors.MemoEdit txtThanhPhan;
        private DevExpress.XtraEditors.SimpleButton btnThem;
        private DevExpress.XtraGrid.GridControl dgvMATHANGMain;
        private DevExpress.XtraGrid.Views.Grid.GridView dgvMATHANG;
        private DevExpress.XtraGrid.Columns.GridColumn STT;
        private DevExpress.XtraGrid.Columns.GridColumn Ten;
        private DevExpress.XtraGrid.Columns.GridColumn DonViTinh;
        private DevExpress.XtraGrid.Columns.GridColumn GiaBan;
        private System.Windows.Forms.PictureBox imgAnh;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label txtTitleDonViTinh;
        private System.Windows.Forms.Label txtTitleTen;
        private System.Windows.Forms.Label label6;
        private DevExpress.XtraEditors.LookUpEdit cbxLoaiMatHang;
        private DevExpress.XtraGrid.Columns.GridColumn LoaiMatHang;
    }
}
