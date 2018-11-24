using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace DAL
{
    class DataProvider
    {
        private string chuoiketnoi = @"Data Source=.;Initial Catalog=QuanLyKhachSan;Integrated Security=True";
        private static DataProvider instance;
        public static DataProvider Instance
        {
            get { if (instance == null) instance = new DataProvider(); return instance; }
            private set { instance = value;}
        }
        private DataProvider() { }
        private SqlConnection con = null;
        /// <summary>
        /// Mở kết nối
        /// </summary>
        /// <returns></returns>
        public int open()
        {
            int ret;
            con = new SqlConnection(chuoiketnoi);
            try
            {
                con.Open();
                ret = 1;
            }
            catch (Exception)
            {
                ret = 0;
            }
            return ret;
        }
        public int close()
        {
            int ret;
            if (con == null)
            {
                ret = 1;
            }
            try
            {
                con.Close();
                ret = 1;
            }
            catch (Exception)
            {
                ret = 0;
            }
            return ret;

        }
        /// <summary>
        /// Lấy dữ liệu từ database đổ về datatable
        /// </summary>
        /// <param name="querry"></param>
        /// <param name="pa"></param>
        /// <returns></returns>
        public DataTable GetData(string querry, SqlParameter[] pa = null)
        {
            DataTable dt = new DataTable();
            if (open() == 0)
            {
                open();
            }
            SqlCommand command = new SqlCommand();
            command.Connection = con;
            command.CommandText = querry;
            command.CommandType = CommandType.StoredProcedure;
            if (pa != null)
            {
                command.Parameters.AddRange(pa);
            }
            SqlDataAdapter data = new SqlDataAdapter(command);
            data.Fill(dt);
            close();
            return dt;
        }
        public DataTable GetDataQuerry(string querry)
        {
            DataTable dt = new DataTable();
            if (open() == 0)
            {
                open();
            }
            SqlCommand command = new SqlCommand();
            command.Connection = con;
            command.CommandText = querry;
            command.CommandType = CommandType.Text;
            SqlDataAdapter data = new SqlDataAdapter(command);
            data.Fill(dt);
            close();
            return dt;
        }
        /// <summary>
        ///  thực thi truy vấn nonquery -insert-update-delete trả về số bản ghi được tác động
        /// </summary>
        /// <param name="storename">tên thủ tục hoặc câu lệnh truy vấn</param>
        /// <param name="pa">tham số truyền vào nếu có</param>
        /// <returns></returns>
        public int ExecuteNonQuery(string storename, SqlParameter[] pa = null)
        {
            int ret = 0;
            if (open() == 0)
            {
                open();
            }
            SqlCommand command = new SqlCommand();
            command.CommandText = storename;
            command.Connection = con;
            command.CommandType = CommandType.StoredProcedure;
            if (pa != null) command.Parameters.AddRange(pa);
            try
            {
                ret = command.ExecuteNonQuery();
                
            }
            catch (Exception)
            {
             
                ret = -1;
            }
            close();
            return ret;
        }
        public int DangNhap(string name_storeproc, SqlParameter[] pa) {
            int ret = 0;
            open();
            SqlCommand commd = new SqlCommand();
            commd.CommandText = name_storeproc;
            commd.Connection = con;
            commd.CommandType = CommandType.StoredProcedure;
            if (pa != null) {
                commd.Parameters.AddRange(pa);
            }
            try
            {
                ret = (Int32)commd.ExecuteScalar();
            }
            catch (Exception ex) {
                return -1;
            }
            close();
            return ret;
        }
        public int ExNonQuery(string query, object[] pramater = null)
        {
            int data = 0;
            using (SqlConnection connection = new SqlConnection(chuoiketnoi))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);

                if (pramater != null)
                {
                    string[] listPars = query.Split(' ');
                    int i = 0;
                    foreach (string item in listPars)
                    {
                        if (item.Contains('@'))
                        {
                            command.Parameters.AddWithValue(item, pramater[i]);
                            i++;
                        }
                    }
                }
                data = command.ExecuteNonQuery();
                connection.Close();
            }
            return data;
        }
    }
}
