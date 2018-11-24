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
    class KyLuatModTH
    {
        ConnectToSQLTH con = new ConnectToSQLTH();
        SqlCommand cmd = new SqlCommand();

        public DataTable GetData()
        {
            DataTable dt = new DataTable();

            cmd.CommandText = "select * from KyLuat";
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
        public bool AddData(KyLuatObjTH Obj)
        {

            cmd.CommandText = " insert into KyLuat (MaKL,TenKL,HinhThuc,NguyenNhan,QuyDoiRaTienMat) values('" + Obj.makl + "',N'" + Obj.tenkl + "',N'" + Obj.hinhthuc + "' ,N'" + Obj.nguyennhan + "',N'" + Obj.quydoi + "')";
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
        public bool UpDate(KyLuatObjTH Obj)
        {

            cmd.CommandText = " update KyLuat set TenKL = N'" + Obj.tenkl + "' , HinhThuc = N'" + Obj.hinhthuc + "' , NguyenNhan = N'" + Obj.nguyennhan + "' , QuyDoiRaTienMat = N'" + Obj.quydoi + "' where MaKL = '" + Obj.makl+ "'";
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

            cmd.CommandText = " delete KyLuat where MaKL =  '" + ma + "'";
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
