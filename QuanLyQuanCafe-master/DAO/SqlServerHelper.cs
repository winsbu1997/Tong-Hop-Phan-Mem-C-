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
        /**
         * strConnect : link đến CSDL
         * SqlConnection: đối tượng kết nối đến CSDL
         * 
         */
        static private string strConnect = @"Data Source=.;Initial Catalog=QLBANHANG;Integrated Security=True";
        static private SqlConnection connection;
        static public string LopDangKy = "";

        public static void ConnectDataBase()
        {
            connection = new SqlConnection(strConnect); // Tạo đối tượng kết nối đến CSDL mới
            connection.Open();                          // Mở kết nối
        }

        public static void Disconnect()
        {
            connection.Close(); // Đóng kết nối CSDL
        }

        // Hàm thực hiện câu lện SQL Query: Trả về 1 DataTable
        public static DataTable ExecuteQuery(string query, object[] thamso = null)
        {
            SqlServerHelper.ConnectDataBase(); // Mở kết nối

            SqlCommand cmd = new SqlCommand(query, connection); // Tạo đối tượng thực hiện lệnh Query
            if (thamso != null)
            {
                string[] dsThamSo = query.Split(' '); // Tách tham số thành mảng
                int i = 0;
                foreach (string item in dsThamSo)
                    if (item.Contains("@"))    // Trả về bool giá trị '@' có trong chuỗi không ?
                    {
                        cmd.Parameters.AddWithValue(item, thamso[i]); // Gán thamso[i] = @__ vào lệnh Query 
                        i++;
                    }
            }
            DataTable ans = new DataTable();                    // Tạo DataTable chứa dữ liệu trả về
            SqlDataAdapter apdapter = new SqlDataAdapter(cmd);  // Thực hiện truy vấn
            apdapter.Fill(ans);                                 // Đổ dữ liệu vào DâtTable

            Disconnect(); //Ngắt kết nối CSDL
            return ans;
        }

        /**
         * Dùng khi không cần dữ liệu trả về là bảng mà chỉ cần trả về số row mà Query tác động lên (VD:insert, update, delete)
         */
        public static int ExecuteNonQuery(string query, object[] thamso = null)
        {
            ConnectDataBase();
            int ans = 0;

            SqlCommand cmd = new SqlCommand(query, connection); // nắm giữ thông tin về mệnh lệnh
            if (thamso != null)
            {
                string[] dsThamSo = query.Split(' '); //Tách chuỗi query thàng mảng các từ 
                int i = 0;
                foreach (string item in dsThamSo)
                    if (item.Contains("@"))
                    {
                        cmd.Parameters.AddWithValue(item, thamso[i]); 
                    }
            }

            ans = cmd.ExecuteNonQuery(); // trả về số row bị tác động

            Disconnect();
            return ans;
        }

        /**
         * Sử dụng khi muốn kết quả trả về là dữ liễu đơn: VD: tổng số tiền hóa đơn, tống số mặt hàng, ....
         */
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
