using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace QuanLiNhaHang.Model
{
   
    class ChiTietBanMod
    {
        public string MaHDB { get; set; }
        public string STTMA { get; set; }
        public int SoLuong { get; set; }
        public int ThanhTien { get; set; }

        public ChiTietBanMod() { }

        public ChiTietBanMod(string _MaHDB, string _STTMA)
        {
            MaHDB = _MaHDB;
            STTMA = _STTMA;
        }
        public ChiTietBanMod(string _MaHDB)
        {
            MaHDB = _MaHDB;
        }

        public ChiTietBanMod(string _MaHDB,string _STTMA,int _SoLuong,int _ThanhTien)
        {
            MaHDB = _MaHDB;
            STTMA = _STTMA;
            SoLuong = _SoLuong;
            ThanhTien = _ThanhTien;
        }     
        public int InsertChiTietBan()
        {
            int i = 0;
            string[] paras = new string[4] { "@MaHDB", "@STTMA", "@SoLuong", "@ThanhTien" };
            object[] values = new object[4] { MaHDB, STTMA, SoLuong, ThanhTien };
            i = Model.Connection.Excute_Sql("insertChiTietBan", CommandType.StoredProcedure, paras, values);
            return i;
        }

        public int UpdateChiTietBan()
        {
            int i = 0;
            string[] paras = new string[4] { "@MaHDB", "@STTMA", "@SoLuong", "@ThanhTien" };
            object[] values = new object[4] { MaHDB, STTMA, SoLuong, ThanhTien };
            i = Model.Connection.Excute_Sql("updateChiTietBan", CommandType.StoredProcedure, paras, values);
            return i;
        }
        public int DeleteChiTietBan()
        {
            int i = 0;
            string[] paras = new string[2] { "@MaHDB", "@STTMA" };
            object[] values = new object[2] { MaHDB, STTMA };
            i = Model.Connection.Excute_Sql("deleteChiTietBan", CommandType.StoredProcedure, paras, values);
            return i;
        }
        public static DataSet FillDataSetChiTietBan()
        {
            return Model.Connection.FillDataSet("getChiTietBan", CommandType.StoredProcedure);
        }
        public DataSet SearchChiTietBanbyMaHDB()
        {
            DataSet ds;
            string[] paras = new string[1] { "@MaHDB" };
            object[] values = new object[1] { MaHDB};
            ds = Model.Connection.FillDataSet("searchChiTietBanByMaHDB", CommandType.StoredProcedure,paras,values);
            return ds;
        }
    }
}
