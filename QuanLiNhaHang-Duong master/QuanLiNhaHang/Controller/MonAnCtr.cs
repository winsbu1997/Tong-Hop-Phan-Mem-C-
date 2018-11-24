using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiNhaHang.Controller
{
    class MonAnCtr
    {
        public static int FoodWidth = 180;
        public static int FoodHeight = 100;
        public static int InsertMonAn(string _STTMA,string _TenMA, int _DonGia, string _MaNM, string _DonViTinh, byte[] _HinhAnh)
        {
            try
            {
                Model.MonAnMod ma = new Model.MonAnMod(_STTMA,_TenMA,_DonGia,_MaNM,_DonViTinh,_HinhAnh);
                return ma.InsertMonAn();
            }
            catch
            {
                return 0;
            }
        }
        public static int DeleteMonAn(string _STTMA)
        {
            try
            {
                Model.MonAnMod ma = new Model.MonAnMod(_STTMA,"");
                return ma.DeleteMonAn();
            }
            catch
            {
                return 0;
            }
        }
        public static int UpdateMonAn(string _STTMA, string _TenMA, int _DonGia, string _MaNM, string _DonViTinh, byte[] _HinhAnh)
        {
            try
            {
                Model.MonAnMod ma = new Model.MonAnMod(_STTMA, _TenMA, _DonGia, _MaNM, _DonViTinh, _HinhAnh);
                return ma.UpdateMonAn();
            }
            catch
            {
                return 0;
            }
        }
        public static List<Model.MonAnMod> DanhSachMonAn(string _MaNM)
        {
            List<Model.MonAnMod> listMA = new List<Model.MonAnMod>();
            DataTable dt = Controller.MonAnCtr.SearchMonAnByNhomMon(_MaNM).Tables[0];
            foreach(DataRow item in dt.Rows)
            {
                Model.MonAnMod food = new Model.MonAnMod(item);
                listMA.Add(food);
            }
            return listMA;
        }
        public static DataSet SearchMonAnByNhomMon(string _MaNM)
        {
            try
            {
                Model.MonAnMod ma = new Model.MonAnMod(_MaNM);
                return ma.SearchMonAnByNhomMon();
            }
            catch { return null; }
        }
    }
}
