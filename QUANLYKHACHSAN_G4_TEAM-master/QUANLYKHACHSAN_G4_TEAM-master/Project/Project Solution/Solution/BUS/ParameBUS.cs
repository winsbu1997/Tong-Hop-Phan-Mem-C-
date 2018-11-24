using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using DTO;
namespace BUS
{
    public class ParameBUS
    {
        public static List<ThamSoDTO> LoadSoLuongKhach()
        {
            return ParameDAO.LoadSoLuongKhach();
        }

        public static List<ThamSoDTO> LoadHeSo()
        {
            return ParameDAO.LoadHeSo();
        }

        public static List<ThamSoDTO> LoadPhuThu()
        {
            return ParameDAO.LoadPhuThu();
        }

        public static bool CapNhatTSSoKhachToiDa(ThamSoDTO infor)
        {
            return ParameDAO.CapNhatTSSoKhachToiDa(infor);
        }

        public static bool CapNhatTSHeSo(ThamSoDTO infor)
        {
            return ParameDAO.CapNhatTSHeSo(infor);
        }

        public static bool CapNhatTSPhuThu(ThamSoDTO infor)
        {
            return ParameDAO.CapNhatTSPhuThu(infor);
        }

        public static List<ThamSoDTO> LayThongTinTS()
        {
            return ParameDAO.LayThongTinTS();
        }

        public static List<ThamSoDTO> LoadDonGia(string text)
        {
            return ParameDAO.LoadDonGia(text);
        }

        public static bool CapNhatTSDonGia(ThamSoDTO ts, string t)
        {
            if (ts.DonGia <= 0)
                return false;
            return ParameDAO.CapNhatTSDonGia(ts, t);
        }
    }
}
