using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyQuanCafe.DAO
{
    public static class HoaDonBanDAO
    {
        public static void InsertHoaDonBan(int idtable)
        {
            string query = "USP_InsertHoaDonBan @idtable ";

            SqlServerHelper.ExecuteNonQuery(query, new object[] { idtable });
        }

        public static void UpdateHoaDonBan(int idtable)
        {
            string query = "update HOADONBAN set STATUS = 1 where MABA = " + idtable + "";

            SqlServerHelper.ExecuteNonQuery(query);
        }
        public static void DeleteHoaDonBan(int idtable)
        {
            string query = "delete HOADONBAN where MABA = " + idtable + "";

            SqlServerHelper.ExecuteNonQuery(query);
        }
        public static int LayHoaDonTheoBan(int idtable)
        {
            string query = "select mahdb from hoadonban where MABA = " + idtable + " and status = 0";
            try
            {
                int id = (int)SqlServerHelper.ExecuteScalar(query);

                return id;
            }
            catch (System.Exception ex)
            {
                return -1;
            }
        }
        public static int LayHoaDonBanMax()
        {
            return (int)SqlServerHelper.ExecuteScalar("select MAX(MAHDB) from HoaDonBan");
        }
        public static void ChuyenBan(int idtable_old, int idtable_new)
        {
            string query = "USP_ChuyenBan @idtable_old , @idtable_new ";

            SqlServerHelper.ExecuteNonQuery(query, new object[] { idtable_old, idtable_new });
        }
    }
}
