using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data;

namespace DAL
{
   public class LoaiPhongDAL
    {
        public List<LoaiPhong> DanhSachLoaiPhong()
        {
            List<LoaiPhong> dstb = new List<LoaiPhong>();
            DataTable dt = new DataTable();
            dt = DataProvider.Instance.GetDataQuerry("select * from LoaiPhong");
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                DataRow dr = dt.Rows[i];
                LoaiPhong tb = new LoaiPhong();
                tb.Maloaiphong = dr["maloaiphong"].ToString();
                tb.Tenloaiphong = dr["tenloaiphong"].ToString();
                tb.Songuoi= Int32.Parse(dr["songuoi"].ToString());
                tb.Giaphong = Decimal.Parse(dr["giaphong"].ToString());
                dstb.Add(tb);
            }
            return dstb;
        }

        public bool ThemLoaiPhong(string maloaiphong, string tenloaiphong, decimal giaphong, int songuoi)
        {
            string query = string.Format("Insert dbo.LoaiPhong ( maloaiphong , tenloaiphong, giaphong, songuoi ) values ( N'{0}', N'{1}', '{2}', '{3}')", maloaiphong, tenloaiphong, giaphong, songuoi);
            int result = DataProvider.Instance.ExNonQuery(query);
            return result > 0;
        }

        public bool XoaLoaiPhong(string maloaiphong)
        {
            string query = string.Format("delete dbo.LoaiPhong where maloaiphong = '{0}'", maloaiphong);
            int result = DataProvider.Instance.ExNonQuery(query);
            return result > 0;
        }

        public bool SuaLoaiPhong(string maloaiphong, string tenloaiphong, decimal giaphong, int songuoi)
        {
            string query = string.Format("Update dbo.LoaiPhong Set tenloaiphong = N'{0}', giaphong = N'{1}', songuoi =N'{2}' where maloaiphong = N'{3}'", tenloaiphong, giaphong, songuoi, maloaiphong);
            int result = DataProvider.Instance.ExNonQuery(query);
            return result > 0;
        }

        public List<LoaiPhong> TimKiemloaiphong(string tenloaiphong)
        {
            List<LoaiPhong> dstb = new List<LoaiPhong>();
            string query = string.Format("select * from dbo.LoaiPhong where tenloaiphong Like N'%' + N'{0}' +'%'", tenloaiphong);
            DataTable dt = new DataTable();
            dt = DataProvider.Instance.GetDataQuerry(query);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                DataRow dr = dt.Rows[i];
                LoaiPhong tb = new LoaiPhong();
                tb.Maloaiphong = dr["maloaiphong"].ToString();
                tb.Tenloaiphong = dr["tenloaiphong"].ToString();
                tb.Songuoi = Int32.Parse(dr["songuoi"].ToString());
                tb.Giaphong = Decimal.Parse(dr["giaphong"].ToString());
                dstb.Add(tb);
            }
            return dstb;
        }
        public LoaiPhong ThôngTinLoaiPhong(string maloaiphong)
        {
            LoaiPhong dstb = new LoaiPhong();
            string query = string.Format("select * from dbo.LoaiPhong where maloaiphong = N'{0}'", maloaiphong);
            DataTable dt = new DataTable();
            dt = DataProvider.Instance.GetDataQuerry(query);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                DataRow dr = dt.Rows[i];
                dstb.Maloaiphong = dr["maloaiphong"].ToString();
                dstb.Tenloaiphong = dr["tenloaiphong"].ToString();
                dstb.Songuoi = Int32.Parse(dr["songuoi"].ToString());
                dstb.Giaphong = Decimal.Parse(dr["giaphong"].ToString());
            }
            return dstb;
        }
        public string SinhMaLoaiPhong()
        {
            string s = "";
            DataTable dt = new DataTable();
            dt = DataProvider.Instance.GetDataQuerry("select *from LoaiPhong");
            if (dt.Rows.Count < 0)
            {
                s = "LP01";
            }
            else
            {
                int k = dt.Rows.Count;
                if (k < 9)
                {
                    s = "LP0" + (k + 1).ToString();
                }
                else if (k >= 9)
                {
                    s = "LP" + (k + 1).ToString();
                }

            }
            return s;
        }
    }

}

