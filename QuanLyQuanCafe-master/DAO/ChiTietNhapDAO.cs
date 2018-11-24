using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanCafe.DAO
{
    public static class ChiTietNhapDAO
    {
        public static DataTable DanhSachChiTietNhap()
        {
            string query = "SELECT * FROM CHITIETNHAP";
            return DAO.SqlServerHelper.ExecuteQuery(query);
        }

        public static void CapNhatChiTietNhap(int MACTN, int MAHDN, int MAMH, int SOLUONG, int DONGIA, int THANHTIEN)
        {
            string query = "UPDATE CHITIETNHAP SET MAHDN = @MAHDN , MAMH = @MAMH , SOLUONG = @SOLUONG , DONGIA = @DONGIA , THANHTIEN = @THANHTIEN WHERE MACTN = @MACTN";
            DAO.SqlServerHelper.ExecuteNonQuery(query, new object[] { MAHDN, MAMH, SOLUONG, DONGIA, THANHTIEN, MACTN });
        }

        public static int ThemChiTietNhap(int MaHDN, int MaMH, int SoLuong, int DonGia, int ThanhTien)
        {
            string query = "INSERT INTO CHITIETNHAP(MAHDN, MAMH, SOLUONG, DONGIA, THANHTIEN) VALUES( @MAHDN ,  @MAMH , @SOLUONG , @DONGIA , @THANHTIEN )";
            DAO.SqlServerHelper.ExecuteNonQuery(query, new object[] { MaHDN, MaMH, SoLuong, DonGia, ThanhTien });
            query = "SELECT MAX(MACTN) FROM CHITIETNHAP";
            int ans = (int)DAO.SqlServerHelper.ExecuteScalar(query);
            return ans;
        }

        public static void XoaChiTietNhap(int MaCTN)
        {
            string query = "DELETE FROM CHITIETNHAP WHERE MACTN = @MACTN";
            DAO.SqlServerHelper.ExecuteNonQuery(query, new object[] { MaCTN });
        }
    }
}
