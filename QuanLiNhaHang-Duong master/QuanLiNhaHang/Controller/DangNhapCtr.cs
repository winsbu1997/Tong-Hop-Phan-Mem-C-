using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiNhaHang.Controller
{
    class DangNhapCtr
    {
        public static int InsertDangNhap(string _IdDangNhap, string _MatKhau)
        {
            try
            {
                Model.DangNhapMod dn = new Model.DangNhapMod(_IdDangNhap, _MatKhau);
                return dn.InsertDangNhap();
            }
            catch
            {
                return 0;
            }
        }

        public static int DeleteDangNhap(string _IdDangNhap)
        {
            try
            {
                Model.DangNhapMod dn = new Model.DangNhapMod(_IdDangNhap);
                return dn.DeleteDangNhap();
            }
            catch
            {
                return 0;
            }
        }

        public static int UpdateDangnhap(string _Iddangnhap, string _matkhau)
        {
            try
            {
                Model.DangNhapMod dn = new Model.DangNhapMod(_Iddangnhap, _matkhau);
                return dn.UpdateDangnhap();
            }
            catch
            {
                return 0;
            }
        }
    }
}
