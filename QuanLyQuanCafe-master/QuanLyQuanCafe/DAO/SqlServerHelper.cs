using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanCafe.DAO
{
    class SqlServerHelper
    {
        static private string strConnect = @"Data Source=DESKTOP-46S65U6;Initial Catalog=QUANLYQUANCAFE;Integrated Security=True";
        static private SqlConnection connection;
        static public string LopDangKy = "";

        public static void ConnectDataBase()
        {
            connection = new SqlConnection(strConnect);
            connection.Open();
        }

        public static void Disconnect()
        {
            connection.Close();
        }

        public static DataTable ExecuteQuery(string query, object[] thamso = null)
        {
            SqlServerHelper.ConnectDataBase();

            SqlCommand cmd = new SqlCommand(query, connection);
            if (thamso != null)
            {
                string[] dsThamSo = query.Split(' ');
                int i = 0;
                foreach (string item in dsThamSo)
                    if (item.Contains("@"))
                    {
                        cmd.Parameters.AddWithValue(item, thamso[i]);
                        i++;
                    }
            }
            DataTable ans = new DataTable();
            SqlDataAdapter apdapter = new SqlDataAdapter(cmd);
            apdapter.Fill(ans);

            Disconnect();
            return ans;
        }

        public static int ExecuteNonQuery(string query, object[] thamso = null)
        {
            ConnectDataBase();
            int ans = 0;

            SqlCommand cmd = new SqlCommand(query, connection);
            if (thamso != null)
            {
                string[] dsThamSo = query.Split(' ');
                int i = 0;
                foreach (string item in dsThamSo)
                    if (item.Contains("@"))
                    {
                        cmd.Parameters.AddWithValue(item, thamso[i]);
                        i++;
                    }
            }

            ans = cmd.ExecuteNonQuery();

            Disconnect();
            return ans;
        }

        public static object ExecuteScalar(string query, object[] thamso = null)
        {
            object ans = new object();
            ConnectDataBase();

            SqlCommand cmd = new SqlCommand(query, connection);
            if (thamso != null)
            {
                string[] dsThamSo = query.Split(' ');
                int i = 0;
                foreach (string item in dsThamSo)
                    if (item.Contains("@"))
                    {
                        cmd.Parameters.AddWithValue(item, thamso[i]);
                        i++;
                    }
            }

            ans = cmd.ExecuteScalar();
            Disconnect();

            return ans;
        }
    }
}
