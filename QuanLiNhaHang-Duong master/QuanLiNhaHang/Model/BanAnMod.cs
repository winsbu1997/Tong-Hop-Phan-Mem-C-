using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiNhaHang.Model
{
    class BanAnMod
    {
        public string MaBA { get; set; }
        public string MaHDB { get; set; }
        public int SoCho { get; set; }
        public string TrangThai { get; set; }
        public string ViTri { get; set; }
        public BanAnMod()
        { }
        public BanAnMod(string _MaBA)
        {
            MaBA = _MaBA;
        }
        public BanAnMod(string _MaBA, string _MaHDB, int _SoCho, string _TrangThai, string _ViTri)
        {
            MaBA = _MaBA;
            MaHDB = _MaHDB;
            SoCho = _SoCho;
            TrangThai = _TrangThai;
            ViTri = _ViTri;
        }
        public BanAnMod(string _MaBA, string _TrangThai, string _MaHDB)
        {
            MaBA = _MaBA;
            TrangThai = _TrangThai;
            MaHDB = _MaHDB;
        }
        public BanAnMod(DataRow row)
        {
            try
            {
                MaBA = row["MaBA"].ToString();
                MaHDB = row["MaHDB"].ToString();
                SoCho = Convert.ToInt32(row["SoCho"]);
                TrangThai = row["TrangThai"].ToString();
                ViTri = row["ViTri"].ToString();
            }
            catch { }
        }
        public int InsertBanAn()
        {
            int i = 0;
            string[] paras = new string[5] { "@MaBA", "@MaHDB", "@SoCho", "@TrangThai", "@ViTri" };
            object[] values = new object[5] { MaBA, MaHDB, SoCho, TrangThai, ViTri };
            i = Model.Connection.Excute_Sql("insertBanAn", System.Data.CommandType.StoredProcedure, paras, values);
            return i;
        }
        public int UpdateBanAn()
        {
            int i = 0;
            string[] paras = new string[5] { "@MaBA", "@MaHDB", "@SoCho", "@TrangThai", "@ViTri" };
            object[] values = new object[5] { MaBA, MaHDB, SoCho, TrangThai, ViTri };
            i = Model.Connection.Excute_Sql("updateBanAn", System.Data.CommandType.StoredProcedure, paras, values);
            return i;
        }
        public int DeleteBanAn()
        {
            int i = 0;
            string[] paras = new string[1] { "@MaBA" };
            object[] values = new object[1] { MaBA };
            i = Model.Connection.Excute_Sql("deleteBanAn", System.Data.CommandType.StoredProcedure, paras, values);
            return i;
        }
        public static DataSet FillDataSetBanAn()
        {
            return Model.Connection.FillDataSet("getBanAn", CommandType.StoredProcedure);
        }
        public DataSet FillDataSetBanAnbyMaBA()
        {
            DataSet dt = new DataSet();
            string[] paras = new string[1] { "@MaBA" };
            object[] values = new object[1] { MaBA };
            dt = Model.Connection.FillDataSet("getBanAnbyMaBA", CommandType.StoredProcedure, paras, values);
            return dt;
        }
        public void UpdateTrangThaiBA()
        {
            int i = 0;
            string[] paras = new string[3] { "@MaBA", "@TrangThai", "@MaHDB" };
            object[] values = new object[3] { MaBA, TrangThai, MaHDB };
            i = Model.Connection.Excute_Sql("updateTrangThaiBA", CommandType.StoredProcedure, paras, values);
        }

    }
}
