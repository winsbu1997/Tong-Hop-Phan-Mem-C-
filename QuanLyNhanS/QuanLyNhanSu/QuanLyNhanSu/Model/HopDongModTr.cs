using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using QuanLyNhanSu.Object;
namespace QuanLyNhanSu.Model
{
    class HopDongModTr
    {
        public static DataTable GetListHopDong()
        {
            return ConnetctToSQLTr.GetData("select *  from HopDong");
        }
    }
}
