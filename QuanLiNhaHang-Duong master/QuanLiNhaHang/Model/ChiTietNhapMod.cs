using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiNhaHang.Model
{
    class ChiTietNhapMod
    {
        public string MaHDN { get; set; }
        public string MaNL { get; set; }
        public int SoLuong { get; set; }

        public int DonGia { get; set; }

        public ChiTietNhapMod() { }

        public ChiTietNhapMod(string _MaHDN, string _MaNL)
        {
            MaHDN = _MaHDN;
            MaNL = _MaNL;
        }

        public ChiTietNhapMod(string _MaHDN, string _MaNL, int _SoLuong,int _DonGia)
        {
            MaHDN = _MaHDN;
            MaNL = _MaNL;
            SoLuong = _SoLuong;
            DonGia = _DonGia;
        }
        public int InsertChiTietNhap()
        {
            int i = 0;
            string[] paras = new string[4] { "@MaHDN", "@MaNL", "@SoLuong" ,"@DonGia"};
            object[] values = new object[4] { MaHDN, MaNL, SoLuong,DonGia };
            i = Model.Connection.Excute_Sql("insertChiTietNhap", CommandType.StoredProcedure, paras, values);
            return i;
        }

        public int UpdateChiTietNhap()
        {
            int i = 0;
            string[] paras = new string[4] { "@MaHDN", "@MaNL", "@SoLuong", "@DonGia" };
            object[] values = new object[4] { MaHDN, MaNL, SoLuong,DonGia };
            i = Model.Connection.Excute_Sql("updateChiTietNhap", CommandType.StoredProcedure, paras, values);
            return i;
        }
        public int DeleteChiTietNhap()
        {
            int i = 0;
            string[] paras = new string[2] { "@MaHDN", "@MaNL" };
            object[] values = new object[2] { MaHDN, MaNL };
            i = Model.Connection.Excute_Sql("deleteChiTietNhap", CommandType.StoredProcedure, paras, values);
            return i;
        }
        public static DataSet FillDataSetChiTietNhap()
        {
            return Model.Connection.FillDataSet("getChiTietNhap", CommandType.StoredProcedure);
        }
    }
}
