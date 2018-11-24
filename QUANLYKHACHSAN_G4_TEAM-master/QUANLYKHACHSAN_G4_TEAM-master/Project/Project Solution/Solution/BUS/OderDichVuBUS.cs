using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using DTO;

namespace BUS
{
    public class OderDichVuBUS
    {
        public static List<OderDichVuDTO> LoadDanhSachMaPhong()
        {
            return OderServiceDAO.LoadDanhSachMaPhong();
        }

        public static List<OderDichVuDTO> LoadDanhSachDichVu()
        {
            return OderServiceDAO.LoadDanhSachDichVu();
        }

        public static bool DangKiDichVu(OderDichVuDTO infor)
        {
            if (infor.SoLuong > 0)
                return OderServiceDAO.DangKiDichVu(infor);
            else return false;
        }

        public static List<OderDichVuDTO> LayMaDichVuDangKi(string tendichvu)
        {
            return OderServiceDAO.LayMaDichVuDangKi(tendichvu);
        }

        public static int LaySoLuongDichVuDK(int? maPhong)
        {
            return OderServiceDAO.LaySoLuongDichVuDK(maPhong);
        }

        public static List<OderDichVuDTO> DanhSachDichVuDK(int? maPhong)
        {
            return OderServiceDAO.DanhSachDichVuDK(maPhong);
        }

        public static bool XoaDichVuPhongDK(HoaDonDTO inforHD)
        {
            return OderServiceDAO.XoaDichVuPhongDK(inforHD);
        }
    }
}
