using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyNhanSu.Model;
using System.Data;
using QuanLyNhanSu.Object;

namespace QuanLyNhanSu.Control
{
    class KhenThuongCtrlTH
    {
        KhenThuongModTH ktMod = new KhenThuongModTH();
        public DataTable GetData()
        {
            return ktMod.GetData();
        }
        public bool addData(KhenThuongObjTH ktObj)
        {
            return ktMod.AddData(ktObj);
        }
        public bool upData(KhenThuongObjTH ktObj)
        {
            return ktMod.UpDate(ktObj);
        }
        public bool delData(string ma)
        {
            return ktMod.DelData(ma);
        }
       
    }
}
