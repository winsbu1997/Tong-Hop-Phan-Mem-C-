using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class ChiTietThietBiPhongDAL
    {

        public DataTable ThietBiTheoPhong(string maphong)
        {
            string query = string.Format(@"select ChiTietThietBiPhong.mathietbi, tenthietbi, ChiTietThietBiPhong.soluong from ChiTietThietBiPhong inner join Phong 
               on ChiTietThietBiPhong.maphong = Phong.maphong inner join ThietBi
                on ThietBi.mathietbi = ChiTietThietBiPhong.mathietbi
                where Phong.maphong = N'{0}'", maphong);
            DataTable dsThietBi = DataProvider.Instance.GetDataQuerry(query);
            return dsThietBi;
        }
        public bool ThemThietBiPhong(string mathietbi, string maphong, string soluong)
        {
            string query = string.Format("Insert dbo.ChiTietThietBiPhong ( mathietbi , maphong, soluong ) values ('{0}', '{1}', '{2}')", mathietbi, maphong, soluong);
            int result = DataProvider.Instance.ExNonQuery(query);
            return result > 0;
        }
        public bool XoaThietBiPhong(string mathietbi, string maphong)
        {
            string query = string.Format("delete dbo.ChiTietThietBiPhong where mathietbi = '{0}' and maphong ='{1}'", mathietbi, maphong);
            int result = DataProvider.Instance.ExNonQuery(query);
            return result > 0;
        }
        public bool SuaThietBiPhong(string mathietbi, string soluong, string maphong)
        {
            string query = string.Format("update dbo.ChiTietThietBiPhong set soluong = '{0}' where maphong = '{1}' and mathietbi = '{2}'", soluong, maphong, mathietbi);
            int result = DataProvider.Instance.ExNonQuery(query);
            return result > 0;
        }
        public bool Kiemtramathietbi(string mathietbi, string maphong)
        {
            string query = string.Format("select mathietbi from dbo.ChiTietThietBiPhong where mathietbi = '{0}' and maphong = '{1}'", mathietbi, maphong);
            DataTable data = DataProvider.Instance.GetDataQuerry(query);
            if (data.Rows.Count > 0)
                return true;
            else
                return false;
        }
    }
}