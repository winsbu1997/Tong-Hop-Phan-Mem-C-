
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyNhanSu.Object;
using System.Data;
using System.Data.SqlClient;

namespace QuanLyNhanSu.Model
{
    class ChucVuMolL
    {
        ConnectToSQL_L con = new ConnectToSQL_L();
        SqlCommand cmd = new SqlCommand();

        public DataTable GetData()
        {
            DataTable dt = new DataTable();

            cmd.CommandText = "select * from ChucVu";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = con.conn;

            try
            {
                con.OpenConn();
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                sda.Fill(dt);
                con.CloseConn();
            }
            catch
            {
                cmd.Dispose();
                con.CloseConn();
            }
            return dt;
        }
        public bool AddData(ChucVuObjL Obj)
        {

            cmd.CommandText = " insert into ChucVu (MaCV,TenCV) values('" + Obj.MaCV + "',N'" + Obj.TenCV + "')";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = con.Connection;

            try
            {
                con.OpenConn();
                cmd.ExecuteNonQuery();

                return true;
            }
            catch (Exception ex)
            {
                string mex = ex.Message;
                cmd.Dispose();
                con.CloseConn();
            }

            return false;
        }
        public bool UpDate(ChucVuObjL Obj)
        {

            cmd.CommandText = " update ChucVu set TenCV = N'" + Obj.TenCV + "' where MaCV = '" + Obj.MaCV + "'";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = con.Connection;


            try
            {

                con.OpenConn();
                cmd.ExecuteNonQuery();

                return true;
            }
            catch (Exception ex)
            {
                string mex = ex.Message;
                cmd.Dispose();
                con.CloseConn();
            }

            return false;
        }

        public bool DelData(string ma)
        {
            DataTable dt = new DataTable();

            cmd.CommandText = " delete ChucVu where MaCV =  '" + ma + "'";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = con.Connection;

            try
            {
                con.OpenConn();
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                sda.Fill(dt);
                con.CloseConn();
            }
            catch (Exception ex)
            {
                string mex = ex.Message;
                cmd.Dispose();
                con.CloseConn();
            }
            return false;
        }

    }
}
