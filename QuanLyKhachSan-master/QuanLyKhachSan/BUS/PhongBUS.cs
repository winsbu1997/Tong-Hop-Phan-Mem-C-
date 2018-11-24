using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class PhongBUS
    {
        public List<Phong> getListPhong()
        {
            PhongDAL phongDAL = new PhongDAL();
            return phongDAL.getListPhong();
        }
        public List<Phong> DanhSachPhongTrongTheoNgay(DateTime ngaythue,DateTime ngaytra)
        {
            return new PhongDAL().DanhSachPhongTrongTheoNgay(ngaythue, ngaytra);
        }
        public List<Phong> DanhSachPhongTrong()
        {
            return new PhongDAL().DanhSachPhongTrong();
        }
        public bool ThemPhong(string maphong, string tenphong, string maloaiphong, int trangthai)
        {
            return new PhongDAL().ThemPhong(maphong, tenphong, maloaiphong, trangthai);
        }
        public bool SuaPhong(string maphong, string tenphong, string maloaiphong, int trangthai)
        {
            return new PhongDAL().SuaPhong(maphong, tenphong, maloaiphong, trangthai);
        }
        public bool XoaPhong(string maphong)
        {
            return new PhongDAL().XoaPhong(maphong);
        }
        public bool KiemTraMaPhong(string maphong)
        {
            return new PhongDAL().KiemTraMaPhong(maphong);
        }
        public List<Phong> TimKiemPhong(string tenphong)
        {
            return new PhongDAL().TimKiemPhong(tenphong);
        }
        public Phong PhongTheoMa(string maphong)
        {
            return new PhongDAL().PhongTheoMa(maphong);
        }
        public bool CapNhatTrangThaiPhong(string maphong, int trangthai)
        {
            return new PhongDAL().CapNhatTrangThaiPhong(maphong, trangthai);
        }
        public string SinhMaPhong()
        {
            return new PhongDAL().SinhMaPhong();
        }
    }
}
