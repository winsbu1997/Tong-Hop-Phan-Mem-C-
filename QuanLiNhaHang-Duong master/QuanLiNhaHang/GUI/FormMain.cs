using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars;
using DevExpress.XtraTab;
using DevExpress.XtraBars.Ribbon;

namespace QuanLiNhaHang.GUI
{
    public partial class FormMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        #region Properties
        #endregion
        public FormMain()
        {
            InitializeComponent();
            timer1.Start();
        }
        public static FormMain main = new FormMain();
        #region Method
        public void DangNhap()
        {
            frmDangNhap frm = new frmDangNhap();
            frm.ShowDialog();
            txtTenDangNhap.Text = frm.TenDN;
            if (txtTenDangNhap.Text == "admin") Dis_End(true);
            else Dis_End(false);
        }
        public void ThemTapPage(UserControl uct, string tenTap)
        {
            Model.Connection.close();
            for (int i = 0; i < tabHienThi.TabPages.Count; i++)
            {
                if (tabHienThi.TabPages[i].Contains(uct))
                {
                    tabHienThi.SelectedTabPage = tabHienThi.TabPages[i];
                    return;
                }
            }
            XtraTabPage tab = new XtraTabPage();
            tab.Name = uct.Name;
            tab.Size = tabHienThi.Size;
            tab.Text = tenTap;

            tabHienThi.TabPages.Add(tab);
            tabHienThi.SelectedTabPage = tab;
            uct.Dock = DockStyle.Fill;
            tab.Controls.Add(uct);
            uct.Focus();
        }

        public void DongTapHienTai()
        {
            Model.Connection.close();
            tabHienThi.TabPages.Remove(tabHienThi.SelectedTabPage);
        }

        public void DongAllHienTai()
        {
            while (tabHienThi.TabPages.Count > 0)
                DongTapHienTai();
        }
        public void LoadTrangThai()
        {
            int i = 0;
            string[] trangthai = new string[3] { "Có Khách", "Đã Đặt Bàn", "Trống" };
            Model.Connection.Excute_Sql("dbo.RefreshDatCho");
            DataTable dt = Model.Connection.FillDataTable("SELECT *FROM TkTrangThaiBanAn()");
            lbTrong.Caption = "Trống: " + Convert.ToInt32(dt.Rows[2]["SoBan"]).ToString();
            lbDaDatCho.Caption = "Đã Đặt Bàn: " + Convert.ToInt32(dt.Rows[1]["SoBan"]).ToString();
            lbCoKhach.Caption = "Có Khách: " + Convert.ToInt32(dt.Rows[0]["SoBan"]).ToString();
            GoiMon.uct_gm.LoadBanAn();
        }
        public void Dis_End(bool e)
        {
            bbtnQl_NguyenLieu.Enabled = e;
            bbtnQl_NhanVien.Enabled = e;
            bbtnQl_NhapHang.Enabled = e;
            btnLoiNhuan.Enabled = e;
            btnThongKeHDB.Enabled = e;
            btnThongKeHDN.Enabled = e;
            bbtnQl_ThucDon.Enabled = e;
            bbtnQl_BanAn.Enabled = e;
            bbtnQl_KhachHang.Enabled = e;
            btnQlMatKhau.Enabled = e;
        }
        #endregion

        #region Events

        private void bbtnQl_NhanVien_ItemClick(object sender, ItemClickEventArgs e)
        {
            ThemTapPage(QuanLiNhanVien.uct_nv, "Quản Lí Nhân Viên");
        }

        private void tabHienThi_CloseButtonClick(object sender, EventArgs e)
        {
            DongTapHienTai();
        }

        private void bbtnQl_KhachHang_ItemClick(object sender, ItemClickEventArgs e)
        {
            ThemTapPage(QuanLiKhachHang.uct_KH, "Quản Lí Khách Hàng");
        }
        private void bbtnQl_NhapHang_ItemClick(object sender, ItemClickEventArgs e)
        {
            ThemTapPage(QuanLiNhapHang.uct_NH, "Quản Lí Nhập Hàng");
        }

        private void bbtnQl_BanAn_ItemClick(object sender, ItemClickEventArgs e)
        {
            ThemTapPage(QuanLiBanAn.uct_BA, "Quản Lí Bàn Ăn");
        }

        private void bbtnQl_ThucDon_ItemClick(object sender, ItemClickEventArgs e)
        {
            ThemTapPage(ThucDon.uct_MonAn, "Quản Lí Món Ăn");
        }

        private void bbtnQl_NguyenLieu_ItemClick(object sender, ItemClickEventArgs e)
        {
            ThemTapPage(QuanLiNguyenLieu.uct_NL, "Quản Lí Nguyên Liệu");
        }

        private void btnThongTin_ItemClick(object sender, ItemClickEventArgs e)
        {
            ThemTapPage(GoiMon.uct_gm, "Bang Goi Mon");
        }

        private void btnThongKe_ItemClick(object sender, ItemClickEventArgs e)
        {
            ThemTapPage(ThongKeHDB.uct_TK, "Thống kê bán hàng");
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToString("HH:mm");
            lblSec.Text = DateTime.Now.ToString("ss");
            lblDate.Text = DateTime.Now.ToString("MMM dd yyyy");
            lblDay.Text = DateTime.Now.ToString("dddd") + ",";
            lblDay.Location = new Point(ribbon.Size.Width - 300, lblDay.Location.Y);
            lblTime.Location = new Point(lblDay.Location.X - 150, lblTime.Location.Y);
            lblSec.Location = new Point(lblTime.Location.X + lblTime.Width - 7, lblSec.Location.Y);
            lblDate.Location = new Point(lblDay.Location.X + lblDay.Width - 3, lblDay.Location.Y);
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            DevExpress.LookAndFeel.DefaultLookAndFeel themes = new DevExpress.LookAndFeel.DefaultLookAndFeel();
            themes.LookAndFeel.SkinName = "Metropolis";
            LoadTrangThai();
            DangNhap();
        }

        private void btnThucDon_ItemClick(object sender, ItemClickEventArgs e)
        {
            ThemTapPage(ListThucDon.uct_listTD, "Thực Đơn");
        }

        private void btnThongKeHDN_CheckedChanged(object sender, ItemClickEventArgs e)
        {
            ThemTapPage(ThongKeHDN.uct_TKHDN, "Thống Kê Hóa Đơn Nhập");
        }

        private void barButtonItem7_ItemClick(object sender, ItemClickEventArgs e)
        {
            ThemTapPage(LoiNhuanBanHang.uct_LN, "Lợi Nhuận Thu Về");
        }

        private void barButtonItem8_ItemClick(object sender, ItemClickEventArgs e)
        {
            LoadTrangThai();
        }

        private void btnThongTinNH_ItemClick(object sender, ItemClickEventArgs e)
        {
            ThemTapPage(ThongTinNhaHang.uct_TTNH, "Thông Tin Nhà Hàng");
        }
        #endregion

        private void btnDoiMatKhau_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmDoiMatKhau dmk = new frmDoiMatKhau();
            dmk.Sender(txtTenDangNhap.Text);
            dmk.ShowDialog();
        }

        private void btnDangXuat_ItemClick(object sender, ItemClickEventArgs e)
        {
            DangNhap();
        }
        private void btnQlMatKhau_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmXoaTaiKhoan fr = new frmXoaTaiKhoan();
            fr.Show();
        }
    }
}