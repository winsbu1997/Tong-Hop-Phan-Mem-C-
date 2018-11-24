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
    public class PhongDAL
    {
        public List<Phong> getListPhong()
        {
            DataTable dt = new DataTable();
            dt=DataProvider.Instance.GetDataQuerry("select * from Phong  p join LoaiPhong lp on p.maloaiphong=lp.maloaiphong");
            List<Phong> list = new List<Phong>();
            for(int i = 0; i < dt.Rows.Count; i++)
            {
                DataRow dr = dt.Rows[i];
                Phong p = new Phong();
                p.Maphong = dr["maphong"].ToString();
                p.Tenphong = dr["tenphong"].ToString();
                p.Tenloaiphong = dr["tenloaiphong"].ToString();
                p.Trangthai =(int)dr["trangthai"];
                p.Songuoi =(int) dr["songuoi"];
                p.Maloaiphong = dr["maloaiphong"].ToString();
                p.Giaphong =(Decimal) dr["giaphong"];
               
                list.Add(p);
            }
            return list;
        }
        public List<Phong> DanhSachPhongTrong()
        {
            DataTable dt = new DataTable();

            dt = DataProvider.Instance.GetDataQuerry("select * from Phong  p join LoaiPhong lp on p.maloaiphong=lp.maloaiphong where trangthai=0");
            List<Phong> list = new List<Phong>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                DataRow dr = dt.Rows[i];
                Phong p = new Phong();
                p.Maphong = dr["maphong"].ToString();
                p.Tenphong = dr["tenphong"].ToString();
                p.Tenloaiphong = dr["tenloaiphong"].ToString();
                p.Giaphong = Decimal.Parse(dr["giaphong"].ToString());
                p.Songuoi = (int)dr["songuoi"];
                p.Maloaiphong = dr["maloaiphong"].ToString();
                list.Add(p);
            }
            return list;
        }
        public List<Phong> DanhSachPhongTrongTheoNgay(DateTime ngaythue,DateTime ngaytra)
        {
            DataTable dt = new DataTable();
            SqlParameter[] pa = new SqlParameter[]
            {
                new SqlParameter("@ngayden",ngaythue),
                new SqlParameter("@ngaytra",ngaytra)
            };
            dt = DataProvider.Instance.GetData("sp_timkiemphongtheongay", pa);
            List<Phong> list = new List<Phong>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                DataRow dr = dt.Rows[i];
                Phong p = new Phong();
                p.Maphong = dr["maphong"].ToString();
                p.Tenphong = dr["tenphong"].ToString();
                p.Tenloaiphong = dr["tenloaiphong"].ToString();
                p.Giaphong = Decimal.Parse(dr["giaphong"].ToString());
                p.Songuoi = (int)dr["songuoi"];
                p.Maloaiphong = dr["maloaiphong"].ToString();
                list.Add(p);
            }
            return list;
        }
        public bool ThemPhong(string maphong, string tenphong,string maloaiphong , int trangthai )
        {
            string query = string.Format("Insert dbo.Phong (maphong, tenphong, maloaiphong, trangthai) values ('{0}', '{1}', '{2}', '{3}')", maphong, tenphong, maloaiphong, trangthai);
            int result = DataProvider.Instance.ExNonQuery(query);
            return result > 0;
        }
        public bool SuaPhong(string maphong, string tenphong, string maloaiphong, int trangthai)
        {
            string query = string.Format("update dbo.Phong set tenphong= N'{0}', maloaiphong = '{1}', trangthai= '{2}' where maphong = '{3}'", tenphong, maloaiphong, trangthai, maphong);
            int result = DataProvider.Instance.ExNonQuery(query);
            return result > 0;
        }
        public bool XoaPhong(string maphong)
        {
            string query = string.Format("delete dbo.Phong where maphong ='{0}'", maphong);
            int result = DataProvider.Instance.ExNonQuery(query);
            return result > 0;
        }
        public bool KiemTraMaPhong(string maphong)
        {
            string query = string.Format("select maphong from dbo.Phong where maphong ='{0}'", maphong);
            DataTable data = DataProvider.Instance.GetDataQuerry(query);
            if (data.Rows.Count > 0)
            {
                return true;
            }
            else
                return false;
        }
        public bool CapNhatTrangThaiPhong(string maphong, int trangthai)
        {
            string query = string.Format("update dbo.Phong set trangthai = '{0}' where maphong ='{1}'", trangthai, maphong);
            int result = DataProvider.Instance.ExNonQuery(query);
            return result > 0;

        }
        public List<Phong> TimKiemPhong(string tenphong)
        {
            DataTable dt = new DataTable();
            string query = string.Format("select * from Phong  p join LoaiPhong lp on p.maloaiphong=lp.maloaiphong where tenphong like N'%' + N'{0}' +'%'", tenphong);
            dt = DataProvider.Instance.GetDataQuerry(query);
            List<Phong> list = new List<Phong>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                DataRow dr = dt.Rows[i];
                Phong p = new Phong();
                p.Maphong = dr["maphong"].ToString();
                p.Tenphong = dr["tenphong"].ToString();
                p.Tenloaiphong = dr["tenloaiphong"].ToString();
                p.Trangthai = (int)dr["trangthai"];
                p.Songuoi = (int)dr["songuoi"];
                p.Maloaiphong = dr["maloaiphong"].ToString();
                p.Giaphong = (Decimal)dr["giaphong"];

                list.Add(p);
            }
            return list;
        }
        public Phong PhongTheoMa(string maphong)
        {
            Phong p = new Phong();
            DataTable dt = new DataTable();
            string query = string.Format("select * from Phong  p join LoaiPhong lp on p.maloaiphong=lp.maloaiphong where maphong='{0}'",maphong);
            dt = DataProvider.Instance.GetDataQuerry(query);
            
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                DataRow dr = dt.Rows[i];
               
                p.Maphong = dr["maphong"].ToString();
                p.Tenphong = dr["tenphong"].ToString();
                p.Tenloaiphong = dr["tenloaiphong"].ToString();
                p.Trangthai = (int)dr["trangthai"];
                p.Songuoi = (int)dr["songuoi"];
                p.Maloaiphong = dr["maloaiphong"].ToString();
                p.Giaphong = (Decimal)dr["giaphong"];
            }
            return p;
        }
        public string SinhMaPhong()
        {
            string s = "";
            DataTable dt = new DataTable();
            dt = DataProvider.Instance.GetDataQuerry("select *from Phong");
            if (dt.Rows.Count < 0)
            {
                s = "PH0001";
            }
            else
            {
                int k = dt.Rows.Count;
                if (k < 9)
                {
                    s = "LP000" + (k + 1).ToString();
                }
                else if (k >= 9)
                {
                    s = "LP00" + (k + 1).ToString();
                }

            }
            return s;
        }
    }
}
