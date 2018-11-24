using DTO;
using System;
using System.Collections.Generic;
using System.Data;

namespace DAL
{
    public class ThietBiDAL
    {
        public List<ThietBi> DanhSachThietBi()
        {
            List<ThietBi> dstb = new List<ThietBi>();
            DataTable dt = new DataTable();
            dt = DataProvider.Instance.GetDataQuerry("select * from ThietBi");
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                DataRow dr = dt.Rows[i];
                ThietBi tb = new ThietBi();
                tb.Mathietbi = dr["mathietbi"].ToString();
                tb.Tenthietbi = dr["tenthietbi"].ToString();
                tb.Soluong = Int32.Parse(dr["soluong"].ToString());
                tb.Giathietbi = Decimal.Parse(dr["giathietbi"].ToString());
                dstb.Add(tb);
            }
            return dstb;
        }

        public bool ThemThietBi(string mathietbi, string tenthietbi, decimal giathietbi, int soluong)
        {
            string query = string.Format("Insert dbo.ThietBi ( mathietbi , tenthietbi, giathietbi, soluong ) values ( N'{0}', N'{1}', '{2}', '{3}')", mathietbi, tenthietbi, giathietbi, soluong);
            int result = DataProvider.Instance.ExNonQuery(query);
            return result > 0;
        }

        public bool XoaThietBi(string mathietbi)
        {
            string query = string.Format("delete dbo.ThietBi where mathietbi = '{0}'", mathietbi);
            int result = DataProvider.Instance.ExNonQuery(query);
            return result > 0;
        }

        public bool SuaThietBi(string mathietbi, string tenthietbi, decimal giathietbi, int soluong)
        {
            string query = string.Format("Update dbo.ThietBi Set tenthietbi = N'{0}', giathietbi = N'{1}', soluong =N'{2}' where mathietbi = N'{3}'", tenthietbi, giathietbi, soluong, mathietbi);
            int result = DataProvider.Instance.ExNonQuery(query);
            return result > 0;
        }

        public List<ThietBi> TimKiemThietBi(string tenthietbi)
        {
            List<ThietBi> dstb = new List<ThietBi>();
            string query = string.Format("select * from dbo.ThietBi where tenthietbi Like N'%' + N'{0}' +'%'", tenthietbi);
            DataTable dt = new DataTable();
            dt = DataProvider.Instance.GetDataQuerry(query);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                DataRow dr = dt.Rows[i];
                ThietBi tb = new ThietBi();
                tb.Mathietbi = dr["mathietbi"].ToString();
                tb.Tenthietbi = dr["tenthietbi"].ToString();
                tb.Soluong = Int32.Parse(dr["soluong"].ToString());
                tb.Giathietbi = Decimal.Parse(dr["giathietbi"].ToString());
                dstb.Add(tb);
            }
            return dstb;
        }
        public ThietBi ThietBiTheoMa(string mathietbi)
        {
            ThietBi dstb = new ThietBi();
            DataTable dt = new DataTable();
           string query =string.Format("select * from ThietBi where mathietbi = N'{0}'", mathietbi);
            dt = DataProvider.Instance.GetDataQuerry(query);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                DataRow dr = dt.Rows[i];
               
                dstb.Mathietbi = dr["mathietbi"].ToString();
                dstb.Tenthietbi = dr["tenthietbi"].ToString();
                dstb.Soluong = Int32.Parse(dr["soluong"].ToString());
                dstb.Giathietbi = Decimal.Parse(dr["giathietbi"].ToString());
               
            }
            return dstb;
        }
        public string SinhMaThietBiPhong()
        {
            string s = "";
            DataTable dt = new DataTable();
            dt = DataProvider.Instance.GetDataQuerry("select *from ThietBi");
            if (dt.Rows.Count < 0)
            {
                s = "TB001";
            }
            else
            {
                int k = dt.Rows.Count;
                if (k < 9)
                {
                    s = "TB00" + (k + 1).ToString();
                }
                else if (k >= 9)
                {
                    s = "TB0" + (k + 1).ToString();
                }

            }
            return s;
        }

    }
}