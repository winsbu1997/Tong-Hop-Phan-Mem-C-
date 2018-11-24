using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace QuanLiNhaHang.Controller
{
    class NhanVienCtr
    {
        public static DataSet FillDataSet_SearchNhanVienbyMaNV(string _MaNV)
        {
            try
            {
                Model.NhanVienMod nv = new Model.NhanVienMod(_MaNV);
                return nv.FillDataSet_SearchNhanVienbyMaNV();
            }
            catch
            {
                return null;
            }
        }
        public static DataSet FillDataSet_SearchNhanVienbyTenNV(string _TenNV)
        {
            try
            {
                Model.NhanVienMod nv = new Model.NhanVienMod(_TenNV);
                return nv.FillDataSet_SearchNhanVienbyTenNV();
            }
            catch
            {
                return null;
            }
        }

        public static int InsertNhanVien(string _MaNV, string _TenNV, DateTime _NgaySinh, string _GioiTinh, string _DiaChi, string _Sdt, int _Luong, string _ChucVu)
        {
            try
            {
                Model.NhanVienMod nv = new Model.NhanVienMod(_MaNV, _TenNV, _NgaySinh, _GioiTinh, _DiaChi, _Sdt, _Luong, _ChucVu);
                return nv.InsertNhanVien();
            }
            catch
            {
                return 0;
            }
        }

        public static int UpdateNhanVien(string _MaNV, string _TenNV, DateTime _NgaySinh, string _GioiTinh, string _DiaChi, string _Sdt, int _Luong, string _ChucVu)
        {
            try
            {
                Model.NhanVienMod nv = new Model.NhanVienMod(_MaNV, _TenNV, _NgaySinh, _GioiTinh, _DiaChi, _Sdt, _Luong, _ChucVu);
                return nv.UpdateNhanVien();
            }
            catch
            {
                return 0;
            }
        }

        public static int DeleteNhanVien(string _MaNV)
        {
            try
            {
                Model.NhanVienMod nv = new Model.NhanVienMod(_MaNV);
                return nv.DeleteNhanVien();
            }
            catch
            {
                return 0;
            }
        }
    }
}
