using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class KhachHangBUS
    {
        public bool ThemKhachHang(KhachHang kh)
        {
            KhachHangDAL khDAL = new KhachHangDAL();
            return khDAL.ThemKhachHang(kh);
        }
        public List<KhachHang> DanhSachKhachHang()
        {
            KhachHangDAL khDAL = new KhachHangDAL();
            return khDAL.DanhSachKhachHang();
        }
        public List<KhachHang> TimKiemKhachHang(int danhmuctimkiem,string chuoitimkiem)
        {
            KhachHangDAL khDAL = new KhachHangDAL();
            return khDAL.TimKiemKhachHang(danhmuctimkiem, chuoitimkiem);
        }
        public KhachHang LayThongTinKhachHangTheoMa(string ma)
        {
            KhachHangDAL khDAL = new KhachHangDAL();
            return khDAL.LayThongTinKhachHangTheoMa(ma);
        }

        public bool SuaKhachHang(string makhachhang, string tenkhachhang, int sodienthoai, DateTime ngaysinh, string gioitinh, int sochungminh, string diadiem)
        {
            return new KhachHangDAL().SuaKhachHang(makhachhang, tenkhachhang, sodienthoai, ngaysinh, gioitinh, sochungminh, diadiem);
        }
    }
}
