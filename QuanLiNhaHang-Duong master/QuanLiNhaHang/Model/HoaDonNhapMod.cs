using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiNhaHang.Model
{
    class HoaDonNhapMod
    {
        public string MaHDN { get; set; }
        public DateTime NgayNhap { get; set; }
        public int TongTien { get; set; }
        public string GhiChu { get; set; }
        public string MaNV { get; set; }

        public HoaDonNhapMod() { }
        public HoaDonNhapMod(string _MaHDN)
        {
            MaHDN = _MaHDN;
        }
        public HoaDonNhapMod(string _MaHDN, DateTime _NgayNhap, int _TongTien, string _GhiChu,string _MaNV)
        {
            MaHDN = _MaHDN;
            NgayNhap = _NgayNhap;
            TongTien = _TongTien;
            GhiChu = _GhiChu;
            MaNV = _MaNV;
        }
        public HoaDonNhapMod(DataRow row)
        {
            MaHDN = row["MaHDN"].ToString();
            NgayNhap = (DateTime)row["NgayNhap"];
            TongTien = (int)row["TongTien"];
            GhiChu = row["GhiChu"].ToString();
            MaNV = row["MaNV"].ToString();
        }
        public int InsertHoaDonNhap()
        {
            int i = 0;
            string[] paras = new string[5] { "@MaHDN", "@NgayNhap", "@TongTien", "@GhiChu", "@MaNV"};
            object[] values = new object[5] { MaHDN, NgayNhap, TongTien, GhiChu, MaNV };
            i = Model.Connection.Excute_Sql("insertHoaDonNhap", CommandType.StoredProcedure, paras, values);
            return i;
        }

        public int UpdateHoaDonNhap()
        {
            int i = 0;
            string[] paras = new string[5] { "@MaHDN", "@NgayNhap", "@TongTien", "@GhiChu", "@MaNV" };
            object[] values = new object[5] { MaHDN, NgayNhap, TongTien, GhiChu, MaNV };
            i = Model.Connection.Excute_Sql("updateHoaDonNhap", CommandType.StoredProcedure, paras, values);
            return i;
        }
        public int DeleteHoaDonNhap()
        {
            int i = 0;
            string[] paras = new string[1] { "@MaHDN" };
            object[] values = new object[1] { MaHDN };
            i = Model.Connection.Excute_Sql("deleteHoaDonNhap", CommandType.StoredProcedure, paras, values);
            return i;
        }
        public static DataSet FillDataSetHoaDonNhap()
        {
            return Model.Connection.FillDataSet("getHDN", CommandType.StoredProcedure);
        }

        public DataSet SearchHDNByMaHDN()
        {
            DataSet ds = new DataSet();
            string[] paras = new string[1] { "@MaHDN" };
            object[] values = new object[1] { MaHDN };
            ds = Model.Connection.FillDataSet("SearchHDNByMaHDN", CommandType.StoredProcedure, paras, values);
            return ds;
        }
       
    }
}
