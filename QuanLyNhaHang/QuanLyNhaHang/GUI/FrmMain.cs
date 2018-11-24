using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTL_CNPM.GUI
{
    public partial class FrmMain : MetroForm
    {
        public FrmMain()
        {
            InitializeComponent();
        }


        #region Sự kiện
        private void barNhapHang_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ucNhapHang uc = new ucNhapHang();
            uc.Dock = DockStyle.Fill;
            panelMain.Controls.Clear();
            panelMain.Controls.Add(uc);
        }

        private void barBanHang_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            panelMain.Controls.Clear();
            ucBanHang uc = new ucBanHang();
            uc.Dock = DockStyle.Fill;
            panelMain.Controls.Add(uc);
        }

        private void barKho_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            panelMain.Controls.Clear();
            ucKho uc = new ucKho();
            uc.Dock = DockStyle.Fill;
            panelMain.Controls.Add(uc);
        }

        private void barThongTinCaNhan_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmThongTinCaNhan form = new FrmThongTinCaNhan();
            form.ShowDialog();
        }

        private void barDoiMatKhau_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmDoiMatKhau form = new FrmDoiMatKhau();
            form.ShowDialog();
        }

        private void barNhanVien_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            panelMain.Controls.Clear();
            ucDanhSachNhanVien uc = new ucDanhSachNhanVien();
            uc.Dock = DockStyle.Fill;
            panelMain.Controls.Add(uc);
        }

        private void barMatHang_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            panelMain.Controls.Clear();
            ucDanhSachMatHang uc = new ucDanhSachMatHang();
            uc.Dock = DockStyle.Fill;
            panelMain.Controls.Add(uc);
        }

        private void barBanAn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            panelMain.Controls.Clear();
            ucDanhSachBanAn uc = new ucDanhSachBanAn();
            uc.Dock = DockStyle.Fill;
            panelMain.Controls.Add(uc);
        }

        private void barThongTinNhaHang_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmThongTinNhaHang form = new FrmThongTinNhaHang();
            form.ShowDialog();
        }
        #endregion

        private void FrmMain_Load(object sender, EventArgs e)
        {
            if (Helper.nhanvien.CHUCVU == 0) tabAdmin.Visible = false; else tabAdmin.Visible = true;

            panelMain.Controls.Clear();
            ucBanHang uc = new ucBanHang();
            uc.Dock = DockStyle.Fill;
            panelMain.Controls.Add(uc);
        }

        private void barDangXuat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DialogResult rs = MessageBox.Show("Bạn có chắc chắn đăng xuất", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (rs == DialogResult.Cancel) return;
            this.Close();
        }

        private void barThongKePhieuNhap_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            panelMain.Controls.Clear();
            ucThongKePhieuNhap uc = new ucThongKePhieuNhap();
            uc.Dock = DockStyle.Fill;
            panelMain.Controls.Add(uc);
        }

        private void barThongKeHoaDon_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            panelMain.Controls.Clear();
            ucThongKeHoaDon uc = new ucThongKeHoaDon();
            uc.Dock = DockStyle.Fill;
            panelMain.Controls.Add(uc);
        }

        private void barThongKeBanHang_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            panelMain.Controls.Clear();
            ucThongKeBanHang uc = new ucThongKeBanHang();
            uc.Dock = DockStyle.Fill;
            panelMain.Controls.Add(uc);
        }

        private void barKhuVucBan_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            panelMain.Controls.Clear();
            ucDanhSachKhuVucBan uc = new ucDanhSachKhuVucBan();
            uc.Dock = DockStyle.Fill;
            panelMain.Controls.Add(uc);
        }

        private void barLoaiMatHang_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            panelMain.Controls.Clear();
            ucDanhSachLoaiMatHang uc = new ucDanhSachLoaiMatHang();
            uc.Dock = DockStyle.Fill;
            panelMain.Controls.Add(uc);
        }
    }
}
