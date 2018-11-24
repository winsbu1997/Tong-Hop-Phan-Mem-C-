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
    class KhenThuongModTH
    {
        ConnectToSQLTH con = new ConnectToSQLTH();
        SqlCommand cmd = new SqlCommand();

        public DataTable GetData()
        {
            DataTable dt = new DataTable();

            cmd.CommandText = "select * from KhenThuong";
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
        public bool AddData(KhenThuongObjTH Obj)
        {

            cmd.CommandText = " insert into KhenThuong (MaKT,TenKT,HinhThuc,NoiDung,QuyDoiRaTienMat) values('" + Obj.makt + "',N'" + Obj.tenkt + "',N'" + Obj.hinhthuc + "' ,N'"+Obj.noidung+"',N'"+Obj.quydoi+"')";
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
        public bool UpDate(KhenThuongObjTH Obj)
        {

            cmd.CommandText = " update KhenThuong set TenKT = N'" + Obj.tenkt + "' , HinhThuc = N'" + Obj.hinhthuc + "' , NoiDung = N'"+Obj.noidung+"' , QuyDoiRaTienMat = N'"+Obj.quydoi+"' where MaKT = '" + Obj.makt + "'";
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

            cmd.CommandText = " delete KhenThuong where MaKT =  '" + ma + "'";
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
