using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiNhaHang.Model
{
    class KhachHangMod
    {
        protected string MaKH { get; set; }
        protected string TenKH { get; set; }
        protected string Sdt { get; set; }
        protected string DiaChi { get; set; }

        public KhachHangMod() { }
        public KhachHangMod(string _MaKH)
        {
            MaKH = _MaKH;
        }
        public KhachHangMod(string _MaKH,string _TenKH,string _Sdt,string _DiaChi)
        {
            MaKH = _MaKH;
            TenKH = _TenKH;
            Sdt = _Sdt;
            DiaChi = _DiaChi;
        }
        public int InsertKhachHang()
        {
            int i = 0;
            string[] paras = new string[4] { "@MaKH", "@TenKH", "@Sdt", "@DiaChi" };
            object[] values = new object[4] { MaKH ,TenKH ,Sdt ,DiaChi };
            i = Model.Connection.Excute_Sql("InsertKhachHang", CommandType.StoredProcedure, paras, values);
            return i;
        }

        public int UpdateKhachHang()
        {
            int i = 0;
            string[] paras = new string[4] { "@MaKH", "@TenKH", "@Sdt", "@DiaChi" };
            object[] values = new object[4] { MaKH, TenKH, Sdt, DiaChi };
            i = Model.Connection.Excute_Sql("UpdateKhachHang", CommandType.StoredProcedure, paras, values);
            return i;
        }
        public int DeleteKhachHang()
        {
            int i = 0;
            string[] paras = new string[1] { "@MaKH" };
            object[] values = new object[1] { MaKH };
            i = Model.Connection.Excute_Sql("deleteKhachHang", CommandType.StoredProcedure, paras, values);
            return i;
        }
        public static DataSet FillDataSetKhachHang()
        {
            return Model.Connection.FillDataSet("getKhachHang", CommandType.StoredProcedure);
        }

        public DataSet FillDataSet_SearchKhachHangbyMaKH()
        {
            DataSet ds = new DataSet();
            string[] paras = new string[1] { "@MaKH" };
            object[] values = new object[1] { MaKH };
            ds = Model.Connection.FillDataSet("SearchKhachHangByMaKH", CommandType.StoredProcedure, paras, values);
            return ds;
        }
        public DataSet FillDataSet_SearchKhachHangbyTenKH()
        {
            DataSet ds = new DataSet();
            string[] paras = new string[1] { "@TenKH" };
            object[] values = new object[1] { MaKH };
            ds = Model.Connection.FillDataSet("SearchKhachHangByTenKH", CommandType.StoredProcedure, paras, values);
            return ds;
        }
    }
}
