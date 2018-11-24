namespace QuanLiNhaHang.GUI
{
    partial class ThongKeHDB
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ThongKeHDB));
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpfromDay = new System.Windows.Forms.DateTimePicker();
            this.dgvHoaDonBanMain = new DevExpress.XtraGrid.GridControl();
            this.dgvHoaDonBan = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.MaHDB = new DevExpress.XtraGrid.Columns.GridColumn();
            this.MaNV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.MaKH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NgayBan = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GiamGia = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TongTien = new DevExpress.XtraGrid.Columns.GridColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnThongKe = new DevExpress.XtraEditors.SimpleButton();
            this.dtptoDay = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtTongHoaDon = new System.Windows.Forms.Label();
            this.txtTongTien = new System.Windows.Forms.Label();
            this.txtTongSoMon = new System.Windows.Forms.Label();
            this.txtTienThuVe = new System.Windows.Forms.Label();
            this.txtGiamGia = new System.Windows.Forms.Label();
            this.dgvChiTietBanMain = new DevExpress.XtraGrid.GridControl();
            this.dgvChiTietBan = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.TenMA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SoLuong = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ThanhTien = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DonViTinh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btn_delete = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.btnThongKeTheoMon = new DevExpress.XtraEditors.SimpleButton();
            this.label8 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.btnExport = new DevExpress.XtraEditors.SimpleButton();
            this.lblStatus = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.btndeleteHDB = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoaDonBanMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoaDonBan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTietBanMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTietBan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_delete)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Rockwell", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(-1, 128);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(330, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Thống kê Hóa Đơn Bán";
            // 
            // dtpfromDay
            // 
            this.dtpfromDay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpfromDay.Location = new System.Drawing.Point(808, 62);
            this.dtpfromDay.Name = "dtpfromDay";
            this.dtpfromDay.Size = new System.Drawing.Size(113, 22);
            this.dtpfromDay.TabIndex = 1;
            this.dtpfromDay.ValueChanged += new System.EventHandler(this.dtpfromDay_ValueChanged);
            // 
            // dgvHoaDonBanMain
            // 
            this.dgvHoaDonBanMain.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvHoaDonBanMain.Location = new System.Drawing.Point(3, 176);
            this.dgvHoaDonBanMain.MainView = this.dgvHoaDonBan;
            this.dgvHoaDonBanMain.Name = "dgvHoaDonBanMain";
            this.dgvHoaDonBanMain.Size = new System.Drawing.Size(990, 384);
            this.dgvHoaDonBanMain.TabIndex = 4;
            this.dgvHoaDonBanMain.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.dgvHoaDonBan});
            // 
            // dgvHoaDonBan
            // 
            this.dgvHoaDonBan.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.MaHDB,
            this.MaNV,
            this.MaKH,
            this.NgayBan,
            this.GiamGia,
            this.TongTien});
            this.dgvHoaDonBan.GridControl = this.dgvHoaDonBanMain;
            this.dgvHoaDonBan.Name = "dgvHoaDonBan";
            this.dgvHoaDonBan.OptionsBehavior.ReadOnly = true;
            this.dgvHoaDonBan.OptionsDetail.DetailMode = DevExpress.XtraGrid.Views.Grid.DetailMode.Default;
            this.dgvHoaDonBan.OptionsView.ShowGroupPanel = false;
            this.dgvHoaDonBan.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.dgvHoaDonBan_FocusedRowChanged);
            this.dgvHoaDonBan.DataSourceChanged += new System.EventHandler(this.dgvHoaDonBan_DataSourceChanged);
            // 
            // MaHDB
            // 
            this.MaHDB.Caption = "MaHDB";
            this.MaHDB.FieldName = "MaHDB";
            this.MaHDB.Name = "MaHDB";
            this.MaHDB.Visible = true;
            this.MaHDB.VisibleIndex = 0;
            this.MaHDB.Width = 125;
            // 
            // MaNV
            // 
            this.MaNV.Caption = "Nhân Viên Bán";
            this.MaNV.FieldName = "MaNV";
            this.MaNV.Name = "MaNV";
            this.MaNV.Visible = true;
            this.MaNV.VisibleIndex = 1;
            this.MaNV.Width = 218;
            // 
            // MaKH
            // 
            this.MaKH.Caption = "Khách Hàng Mua";
            this.MaKH.FieldName = "MaKH";
            this.MaKH.Name = "MaKH";
            this.MaKH.Visible = true;
            this.MaKH.VisibleIndex = 2;
            this.MaKH.Width = 210;
            // 
            // NgayBan
            // 
            this.NgayBan.Caption = "Ngày Bán";
            this.NgayBan.FieldName = "NgayBan";
            this.NgayBan.Name = "NgayBan";
            this.NgayBan.Visible = true;
            this.NgayBan.VisibleIndex = 3;
            this.NgayBan.Width = 169;
            // 
            // GiamGia
            // 
            this.GiamGia.Caption = "Giảm giá";
            this.GiamGia.FieldName = "GiamGia";
            this.GiamGia.Name = "GiamGia";
            this.GiamGia.Visible = true;
            this.GiamGia.VisibleIndex = 4;
            this.GiamGia.Width = 138;
            // 
            // TongTien
            // 
            this.TongTien.Caption = "Tổng tiền";
            this.TongTien.FieldName = "TongTien";
            this.TongTien.Name = "TongTien";
            this.TongTien.Visible = true;
            this.TongTien.VisibleIndex = 5;
            this.TongTien.Width = 110;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(598, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Từ ngày:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(996, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "đến ngày";
            // 
            // btnThongKe
            // 
            this.btnThongKe.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThongKe.Appearance.Options.UseFont = true;
            this.btnThongKe.Location = new System.Drawing.Point(1370, 58);
            this.btnThongKe.Name = "btnThongKe";
            this.btnThongKe.Size = new System.Drawing.Size(97, 34);
            this.btnThongKe.TabIndex = 8;
            this.btnThongKe.Text = "Thống kê";
            this.btnThongKe.Click += new System.EventHandler(this.btnThongKe_Click);
            // 
            // dtptoDay
            // 
            this.dtptoDay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtptoDay.Location = new System.Drawing.Point(1149, 64);
            this.dtptoDay.Name = "dtptoDay";
            this.dtptoDay.Size = new System.Drawing.Size(116, 22);
            this.dtptoDay.TabIndex = 9;
            this.dtptoDay.ValueChanged += new System.EventHandler(this.dtptoDay_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Rockwell", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(1510, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(327, 33);
            this.label4.TabIndex = 10;
            this.label4.Text = "Thống kê Chi Tiết Bán";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(54, 759);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 25);
            this.label5.TabIndex = 11;
            this.label5.Text = "Tiền thu về:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(34, 728);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(328, 17);
            this.label6.TabIndex = 12;
            this.label6.Text = "----------------------------------------------------------------";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(14, 635);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(108, 25);
            this.label7.TabIndex = 13;
            this.label7.Text = "Tổng Tiền:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(1094, 614);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(198, 25);
            this.label9.TabIndex = 15;
            this.label9.Text = "Tổng số món đã bán:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(10, 685);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(135, 25);
            this.label10.TabIndex = 16;
            this.label10.Text = "Tiền giảm giá:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(10, 594);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(263, 25);
            this.label11.TabIndex = 17;
            this.label11.Text = "Tổng số hóa đơn thanh toán:";
            // 
            // txtTongHoaDon
            // 
            this.txtTongHoaDon.AutoSize = true;
            this.txtTongHoaDon.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTongHoaDon.Location = new System.Drawing.Point(305, 590);
            this.txtTongHoaDon.Name = "txtTongHoaDon";
            this.txtTongHoaDon.Size = new System.Drawing.Size(102, 29);
            this.txtTongHoaDon.TabIndex = 22;
            this.txtTongHoaDon.Text = "_ _ _ _ _";
            // 
            // txtTongTien
            // 
            this.txtTongTien.AutoSize = true;
            this.txtTongTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTongTien.Location = new System.Drawing.Point(128, 631);
            this.txtTongTien.Name = "txtTongTien";
            this.txtTongTien.Size = new System.Drawing.Size(102, 29);
            this.txtTongTien.TabIndex = 23;
            this.txtTongTien.Text = "_ _ _ _ _";
            // 
            // txtTongSoMon
            // 
            this.txtTongSoMon.AutoSize = true;
            this.txtTongSoMon.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTongSoMon.Location = new System.Drawing.Point(1298, 610);
            this.txtTongSoMon.Name = "txtTongSoMon";
            this.txtTongSoMon.Size = new System.Drawing.Size(102, 29);
            this.txtTongSoMon.TabIndex = 24;
            this.txtTongSoMon.Text = "_ _ _ _ _";
            // 
            // txtTienThuVe
            // 
            this.txtTienThuVe.AutoSize = true;
            this.txtTienThuVe.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTienThuVe.Location = new System.Drawing.Point(175, 755);
            this.txtTienThuVe.Name = "txtTienThuVe";
            this.txtTienThuVe.Size = new System.Drawing.Size(102, 29);
            this.txtTienThuVe.TabIndex = 25;
            this.txtTienThuVe.Text = "_ _ _ _ _";
            // 
            // txtGiamGia
            // 
            this.txtGiamGia.AutoSize = true;
            this.txtGiamGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGiamGia.Location = new System.Drawing.Point(151, 681);
            this.txtGiamGia.Name = "txtGiamGia";
            this.txtGiamGia.Size = new System.Drawing.Size(102, 29);
            this.txtGiamGia.TabIndex = 26;
            this.txtGiamGia.Text = "_ _ _ _ _";
            // 
            // dgvChiTietBanMain
            // 
            this.dgvChiTietBanMain.Font = new System.Drawing.Font(".VnSouthern", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvChiTietBanMain.Location = new System.Drawing.Point(1099, 176);
            this.dgvChiTietBanMain.MainView = this.dgvChiTietBan;
            this.dgvChiTietBanMain.Name = "dgvChiTietBanMain";
            this.dgvChiTietBanMain.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.btn_delete});
            this.dgvChiTietBanMain.Size = new System.Drawing.Size(769, 384);
            this.dgvChiTietBanMain.TabIndex = 27;
            this.dgvChiTietBanMain.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.dgvChiTietBan});
            // 
            // dgvChiTietBan
            // 
            this.dgvChiTietBan.Appearance.Preview.BackColor = System.Drawing.Color.Lime;
            this.dgvChiTietBan.Appearance.Preview.Options.UseBackColor = true;
            this.dgvChiTietBan.Appearance.Row.BackColor = System.Drawing.Color.White;
            this.dgvChiTietBan.Appearance.Row.BorderColor = System.Drawing.Color.White;
            this.dgvChiTietBan.Appearance.Row.ForeColor = System.Drawing.Color.Lime;
            this.dgvChiTietBan.Appearance.Row.Options.UseBackColor = true;
            this.dgvChiTietBan.Appearance.Row.Options.UseBorderColor = true;
            this.dgvChiTietBan.Appearance.Row.Options.UseForeColor = true;
            this.dgvChiTietBan.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.TenMA,
            this.SoLuong,
            this.ThanhTien,
            this.DonViTinh});
            this.dgvChiTietBan.GridControl = this.dgvChiTietBanMain;
            this.dgvChiTietBan.Name = "dgvChiTietBan";
            this.dgvChiTietBan.OptionsBehavior.ReadOnly = true;
            this.dgvChiTietBan.OptionsDetail.DetailMode = DevExpress.XtraGrid.Views.Grid.DetailMode.Default;
            this.dgvChiTietBan.OptionsView.ShowGroupPanel = false;
            // 
            // TenMA
            // 
            this.TenMA.AppearanceCell.BackColor = System.Drawing.Color.White;
            this.TenMA.AppearanceCell.BackColor2 = System.Drawing.Color.White;
            this.TenMA.AppearanceCell.ForeColor = System.Drawing.Color.Blue;
            this.TenMA.AppearanceCell.Options.UseBackColor = true;
            this.TenMA.AppearanceCell.Options.UseForeColor = true;
            this.TenMA.Caption = "Tên Món Ăn";
            this.TenMA.FieldName = "TenMA";
            this.TenMA.Name = "TenMA";
            this.TenMA.Visible = true;
            this.TenMA.VisibleIndex = 0;
            this.TenMA.Width = 192;
            // 
            // SoLuong
            // 
            this.SoLuong.AppearanceCell.BackColor = System.Drawing.Color.White;
            this.SoLuong.AppearanceCell.BackColor2 = System.Drawing.Color.White;
            this.SoLuong.AppearanceCell.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.SoLuong.AppearanceCell.Options.UseBackColor = true;
            this.SoLuong.AppearanceCell.Options.UseForeColor = true;
            this.SoLuong.Caption = "Số Lượng";
            this.SoLuong.FieldName = "SoLuong";
            this.SoLuong.Name = "SoLuong";
            this.SoLuong.Visible = true;
            this.SoLuong.VisibleIndex = 1;
            this.SoLuong.Width = 192;
            // 
            // ThanhTien
            // 
            this.ThanhTien.AppearanceCell.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ThanhTien.AppearanceCell.Options.UseForeColor = true;
            this.ThanhTien.Caption = "Thành Tiền";
            this.ThanhTien.FieldName = "ThanhTien";
            this.ThanhTien.Name = "ThanhTien";
            this.ThanhTien.Visible = true;
            this.ThanhTien.VisibleIndex = 2;
            this.ThanhTien.Width = 186;
            // 
            // DonViTinh
            // 
            this.DonViTinh.Caption = "Đơn Vị tính";
            this.DonViTinh.FieldName = "DonViTinh";
            this.DonViTinh.Name = "DonViTinh";
            this.DonViTinh.Visible = true;
            this.DonViTinh.VisibleIndex = 3;
            this.DonViTinh.Width = 179;
            // 
            // btn_delete
            // 
            this.btn_delete.AutoHeight = false;
            this.btn_delete.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, ((System.Drawing.Image)(resources.GetObject("btn_delete.Buttons"))), new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, "", null, null, true)});
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            // 
            // btnThongKeTheoMon
            // 
            this.btnThongKeTheoMon.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThongKeTheoMon.Appearance.Options.UseFont = true;
            this.btnThongKeTheoMon.Image = ((System.Drawing.Image)(resources.GetObject("btnThongKeTheoMon.Image")));
            this.btnThongKeTheoMon.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.btnThongKeTheoMon.Location = new System.Drawing.Point(1666, 592);
            this.btnThongKeTheoMon.Name = "btnThongKeTheoMon";
            this.btnThongKeTheoMon.Size = new System.Drawing.Size(202, 76);
            this.btnThongKeTheoMon.TabIndex = 28;
            this.btnThongKeTheoMon.Text = "Thống kê theo món";
            this.btnThongKeTheoMon.Click += new System.EventHandler(this.btnThongKeTheoMon_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Sitka Text", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(326, 752);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 35);
            this.label8.TabIndex = 29;
            this.label8.Text = "VND";
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.WorkerReportsProgress = true;
            this.backgroundWorker1.WorkerSupportsCancellation = true;
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker1_ProgressChanged);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // btnExport
            // 
            this.btnExport.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExport.Appearance.Options.UseFont = true;
            this.btnExport.Location = new System.Drawing.Point(833, 605);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(160, 45);
            this.btnExport.TabIndex = 30;
            this.btnExport.Text = "Export to Exel";
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Location = new System.Drawing.Point(1423, 761);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(103, 20);
            this.lblStatus.TabIndex = 31;
            this.lblStatus.Text = "Process ...%";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(1627, 751);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(223, 33);
            this.progressBar1.TabIndex = 32;
            // 
            // btndeleteHDB
            // 
            this.btndeleteHDB.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndeleteHDB.Appearance.Options.UseFont = true;
            this.btndeleteHDB.Location = new System.Drawing.Point(648, 605);
            this.btndeleteHDB.Name = "btndeleteHDB";
            this.btndeleteHDB.Size = new System.Drawing.Size(160, 45);
            this.btndeleteHDB.TabIndex = 33;
            this.btndeleteHDB.Text = "Clear HDB";
            this.btndeleteHDB.Click += new System.EventHandler(this.btndeleteHDB_Click);
            // 
            // ThongKeHDB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btndeleteHDB);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnThongKeTheoMon);
            this.Controls.Add(this.dgvChiTietBanMain);
            this.Controls.Add(this.txtGiamGia);
            this.Controls.Add(this.txtTienThuVe);
            this.Controls.Add(this.txtTongSoMon);
            this.Controls.Add(this.txtTongTien);
            this.Controls.Add(this.txtTongHoaDon);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dtptoDay);
            this.Controls.Add(this.btnThongKe);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvHoaDonBanMain);
            this.Controls.Add(this.dtpfromDay);
            this.Controls.Add(this.label1);
            this.Name = "ThongKeHDB";
            this.Size = new System.Drawing.Size(1881, 798);
            this.Load += new System.EventHandler(this.frmThongKeHDB_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoaDonBanMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoaDonBan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTietBanMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTietBan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_delete)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpfromDay;
        private DevExpress.XtraGrid.GridControl dgvHoaDonBanMain;
        private DevExpress.XtraGrid.Views.Grid.GridView dgvHoaDonBan;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraEditors.SimpleButton btnThongKe;
        private System.Windows.Forms.DateTimePicker dtptoDay;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label txtTongHoaDon;
        private System.Windows.Forms.Label txtTongTien;
        private System.Windows.Forms.Label txtTongSoMon;
        private System.Windows.Forms.Label txtTienThuVe;
        private System.Windows.Forms.Label txtGiamGia;
        private DevExpress.XtraGrid.Columns.GridColumn MaHDB;
        private DevExpress.XtraGrid.Columns.GridColumn MaNV;
        private DevExpress.XtraGrid.Columns.GridColumn MaKH;
        private DevExpress.XtraGrid.Columns.GridColumn NgayBan;
        private DevExpress.XtraGrid.Columns.GridColumn TongTien;
        private DevExpress.XtraGrid.GridControl dgvChiTietBanMain;
        private DevExpress.XtraGrid.Views.Grid.GridView dgvChiTietBan;
        private DevExpress.XtraGrid.Columns.GridColumn TenMA;
        private DevExpress.XtraGrid.Columns.GridColumn SoLuong;
        private DevExpress.XtraGrid.Columns.GridColumn ThanhTien;
        private DevExpress.XtraGrid.Columns.GridColumn DonViTinh;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btn_delete;
        private DevExpress.XtraGrid.Columns.GridColumn GiamGia;
        private DevExpress.XtraEditors.SimpleButton btnThongKeTheoMon;
        private System.Windows.Forms.Label label8;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private DevExpress.XtraEditors.SimpleButton btnExport;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.ProgressBar progressBar1;
        private DevExpress.XtraEditors.SimpleButton btndeleteHDB;
    }
}
