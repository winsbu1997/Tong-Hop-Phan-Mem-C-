using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
   public class ChiTietThietBiPhongBUS
    {
        public DataTable ThietBiTheoPhong(string maphong)
        {
            return new ChiTietThietBiPhongDAL().ThietBiTheoPhong(maphong);
        }
        public bool ThemThietBiPhong(string mathietbi, string maphong, string soluong)
        {
            return new ChiTietThietBiPhongDAL().ThemThietBiPhong(mathietbi, maphong, soluong);
        }
        public bool XoaThietBiPhong(string mathietbi, string maphong)
        {
            return new ChiTietThietBiPhongDAL().XoaThietBiPhong(mathietbi, maphong);
        }
        public bool SuaThietBiPhong(string mathietbi, string soluong, string maphong)
        {
            return new ChiTietThietBiPhongDAL().SuaThietBiPhong(mathietbi, soluong, maphong);
        }
        public bool Kiemtramathietbi(string mathietbi, string maphong)
        {
            return new ChiTietThietBiPhongDAL().Kiemtramathietbi(mathietbi, maphong);
        }
    }
}
