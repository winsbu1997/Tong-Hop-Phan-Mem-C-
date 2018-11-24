using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;

namespace BUS
{
   public class ThietBiBUS
    {
        public List<ThietBi> DanhSachThietBi()
        {
            return new ThietBiDAL().DanhSachThietBi();
        }
        public bool ThemThietBi(string mathietbi, string tenthietbi, decimal giathietbi, int soluong)
        {
            return new ThietBiDAL().ThemThietBi(mathietbi, tenthietbi, giathietbi,soluong);
        }
        public bool SuaThietBi(string mathietbi, string tenthietbi, decimal giathietbi, int soluong)
        {
            return new ThietBiDAL().SuaThietBi(mathietbi, tenthietbi, giathietbi, soluong);
        }
        public bool XoaThietBi(string mathietbi)
        {
            return new ThietBiDAL().XoaThietBi(mathietbi);
        }
        public List<ThietBi> TimKiemThietBi(string tenthietbi)
        {
            return new ThietBiDAL().TimKiemThietBi(tenthietbi);
        }
        public ThietBi ThietBiTheoMa(string mathietbi)
        {
            return new ThietBiDAL().ThietBiTheoMa(mathietbi);
        }
        public string SinhMaThietBiPhong()
        {
            return new ThietBiDAL().SinhMaThietBiPhong();
        }
    }
}
