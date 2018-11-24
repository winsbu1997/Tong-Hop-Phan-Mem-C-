using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BTL_CNPM.Data;
using BTL_CNPM.Report;

namespace BTL_CNPM.GUI
{
    public partial class ucThongKeHoaDon : UserControl
    {
        private RM_Context db = Helper.db;

        #region Hàm khởi tạo
        public ucThongKeHoaDon()
        {
            InitializeComponent();
            Helper.Reload();

            dgvChiTietNhapMain.DataSource = null;
            dgvPhieuNhapMain.DataSource = null;
        }
        #endregion


        #region LoadForm
        private void LoadInitControl()
        {
            dateBatDau.DateTime = DateTime.Now.AddDays(-30);
            dateKetThuc.DateTime = DateTime.Now;
        }

        private void LoadDgvDanhSachHoaDon()
        {
            txtTongGiaTri.Text = "Tổng giá trị: 0";
            try
            {
                dgvPhieuNhapMain.DataSource = db.HOADONs.ToList()
                                               .Where(p => p.NGAYNHAP >= dateBatDau.DateTime && p.NGAYNHAP <= dateKetThuc.DateTime)
                                               .OrderBy(p => p.NGAYNHAP)
                                               .Select(p => new
                                               {
                                                   ID = p.ID,
                                                   TongChiPhi = ((int)p.TONGTIEN).ToString("N0"),
                                                   MaHoaDon = p.MAHOADON,
                                                   Ngay = ((DateTime)p.NGAYNHAP).ToString("dd/MM/yyyy"),
                                                   NhanVien = db.NHANVIENs.Where(z => z.ID == p.NHANVIENID).FirstOrDefault().TEN
                                               })
                                               .ToList();
                txtTongGiaTri.Text = "Tổng giá trị : " + ((int)db.HOADONs.ToList()
                                                           .Where(p => p.NGAYNHAP >= dateBatDau.DateTime && p.NGAYNHAP <= dateKetThuc.DateTime)
                                                           .OrderBy(p => p.NGAYNHAP)
                                                           .Select(p => new
                                                           {
                                                               ID = p.ID,
                                                               ChiPhi = p.TONGTIEN,
                                                               TongChiPhi = ((int)p.TONGTIEN).ToString("N0"),
                                                               MaHoaDon = p.MAHOADON,
                                                               Ngay = ((DateTime)p.NGAYNHAP).ToString("dd/MM/yyyy"),
                                                               NhanVien = db.NHANVIENs.Where(z => z.ID == p.NHANVIENID).FirstOrDefault().TEN
                                                           })
                                                           .Sum(p => p.ChiPhi))
                                                           .ToString("N0");

                LoadCHITIETHOADON();
            }
            catch { }
        }

        private void LoadCHITIETHOADON()
        {
            try
            {
                int ID = (int)dgvPhieuNhap.GetFocusedRowCellValue("ID");
                HOADON hd = db.HOADONs.Where(p => p.ID == ID).FirstOrDefault();

                int i = 0;
                dgvChiTietNhapMain.DataSource = db.CHITIETHOADONs.Where(p => p.HOADONID == hd.ID).ToList()
                                                .Select(p => new
                                                {
                                                    ID = p.ID,
                                                    STT = ++i,
                                                    MatHang = db.MATHANGs.Where(z => z.ID == p.MATHANGID).FirstOrDefault().TEN,
                                                    DonGia = ((int)p.DONGIA).ToString("N0"),
                                                    SoLuong = p.SOLUONG,
                                                    ThanhTien = ((int)p.THANHTIEN).ToString("N0")
                                                })
                                                .ToList();
            }
            catch { }
        }

        private void ucThongKePhieuNhap_Load(object sender, EventArgs e)
        {
            LoadInitControl();
            LoadDgvDanhSachHoaDon();
        }
        #endregion

        #region Sự kiện ngầm
        private void dgvPhieuNhap_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            UpdateDetail();
        }

        private void dateKetThuc_EditValueChanged(object sender, EventArgs e)
        {
            LoadDgvDanhSachHoaDon();
        }
        #endregion

        #region Hàm chức năng

        private void UpdateDetail()
        {
            try
            {
                int ID = (int)dgvPhieuNhap.GetFocusedRowCellValue("ID");
                HOADON hd = db.HOADONs.Where(p => p.ID == ID).FirstOrDefault();

                txtMaPhieuNhap.Text = hd.MAHOADON;
                dateNgayBan.Text = ((DateTime)hd.NGAYNHAP).ToString("dd/MM/yyyy");
                txtNhanVien.Text = db.NHANVIENs.Where(p => p.ID == hd.NHANVIENID).FirstOrDefault().TEN;
                txtTongChiPhi.Text = ((int)hd.TONGTIEN).ToString("N0");

                LoadCHITIETHOADON();
            }
            catch { }
        }

        #endregion

        private void btnInHoaDon_Click(object sender, EventArgs e)
        {
            try
            {
                int ID = (int)dgvPhieuNhap.GetFocusedRowCellValue("ID");
                HOADON hd = db.HOADONs.Where(p => p.ID == ID).FirstOrDefault();
                FrmRpHoaDon form = new FrmRpHoaDon(hd, (int) hd.KHUYENMAI);
                form.ShowDialog();
            }
            catch
            {
                MessageBox.Show("Chưa có hóa đơn nào được chọn",
                                "Thông báo",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                return;
            }
        }

    }
}
