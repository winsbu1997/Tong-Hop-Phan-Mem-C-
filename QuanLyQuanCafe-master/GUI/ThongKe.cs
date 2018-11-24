using QuanLyQuanCafe.DAO;
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
using System.Windows.Forms.DataVisualization.Charting;

namespace QuanLyQuanCafe.GUI
{
    public partial class ThongKe : Form
    {
        public ThongKe()
        {
            InitializeComponent();

            dtpfromday.Value = DateTime.Now.AddMonths(-2);
        }

        #region Methods
        void load()
        {
            DateTime fromday = dtpfromday.Value;
            DateTime today = dtptoday.Value;

            QuanLyQuanCafeDBContext db = new QuanLyQuanCafeDBContext();

            var ListCTB =
                        (
                            from hd in db.HOADONBANs.Where(p => p.NGAY > fromday && p.NGAY < today).ToList()
                            from ctb in db.CHITIETBANs.Where(p => p.MAHDB == hd.MAHDB).ToList()
                            select new
                            {
                                MaMH = ctb.MAMH,
                                SoLuong = ctb.SOLUONG
                            }
                        ).ToList();

            int i = 0;
            var ListMatHang = (
                                from mh in db.MATHANGs.ToList()
                                select new
                                {
                                    ID = mh.MAMH,
                                    TenMatHang = mh.TENMH,
                                    SoLuong = ListCTB.Where(p => p.MaMH == mh.MAMH).Sum(p => p.SoLuong),
                                    TongTien = ListCTB.Where(p => p.MaMH == mh.MAMH).Sum(p => p.SoLuong) * mh.DONGIA
                                    
                                }
                              )
                              .Where(p => p.SoLuong > 0)
                              .OrderByDescending(p=>p.TongTien)
                              .Select(p => new
                              {
                                  STT = ++i,
                                  ID = p.ID,
                                  MatHang = p.TenMatHang,
                                  SoLuong = p.SoLuong,
                                  TongTien = ((int)p.TongTien).ToString("N0"),
                                  gt = p.TongTien
                              })
                              .ToList();

            txtLoiNhuan.Text = "Tổng lợi nhuận : " + ((int)ListMatHang.Sum(p => p.gt).Value).ToString("N0");

            dgrThongKe.DataSource = ListMatHang;

            


            chartThongKe.DataSource = ListMatHang;
            chartThongKe.Series[0].XValueMember = "MatHang";
            chartThongKe.Series[0].XValueType = ChartValueType.String;
            chartThongKe.Series[0].YValueMembers = "TongTien";
            chartThongKe.Series[0].YValueType = ChartValueType.Int32;
        }
        #endregion

        #region Events
        private void btnThongKe_Click(object sender, EventArgs e)
        {
            load();
        }

        private void dtpfromday_ValueChanged(object sender, EventArgs e)
        {
            load();
        }

        private void dtptoday_ValueChanged(object sender, EventArgs e)
        {
            load();
        }
        #endregion

       
    }
}
