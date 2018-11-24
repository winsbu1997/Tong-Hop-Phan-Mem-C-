using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using DTO;

namespace BUS
{
    public class CustomerBUS
    {
        public static List<KhachHangDTO> LayDSLoaiKhach()
        {
            return CustomerDAO.LayDSLoaiKhach();
        }

        public static bool ThemKhachHang(KhachHangDTO kh)
        {
            return CustomerDAO.ThemKhachHang(kh);
        }

        public static List<KhachHangDTO> DanhSachKhachHang()
        {
            return CustomerDAO.DanhSachKhachHang();
        }

        public static List<KhachHangDTO> DSKHTheoTen(KhachHangDTO thongtin)
        {
            return CustomerDAO.DSKHTheoTen(thongtin);
        }

        public static List<KhachHangDTO> DSKHTheoTenDiaChi(KhachHangDTO thongtin)
        {
            return CustomerDAO.DSKHTheoTenDiaChi(thongtin);
        }

        public static List<KhachHangDTO> DSKHTheoTenLoaiKhach(KhachHangDTO thongtin)
        {
            return CustomerDAO.DSKHTheoTenLoaiKhach(thongtin);
        }

        public static List<KhachHangDTO> DSKHTheoTenDiaChiLoaiKhach(KhachHangDTO thongtin)
        {
            return CustomerDAO.DSKHTheoTenDiaChiLoaiKhach(thongtin);
        }

        public static List<KhachHangDTO> DSKHTheoLoaiKhach(KhachHangDTO thongtin)
        {
            return CustomerDAO.DSKHTheoLoaiKhach(thongtin);
        }

        public static List<KhachHangDTO> DSKHTheoLoaiKhachDiaChi(KhachHangDTO thongtin)
        {
            return CustomerDAO.DSKHTheoLoaiKhachDiaChi(thongtin);
        }

        public static List<KhachHangDTO> DSKHTheoDiaChi(KhachHangDTO thongtin)
        {
            return CustomerDAO.DSKHTheoDiaChi(thongtin);
        }

        public static List<KhachHangDTO> DSKHTheoPhong(PhongDTO thongtin)
        {
            return CustomerDAO.DSKHTheoPhong(thongtin);
        }

        public static List<KhachHangDTO> DSKHTheoCMND(KhachHangDTO thongtin)
        {
            return CustomerDAO.DSKHTheoCMND(thongtin);
        }

        public static List<KhachHangDTO> DSKHTheoTenDiaChiLoaiKhachCMND(KhachHangDTO thongtin)
        {
            return CustomerDAO.DSKHTheoTenDiaChiLoaiKhachCMND(thongtin);
        }

        public static List<KhachHangDTO> DSKHTheoTenDiaChiCMND(KhachHangDTO thongtin)
        {
            return CustomerDAO.DSKHTheoTenDiaChiCMND(thongtin);
        }

        public static List<KhachHangDTO> DSKHTheoTenCMND(KhachHangDTO thongtin)
        {
            return CustomerDAO.DSKHTheoTenCMND(thongtin);
        }

        public static List<KhachHangDTO> DSKHTheoTenLoaiKhachCMND(KhachHangDTO thongtin)
        {
            return CustomerDAO.DSKHTheoTenLoaiKhachCMND(thongtin);
        }

        public static List<KhachHangDTO> DSKHLoaiKhachCMND(KhachHangDTO thongtin)
        {
            return CustomerDAO.DSKHTheoLoaiKhachCMND(thongtin);
        }

        public static List<KhachHangDTO> DSKHDiaChiLoaiKhachCMND(KhachHangDTO thongtin)
        {
            return CustomerDAO.DSKHDiaChiLoaiKhachCMND(thongtin);
        }

        public static List<KhachHangDTO> DSKHDiaChiCMND(KhachHangDTO thongtin)
        {
            return CustomerDAO.DSKHDiaChiCMND(thongtin);
        }

        public static List<KhachHangDTO> LayMaKhachHangCanXoa(int? maphieuthue)
        {
            return CustomerDAO.LayMaKhachHangCanXoa(maphieuthue);
        }

        public static bool XoaKhachHang(KhachHangDTO id)
        {
            return CustomerDAO.XoaKhachHang(id);
        }
    }
}
