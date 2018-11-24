using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using DTO;

namespace BUS
{
    public class RoomBUS
    {
        //11111111111111
        public static List<PhongDTO> LayMaPhongLoaiPhong()
        {
            return RoomDAO.LayMaPhongLoaiPhong();
        }

        //2222222222222222222222222
        public static List<PhongDTO> LayDanhSachLoaiPhong()
        {
            return RoomDAO.LayDanhSachLoaiPhong();
        }

        //33333333333333
        public static int LaySLPhongTrongTheoLoai(string lp)
        {
            return RoomDAO.LaySLPhongTrongTheoLoai(lp);
        }

        public static List<ThamSoDTO> SoLuongKhachToiDa()
        {
            return RoomDAO.SoLuongKhachToiDa();
        }

        public static bool CapNhatTinhTrangPhong(PhieuThuePhongDTO p)
        {
            return RoomDAO.CapNhatTinhTrangPhong(p);
        }

        public static List<PhongDTO> DanhSachPhongTK()
        {
            return RoomDAO.DanhSachPhongTK();
        }

        public static List<PhongDTO> LoaiPhong()
        {
            return RoomDAO.LoaiPhong();
        }

        public static List<PhieuThuePhongDTO> DanhSachPhongDangDuocThue()
        {
            return RoomDAO.DanhSachPhongDangDuocThue();
        }

        public static List<PhongDTO> DanhSachPhong()
        {
            return RoomDAO.DanhSachPhong();
        }

        public static List<PhongDTO> LoadDonGia(string text)
        {
            return RoomDAO.LoadDonGia(text);
        }

        public static bool ThemPhong(PhongDTO infor)
        {
            return RoomDAO.ThemPhong(infor);
        }

        public static bool SuaThongTinPhong(PhongDTO infor)
        {
            return RoomDAO.SuaThongTinPhong(infor);
        }

        public static bool XoaPhong(PhongDTO infor)
        {
            return RoomDAO.XoaPhong(infor);
        }

        public static bool ThietLapTrangThaiPhongBanDau(HoaDonDTO inforHD)
        {
            return RoomDAO.ThietLapTrangThaiPhongBanDau(inforHD);
        }

        public static List<PhongDTO> DanhSachPhongTheoLoai(PhongDTO thongtin)
        {
            return RoomDAO.DanhSachPhongTheoLoai(thongtin);
        }

        public static List<PhongDTO> DanhSachPhongYeuCau(PhongDTO thongtin)
        {
            return RoomDAO.DanhSachPhongYeuCau(thongtin);
        }

        public static List<PhongDTO> DanhSachPhongTheoLoaiTheoYeuCau(PhongDTO thongtin)
        {
            return RoomDAO.DanhSachPhongTheoLoaiTheoYeuCau(thongtin);
        }

        public static List<PhongDTO> DanhSachPhongTheoDGTu(decimal dgtu)
        {
            return RoomDAO.DanhSachPhongTheoDGTu(dgtu);
        }

        public static List<PhongDTO> DanhSachPhongTheoKhoangDG(decimal dgtu, decimal dgden)
        {
            return RoomDAO.DanhSachPhongTheoKhoangDG(dgtu, dgden);
        }

        public static List<PhongDTO> DanhSachPhongTheoDGDen(decimal dgden)
        {
            return RoomDAO.DanhSachPhongTheoDGDen(dgden);
        }

        public static List<PhieuThuePhongDTO> NgayTraPhong()
        {
            return RoomDAO.NgayTraPhong();
        }

        public static object DanhSachPhongTraGanNhat()
        {
            return RoomDAO.DanhSachPhongTraGanNhat();
        }

        public static bool XoaPhongTrongCTHoaDon(PhongDTO infor)
        {
            return RoomDAO.XoaPhongTrongCTHoaDon(infor);
        }
    }
}
