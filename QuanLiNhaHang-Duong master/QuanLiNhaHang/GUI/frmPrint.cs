using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using QuanLiNhaHang.Report_Viewer;

namespace QuanLiNhaHang.GUI
{
    public partial class frmPrint : DevExpress.XtraEditors.XtraForm
    {
        public frmPrint()
        {
            InitializeComponent();
        }
        public void printHD(string MaHDB, string MaNV, string MaKH, int TongTien, int GiamGia, DateTime tgden,string TienTra, int TienThua, DataTable dt)
        {
            InHoaDonBan inHD = new Report_Viewer.InHoaDonBan();
            foreach (DevExpress.XtraReports.Parameters.Parameter pr in inHD.Parameters) pr.Visible = false;
            inHD.InitData(MaHDB, MaNV, MaKH, TongTien, GiamGia, tgden, TienTra, TienThua, dt); 
            documentViewer1.DocumentSource = inHD;
            inHD.CreateDocument();
        }
    }
}