using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
   public class NhanVienBUS
    {
        public bool DangNhap(string tk,string mk)
        {
            return new NhanVienDAL().DangNhap(tk, mk);
        }
        public NhanVien LayThongTinNhanVien(string tk,string mk)
        {
            return new NhanVienDAL().LayThongTinNhanVien(tk, mk);
        }
        public bool DoiMatKhau(string manhanvien,string matkhau)
        {
            return new NhanVienDAL().DoiMatKhau(manhanvien, matkhau);
        }
        public List<NhanVien1> DanhSachNhanVien()
        {
            return new NhanVienDAL().DanhSachNhanVien();
        }
        public List<NhanVien1> TimKiemNhanVien(int tieuchi, string chuoitimkiem)
        {
            return new NhanVienDAL().TimKiemNhanVien(tieuchi, chuoitimkiem);
        }
        public bool ThemNhanVien(NhanVien1 nv)
        {
            return new NhanVienDAL().ThemNhanVien(nv);
        }
        public bool SuaNhanVien(NhanVien1 nv)
        {
            return new NhanVienDAL().SuaNhanVien(nv);
        }
        public bool KiemTraTaiKhoanTonTai(string tk)
        {
            //Check la bien kiem tra su ton tai cua tai khoan neu tai khoan da ton tai return true
            bool check = false;
            foreach(NhanVien1 nv in new NhanVienDAL().DanhSachNhanVien())
            {
                if (nv.Taikhoan.Equals(tk)) return true;
            }
            return check;
        }
    }
}
