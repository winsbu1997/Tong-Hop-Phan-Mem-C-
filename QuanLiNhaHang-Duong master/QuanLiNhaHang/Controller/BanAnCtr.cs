using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiNhaHang.Controller
{
    class BanAnCtr
    {
        public static int TableWidth = 100;
        public static int TableHeight = 100;
        public static int InsertBanAn(string _MaBA, string _MaHDB, int _SoCho, string _TrangThai, string _ViTri)
        {
            try
            {
                Model.BanAnMod ba = new Model.BanAnMod(_MaBA, _MaHDB, _SoCho, _TrangThai, _ViTri);
                return ba.InsertBanAn();
            }
            catch { return 0; }
        }
        public static int UpdateBanAn(string _MaBA, string _MaHDB, int _SoCho, string _TrangThai, string _ViTri)
        {
            try
            {
                Model.BanAnMod ba = new Model.BanAnMod(_MaBA, _MaHDB, _SoCho, _TrangThai, _ViTri);
                return ba.UpdateBanAn();
            }
            catch { return 0; }
        }
        public static int DeleteBanAn(string _MaBA)
        {
            try
            {
                Model.BanAnMod ba = new Model.BanAnMod(_MaBA);
                return ba.DeleteBanAn();
            }
            catch { return 0; }
        }
        public static DataSet FillDataSetBanAnbyMaBA(string _MaBA)
        {
            try
            {
                Model.BanAnMod ba = new Model.BanAnMod(_MaBA);
                return ba.FillDataSetBanAnbyMaBA();
            }
            catch
            {
                return null;
            }
        }
        public static void UpdateTrangThaiBA(string _MaBA ,string _TrangThai,string _MaHDB)
        {

            try
            {
                Model.BanAnMod ba = new Model.BanAnMod(_MaBA,_TrangThai,_MaHDB);
                ba.UpdateTrangThaiBA();
            }
            catch { }
        }
        public static List<Model.BanAnMod> DanhSachBanAn()
        {
            List<Model.BanAnMod> listBA = new List<Model.BanAnMod>();
            DataTable dt = Model.BanAnMod.FillDataSetBanAn().Tables[0];
            foreach(DataRow item in dt.Rows)
            {
                Model.BanAnMod table = new Model.BanAnMod(item);
                listBA.Add(table);
            }

            return listBA;
        }
        
    }
}
