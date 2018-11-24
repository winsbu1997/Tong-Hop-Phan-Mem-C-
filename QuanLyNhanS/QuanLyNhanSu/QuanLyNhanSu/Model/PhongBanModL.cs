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
    class PhongBanModL
    {
        ConnectToSQL_L con = new ConnectToSQL_L();
        SqlCommand cmd = new SqlCommand();

        public DataTable GetData()
        {
            DataTable dt = new DataTable();

            cmd.CommandText = "select * from PhongBan";
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
        public bool AddData(PhongBanObjL Obj)
        {

            cmd.CommandText = " insert into PhongBan (MaPB,TenPB,DiaChi,SDT) values('" + Obj.MaPB + "',N'" + Obj.TenPB + "',N'" + Obj.DiaChi + "' ,N'" + Obj.SDT + "')";
            cmd.CommandType = CommandType.Text;
            cmd.Connection =con.Connection;

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
        public bool UpDate(PhongBanObjL Obj)
        {

            cmd.CommandText = " update PhongBan set TenPB = N'" + Obj.TenPB+ "' , DiaChi = N'" + Obj.DiaChi + "' , SDT = N'" + Obj.SDT + "' where MaPB = '" + Obj.MaPB + "'";
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

            cmd.CommandText = " delete PhongBan where MaPB =  '" + ma + "'";
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
