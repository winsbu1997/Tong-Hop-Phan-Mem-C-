namespace QuanLiNhaHang.GUI
{
    partial class ThongKeHDN
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ThongKeHDN));
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.dgvChiTietNhapMain = new DevExpress.XtraGrid.GridControl();
            this.dgvChiTietNhap = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.TenNL = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SoLuong = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ThanhTien = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DonViTinh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btn_delete = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.txtTongTien = new System.Windows.Forms.Label();
            this.txtTongSoNL = new System.Windows.Forms.Label();
            this.txtTongHoaDon = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnThongKeTheoNL = new DevExpress.XtraEditors.SimpleButton();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.btndeleteHDN = new DevExpress.XtraEditors.SimpleButton();
            this.lblStatus = new System.Windows.Forms.Label();
            this.btnExport = new DevExpress.XtraEditors.SimpleButton();
            this.label11 = new System.Windows.Forms.Label();
            this.dgvHoaDonNhapMain = new DevExpress.XtraGrid.GridControl();
            this.dgvHoaDonNhap = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.MaHDN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.MaNV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NgayNhap = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GhiChu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TongTien = new DevExpress.XtraGrid.Columns.GridColumn();
            this.dtpfromDay = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dtptoDay = new System.Windows.Forms.DateTimePicker();
            this.btnThongKe = new DevExpress.XtraEditors.SimpleButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTietNhapMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTietNhap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_delete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoaDonNhapMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoaDonNhap)).BeginInit();
            this.SuspendLayout();
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(1689, 726);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(181, 30);
            this.progressBar1.TabIndex = 58;
            // 
            // dgvChiTietNhapMain
            // 
            this.dgvChiTietNhapMain.Font = new System.Drawing.Font(".VnSouthern", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvChiTietNhapMain.Location = new System.Drawing.Point(1101, 151);
            this.dgvChiTietNhapMain.MainView = this.dgvChiTietNhap;
            this.dgvChiTietNhapMain.Name = "dgvChiTietNhapMain";
            this.dgvChiTietNhapMain.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.btn_delete});
            this.dgvChiTietNhapMain.Size = new System.Drawing.Size(769, 384);
            this.dgvChiTietNhapMain.TabIndex = 53;
            this.dgvChiTietNhapMain.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.dgvChiTietNhap});
            // 
            // dgvChiTietNhap
            // 
            this.dgvChiTietNhap.Appearance.Preview.BackColor = System.Drawing.Color.Lime;
            this.dgvChiTietNhap.Appearance.Preview.Options.UseBackColor = true;
            this.dgvChiTietNhap.Appearance.Row.BackColor = System.Drawing.Color.White;
            this.dgvChiTietNhap.Appearance.Row.BorderColor = System.Drawing.Color.White;
            this.dgvChiTietNhap.Appearance.Row.ForeColor = System.Drawing.Color.Lime;
            this.dgvChiTietNhap.Appearance.Row.Options.UseBackColor = true;
            this.dgvChiTietNhap.Appearance.Row.Options.UseBorderColor = true;
            this.dgvChiTietNhap.Appearance.Row.Options.UseForeColor = true;
            this.dgvChiTietNhap.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.TenNL,
            this.SoLuong,
            this.ThanhTien,
            this.DonViTinh});
            this.dgvChiTietNhap.GridControl = this.dgvChiTietNhapMain;
            this.dgvChiTietNhap.Name = "dgvChiTietNhap";
            this.dgvChiTietNhap.OptionsBehavior.ReadOnly = true;
            this.dgvChiTietNhap.OptionsDetail.DetailMode = DevExpress.XtraGrid.Views.Grid.DetailMode.Default;
            this.dgvChiTietNhap.OptionsView.ShowGroupPanel = false;
            // 
            // TenNL
            // 
            this.TenNL.AppearanceCell.BackColor = System.Drawing.Color.White;
            this.TenNL.AppearanceCell.BackColor2 = System.Drawing.Color.White;
            this.TenNL.AppearanceCell.ForeColor = System.Drawing.Color.Blue;
            this.TenNL.AppearanceCell.Options.UseBackColor = true;
            this.TenNL.AppearanceCell.Options.UseForeColor = true;
            this.TenNL.Caption = "Tên Nguyên Liệu";
            this.TenNL.FieldName = "TenNL";
            this.TenNL.Name = "TenNL";
            this.TenNL.Visible = true;
            this.TenNL.VisibleIndex = 0;
            this.TenNL.Width = 192;
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
            this.ThanhTien.Caption = "Thành Tiên";
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
            // txtTongTien
            // 
            this.txtTongTien.AutoSize = true;
            this.txtTongTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTongTien.Location = new System.Drawing.Point(171, 687);
            this.txtTongTien.Name = "txtTongTien";
            this.txtTongTien.Size = new System.Drawing.Size(102, 29);
            this.txtTongTien.TabIndex = 51;
            this.txtTongTien.Text = "_ _ _ _ _";
            // 
            // txtTongSoNL
            // 
            this.txtTongSoNL.AutoSize = true;
            this.txtTongSoNL.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTongSoNL.Location = new System.Drawing.Point(1376, 586);
            this.txtTongSoNL.Name = "txtTongSoNL";
            this.txtTongSoNL.Size = new System.Drawing.Size(102, 29);
            this.txtTongSoNL.TabIndex = 50;
            this.txtTongSoNL.Text = "_ _ _ _ _";
            // 
            // txtTongHoaDon
            // 
            this.txtTongHoaDon.AutoSize = true;
            this.txtTongHoaDon.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTongHoaDon.Location = new System.Drawing.Point(307, 565);
            this.txtTongHoaDon.Name = "txtTongHoaDon";
            this.txtTongHoaDon.Size = new System.Drawing.Size(102, 29);
            this.txtTongHoaDon.TabIndex = 48;
            this.txtTongHoaDon.Text = "_ _ _ _ _";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Sitka Text", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(297, 681);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 35);
            this.label8.TabIndex = 55;
            this.label8.Text = "VND";
            // 
            // btnThongKeTheoNL
            // 
            this.btnThongKeTheoNL.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThongKeTheoNL.Appearance.Options.UseFont = true;
            this.btnThongKeTheoNL.Image = ((System.Drawing.Image)(resources.GetObject("btnThongKeTheoNL.Image")));
            this.btnThongKeTheoNL.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.btnThongKeTheoNL.Location = new System.Drawing.Point(1648, 546);
            this.btnThongKeTheoNL.Name = "btnThongKeTheoNL";
            this.btnThongKeTheoNL.Size = new System.Drawing.Size(222, 79);
            this.btnThongKeTheoNL.TabIndex = 54;
            this.btnThongKeTheoNL.Text = "Thống kê Nguyên Liệu";
            this.btnThongKeTheoNL.Click += new System.EventHandler(this.btnThongKeTheoNL_Click);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.WorkerReportsProgress = true;
            this.backgroundWorker1.WorkerSupportsCancellation = true;
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // btndeleteHDN
            // 
            this.btndeleteHDN.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndeleteHDN.Appearance.Options.UseFont = true;
            this.btndeleteHDN.Location = new System.Drawing.Point(650, 580);
            this.btndeleteHDN.Name = "btndeleteHDN";
            this.btndeleteHDN.Size = new System.Drawing.Size(160, 45);
            this.btndeleteHDN.TabIndex = 59;
            this.btndeleteHDN.Text = "Clear HDN";
            this.btndeleteHDN.Click += new System.EventHandler(this.btndeleteHDN_Click);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Location = new System.Drawing.Point(1514, 736);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(103, 20);
            this.lblStatus.TabIndex = 57;
            this.lblStatus.Text = "Process ...%";
            // 
            // btnExport
            // 
            this.btnExport.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExport.Appearance.Options.UseFont = true;
            this.btnExport.Location = new System.Drawing.Point(835, 580);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(160, 45);
            this.btnExport.TabIndex = 56;
            this.btnExport.Text = "Export to Exel";
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(12, 569);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(228, 25);
            this.label11.TabIndex = 47;
            this.label11.Text = "Tổng Số Hóa Đơn Nhập:";
            // 
            // dgvHoaDonNhapMain
            // 
            this.dgvHoaDonNhapMain.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvHoaDonNhapMain.Location = new System.Drawing.Point(5, 151);
            this.dgvHoaDonNhapMain.MainView = this.dgvHoaDonNhap;
            this.dgvHoaDonNhapMain.Name = "dgvHoaDonNhapMain";
            this.dgvHoaDonNhapMain.Size = new System.Drawing.Size(990, 384);
            this.dgvHoaDonNhapMain.TabIndex = 36;
            this.dgvHoaDonNhapMain.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.dgvHoaDonNhap});
            // 
            // dgvHoaDonNhap
            // 
            this.dgvHoaDonNhap.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.MaHDN,
            this.MaNV,
            this.NgayNhap,
            this.GhiChu,
            this.TongTien});
            this.dgvHoaDonNhap.GridControl = this.dgvHoaDonNhapMain;
            this.dgvHoaDonNhap.Name = "dgvHoaDonNhap";
            this.dgvHoaDonNhap.OptionsBehavior.ReadOnly = true;
            this.dgvHoaDonNhap.OptionsDetail.DetailMode = DevExpress.XtraGrid.Views.Grid.DetailMode.Default;
            this.dgvHoaDonNhap.OptionsView.ShowGroupPanel = false;
            this.dgvHoaDonNhap.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.dgvHoaDonNhap_FocusedRowChanged);
            // 
            // MaHDN
            // 
            this.MaHDN.Caption = "MaHDN";
            this.MaHDN.FieldName = "MaHDN";
            this.MaHDN.Name = "MaHDN";
            this.MaHDN.Visible = true;
            this.MaHDN.VisibleIndex = 0;
            this.MaHDN.Width = 125;
            // 
            // MaNV
            // 
            this.MaNV.Caption = "Nhân Viên Nhập";
            this.MaNV.FieldName = "MaNV";
            this.MaNV.Name = "MaNV";
            this.MaNV.Visible = true;
            this.MaNV.VisibleIndex = 1;
            this.MaNV.Width = 218;
            // 
            // NgayNhap
            // 
            this.NgayNhap.Caption = "Ngày Nhập";
            this.NgayNhap.FieldName = "NgayNhap";
            this.NgayNhap.Name = "NgayNhap";
            this.NgayNhap.Visible = true;
            this.NgayNhap.VisibleIndex = 2;
            this.NgayNhap.Width = 169;
            // 
            // GhiChu
            // 
            this.GhiChu.Caption = "Ghi chú";
            this.GhiChu.FieldName = "GhiChu";
            this.GhiChu.Name = "GhiChu";
            this.GhiChu.Visible = true;
            this.GhiChu.VisibleIndex = 3;
            this.GhiChu.Width = 138;
            // 
            // TongTien
            // 
            this.TongTien.Caption = "Tổng tiền";
            this.TongTien.FieldName = "TongTien";
            this.TongTien.Name = "TongTien";
            this.TongTien.Visible = true;
            this.TongTien.VisibleIndex = 4;
            this.TongTien.Width = 110;
            // 
            // dtpfromDay
            // 
            this.dtpfromDay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpfromDay.Location = new System.Drawing.Point(810, 37);
            this.dtpfromDay.Name = "dtpfromDay";
            this.dtpfromDay.Size = new System.Drawing.Size(113, 22);
            this.dtpfromDay.TabIndex = 35;
            this.dtpfromDay.ValueChanged += new System.EventHandler(this.dtpfromDay_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Rockwell", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(1, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(351, 33);
            this.label1.TabIndex = 34;
            this.label1.Text = "Thống kê Hóa Đơn Nhập";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(1096, 589);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(261, 25);
            this.label9.TabIndex = 45;
            this.label9.Text = "Tổng Số Nguyên Liệu Nhập:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(58, 629);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(328, 17);
            this.label6.TabIndex = 43;
            this.label6.Text = "----------------------------------------------------------------";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(56, 691);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 25);
            this.label5.TabIndex = 42;
            this.label5.Text = "Tiền Nhập:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Rockwell", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(1512, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(348, 33);
            this.label4.TabIndex = 41;
            this.label4.Text = "Thống kê Chi Tiết Nhập";
            // 
            // dtptoDay
            // 
            this.dtptoDay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtptoDay.Location = new System.Drawing.Point(1151, 39);
            this.dtptoDay.Name = "dtptoDay";
            this.dtptoDay.Size = new System.Drawing.Size(116, 22);
            this.dtptoDay.TabIndex = 40;
            this.dtptoDay.ValueChanged += new System.EventHandler(this.dtptoDay_ValueChanged);
            // 
            // btnThongKe
            // 
            this.btnThongKe.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThongKe.Appearance.Options.UseFont = true;
            this.btnThongKe.Location = new System.Drawing.Point(1372, 33);
            this.btnThongKe.Name = "btnThongKe";
            this.btnThongKe.Size = new System.Drawing.Size(97, 34);
            this.btnThongKe.TabIndex = 39;
            this.btnThongKe.Text = "Thống kê";
            this.btnThongKe.Click += new System.EventHandler(this.btnThongKe_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(998, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 20);
            this.label3.TabIndex = 38;
            this.label3.Text = "đến ngày";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(600, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 20);
            this.label2.TabIndex = 37;
            this.label2.Text = "Từ ngày:";
            // 
            // ThongKeHDN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.dgvChiTietNhapMain);
            this.Controls.Add(this.txtTongTien);
            this.Controls.Add(this.txtTongSoNL);
            this.Controls.Add(this.txtTongHoaDon);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnThongKeTheoNL);
            this.Controls.Add(this.btndeleteHDN);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.dgvHoaDonNhapMain);
            this.Controls.Add(this.dtpfromDay);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dtptoDay);
            this.Controls.Add(this.btnThongKe);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "ThongKeHDN";
            this.Size = new System.Drawing.Size(1881, 798);
            this.Load += new System.EventHandler(this.ThongKeHDN_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTietNhapMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTietNhap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_delete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoaDonNhapMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoaDonNhap)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar progressBar1;
        private DevExpress.XtraGrid.GridControl dgvChiTietNhapMain;
        private DevExpress.XtraGrid.Views.Grid.GridView dgvChiTietNhap;
        private DevExpress.XtraGrid.Columns.GridColumn TenNL;
        private DevExpress.XtraGrid.Columns.GridColumn SoLuong;
        private DevExpress.XtraGrid.Columns.GridColumn ThanhTien;
        private DevExpress.XtraGrid.Columns.GridColumn DonViTinh;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btn_delete;
        private System.Windows.Forms.Label txtTongTien;
        private System.Windows.Forms.Label txtTongSoNL;
        private System.Windows.Forms.Label txtTongHoaDon;
        private System.Windows.Forms.Label label8;
        private DevExpress.XtraEditors.SimpleButton btnThongKeTheoNL;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private DevExpress.XtraEditors.SimpleButton btndeleteHDN;
        private System.Windows.Forms.Label lblStatus;
        private DevExpress.XtraEditors.SimpleButton btnExport;
        private System.Windows.Forms.Label label11;
        private DevExpress.XtraGrid.GridControl dgvHoaDonNhapMain;
        private DevExpress.XtraGrid.Views.Grid.GridView dgvHoaDonNhap;
        private DevExpress.XtraGrid.Columns.GridColumn MaHDN;
        private DevExpress.XtraGrid.Columns.GridColumn MaNV;
        private DevExpress.XtraGrid.Columns.GridColumn NgayNhap;
        private DevExpress.XtraGrid.Columns.GridColumn GhiChu;
        private DevExpress.XtraGrid.Columns.GridColumn TongTien;
        private System.Windows.Forms.DateTimePicker dtpfromDay;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtptoDay;
        private DevExpress.XtraEditors.SimpleButton btnThongKe;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}
