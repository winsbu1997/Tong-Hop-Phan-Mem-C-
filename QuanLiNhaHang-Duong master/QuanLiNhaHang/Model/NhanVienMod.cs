using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiNhaHang.Model
{
    class NhanVienMod
    {
        protected string MaNV { get; set; }
        protected string TenNV { get; set; }
        protected DateTime NgaySinh { get; set; }
        protected string GioiTinh { get; set; }
        protected string DiaChi { get; set; }
        protected string Sdt  { get; set; }
        protected int Luong { get; set; }
        protected string ChucVu { get; set; }


        public NhanVienMod()
        {

        }

        public NhanVienMod(string _MaNV)
        {
            MaNV = _MaNV;
        }

        public NhanVienMod(string _MaNV, string _TenNV, DateTime _NgaySinh, string _GioiTinh, string _DiaChi, string _Sdt, int _Luong, string _ChucVu)
        {
            MaNV = _MaNV;
            TenNV = _TenNV;
            NgaySinh = _NgaySinh;
            GioiTinh = _GioiTinh;
            DiaChi = _DiaChi;
            Sdt = _Sdt;
            Luong = _Luong;
            ChucVu = _ChucVu;
        }
        
        public int InsertNhanVien()
        {
            int i = 0;
            string[] paras = new string[8] { "@MaNV", "@TenNV", "@NgaySinh", "@GioiTinh", "@DiaChi", "@Sdt", "@Luong ", "@ChucVu" };
            object[] values = new object[8] { MaNV, TenNV , NgaySinh, GioiTinh, DiaChi, Sdt, Luong, ChucVu };
            i = Model.Connection.Excute_Sql("InsertNhanVien", CommandType.StoredProcedure,paras,values);
            return i;
        }
        public int UpdateNhanVien()
        {
            int i = 0;
            string[] paras = new string[8] { "@MaNV", "@TenNV", "@NgaySinh", "@GioiTinh", "@DiaChi", "@Sdt", "@Luong ", "@ChucVu" };
            object[] values = new object[8] { MaNV, TenNV, NgaySinh, GioiTinh, DiaChi, Sdt, Luong, ChucVu };
            i = Model.Connection.Excute_Sql("UpdateNhanVien", CommandType.StoredProcedure, paras, values);
            return i;
        }
        public int DeleteNhanVien()
        {
            int i = 0;
            string[] paras = new string[1] { "@MaNV"};
            object[] values = new object[1] { MaNV };
            i = Model.Connection.Excute_Sql("deleteNhanVien", CommandType.StoredProcedure, paras, values);
            return i;
        }

        public static DataSet FillDataSetNhanVien()
        {
            return Model.Connection.FillDataSet("getNhanVien",CommandType.StoredProcedure);
        }

        public DataSet FillDataSet_SearchNhanVienbyMaNV()
        {
            DataSet ds = new DataSet();
            string[] paras = new string[1] { "@MaNV" };
            object[] values = new object[1] { MaNV };
            ds = Model.Connection.FillDataSet("SearchNhanVienByMaNV", CommandType.StoredProcedure, paras, values);
            return ds;
        }
        public DataSet FillDataSet_SearchNhanVienbyTenNV()
        {
            DataSet ds = new DataSet();
            string[] paras = new string[1] { "@TenNV" };
            object[] values = new object[1] { MaNV };
            ds = Model.Connection.FillDataSet("SearchNhanVienByTenNV", CommandType.StoredProcedure, paras, values);
            return ds;
        }

    }
}
