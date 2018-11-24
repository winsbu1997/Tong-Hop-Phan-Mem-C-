using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
   public class ChiTietThuePhongDAL
    {
        public bool ThemChiTietThuePhong(string mathuephong,string maphong,string masudungdichvu)
        {
            SqlParameter [] pa = new SqlParameter[]
            {
                new SqlParameter("@mathuephong",mathuephong),
                new SqlParameter("@maphong",maphong),
                new SqlParameter("@masudungdichvu",masudungdichvu)
            };
            return DataProvider.Instance.ExecuteNonQuery("sp_themchitietthuephong",pa)>0;
        }
    }
}
