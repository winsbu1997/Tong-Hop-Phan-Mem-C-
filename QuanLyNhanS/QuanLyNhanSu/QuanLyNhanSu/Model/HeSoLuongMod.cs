using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyNhanSu.Object;
using System.Data.SqlClient;
using System.Data;

namespace QuanLyNhanSu.Model
{
    class HeSoLuongMod
    {
        public static SqlConnection conn;
        public static DataTable GetData()
        {
            try
            {
                DataTable dt = new DataTable();
                string sql = " select * from HeSoLuong ";
                conn = ConectToSQL_Datvd.Connect();
                SqlDataAdapter da = new SqlDataAdapter(sql, conn);
                da.Fill(dt);
                conn.Close();
                return dt;
            }
            catch
            {
                conn.Close();
                return null;
            }
        }

        public static int InsertProfile(HeSoLuong qh)
        {
            SqlParameter[] para = new SqlParameter[]
             {
                new SqlParameter("@bac", qh.BacLuong),
                new SqlParameter("@luongcb",qh.LuongCB),
                new SqlParameter("@luongtangca",qh.LuongTangCa)


             };

            return ConectToSQL_Datvd.Execute_NonQuery("ThemLuong", para);
        }
        public static int UpdateProfile(HeSoLuong qh)
        {
            SqlParameter[] para = new SqlParameter[]
            {  new SqlParameter("@bac", qh.BacLuong),
                new SqlParameter("@luongcb",qh.LuongCB),
                new SqlParameter("@luongtangca",qh.LuongTangCa)


            };

            return ConectToSQL_Datvd.Execute_NonQuery("SuaLuong", para);
        }
        public static int DeleteProfile(HeSoLuong qh)
        {
            SqlParameter[] para = new SqlParameter[]
            {
                 new SqlParameter("@bac", qh.BacLuong)

            };

            return ConectToSQL_Datvd.Execute_NonQuery("XoaLuong", para);
        }
    }
}
