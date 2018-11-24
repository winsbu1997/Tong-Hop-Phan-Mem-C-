using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class SuDungDichVuDAL
    {
        public bool ThemChiTietSuDungDichVu(string masudungdichvu, string madichvu, int soluong, decimal thanhtien)
        {
            SqlParameter[] pa = new SqlParameter[]
            {
                new SqlParameter("@masudungdichvu",masudungdichvu),
                new SqlParameter("@madichvu",madichvu),
                new SqlParameter("@soluong",soluong),
                new SqlParameter("@thanhtien",thanhtien)

            };
            return DataProvider.Instance.ExecuteNonQuery("sp_themchitietsudungdichvu", pa) > 0;
        }
        public bool CapNhatChiTietSuDungDichVu(string masudungdichvu, string madichvu, int soluong, decimal thanhtien)
        {
            SqlParameter[] pa = new SqlParameter[]
            {
                new SqlParameter("@masudungdichvu",masudungdichvu),
                new SqlParameter("@madichvu",madichvu),
                new SqlParameter("@soluong",soluong),
                new SqlParameter("@thanhtien",thanhtien)

            };
            return DataProvider.Instance.ExecuteNonQuery("sp_capnhatchitietsudungdichvu", pa) > 0;
        }
        public bool XoaChiTietSuDungDichVu(string masudungdichvu, string madichvu)
        {
            SqlParameter[] pa = new SqlParameter[]
            {
                new SqlParameter("@masudungdichvu",masudungdichvu),
                new SqlParameter("@madichvu",madichvu)

            };
            return DataProvider.Instance.ExecuteNonQuery("sp_xoachitietsudungdichvu", pa) > 0;
        }
        public List<SuDungDichVu> DanhSachDVPhongSD(string masudungdichvu)
        {
            List<SuDungDichVu> list = new List<SuDungDichVu>();
            SqlParameter[] pa = new SqlParameter[]
           {
                new SqlParameter("@masudungdichvu",masudungdichvu),
           };
            DataTable dt = new DataTable();

            dt = DataProvider.Instance.GetData("sp_danhsachdichvusudungcuaphong", pa);
            if (dt.Rows.Count > 0)
            {
                foreach (DataRow dr in dt.Rows)
                {
                    SuDungDichVu s = new SuDungDichVu();
                    s.Masudungdichvu = masudungdichvu;
                    s.Madichvu = dr["madichvu"].ToString();
                    s.Thanhtien = Decimal.Parse(dr["thanhtien"].ToString());
                    s.Soluong = (int)dr["soluong"];
                    s.Dongia = Decimal.Parse(dr["dongia"].ToString());
                    s.Tendichvu = dr["tendichvu"].ToString();
                    list.Add(s);
                }
            }
            return list;
        }
        public decimal TongTienDichVu(string masudungdichvu)
        {
            decimal tongtien = 0;
            SqlParameter[] pa = new SqlParameter[]
            {
                new SqlParameter("@masudungdichvu",masudungdichvu)
            };
            DataTable dt = new DataTable();
            dt = DataProvider.Instance.GetData("sp_tongtiendichvu", pa);
            if (dt.Rows.Count > 0)
            {
                DataRow dr = dt.Rows[0];
                tongtien = (decimal)dr["tongtiendichvu"];
            }
            return tongtien;
        }
    }
}
