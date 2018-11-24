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
    class HopDongMod
    {
        public static SqlConnection conn;
        public static DataTable GetData()
        {
            try
            {
                DataTable dt = new DataTable();
                string sql = " select * from HopDong ";
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

        public static int InsertProfile(HopDongObj qh)
        {
            SqlParameter[] para = new SqlParameter[]
             {
                new SqlParameter("@ma", qh.MaHD),
                new SqlParameter("@ten",qh.TenHD),
                new SqlParameter("@loai",qh.LoaiHD),
                new SqlParameter("@ngaybatdau",qh.NgayBatDau),
                new SqlParameter("@ngayketthuc",qh.NgayKetThuc),
                new SqlParameter("@bac",qh.BacLuong)





             };

            return ConectToSQL_Datvd.Execute_NonQuery("ThemHopDong", para);
        }
        public static int UpdateProfile(HopDongObj qh)
        {
            SqlParameter[] para = new SqlParameter[]
            {  new SqlParameter("@ma", qh.MaHD),
                new SqlParameter("@ten",qh.TenHD),
                new SqlParameter("@loai",qh.LoaiHD),
                new SqlParameter("@ngaybatdau",qh.NgayBatDau),
                new SqlParameter("@ngayketthuc",qh.NgayKetThuc),
                new SqlParameter("@bac",qh.BacLuong)

            };

            return ConectToSQL_Datvd.Execute_NonQuery("SuaHopDong", para);
        }
        public static int DeleteProfile(HopDongObj qh)
        {
            SqlParameter[] para = new SqlParameter[]
            {
                 new SqlParameter("@ma", qh.MaHD)

            };

            return ConectToSQL_Datvd.Execute_NonQuery("XoaHopDong", para);
        }
    }
}
