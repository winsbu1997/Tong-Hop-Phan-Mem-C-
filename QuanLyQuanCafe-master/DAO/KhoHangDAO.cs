using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanCafe.DAO
{
    public static class KhoHangDAO
    {
        public static DataTable QuanLyKho()
        {
            string query = "USP_QuanLyKho";

            DataTable data = SqlServerHelper.ExecuteQuery(query);

            return data;
        }

        public static DataTable ThongKe(DateTime fromday, DateTime today)
        {
            string query = "USP_ThongKe @fromday , @today ";

            DataTable data = SqlServerHelper.ExecuteQuery(query, new object[] { fromday, today });

            return data;
        }
    }
}
