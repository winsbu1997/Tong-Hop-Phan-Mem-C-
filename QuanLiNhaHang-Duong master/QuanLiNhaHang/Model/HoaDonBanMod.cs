using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiNhaHang.Model
{
    class HoaDonBanMod
    {
        public string MaHDB { get; set; }
        public DateTime NgayBan { get; set; }
        public int TongTien { get; set; }
        public int GiamGia { get; set; }
        public string MaNV { get; set; }
        public string MaKH { get; set; }

        public HoaDonBanMod() { }
        public HoaDonBanMod(string _MaHDB)
        {
            MaHDB = _MaHDB;
        }
        public HoaDonBanMod(string _MaHDB, DateTime _NgayBan, int _TongTien, string _MaNV, string _MaKH, int _GiamGia)
        {
            MaHDB = _MaHDB;
            NgayBan = _NgayBan;
            TongTien = _TongTien;
            GiamGia = _GiamGia;
            MaNV = _MaNV;
            MaKH = _MaKH;
        }
        public HoaDonBanMod(DataRow row)
        {
            MaHDB = row["MaHDB"].ToString();
            NgayBan = (DateTime)row["NgayBan"];
            TongTien = (int)row["TongTien"];
            GiamGia = (int)row["GiamGia"];
            MaNV = row["MaNV"].ToString();
            MaKH = row["MaKH"].ToString();
        }
        public int InsertHoaDonBan()
        {
            int i = 0;
            string[] paras = new string[6] { "@MaHDB", "@NgayBan", "@TongTien", "@MaNV", "@MaKH", "@GiamGia" };
            object[] values = new object[6] { MaHDB, NgayBan, TongTien, MaNV, MaKH, GiamGia };
            i = Model.Connection.Excute_Sql("insertHoaDonBan", CommandType.StoredProcedure, paras, values);
            return i;
        }

        public int UpdateHoaDonBan()
        {
            int i = 0;
            string[] paras = new string[6] { "@MaHDB", "@NgayBan", "@TongTien", "@MaNV", "@MaKH", "@GiamGia" };
            object[] values = new object[6] { MaHDB, NgayBan, TongTien, MaNV, MaKH, GiamGia };
            i = Model.Connection.Excute_Sql("updateHoaDonBan", CommandType.StoredProcedure, paras, values);
            return i;
        }
        public int DeleteHoaDonBan()
        {
            int i = 0;
            string[] paras = new string[1] { "@MaHDB" };
            object[] values = new object[1] { MaHDB };
            i = Model.Connection.Excute_Sql("deleteHoaDonBan", CommandType.StoredProcedure, paras, values);
            return i;
        }
        public static DataSet FillDataSetHoaDonBan()
        {
            return Model.Connection.FillDataSet("getHDB", CommandType.StoredProcedure);
        }

        public DataSet SearchHDNByMaHDB()
        {
            DataSet ds = new DataSet();
            string[] paras = new string[1] { "@MaHDB" };
            object[] values = new object[1] { MaHDB };
            ds = Model.Connection.FillDataSet("SearchHDNByMaHDB", CommandType.StoredProcedure, paras, values);
            return ds;
        }
    }
}
