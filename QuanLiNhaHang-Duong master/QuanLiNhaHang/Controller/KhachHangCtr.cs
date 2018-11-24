using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiNhaHang.Controller
{
    class KhachHangCtr
    {
        public static DataSet FillDataSet_SearchKhachHangbyMaKH(string _MaKH)
        {
            try
            {
                Model.KhachHangMod kh = new Model.KhachHangMod(_MaKH);
                return kh.FillDataSet_SearchKhachHangbyMaKH();
            }
            catch
            {
                return null;
            }
        }
        public static DataSet FillDataSet_SearchKhachHangbyTenKH(string _TenKH)
        {
            try
            {
                Model.KhachHangMod kh = new Model.KhachHangMod(_TenKH);
                return kh.FillDataSet_SearchKhachHangbyTenKH();
            }
            catch
            {
                return null;
            }
        }

        public static int InsertKhachHang(string _MaKH, string _TenKH, string _Sdt, string _DiaChi)
        {
            try
            {
                Model.KhachHangMod kh = new Model.KhachHangMod(_MaKH, _TenKH, _Sdt, _DiaChi);
                return kh.InsertKhachHang();
            }
            catch
            {
                return 0;
            }
        }
        public static int UpdateKhachHang(string _MaKH, string _TenKH, string _Sdt, string _DiaChi)
        {
            try
            {
                Model.KhachHangMod kh = new Model.KhachHangMod(_MaKH, _TenKH, _Sdt, _DiaChi);
                return kh.UpdateKhachHang();
            }
            catch
            {
                return 0;
            }
        }
        public static int DeleteKhachHang(string _MaKH)
        {
            try
            {
                Model.KhachHangMod kh = new Model.KhachHangMod(_MaKH);
                return kh.DeleteKhachHang();
            }
            catch
            {
                return 0;
            }
        }

    }
}
