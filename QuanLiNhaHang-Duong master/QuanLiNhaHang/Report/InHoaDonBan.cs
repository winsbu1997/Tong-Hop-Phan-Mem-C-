using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Collections.Generic;
using System.Data;
using DevExpress.XtraPrinting.BarCode;

namespace QuanLiNhaHang.Report_Viewer
{
    public partial class InHoaDonBan : DevExpress.XtraReports.UI.XtraReport
    {
        public InHoaDonBan()
        {
            InitializeComponent();
            
        }
        public void InitData(string MaHDB, string MaNV, string MaKH, int TongTien, int GiamGia, DateTime tgden,string TienTra,int TienThua, System.Data.DataTable dt)
        {
            pMaHDB.Value = MaHDB;
            pMaKH.Value = MaKH;
            pMaNV.Value = MaNV;
            pTongTien.Value = TongTien;
            pGiamGia.Value = GiamGia;
            pThoiGianDen.Value = tgden;
            pTienTra.Value = TienTra;
            pTienThua.Value = TienThua;
            objectDataSource1.DataSource = dt;
        }
    }
}
