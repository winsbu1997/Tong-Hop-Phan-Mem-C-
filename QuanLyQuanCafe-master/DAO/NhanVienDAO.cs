
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanCafe.DAO
{
    public static class NhanVienDAO
    {
        public static DataTable DanhSachNhanVien()
        {
            string query = "SELECT * FROM NHANVIEN";
            return DAO.SqlServerHelper.ExecuteQuery(query);
        }

        public static void ThemNhanVien(string TenNV, string GioiTinh, string DiaChi, int NamSinh, string SDT)
        {
            string query = "INSERT INTO NHANVIEN(TENNV, GIOITINH, DIACHI, NAMSINH, SDT) VALUES( @TENNV , @GIOITINH , @DIACHI , @NAMSINH , @SDT )";
            DAO.SqlServerHelper.ExecuteNonQuery(query, new object[] { TenNV, GioiTinh, DiaChi, NamSinh, SDT });
        }

        public static void XoaNhanVien(int ma)
        {
            string query = "DELETE FROM NHANVIEN WHERE MANV = @MANV ";
            DAO.SqlServerHelper.ExecuteNonQuery(query, new object[] { ma });
        }

        public static void CapNhatNhanVien(int ma, string TenNV, string GioiTinh, string DiaChi, int NamSinh, string SDT)
        {
            string query = "UPDATE NHANVIEN SET TENNV = @TENNV , GIOITINH = @GIOITINH , DIACHI =  @DIACHI , NAMSINH = @NAMSINH , SDT = @SDT WHERE MANV = @MANV";
            DAO.SqlServerHelper.ExecuteNonQuery(query, new object[] { TenNV, GioiTinh, DiaChi, NamSinh, SDT, ma });
        }
    }
}
