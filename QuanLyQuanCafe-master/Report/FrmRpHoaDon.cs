//using Microsoft.Reporting.WinForms;
using QuanLyQuanCafe.DATA;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyQuanCafe.Report
{
    public partial class FrmRpHoaDon : Form
    {
        private int soban;
        private DateTime ngay = DateTime.Now;
        private QuanLyQuanCafeDBContext db = new QuanLyQuanCafeDBContext();
        public FrmRpHoaDon(int sb)
        {
            InitializeComponent();
            soban = sb;
        }

        private void FrmRpHoaDon_Load(object sender, EventArgs e)
        {
            /// Location
            int i = 1;
            HOADONBindingSource.DataSource = (
                    from hd in db.HOADONBANs.Where(p => p.MABA == soban && p.STATUS == 0).ToList()
                    from ctb in db.CHITIETBANs.Where(p => p.MAHDB == hd.MAHDB).ToList()
                    from mh in db.MATHANGs.Where(p => p.MAMH == ctb.MAMH).ToList()
                    select new
                    {
                        STT = i++,
                        MatHang = mh.TENMH,
                        SoLuong = ctb.SOLUONG,
                        DonGia = mh.DONGIA,
                        ThanhTien = ctb.THANHTIEN,
                        DonViTinh = mh.DVTINH
                    }
                ).ToList();

            int TongTien = (
                    from hd in db.HOADONBANs.Where(p => p.MABA == soban && p.STATUS == 0).ToList()
                    from ctb in db.CHITIETBANs.Where(p => p.MAHDB == hd.MAHDB).ToList()
                    from mh in db.MATHANGs.Where(p => p.MAMH == ctb.MAMH).ToList()
                    select new
                    {
                        STT = i++,
                        MatHang = mh.TENMH,
                        SoLuong = ctb.SOLUONG,
                        DonGia = mh.DONGIA,
                        ThanhTien = ctb.THANHTIEN,
                        DonViTinh = mh.DVTINH
                    })
                    .ToList()
                    .Sum(p => p.ThanhTien)
                    .Value;

            int MaHD = (int)db.HOADONBANs.Where(p => p.MABA == soban && p.STATUS == 0).First().MAHDB;

            //add parameter
            ReportParameter[] listPara = new ReportParameter[]{
                 new ReportParameter("TenNhaHang",db.THONGTINNHAHANGs.FirstOrDefault().TENNH),
                 new ReportParameter("DiaChi",db.THONGTINNHAHANGs.FirstOrDefault().DIACHI),
                 new ReportParameter("SoBan", db.BANANs.Where(p=>p.MABA == soban).FirstOrDefault().TENBA),
                 new ReportParameter("Ngay",DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss")),
                 new ReportParameter("TongTien",TongTien.ToString()),
                 new ReportParameter("MaHD",MaHD.ToString())
                };
            this.reportViewer1.LocalReport.SetParameters(listPara);


            this.reportViewer1.LocalReport.Refresh();
            this.reportViewer1.RefreshReport();


            this.reportViewer1.RefreshReport();

        }
    }
}
