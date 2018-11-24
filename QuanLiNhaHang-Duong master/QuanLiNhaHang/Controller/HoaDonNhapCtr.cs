using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiNhaHang.Controller
{
    class HoaDonNhapCtr
    {
        public static int InsertHoaDonNhap(string _MaHDN, DateTime _NgayNhap, int _TongTien, string _GhiChu, string _MaNV)
        {
            try
            {
                Model.HoaDonNhapMod hdn = new Model.HoaDonNhapMod(_MaHDN, _NgayNhap, _TongTien, _GhiChu, _MaNV);
                return hdn.InsertHoaDonNhap();
            }
            catch { return 0; }
        }
        public static int UpdateHoaDonNhap(string _MaHDN, DateTime _NgayNhap, int _TongTien, string _GhiChu, string _MaNV)
        {
            try
            {
                Model.HoaDonNhapMod hdn = new Model.HoaDonNhapMod(_MaHDN, _NgayNhap, _TongTien, _GhiChu, _MaNV);
                return hdn.UpdateHoaDonNhap();
            }
            catch { return 0; }
        }
        public static int DeleteHoaDonNhap(string _MaHDN)
        {
            try
            {
                Model.HoaDonNhapMod hdn = new Model.HoaDonNhapMod(_MaHDN);
                return hdn.DeleteHoaDonNhap();
            }
            catch { return 0; }
        }
        public static List<Model.HoaDonNhapMod> DanhSachHoaDonNhap(string s)
        {
            List<Model.HoaDonNhapMod> listHDN = new List<Model.HoaDonNhapMod>();
            DataTable dt = Model.Connection.FillDataTable(s);
            foreach (DataRow item in dt.Rows)
            {
                Model.HoaDonNhapMod hdn = new Model.HoaDonNhapMod(item);
                listHDN.Add(hdn);
            }
            return listHDN;
        }
    }
}
