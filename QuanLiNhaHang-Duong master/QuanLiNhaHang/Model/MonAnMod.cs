using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiNhaHang.Model
{
    class MonAnMod
    {
        public string STTMA { get; set; }
        public string TenMA { get; set; }
        public int DonGia { get; set; }
        public string MaNM { get; set; }
        public string DonViTinh { get; set; }
        public byte[] HinhAnh { get; set; }
        public MonAnMod() { }
        public MonAnMod(string _STTMA, string _TenMA, int _DonGia, string _MaNM, string _DonViTinh, byte[] _HinhAnh)
        {
            STTMA = _STTMA;
            TenMA = _TenMA;
            DonGia = _DonGia;
            MaNM = _MaNM;
            DonViTinh = _DonViTinh;
            HinhAnh = _HinhAnh;
        }
        public MonAnMod(string _MaNM)
        {
            MaNM = _MaNM;
        }
        public MonAnMod(string _STTMA, string _MaNM)
        {
            STTMA = _STTMA;
        }


        public MonAnMod(DataRow row)
        {
            STTMA = row["STTMA"].ToString();
            TenMA = row["TenMA"].ToString();
            DonGia = (int)row["DonGia"];
            MaNM = row["MaNM"].ToString();
            DonViTinh = row["DonViTinh"].ToString();
            //HinhAnh = (byte[])row["HinhAnh"];
        }
        public int InsertMonAn()
        {
            int i = 0;
            string[] para = new string[6] { "@STTMA", "@TenMA", "@DonGia", "@MaNM", "@DonViTinh", "@HinhAnh" };
            object[] values = new object[6] { STTMA, TenMA, DonGia, MaNM, DonViTinh, HinhAnh };
            i = Model.Connection.Excute_Sql("insertMonAn", CommandType.StoredProcedure, para, values);
            return i;
        }
        public int UpdateMonAn()
        {
            int i = 0;
            string[] para = new string[6] { "@STTMA", "@TenMA", "@DonGia", "@MaNM", "@DonViTinh", "@HinhAnh" };
            object[] values = new object[6] { STTMA, TenMA, DonGia, MaNM, DonViTinh, HinhAnh };
            i = Model.Connection.Excute_Sql("updateMonAn", CommandType.StoredProcedure, para, values);
            return i;
        }
        public int DeleteMonAn()
        {
            int i = 0;
            string[] para = new string[1] { "@STTMA" };
            object[] values = new object[1] { STTMA };
            i = Model.Connection.Excute_Sql("deleteMonAn", CommandType.StoredProcedure, para, values);
            return i;
        }
        public static DataSet FillDataSetMonAn()
        {
            return Model.Connection.FillDataSet("getMonAn", CommandType.StoredProcedure);
        }

        public DataSet SearchMonAnByNhomMon()
        {
            DataSet ds;
            string[] para = new string[1] { "@MaNM" };
            object[] values = new object[1] { MaNM };
            ds = Model.Connection.FillDataSet("getMonAnbyMaNM", CommandType.StoredProcedure, para, values);
            return ds;
        }
    }
}
