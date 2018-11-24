using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;
namespace BUS
{
    public class LoaiPhongBUS
    {
        public List<LoaiPhong> DanhSachLoaiPhong()
        {
            return new LoaiPhongDAL().DanhSachLoaiPhong();
        }
        public bool ThemLoaiPhong(string maloaiphong, string tenloaiphong, decimal giaphong, int songuoi)
        {
            return new LoaiPhongDAL().ThemLoaiPhong(maloaiphong, tenloaiphong, giaphong, songuoi);
        }
        public bool XoaLoaiPhong(string maloaiphong)
        {
            return new LoaiPhongDAL().XoaLoaiPhong(maloaiphong);
        }
        public bool SuaLoaiPhong(string maloaiphong, string tenloaiphong, decimal giaphong, int songuoi)
        {
            return new LoaiPhongDAL().SuaLoaiPhong(maloaiphong, tenloaiphong, giaphong, songuoi);
        }
        public List<LoaiPhong> TimKiemloaiphong(string tenloaiphong)
        {
            return new LoaiPhongDAL().TimKiemloaiphong(tenloaiphong);
        }
        public LoaiPhong ThongTinLoaiPhong(string maloaiphong)
        {
            return new LoaiPhongDAL().ThôngTinLoaiPhong(maloaiphong);
        }
        public string SinhMaLoaiPhong()
        {
            return new LoaiPhongDAL().SinhMaLoaiPhong();
        }
    }
}
