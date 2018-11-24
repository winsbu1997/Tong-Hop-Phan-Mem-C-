using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiNhaHang.Model
{
    class NguyenLieuMod
    {
        protected string MaNL { get; set; }
        protected string TenNL { get; set; }
        protected string DonViTinh { get; set; }
        protected int DonGia { get; set; }

        public NguyenLieuMod() { }

        public NguyenLieuMod(string _MaNL)
        {
            MaNL = _MaNL;
        }

        public NguyenLieuMod(string _MaNL,string _TenNL,string _DonViTinh, int _DonGia)
        {
            MaNL = _MaNL;
            TenNL = _TenNL;
            DonViTinh = _DonViTinh;
            DonGia = _DonGia;
        }
        public int InsertNguyenLieu()
        {
            int i = 0;
            string[] paras = new string[4] { "@MaNL", "@TenNL", "@DonViTinh", "DonGia" };
            object[] values = new object[4] { MaNL, TenNL, DonViTinh, DonGia };
            i = Model.Connection.Excute_Sql("insertNguyenLieu", CommandType.StoredProcedure, paras, values);
            return i;
        }

        public int UpdateNguyenLieu()
        {
            int i = 0;
            string[] paras = new string[4] { "@MaNL", "@TenNL", "@DonViTinh", "DonGia" };
            object[] values = new object[4] { MaNL, TenNL, DonViTinh, DonGia };
            i = Model.Connection.Excute_Sql("updateNguyenLieu", CommandType.StoredProcedure, paras, values);
            return i;
        }
        public int DeleteNguyenLieu()
        {
            int i = 0;
            string[] paras = new string[1] { "@MaNL" };
            object[] values = new object[1] { MaNL };
            i = Model.Connection.Excute_Sql("deleteNguyenLieu", CommandType.StoredProcedure, paras, values);
            return i;
        }
        public static DataSet FillDataSetNguyenLieu()
        {
            return Model.Connection.FillDataSet("getNguyenLieu", CommandType.StoredProcedure);
        }
    }
}
