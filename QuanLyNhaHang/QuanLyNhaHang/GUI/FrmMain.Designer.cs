namespace BTL_CNPM.GUI
{
    partial class FrmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelMain = new System.Windows.Forms.Panel();
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.barNhanVien = new DevExpress.XtraBars.BarButtonItem();
            this.barMatHang = new DevExpress.XtraBars.BarButtonItem();
            this.barBanAn = new DevExpress.XtraBars.BarButtonItem();
            this.barNhapHang = new DevExpress.XtraBars.BarButtonItem();
            this.barBanHang = new DevExpress.XtraBars.BarButtonItem();
            this.barKho = new DevExpress.XtraBars.BarButtonItem();
            this.barThongKePhieuNhap = new DevExpress.XtraBars.BarButtonItem();
            this.barThongKeHoaDon = new DevExpress.XtraBars.BarButtonItem();
            this.barThongTinNhaHang = new DevExpress.XtraBars.BarButtonItem();
            this.barThongTinCaNhan = new DevExpress.XtraBars.BarButtonItem();
            this.barDoiMatKhau = new DevExpress.XtraBars.BarButtonItem();
            this.barDangXuat = new DevExpress.XtraBars.BarButtonItem();
            this.barThongKeBanHang = new DevExpress.XtraBars.BarButtonItem();
            this.tabNhanVien = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup4 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.tabAdmin = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.defaultLookAndFeel1 = new DevExpress.LookAndFeel.DefaultLookAndFeel(this.components);
            this.ribbonPageGroup5 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup6 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.barLoaiMatHang = new DevExpress.XtraBars.BarButtonItem();
            this.barKhuVucBan = new DevExpress.XtraBars.BarButtonItem();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.panelMain);
            this.panel1.Controls.Add(this.ribbonControl1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(20, 30);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1310, 690);
            this.panel1.TabIndex = 0;
            // 
            // panelMain
            // 
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelMain.Location = new System.Drawing.Point(0, 140);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(1308, 548);
            this.panelMain.TabIndex = 7;
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.barNhanVien,
            this.barMatHang,
            this.barBanAn,
            this.barNhapHang,
            this.barBanHang,
            this.barKho,
            this.barThongKePhieuNhap,
            this.barThongKeHoaDon,
            this.barThongTinNhaHang,
            this.barThongTinCaNhan,
            this.barDoiMatKhau,
            this.barDangXuat,
            this.barThongKeBanHang,
            this.barLoaiMatHang,
            this.barKhuVucBan});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 16;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.tabNhanVien,
            this.tabAdmin});
            this.ribbonControl1.Size = new System.Drawing.Size(1308, 140);
            // 
            // barNhanVien
            // 
            this.barNhanVien.Caption = "Nhân viên";
            this.barNhanVien.Glyph = ((System.Drawing.Image)(resources.GetObject("barNhanVien.Glyph")));
            this.barNhanVien.Id = 1;
            this.barNhanVien.Name = "barNhanVien";
            this.barNhanVien.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.barNhanVien.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barNhanVien_ItemClick);
            // 
            // barMatHang
            // 
            this.barMatHang.Caption = "Mặt hàng";
            this.barMatHang.Glyph = ((System.Drawing.Image)(resources.GetObject("barMatHang.Glyph")));
            this.barMatHang.Id = 2;
            this.barMatHang.Name = "barMatHang";
            this.barMatHang.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.barMatHang.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barMatHang_ItemClick);
            // 
            // barBanAn
            // 
            this.barBanAn.Caption = "Bàn ăn";
            this.barBanAn.Glyph = ((System.Drawing.Image)(resources.GetObject("barBanAn.Glyph")));
            this.barBanAn.Id = 3;
            this.barBanAn.Name = "barBanAn";
            this.barBanAn.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.barBanAn.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBanAn_ItemClick);
            // 
            // barNhapHang
            // 
            this.barNhapHang.Caption = "Nhập hàng";
            this.barNhapHang.Glyph = ((System.Drawing.Image)(resources.GetObject("barNhapHang.Glyph")));
            this.barNhapHang.Id = 4;
            this.barNhapHang.Name = "barNhapHang";
            this.barNhapHang.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.barNhapHang.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barNhapHang_ItemClick);
            // 
            // barBanHang
            // 
            this.barBanHang.Caption = "Bán hàng";
            this.barBanHang.Glyph = ((System.Drawing.Image)(resources.GetObject("barBanHang.Glyph")));
            this.barBanHang.Id = 5;
            this.barBanHang.Name = "barBanHang";
            this.barBanHang.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.barBanHang.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBanHang_ItemClick);
            // 
            // barKho
            // 
            this.barKho.Caption = "Kho";
            this.barKho.Glyph = ((System.Drawing.Image)(resources.GetObject("barKho.Glyph")));
            this.barKho.Id = 6;
            this.barKho.Name = "barKho";
            this.barKho.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.barKho.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barKho_ItemClick);
            // 
            // barThongKePhieuNhap
            // 
            this.barThongKePhieuNhap.Caption = "Thống kê phiếu nhập";
            this.barThongKePhieuNhap.Glyph = ((System.Drawing.Image)(resources.GetObject("barThongKePhieuNhap.Glyph")));
            this.barThongKePhieuNhap.Id = 7;
            this.barThongKePhieuNhap.Name = "barThongKePhieuNhap";
            this.barThongKePhieuNhap.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.barThongKePhieuNhap.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barThongKePhieuNhap_ItemClick);
            // 
            // barThongKeHoaDon
            // 
            this.barThongKeHoaDon.Caption = "Thống kê hóa đơn";
            this.barThongKeHoaDon.Glyph = ((System.Drawing.Image)(resources.GetObject("barThongKeHoaDon.Glyph")));
            this.barThongKeHoaDon.Id = 8;
            this.barThongKeHoaDon.Name = "barThongKeHoaDon";
            this.barThongKeHoaDon.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.barThongKeHoaDon.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barThongKeHoaDon_ItemClick);
            // 
            // barThongTinNhaHang
            // 
            this.barThongTinNhaHang.Caption = "Thông tin nhà hàng";
            this.barThongTinNhaHang.Glyph = ((System.Drawing.Image)(resources.GetObject("barThongTinNhaHang.Glyph")));
            this.barThongTinNhaHang.Id = 9;
            this.barThongTinNhaHang.Name = "barThongTinNhaHang";
            this.barThongTinNhaHang.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.barThongTinNhaHang.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barThongTinNhaHang_ItemClick);
            // 
            // barThongTinCaNhan
            // 
            this.barThongTinCaNhan.Caption = "Thông tin cá nhân";
            this.barThongTinCaNhan.Glyph = ((System.Drawing.Image)(resources.GetObject("barThongTinCaNhan.Glyph")));
            this.barThongTinCaNhan.Id = 10;
            this.barThongTinCaNhan.Name = "barThongTinCaNhan";
            this.barThongTinCaNhan.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.barThongTinCaNhan.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barThongTinCaNhan_ItemClick);
            // 
            // barDoiMatKhau
            // 
            this.barDoiMatKhau.Caption = "Đổi mật khẩu";
            this.barDoiMatKhau.Glyph = ((System.Drawing.Image)(resources.GetObject("barDoiMatKhau.Glyph")));
            this.barDoiMatKhau.Id = 11;
            this.barDoiMatKhau.Name = "barDoiMatKhau";
            this.barDoiMatKhau.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.barDoiMatKhau.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barDoiMatKhau_ItemClick);
            // 
            // barDangXuat
            // 
            this.barDangXuat.Caption = "Đăng xuất";
            this.barDangXuat.Glyph = ((System.Drawing.Image)(resources.GetObject("barDangXuat.Glyph")));
            this.barDangXuat.Id = 12;
            this.barDangXuat.Name = "barDangXuat";
            this.barDangXuat.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.barDangXuat.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barDangXuat_ItemClick);
            // 
            // barThongKeBanHang
            // 
            this.barThongKeBanHang.Caption = "Thống kê bán hàng";
            this.barThongKeBanHang.Glyph = ((System.Drawing.Image)(resources.GetObject("barThongKeBanHang.Glyph")));
            this.barThongKeBanHang.Id = 13;
            this.barThongKeBanHang.Name = "barThongKeBanHang";
            this.barThongKeBanHang.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.barThongKeBanHang.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barThongKeBanHang_ItemClick);
            // 
            // tabNhanVien
            // 
            this.tabNhanVien.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1,
            this.ribbonPageGroup4});
            this.tabNhanVien.Name = "tabNhanVien";
            this.tabNhanVien.Text = "Nhân viên";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.barNhapHang);
            this.ribbonPageGroup1.ItemLinks.Add(this.barBanHang);
            this.ribbonPageGroup1.ItemLinks.Add(this.barKho);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "Mua - bán hàng";
            // 
            // ribbonPageGroup4
            // 
            this.ribbonPageGroup4.ItemLinks.Add(this.barThongTinCaNhan);
            this.ribbonPageGroup4.ItemLinks.Add(this.barDoiMatKhau);
            this.ribbonPageGroup4.ItemLinks.Add(this.barDangXuat);
            this.ribbonPageGroup4.Name = "ribbonPageGroup4";
            this.ribbonPageGroup4.Text = "Tài khoản";
            // 
            // tabAdmin
            // 
            this.tabAdmin.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup2,
            this.ribbonPageGroup3});
            this.tabAdmin.Name = "tabAdmin";
            this.tabAdmin.Text = "Quản lý";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.barNhanVien);
            this.ribbonPageGroup2.ItemLinks.Add(this.barLoaiMatHang);
            this.ribbonPageGroup2.ItemLinks.Add(this.barMatHang);
            this.ribbonPageGroup2.ItemLinks.Add(this.barKhuVucBan);
            this.ribbonPageGroup2.ItemLinks.Add(this.barBanAn);
            this.ribbonPageGroup2.ItemLinks.Add(this.barThongTinNhaHang);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.Text = "Danh mục";
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.ItemLinks.Add(this.barThongKePhieuNhap);
            this.ribbonPageGroup3.ItemLinks.Add(this.barThongKeHoaDon);
            this.ribbonPageGroup3.ItemLinks.Add(this.barThongKeBanHang);
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            this.ribbonPageGroup3.Text = "Thống kê";
            // 
            // defaultLookAndFeel1
            // 
            this.defaultLookAndFeel1.LookAndFeel.SkinName = "Visual Studio 2013 Light";
            // 
            // ribbonPageGroup5
            // 
            this.ribbonPageGroup5.ItemLinks.Add(this.barNhapHang);
            this.ribbonPageGroup5.ItemLinks.Add(this.barBanHang);
            this.ribbonPageGroup5.Name = "ribbonPageGroup5";
            this.ribbonPageGroup5.Text = "Thống kê";
            // 
            // ribbonPageGroup6
            // 
            this.ribbonPageGroup6.ItemLinks.Add(this.barNhapHang);
            this.ribbonPageGroup6.ItemLinks.Add(this.barBanHang);
            this.ribbonPageGroup6.Name = "ribbonPageGroup6";
            this.ribbonPageGroup6.Text = "Thống kê";
            // 
            // barLoaiMatHang
            // 
            this.barLoaiMatHang.Caption = "Loại mặt hàng";
            this.barLoaiMatHang.Glyph = ((System.Drawing.Image)(resources.GetObject("barLoaiMatHang.Glyph")));
            this.barLoaiMatHang.Id = 14;
            this.barLoaiMatHang.Name = "barLoaiMatHang";
            this.barLoaiMatHang.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.barLoaiMatHang.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barLoaiMatHang_ItemClick);
            // 
            // barKhuVucBan
            // 
            this.barKhuVucBan.Caption = "Khu vực bàn";
            this.barKhuVucBan.Glyph = ((System.Drawing.Image)(resources.GetObject("barKhuVucBan.Glyph")));
            this.barKhuVucBan.Id = 15;
            this.barKhuVucBan.Name = "barKhuVucBan";
            this.barKhuVucBan.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.barKhuVucBan.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barKhuVucBan_ItemClick);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1350, 740);
            this.Controls.Add(this.panel1);
            this.DisplayHeader = false;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmMain";
            this.Padding = new System.Windows.Forms.Padding(20, 30, 20, 20);
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Silver;
            this.Text = "QUẢN LÝ NHÀ HÀNG";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage tabNhanVien;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.LookAndFeel.DefaultLookAndFeel defaultLookAndFeel1;
        private DevExpress.XtraBars.BarButtonItem barNhanVien;
        private DevExpress.XtraBars.Ribbon.RibbonPage tabAdmin;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.BarButtonItem barMatHang;
        private DevExpress.XtraBars.BarButtonItem barBanAn;
        private DevExpress.XtraBars.BarButtonItem barNhapHang;
        private DevExpress.XtraBars.BarButtonItem barBanHang;
        private DevExpress.XtraBars.BarButtonItem barKho;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private DevExpress.XtraBars.BarButtonItem barThongKePhieuNhap;
        private DevExpress.XtraBars.BarButtonItem barThongKeHoaDon;
        private DevExpress.XtraBars.BarButtonItem barThongTinNhaHang;
        private DevExpress.XtraBars.BarButtonItem barThongTinCaNhan;
        private DevExpress.XtraBars.BarButtonItem barDoiMatKhau;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup4;
        private System.Windows.Forms.Panel panelMain;
        private DevExpress.XtraBars.BarButtonItem barDangXuat;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup5;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup6;
        private DevExpress.XtraBars.BarButtonItem barThongKeBanHang;
        private DevExpress.XtraBars.BarButtonItem barLoaiMatHang;
        private DevExpress.XtraBars.BarButtonItem barKhuVucBan;
    }
}