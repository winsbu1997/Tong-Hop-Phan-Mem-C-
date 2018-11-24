using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanCafe.DAO
{
    public static class HoaDonNhapDAO
    {
        public static DataTable DanhSachHoaDon()
        {
            string query = "SELECT * FROM HOADONNHAP";
            return DAO.SqlServerHelper.ExecuteQuery(query);
        }

        public static void CapNhatHoaDonNhap(int MaHDN, int MaNV, DateTime Ngay, int TongTien, string NoiNhap)
        {
            string query = "UPDATE HOADONNHAP SET MANV = @MANV , NGAY = @NGAY , TONGTIEN = @TONGTIEN , NOINHAP = @NOINHAP WHERE MAHDN = @MAHDN";
            DAO.SqlServerHelper.ExecuteNonQuery(query, new object[] { MaNV, Ngay, TongTien, NoiNhap, MaHDN });
        }

        public static int ThemHoaDonNhap(int MaNV, DateTime Ngay, int TongTien, string NoiNhap){
            string query = "INSERT INTO HOADONNHAP(MANV, NGAY, TONGTIEN, NOINHAP) VALUES( @MANV , @NGAY , @TONGTIEN , @NOINHAP ) ";
            DAO.SqlServerHelper.ExecuteNonQuery(query, new object[] { MaNV, Ngay, TongTien, NoiNhap });
            query = "SELECT MAX(MAHDN) FROM HOADONNHAP";
            int ans = (int) DAO.SqlServerHelper.ExecuteScalar(query);
            return ans;
        }

        public static void XoaHoaDonNhap(int ma)
        {
            string query = "DELETE FROM HOADONNHAP WHERE MAHDN = @MAHDN ";
            DAO.SqlServerHelper.ExecuteNonQuery(query, new object[] { ma });
        }
    }
}
