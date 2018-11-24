using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiNhaHang.Controller
{
    class HoaDonBanCtr
    {
        public static int InsertHoaDonBan(string _MaHDB, DateTime _NgayBan, int _TongTien, string _MaNV, string _MaKH, int _GiamGia)
        {
            try
            {
                Model.HoaDonBanMod hdb = new Model.HoaDonBanMod(_MaHDB, _NgayBan, _TongTien, _MaNV,_MaKH, _GiamGia);
                return hdb.InsertHoaDonBan();
            }
            catch { return 0; }
        }
        public static int UpdateHoaDonBan(string _MaHDB, DateTime _NgayBan, int _TongTien, string _MaNV, string _MaKH, int _GiamGia)
        {
            try
            {
                Model.HoaDonBanMod hdb = new Model.HoaDonBanMod(_MaHDB, _NgayBan, _TongTien, _MaNV, _MaKH, _GiamGia);
                return hdb.UpdateHoaDonBan();
            }
            catch { return 0; }
        }
        public static int DeleteHoaDonBan(string _MaHDB)
        {
            try
            {
                Model.HoaDonBanMod hdb = new Model.HoaDonBanMod(_MaHDB);
                return hdb.DeleteHoaDonBan();
            }
            catch { return 0; }
        }
        public static DataSet FillDatasetHDBbyMaHDB(string _MaHDB)
        {
            try
            {
                Model.HoaDonBanMod hdb = new Model.HoaDonBanMod(_MaHDB);
                return hdb.SearchHDNByMaHDB();
            }
            catch { return null; }
        }
        public static List<Model.HoaDonBanMod> DanhSachHoaDonBan(string s)
        {
            List<Model.HoaDonBanMod> listHDB = new List<Model.HoaDonBanMod>();
            DataTable dt = Model.Connection.FillDataTable(s);
            foreach (DataRow item in dt.Rows)
            {
                Model.HoaDonBanMod hd = new Model.HoaDonBanMod(item);
                listHDB.Add(hd);
            }
            return listHDB;
        }
    }
}
