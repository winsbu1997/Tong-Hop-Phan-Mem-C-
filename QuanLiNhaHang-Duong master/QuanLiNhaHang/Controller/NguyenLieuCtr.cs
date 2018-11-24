using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiNhaHang.Controller
{
    class NguyenLieuCtr
    {
        public static int InsertNguyenLieu(string _MaNL, string _TenNL, string _DonViTinh, int _DonGia)
        {
            try
            {
                Model.NguyenLieuMod nl = new Model.NguyenLieuMod(_MaNL, _TenNL, _DonViTinh, _DonGia);
                return nl.InsertNguyenLieu();
            }            
            catch { return 0; }
        }
        public static int UpdateNguyenLieu(string _MaNL, string _TenNL, string _DonViTinh, int _DonGia)
        {
            try
            {
                Model.NguyenLieuMod nl = new Model.NguyenLieuMod(_MaNL, _TenNL, _DonViTinh, _DonGia);
                return nl.UpdateNguyenLieu();
            }
            catch { return 0; }
        }
        public static int DeleteNguyenLieu(string _MaNL)
        {
            try
            {
                Model.NguyenLieuMod nl = new Model.NguyenLieuMod(_MaNL);
                return nl.DeleteNguyenLieu();
            }
            catch { return 0; }
        }
    }
}
