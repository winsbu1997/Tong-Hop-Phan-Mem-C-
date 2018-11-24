using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using QuanLyQuanCafe.DAO;
using QuanLyQuanCafe.DTO;
using QuanLyQuanCafe.GUI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyQuanCafe
{
    public partial class FrmMain : Form
    {
        private System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
        private int isDangNhap = 0;
    
        public FrmMain()
        {
            InitializeComponent();
        }

        #region Load Form

        private void LoadDanhSachBanAn()
        {
            panelMainControl.Controls.Clear();
            /// lấy được danh sách bàn ăn
            List<DTO.BanAnDTO> dsBanAn = new List<DTO.BanAnDTO>();
            dsBanAn = DAO.BanAnDAO.DanhSachBanAnList();

            foreach (BanAnDTO BanAn  in dsBanAn)
            {
                SimpleButton btnBanAn = new SimpleButton();
                btnBanAn.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
                btnBanAn.Appearance.ForeColor = System.Drawing.Color.Black;
                btnBanAn.Appearance.Options.UseFont = true;
                btnBanAn.Appearance.Options.UseForeColor = true;
                btnBanAn.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
                
                if (BanAn.TrangThai > 0) btnBanAn.Image = ((System.Drawing.Image)(resources.GetObject("btn1.Image")));
                else btnBanAn.Image = ((System.Drawing.Image)(resources.GetObject("btn2.Image")));
                
                btnBanAn.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter;
                btnBanAn.Margin = new System.Windows.Forms.Padding(10, 10, 0, 0);
                btnBanAn.Name = "BtnBanAn" + BanAn.MaBA.ToString();
                btnBanAn.Size = new System.Drawing.Size(108, 76);
                btnBanAn.Text = BanAn.TenBA;

                btnBanAn.Click += btnBanAn_Click;
                btnBanAn.Tag = BanAn;

                panelMainControl.Controls.Add(btnBanAn);
            }
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            isDangNhap = 0;
            barQuanLyDangXuat.Visibility = BarItemVisibility.Never;
            barQuanLyDoiMatKhau.Visibility = BarItemVisibility.Never;
            barQuanLyMatHang.Visibility = BarItemVisibility.Never;
            barQuanLyNhanVien.Visibility = BarItemVisibility.Never;
            barQuanLyThongTinNhaHang.Visibility = BarItemVisibility.Never;
            barQuanLyThongTinChiTieu.Visibility = BarItemVisibility.Never;
            barQuanLyThongKeBanHang.Visibility = BarItemVisibility.Never;
            barQuanLyBanAn.Visibility = BarItemVisibility.Never;
            //.Visibility = BarItemVisibility.Never;

            LoadDanhSachBanAn();
        }
        #endregion

        #region đăng nhập - đăng xuất delegate
        private void dangnhapthanhcong()
        {
            isDangNhap = 1;
            barQuanLyDangXuat.Visibility = BarItemVisibility.Always;
            barQuanLyDoiMatKhau.Visibility = BarItemVisibility.Always;
            barQuanLyMatHang.Visibility = BarItemVisibility.Always;
            barQuanLyNhanVien.Visibility = BarItemVisibility.Always;
            barQuanLyThongTinNhaHang.Visibility = BarItemVisibility.Always;
            barQuanLyThongTinChiTieu.Visibility = BarItemVisibility.Always;
            barQuanLyThongKeBanHang.Visibility = BarItemVisibility.Always;
            barQuanLyBanAn.Visibility = BarItemVisibility.Always;
            barQuanLyDangNhap.Visibility = BarItemVisibility.Never;
        }

        private void dangxuatthanhcong()
        {
            isDangNhap = 0;
            barQuanLyDangXuat.Visibility = BarItemVisibility.Never;
            barQuanLyDoiMatKhau.Visibility = BarItemVisibility.Never;
            barQuanLyMatHang.Visibility = BarItemVisibility.Never;
            barQuanLyNhanVien.Visibility = BarItemVisibility.Never;
            barQuanLyThongTinNhaHang.Visibility = BarItemVisibility.Never;
            barQuanLyThongTinChiTieu.Visibility = BarItemVisibility.Never;
            barQuanLyThongKeBanHang.Visibility = BarItemVisibility.Never;
            barQuanLyBanAn.Visibility = BarItemVisibility.Never;
            barQuanLyDangNhap.Visibility = BarItemVisibility.Always;
        }

        #endregion

        #region sự kiện mở form khác
        private void barQuanLyDangNhap_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Helper.DangNhapThanhCong DangNhapTC = new Helper.DangNhapThanhCong(dangnhapthanhcong);
            FrmDangNhap dangnhap = new FrmDangNhap(DangNhapTC);
            dangnhap.ShowDialog();
        }

        private void barQuanLyMatHang_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmQuanLyMatHang mathang = new FrmQuanLyMatHang();
            mathang.ShowDialog();
        }

        private void barQuanLyThongTinNhaHang_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmThongTinNhaHang thongtin = new FrmThongTinNhaHang();
            thongtin.ShowDialog();
        }

        private void barQuanLyDangXuat_ItemClick(object sender, ItemClickEventArgs e)
        {
            MessageBox.Show("Đăng xuất thành công");
            dangxuatthanhcong();
        }

        private void barQuanLyDoiMatKhau_ItemClick(object sender, ItemClickEventArgs e)
        {
            FrmDoiMatKhau doimatkhau = new FrmDoiMatKhau();
            doimatkhau.ShowDialog();
        }

        private void barQuanLyBanAn_ItemClick(object sender, ItemClickEventArgs e)
        {
            FrmQuanLyBanAn banan = new FrmQuanLyBanAn();
            banan.ShowDialog();
        }

        private void barQuanLyNhanVien_ItemClick(object sender, ItemClickEventArgs e)
        {
            FrmQuanLyNhanVien nhanvien = new FrmQuanLyNhanVien();
            nhanvien.ShowDialog();
        }

        private void barMuaBanNhapHang_ItemClick(object sender, ItemClickEventArgs e)
        {
            FrmNhapHang nhaphang = new FrmNhapHang();
            nhaphang.ShowDialog();
        }

        private void barMuaBanThongTinKho_ItemClick(object sender, ItemClickEventArgs e)
        {
            FrmQuanLyKho quanlykho = new FrmQuanLyKho();
            quanlykho.ShowDialog();
        }
        #endregion

        #region Methods
        int HienThiHoaDon(int idtable)
        {
            DataTable data = ChiTietBan.HienThiHoaDon(idtable);
            dgvChiTietNhapMain.DataSource = data;
            TongTien((int)HoaDonBanDAO.LayHoaDonTheoBan(idtable));
            return data.Rows.Count;
        }
        void LayDanhSachMatHang()
        {
            cboDanhSachMatHang.DataSource = MatHangDAO.DanhSachMatHang();
            cboDanhSachMatHang.DisplayMember = "TENMH";
            cboDanhSachMatHang.ValueMember = "MAMH";
        }
        void LayDanhSachBanTrong()
        {
            cboChuyenBan.DataSource = BanAnDAO.DanhSachBanTrong();
            cboChuyenBan.DisplayMember = "TENBA";
            cboChuyenBan.ValueMember = "MABA";
        }
        void TongTien(int mahdb)
        {
            double tongtien = ChiTietBan.TongTien(mahdb);

            CultureInfo culture = new CultureInfo("vi-VN");

            //Thread.CurrentThread.CurrentCulture = culture;

            txbTongTien.Text = tongtien.ToString("c", culture);
        }

        void ChangeImageTable(int idtable, int check)
        {
            if(check == 0)
            {
                SimpleButton btntemp = groupControl1.Tag as SimpleButton;
                btntemp.Image = ((System.Drawing.Image)(resources.GetObject("btn2.Image")));
                BanAnDAO.SuaTrangThaiBA(idtable, check);
            }
            else
            {
                SimpleButton btntemp = groupControl1.Tag as SimpleButton;
                btntemp.Image = ((System.Drawing.Image)(resources.GetObject("btn1.Image")));
                BanAnDAO.SuaTrangThaiBA(idtable, check);
            }
            LayDanhSachBanTrong();
        }

        #endregion

        #region Events
        private void btnBanAn_Click(object sender, EventArgs e)
        {
            int idtable = ((sender as SimpleButton).Tag as BanAnDTO).MaBA;
            dgvChiTietNhapMain.Tag = idtable;
            groupControl1.Text = "Thông tin " + ((sender as SimpleButton).Tag as BanAnDTO).TenBA.ToString();
            groupControl1.Tag = (sender as SimpleButton);
            HienThiHoaDon(idtable);
        }
        private void FrmMain_Activated(object sender, EventArgs e)
        {
            LayDanhSachMatHang();
            LayDanhSachBanTrong();
        }
        private void btnDatMon_Click(object sender, EventArgs e)
        {
            int idtable = (int)dgvChiTietNhapMain.Tag;
            int mamh = (int)cboDanhSachMatHang.SelectedValue;
            int soluong = (int)SpinEditSoLuong.Value;

            int mahdb = HoaDonBanDAO.LayHoaDonTheoBan(idtable);

            if (mahdb == -1)
            {
                HoaDonBanDAO.InsertHoaDonBan(idtable);
                ChiTietBan.InsertChiTietBan(HoaDonBanDAO.LayHoaDonBanMax(), mamh, soluong);
                mahdb = HoaDonBanDAO.LayHoaDonTheoBan(idtable);
                ChangeImageTable(idtable, 1);
            }
            else
            {
                ChiTietBan.InsertChiTietBan(mahdb, mamh, soluong);
            }
            HienThiHoaDon(idtable);
            TongTien(mahdb);
        }
        private void btnTraMon_Click(object sender, EventArgs e)
        {
            int idtable = (int)dgvChiTietNhapMain.Tag;
            int mahdb = (int)HoaDonBanDAO.LayHoaDonTheoBan(idtable);
            int mamh = (int)cboDanhSachMatHang.SelectedValue;
            int soluong = (int)SpinEditSoLuong.Value;

            if (mahdb == -1)
            {
                MessageBox.Show("Không có món, không thể trả món", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                ChiTietBan.TraMon(mahdb, mamh, soluong);
            }
            if(HienThiHoaDon(idtable) == 0)
            {
                HoaDonBanDAO.DeleteHoaDonBan(idtable);
                ChangeImageTable(idtable, 0);
            }
            TongTien(mahdb);
        }
        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            try
            {
                int idtable = (int)dgvChiTietNhapMain.Tag;
                int mahdb = (int)HoaDonBanDAO.LayHoaDonTheoBan(idtable);
                ChiTietBan.DeleteChiTietBan(mahdb);
                HoaDonBanDAO.DeleteHoaDonBan(idtable);
                MessageBox.Show("Thanh toán thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                HienThiHoaDon(idtable);
                TongTien(mahdb);
                ChangeImageTable(idtable, 0);
            }
            catch 
            {
            	
            }         
        }
        private void btnChuyenBan_Click(object sender, EventArgs e)
        {
            int idtable_old = (int)dgvChiTietNhapMain.Tag;
            int idtable_new = (int)cboChuyenBan.SelectedValue;
            HoaDonBanDAO.ChuyenBan(idtable_old, idtable_new);
            ChangeImageTable(idtable_old, 0);
            ChangeImageTable(idtable_new, 1);
            LoadDanhSachBanAn();
            HienThiHoaDon(idtable_new);
            LayDanhSachBanTrong();
            groupControl1.Text = "Thông tin bàn " + idtable_new.ToString();
        }
        #endregion


    }
}
