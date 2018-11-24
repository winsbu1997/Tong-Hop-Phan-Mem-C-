using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiNhaHang.Controller
{
    class ChiTietNhapCtr
    {
       public static int InsertChiTietNhap(string _MaHDN,string _MaNL,int _SoLuong,int _DonGia)
        {
            try
            {
                Model.ChiTietNhapMod ctn = new Model.ChiTietNhapMod(_MaHDN, _MaNL, _SoLuong,_DonGia);
                return ctn.InsertChiTietNhap();
            }
            catch
            {
                return 0;
            }
        }
        public static int UpdateChiTietNhap(string _MaHDN, string _MaNL, int _SoLuong,int _DonGia)
        {
            try
            {
                Model.ChiTietNhapMod ctn = new Model.ChiTietNhapMod(_MaHDN, _MaNL, _SoLuong,_DonGia);
                return ctn.UpdateChiTietNhap();
            }
            catch
            {
                return 0;
            }
        }
        public static int DeleteChiTietNhap(string _MaHDN, string _MaNL)
        {
            try
            {
                Model.ChiTietNhapMod ctn = new Model.ChiTietNhapMod(_MaHDN, _MaNL);
                return ctn.DeleteChiTietNhap();
            }
            catch
            {
                return 0;
            }
        }
    }
}
