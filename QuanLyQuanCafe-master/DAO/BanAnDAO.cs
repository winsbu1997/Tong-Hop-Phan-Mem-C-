using QuanLyQuanCafe.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanCafe.DAO
{
    public static class BanAnDAO
    {
        public static DataTable DanhSachBanAn()
        {
            string query = "SELECT * FROM BANAN";
            return SqlServerHelper.ExecuteQuery(query);
        }
        public static DataTable DanhSachBanTrong()
        {
            string query = "select * from BANAN where TRANGTHAI = 0";
            return SqlServerHelper.ExecuteQuery(query);
        }
        public static void SuaTrangThaiBA(int idtable, int trangthai)
        {
            string query = "update BANAN set TRANGTHAI = " + trangthai + " where MABA = " + idtable + "";
            SqlServerHelper.ExecuteNonQuery(query);
        }
        public static List<BanAnDTO> DanhSachBanAnList()
        {
            DataTable ans = new DataTable();
            string query = "SELECT * FROM BANAN";
            ans = SqlServerHelper.ExecuteQuery(query);

            List<BanAnDTO> ketqua = new List<BanAnDTO>();

            ketqua.Clear();
            foreach (DataRow row in ans.Rows)
            {
                BanAnDTO banan = new BanAnDTO(row);
                ketqua.Add(banan);
            }

            return ketqua;
        }

        public static void ThemBanAn(string TenBA, int SoCho, string ViTri){
            string query = "INSERT INTO BANAN(TENBA, SOCHO, VITRI, TrangThai) VALUES ( @TENBA , @SOCHO , @VITRI , 0) ";
            SqlServerHelper.ExecuteNonQuery(query, new object[] { TenBA, SoCho, ViTri });
        }

        public static void CapNhatBanAn(int MaBA, string TenBA, int SoCho, string Vitri)
        {
            string query = "UPDATE BANAN SET TENBA = @TENBA , SOCHO = @SOCHO , VITRI = @VITRI WHERE MABA = @MABA";
            SqlServerHelper.ExecuteNonQuery(query, new object[] { TenBA, SoCho, Vitri, MaBA });
        }

        public static void XoaBanAn(int MaBA)
        {
            string query = "DELETE FROM BANAN WHERE MABA = @MABA";
            SqlServerHelper.ExecuteQuery(query, new object[] { MaBA });
        }
    }
}
