using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraCharts;

namespace QuanLiNhaHang.GUI
{
    public partial class LoiNhuanBanHang : UserControl
    {
        public long TongHDB = 0;
        public long TongHDN = 0;
        public int thang = 0;
        public static LoiNhuanBanHang uct_LN = new LoiNhuanBanHang();
        public LoiNhuanBanHang()
        {
            InitializeComponent();
        }
        public static DateTime GetLastDayInMonth(int year, int month)
        {
            DateTime aDateTime = new DateTime(year, month, 1);

            // Cộng thêm 1 tháng và trừ đi một ngày.
            DateTime retDateTime = aDateTime.AddMonths(1).AddDays(-1);

            return retDateTime;
        }
        public void LoadChart()
        {
            for (int i = 1; i <= 12; i++)
            {
                DateTime d1 = new DateTime(DateTime.Now.Year, i, 1);
                DateTime d2 = new DateTime(DateTime.Now.Year, i, GetLastDayInMonth(DateTime.Now.Year, i).Day);

                int hdb = 0;
                try
                {
                    hdb = Convert.ToInt32(Model.Connection.docGiaTri("select SUM(TongTien) FROM dbo.HoaDonBan WHERE NgayBan BETWEEN '" + d1 + "' AND '" + d2 + "'"));
                    TongHDB += hdb;
                    thang++;
                }
                catch { }
                int hdn = 0;
                try
                {
                    hdn = Convert.ToInt32(Model.Connection.docGiaTri("select SUM(TongTien) FROM dbo.HoaDonNhap WHERE NgayNhap BETWEEN '" + d1 + "' AND '" + d2 + "'"));
                    TongHDN += hdn;
                }
                catch { }
                chartThuNhap.Series[1].Points.Add(new SeriesPoint(i, hdb));
                chartThuNhap.Series[0].Points.Add(new SeriesPoint(i, hdn));
            }

        }

        private void LoiNhuanBanHang_Load(object sender, EventArgs e)
        {
            LoadChart();
            TinhLoiNhuan();
        }

        public void TinhLoiNhuan()
        {
            long tienluongtra = Convert.ToInt32(Model.Connection.docGiaTri("SELECT SUM(Luong) FROM dbo.NhanVien")) * thang;
            txtTienMuaNL.Text = String.Format("{0:N0}", TongHDN);
            txtTienThuVe.Text = String.Format("{0:N0}", TongHDB);
            txtTienLuongTra.Text = String.Format("{0:N0}", tienluongtra);
            TxtTienLai.Text = String.Format("{0:N0}", (TongHDB - TongHDN - tienluongtra));
            long x = TongHDN + Convert.ToInt32(tienluongtra);
            txtLaiSuat.Text = String.Format("{0,4:P1}", ((TongHDB - TongHDN - tienluongtra) / (float)x));
        }

        private void btnInThongKe_Click(object sender, EventArgs e)
        {
            chartThuNhap.ShowPrintPreview();
        }
    }
}
