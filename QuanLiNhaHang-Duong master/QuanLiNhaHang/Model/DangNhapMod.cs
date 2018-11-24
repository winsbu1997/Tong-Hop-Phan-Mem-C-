using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiNhaHang.Model
{
    class DangNhapMod
    {
        protected string IdDangNhap { get; set; }
        protected string MatKhau { get; set; }

        public DangNhapMod()
        {

        }

        public DangNhapMod(string _IdDangNhap)
        {
            IdDangNhap = _IdDangNhap;
        }

        public DangNhapMod(string _IdDangNhap, string _MatKhau)
        {
            IdDangNhap = _IdDangNhap;
            MatKhau = _MatKhau;
        }
        public int InsertDangNhap()
        {
            int i = 0;
            string[] paras = new string[2] { "@IdDangNhap","@matkhau"};
            object[] values = new object[2] {IdDangNhap, MatKhau };
            i = Model.Connection.Excute_Sql("InsertDangNhap", CommandType.StoredProcedure, paras, values);
            return i;
        }
        public int DeleteDangNhap()
        {
            int i = 0;
            string[] paras = new string[1] {"@IdDangNhap"};
            object[] values = new object[1] { IdDangNhap };
            i = Model.Connection.Excute_Sql("DeleteDangNhapByIdDangNhap", CommandType.StoredProcedure, paras, values);
            return i;
        }
        public int UpdateDangnhap()
        {
            int i = 0;
            string[] paras = new string[2] { "@IdDangNhap", "@matkhau" };
            object[] values = new object[2] { IdDangNhap, MatKhau };
            i = Model.Connection.Excute_Sql("UpdateDangNhap_MatKhau", CommandType.StoredProcedure, paras, values);
            return i;
        }
        public static DataTable FillDataTableDN()
        {
            DataTable dt = Model.Connection.FillDataTable("getDangNhap");
            return dt;
        }

    }
}
