using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using DTO;

namespace BUS
{
    public class ServiceBUS
    {
        public static List<DichVuDTO> LoadDanhSach()
        {
            return ServiceDAO.LoadDanhSach();
        }

        public static bool XoaDichVu(DichVuDTO infor)
        {
            return ServiceDAO.XoaDichVu(infor);
        }

        public static bool SuaThongTinDichVu(DichVuDTO infor)
        {
            return ServiceDAO.SuaThongTinDichVu(infor);
        }

        public static bool ThemDichVu(DichVuDTO infor)
        {
            return ServiceDAO.ThemDichVu(infor);
        }

        public static List<DichVuDTO> LayDonGia(int maDichVu)
        {
            return ServiceDAO.LayDonGia(maDichVu);
        }
    }
}
