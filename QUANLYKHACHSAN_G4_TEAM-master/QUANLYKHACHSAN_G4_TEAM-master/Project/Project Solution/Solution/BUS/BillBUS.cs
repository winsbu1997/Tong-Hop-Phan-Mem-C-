using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using DTO;

namespace BUS
{
    public class BillBUS
    {
        public static List<HoaDonDTO> LoadMaPhong()
        {
            return BillDAO.LoadDanhSach();
        }

        public static List<HoaDonDTO> LayThongTinPhongThue(HoaDonDTO infor)
        {
            return BillDAO.LayThongTinPhongThue(infor);
        }

        public static bool TinhSoNgayDaThue(HoaDonDTO infor)
        {
            return BillDAO.TinhSoNgayDaThue(infor);
        }

        public static List<HoaDonDTO> LaySoNgayDaThue()
        {
            return BillDAO.LaySoNgayDaThue();
        }

        public static object LayMaPhongDaThue()
        {
            return BillDAO.LayMaPhongDaThue();
        }

        public static int LaySoLuongKhach(int maphieuthue)
        {
            return BillDAO.LaySoLuongKhach(maphieuthue);
        }

        public static List<HoaDonDTO> LayKhachNuocNgoai()
        {
            return BillDAO.LayKhachNuocNgoai();
        }

        public static List<HoaDonDTO> TinhPhuThu(int num)
        {
            return BillDAO.TinhPhuThu(num);
        }

        public static int DemSoLuongKhachNuocNgoai(HoaDonDTO infor)
        {
            return BillDAO.DemSoLuongKhachNuocNgoai(infor);
        }

        public static List<HoaDonDTO> TinhHeSo()
        {
            return BillDAO.TinhHeSo();
        }

        public static decimal ThanhTien(int snt, decimal dg, decimal pt, decimal hs, decimal pdv)
        {
            decimal thanhtien = 0;
            if (hs != 0)
                thanhtien = dg * snt * (hs + pt) + pdv;
            else
                thanhtien = dg * snt * (1 + pt) + pdv;
            return thanhtien;
        }
        /*public static decimal ThanhTien(int snt, decimal dg, decimal pt, decimal hs)
        {
            decimal thanhtien = 0;
            if (snt == 0)
            {
                return (thanhtien = dg );
            }
            else
            {
                thanhtien = dg * snt;
                thanhtien = thanhtien + dg * pt ;
                if (hs != 0)
                {
                    thanhtien *= hs;
                    return thanhtien;
                }
                else
                {
                    return thanhtien;
                }
            }
        }*/

        public static int? LayMaHDCuoiCung()
        {
            return BillDAO.LayMaHDCuoiCung();
        }

        public static bool LapHoaDon(HoaDonDTO infor)
        {
            return BillDAO.LapHoaDon(infor);
        }

        public static List<HoaDonDTO> LayMaPhieuThue(int maphong)
        {
            return BillDAO.LayMaPhieuThue(maphong);
        }

        public static bool LapChiTietHoaDon(HoaDonDTO infor, HoaDonDTO inforHD)
        {
            return BillDAO.LapChiTietHoaDon(infor, inforHD);
        }

        public static bool XoaChiTietPhieuThue(HoaDonDTO inforHD)
        {
            return BillDAO.XoaChiTietPhieuThue(inforHD);
        }

        public static bool XoaPhieuThue(HoaDonDTO inforHD)
        {
            return BillDAO.XoaPhieuThue(inforHD);
        }
    }
}
