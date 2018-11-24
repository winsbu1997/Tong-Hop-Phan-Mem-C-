using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using QuanLyNhanSu.Model;
using QuanLyNhanSu.Object;
namespace QuanLyNhanSu.Control
{
    class KyLuatCtrlTh
    {
       KyLuatModTH klMod = new KyLuatModTH();
        public DataTable GetData()
        {
            return klMod.GetData();
        }
        public bool addData(KyLuatObjTH klObj)
        {
            return klMod.AddData(klObj);
        }
        public bool upData(KyLuatObjTH ktObj)
        {
            return klMod.UpDate(ktObj);
        }
        public bool delData(string ma)
        {
            return klMod.DelData(ma);
        }
    }
}
