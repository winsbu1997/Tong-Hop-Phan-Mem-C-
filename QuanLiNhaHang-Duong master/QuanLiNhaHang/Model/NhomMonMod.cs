using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiNhaHang.Model
{
    class NhomMonMod
    {
        public string MaNM { get; set; }
        public string TenNM { get; set; }

        public NhomMonMod() { }
        public NhomMonMod(string _MaNM)
        {
            MaNM = _MaNM;
        }
        public NhomMonMod(string _MaNM,string _TenNM)
        {
            MaNM = _MaNM;
            TenNM = _TenNM;
        }
        public NhomMonMod(DataRow row)
        {
            MaNM = row["MaNM"].ToString();
            TenNM = row["TenNM"].ToString();
        }
        public int InsertNhomMon()
        {
            int i = 0;
            string[] paras = new string[2] { "@MaNM","@TenNM" };
            object[] values = new object[2] {  MaNM,TenNM };
            i = Model.Connection.Excute_Sql("insertNhomMon", System.Data.CommandType.StoredProcedure, paras, values);
            return i;
        }
        public int UpdateNhomMon()
        {
            int i = 0;
            string[] paras = new string[2] { "@MaNM", "TenNM" };
            object[] values = new object[2] { MaNM, TenNM };
            i = Model.Connection.Excute_Sql("updateNhomMon", System.Data.CommandType.StoredProcedure, paras, values);
            return i;
        }
        public int DeleteNhomMon()
        {
            int i = 0;
            string[] paras = new string[1] { "@MaNM" };
            object[] values = new object[1] { MaNM };
            i = Model.Connection.Excute_Sql("deleteNhomMon", System.Data.CommandType.StoredProcedure, paras, values);
            return i;
        }
        public static DataSet FillDataSetNhomMon()
        {
            return Model.Connection.FillDataSet("getNhomMon",CommandType.StoredProcedure);
        }
        public DataSet SearchNhomMonByMaNM()
        {
            DataSet ds;
            string[] paras = new string[1] { "@MaNM" };
            object[] values = new object[1] { MaNM };
            ds = Model.Connection.FillDataSet("getMonAnbyMaNM", CommandType.StoredProcedure, paras, values);
            return ds;

        }
    }
}
