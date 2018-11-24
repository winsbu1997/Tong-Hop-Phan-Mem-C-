using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiNhaHang.Controller
{
    class ChiTietBanCtr
    {
        public static int InsertChiTietBan(string _MaHDB, string _STTMA, int _SoLuong, int _ThanhTien)
        {
            try
            {
                Model.ChiTietBanMod ctb = new Model.ChiTietBanMod(_MaHDB, _STTMA, _SoLuong, _ThanhTien);
                return ctb.InsertChiTietBan();
            }
            catch { return 0; }
        }

        public static int UpdateChiTietBan(string _MaHDB, string _STTMA, int _SoLuong, int _ThanhTien)
        {
            try
            {
                Model.ChiTietBanMod ctb = new Model.ChiTietBanMod(_MaHDB, _STTMA, _SoLuong, _ThanhTien);
                return ctb.UpdateChiTietBan();
            }
            catch { return 0; }
        }
        public static int DeleteChiTietBan(string _MaHDB,string _STTMA)
        {
            try
            {
                Model.ChiTietBanMod ctb = new Model.ChiTietBanMod(_MaHDB,_STTMA);
                return ctb.DeleteChiTietBan();
            }
            catch { return 0; }
        }
        public static DataSet SearchChiTietBanbyMaHDB(string _MaHDB)
        {
            try
            {
                Model.ChiTietBanMod ctb = new Model.ChiTietBanMod(_MaHDB);
                return ctb.SearchChiTietBanbyMaHDB();
            }
            catch { return null; }
        }
    }
}
