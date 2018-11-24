using BTL_CNPM.Data;
using MetroFramework.Forms;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTL_CNPM.Report
{
    public partial class FrmRpHoaDon : MetroForm
    {
        private RM_Context db = Helper.db;
        private HOADON hd = new HOADON();
        private int khuyenmai = 0;

        public FrmRpHoaDon(HOADON z, int km)
        {

            // khuyen mai theo %
            InitializeComponent();
            Helper.Reload();
            hd = z;
            khuyenmai = km;

            if (khuyenmai < 0) khuyenmai = 0;
            if (khuyenmai > 100) khuyenmai = 100;
        }

        private void FrmRpHoaDon_Load(object sender, EventArgs e)
        {
            // CHi tiết hóa đơn
            int i = 0;
            hOADONBindingSource.DataSource = db.CHITIETHOADONs.Where(p => p.HOADONID == hd.ID).ToList()
                                             .Select(p => new
                                             {
                                                 STT = ++i,
                                                 MatHang = db.MATHANGs.Where(k => k.ID == p.MATHANGID).FirstOrDefault().TEN,
                                                 SoLuong = p.SOLUONG,
                                                 DonGia = ((int)p.DONGIA).ToString("N0"),
                                                 ThanhTien = ((int)p.THANHTIEN).ToString("N0"),
                                                 DonViTinh = db.MATHANGs.Where(k=>k.ID == p.MATHANGID).FirstOrDefault().DONVITINH
                                             })
                                             .ToList();

            int tKhuyenMai = (int)((float)hd.TONGTIEN / 100.0 * khuyenmai);
            int tThanhToan = ((int)hd.TONGTIEN - tKhuyenMai);

            THONGTINNHAHANG thongtin = db.THONGTINNHAHANGs.FirstOrDefault();

            ReportParameter[] listPara = new ReportParameter[]{
                    new ReportParameter("MaHoaDon", hd.MAHOADON),
                    new ReportParameter("NgayBan", ((DateTime) hd.NGAYNHAP).ToString("dd/MM/yyyy")),
                    new ReportParameter("NhanVienBanHang", db.NHANVIENs.Where(p=>p.ID== hd.NHANVIENID).FirstOrDefault().TEN),
                    new ReportParameter("TongTien", ((int)hd.TONGTIEN).ToString("N0")),
                    new ReportParameter("TenNhaHang", thongtin.TEN),
                    new ReportParameter("DiaChi", thongtin.DIACHI),
                    new ReportParameter("KhuyenMai", tKhuyenMai.ToString("N0")),
                    new ReportParameter("ThanhToan", tThanhToan.ToString("N0")),
                    new ReportParameter("PhanTramKhuyenMai",khuyenmai+"%")
                    
                };
            this.rpViewerHoaDon.LocalReport.SetParameters(listPara);


            this.rpViewerHoaDon.LocalReport.Refresh();
            this.rpViewerHoaDon.RefreshReport();
            this.rpViewerHoaDon.RefreshReport();
        }
    }
}
