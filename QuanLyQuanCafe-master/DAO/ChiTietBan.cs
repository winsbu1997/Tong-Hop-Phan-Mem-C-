using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyQuanCafe.DAO
{
    public static class ChiTietBan
    {
        public static DataTable HienThiHoaDon(int idtable)
        {
            string query = "HienThiHoaDon @idtable ";

            DataTable data = SqlServerHelper.ExecuteQuery(query, new object[] { idtable });

            return data;
        }

        public static void InsertChiTietBan(int mahdb, int mamh, int soluong)
        {
            string query = "USP_InsertChiTietBan @mahdb , @mamh , @soluong ";

            SqlServerHelper.ExecuteNonQuery(query, new object[] { mahdb, mamh, soluong});
        }

        public static void DeleteChiTietBan(int mahdb)
        {
            string query = "delete CHITIETBAN where MAHDB = " + mahdb + "";

            SqlServerHelper.ExecuteNonQuery(query);
        }

        public static void TraMon(int mahdb, int mamh, int soluong)
        {
            string query = "USP_TraMon @mahdb , @mamh , @soluong ";

            SqlServerHelper.ExecuteNonQuery(query, new object[] { mahdb, mamh, soluong });
        }

        public static double TongTien(int mahdb)
        {
            string query = "USP_TongTien @mahdb ";

            try
            {
                int data = (int)SqlServerHelper.ExecuteScalar(query, new object[] { mahdb });
                return data;
            }
            catch
            {
                return 0;
            }
        }
    }

}
