using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;

namespace QuanLyNhanSu.Model
{
    class ConnectToSQLTH
    {
        public SqlConnection conn { get; set; }
        public SqlCommand cmd { get; set; }
        public string error { get; set; }
        string strCon;
        public SqlConnection Connection { get { return conn; } }

        public ConnectToSQLTH()
        {
           strCon = @"Data Source=.;Initial Catalog=QuanLyNhanSu;Integrated Security=True";
           // strCon = @"Data Source=ThuyLinh\SQLEXPRESS;Initial Catalog=QuanLyNhanSu;Integrated Security=True";

            conn = new SqlConnection(strCon);
        }
        public bool OpenConn()
        {
            try
            {
                if (conn.State == ConnectionState.Closed)
                    conn.Open();
                return true;
            }
            catch (Exception e)
            {
                error = e.Message;
                return false;
            }
        }
        public bool CloseConn()
        {
            try
            {
                if (conn.State == ConnectionState.Open)
                    conn.Close();
            }
            catch (Exception e)
            {
                error = e.Message;
                return false;
            }
            return true;
        }

    }
}
