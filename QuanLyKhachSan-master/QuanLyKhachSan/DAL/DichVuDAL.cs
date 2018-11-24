using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
   public class DichVuDAL
    {
        public List<DichVu> DanhSachDichVu()
        {
            List<DichVu> list = new List<DichVu>();
            DataTable dt = new DataTable();
            dt = DataProvider.Instance.GetDataQuerry("select *from DichVu");
            foreach(DataRow dr in dt.Rows)
            {
                DichVu d = new DichVu();
                d.Madichvu = dr["madichvu"].ToString();
                d.Tendichvu = dr["tendichvu"].ToString();
                d.Dongia =Decimal.Parse( dr["dongia"].ToString());
                list.Add(d);
            }
            return list;
        }
        public List<DichVu> TimKiemDichVu(string chuoitimkiem)
        {

            List<DichVu> list = new List<DichVu>();
            DataTable dt = new DataTable();
            dt = DataProvider.Instance.GetDataQuerry("select * from DichVu where tendichvu like N'%" + chuoitimkiem + "%'");
            foreach (DataRow dr in dt.Rows)
            {
                DichVu d = new DichVu();
                d.Madichvu = dr["madichvu"].ToString();
                d.Tendichvu = dr["tendichvu"].ToString();
                d.Dongia = Decimal.Parse(dr["dongia"].ToString());
                list.Add(d);
            }
            return list;
        }

        public bool ThemDichVu(string madichvu, string tendichvu, decimal dongia)
        {
            string query = string.Format("insert dbo.DichVu (madichvu,tendichvu,dongia) values (N'{0}', N'{1}', '{2}')", madichvu, tendichvu, dongia);
            int result = DataProvider.Instance.ExNonQuery(query);
            return result > 0;
        }

        public bool SuaDichVu(string madichvu, string tendichvu, decimal dongia)
        {
            string s = string.Format("update dbo.DichVu set tendichvu = N'{0}', dongia = N'{1}'  where madichvu = N'{2}'", tendichvu, dongia, madichvu);
            int result = DataProvider.Instance.ExNonQuery(s);
            return result > 0;
        }

        public bool XoaDichVu(string madichvu)
        {
            string s = string.Format("delete dbo.DichVu where madichvu=N'{0}'", madichvu);
            int result = DataProvider.Instance.ExNonQuery(s);
            return result > 0;
        }


    }
}
