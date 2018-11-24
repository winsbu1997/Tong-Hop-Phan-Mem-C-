using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
   public class TraPhongDAL
    {
        public bool ThemTraPhong(string mathuephong, string matraphong, decimal tongtien, DateTime ngaytra, string manhanvien, string thongtin)
        {
            string query = string.Format("Insert dbo.TraPhong (mathuephong, matraphong, tongtien, ngaytra, manhanvien, thongtin) values ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}')", mathuephong, matraphong, tongtien, ngaytra, manhanvien, thongtin);
            int result = DataProvider.Instance.ExNonQuery(query);
            return result > 0;
        }
        public string SinhMaTraPhong()
        {
            string s = "";
            DataTable dt = new DataTable();
            dt = DataProvider.Instance.GetDataQuerry("select *from TraPhong");
            if (dt.Rows.Count < 0)
            {
                s = "TraP01";
            }
            else
            {
                int k = dt.Rows.Count;
                if (k < 9)
                {
                    s = "TraP0" + (k + 1).ToString();
                }
                else if (k >= 9)
                {
                    s = "TraP" + (k + 1).ToString();
                }

            }
            return s;
        }
    }
}
