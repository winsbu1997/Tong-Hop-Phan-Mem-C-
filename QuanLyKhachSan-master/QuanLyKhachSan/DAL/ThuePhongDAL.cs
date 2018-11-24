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
    public class ThuePhongDAL
    {
        public ThuePhong LayThongTinThuePhong(string maphong)
        {
            SqlParameter[] pa = new SqlParameter[]
            {
                new SqlParameter("@maphong",maphong)
            };
            ThuePhong tp = new ThuePhong();
            DataTable dt = new DataTable();
            dt = DataProvider.Instance.GetData("sp_laythongtinthuephonggannhat", pa);
            if (dt.Rows.Count > 0)
            {
                DataRow dr = dt.Rows[0];
                tp.Makhachhang = dr["makhachhang"].ToString();
                tp.Mathuephong = dr["mathuephong"].ToString();
                tp.Makhachhang = dr["makhachhang"].ToString();
                tp.Ngaythue = (DateTime)dr["ngaythuephong"];
                tp.Masudungdichvu= dr["masudungdichvu"].ToString();
               
            }
            return tp;
        }
        public bool ThemThuePhong(List<Phong> dsThuePhong,string makhachhang,string manhanvien,DateTime ngaythue)
        {
            string mathuephong = SinhMaThuePhong();
            SqlParameter[] pa = new SqlParameter[]
            {
              new SqlParameter("@mathuephong",mathuephong),
              new SqlParameter("@makhachhang",makhachhang),
              new SqlParameter("@manhanvien",manhanvien),
              new SqlParameter("@ngaythue",ngaythue)
            };
            ChiTietThuePhongDAL ct = new ChiTietThuePhongDAL();
            bool check = true;
            if(DataProvider.Instance.ExecuteNonQuery("sp_themthuephong", pa) > 0)
            {
                foreach(Phong p in dsThuePhong)
                {
                   if(ct.ThemChiTietThuePhong(mathuephong, p.Maphong, mathuephong + "-" + p.Maphong) == false)
                    {
                        check = false;
                    }
                }
            }
            
            return check;
          
        }
        public string SinhMaThuePhong()
        {
            string s = "";
            DataTable dt = new DataTable();
            dt = DataProvider.Instance.GetDataQuerry("select *from ThuePhong");
            if (dt.Rows.Count < 0)
            {
                s = "TP0001";
            }
            else
            {
                int k = dt.Rows.Count;
                if (k < 9)
                {
                    s = "TP000" + (k + 1).ToString();
                }
                else if (k >= 9 && k < 99)
                {
                    s = "TP00" + (k + 1).ToString();
                }
                else if (k >= 99 && k < 999)
                {
                    s = "TP0" + (k + 1).ToString();
                }
                else if (k >= 999)
                    s = "TP" + (k + 1).ToString();

            }
            return s;
        }
     
    }
}
