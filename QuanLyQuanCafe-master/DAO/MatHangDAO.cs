using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyQuanCafe.DAO
{
    public static class MatHangDAO
    {
        public static DataTable DanhSachMatHang()
        {
            DataTable ans = new DataTable();
            string query = "SELECT * FROM MATHANG";
            ans = DAO.SqlServerHelper.ExecuteQuery(query);
            return ans;
        }

        public static void ThemMatHang(string TenMH, string DvTinh, int DONGIA, byte[] HinhAnh)
        {
            if (HinhAnh != null)
            {
                string query = "INSERT INTO MATHANG(TENMH, DVTINH, DONGIA, HINHANH) VALUES( @TENMH , @DVTINH , @DONGIA , @HINHANH )";
                DAO.SqlServerHelper.ExecuteNonQuery(query, new object[] { TenMH, DvTinh, DONGIA, HinhAnh });
            }
            else
            {
                string query = "INSERT INTO MATHANG(TENMH, DVTINH, DONGIA, HINHANH) VALUES( @TENMH , @DVTINH , @DONGIA , NULL )";
                DAO.SqlServerHelper.ExecuteNonQuery(query, new object[] { TenMH, DvTinh, DONGIA});
            }
        }

        public static void CapNhatMatHang(int MaMH, string TenMH, string DvTinh, int DONGIA, byte[] HinhAnh)
        {
            if (HinhAnh != null)
            {
                string query = "UPDATE MATHANG SET TENMH = @TENMH , DVTINH = @DONVITINH , DONGIA = @DONGIA , HINHANH = @HINHANH WHERE MAMH = @MAMH";
                DAO.SqlServerHelper.ExecuteNonQuery(query, new object[] { TenMH, DvTinh, DONGIA, HinhAnh, MaMH });
            }
            else
            {
                string query = "UPDATE MATHANG SET TENMH = @TENMH , DVTINH = @DONVITINH , DONGIA = @DONGIA , HINHANH = NULL WHERE MAMH = @MAMH";
                DAO.SqlServerHelper.ExecuteNonQuery(query, new object[] { TenMH, DvTinh, DONGIA, MaMH });
            }
        }
        public static void XoaMatHang(int MaMH)
        {
            string query = "DELETE FROM MATHANG WHERE MAMH = @MAMH";
            DAO.SqlServerHelper.ExecuteNonQuery(query, new object[] { MaMH });
        }

        public static int CheckHangTonKho(int mamh, int soluong)
        {
            string query = "USP_CheckHangTonKho @mamh , @soluong ";

            int chk = (int)SqlServerHelper.ExecuteScalar(query, new object[] { mamh, soluong });

            return chk;
        }
    }
}
