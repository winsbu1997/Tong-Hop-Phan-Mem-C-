using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class ThuePhongBUS
    {
        public bool ThuePhong(List<Phong> dsPhongThue,string makhachhang,string manhanvien,DateTime ngaythue)
        {
            ThuePhongDAL thuePhongDAL = new ThuePhongDAL();

            return thuePhongDAL.ThemThuePhong(dsPhongThue, makhachhang, manhanvien, ngaythue);
        }
        public ThuePhong LayThongTinThuePhong(string maphong)
        {
            ThuePhongDAL thuePhongDAL = new ThuePhongDAL();
            return thuePhongDAL.LayThongTinThuePhong(maphong);
        }
    }
}
