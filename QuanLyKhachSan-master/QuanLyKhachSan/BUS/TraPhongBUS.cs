using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
   public class TraPhongBUS
    {
        public bool ThemTraPhong(string mathuephong, string matraphong, decimal tongtien, DateTime ngaytra, string manhanvien, string thongtin)
        {
            return new TraPhongDAL().ThemTraPhong(mathuephong, matraphong, tongtien, ngaytra, manhanvien, thongtin);
        }
        public string SinhMaTraPhong()
        {
            return new TraPhongDAL().SinhMaTraPhong();
        }
    }
}
