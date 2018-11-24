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
    class PhongBanCtrlL
    {
        PhongBanModL pbMod = new PhongBanModL();
        public DataTable GetData()
        {
            return pbMod.GetData();
        }
        public bool addData(PhongBanObjL pbObj)
        {
            return pbMod.AddData(pbObj);
        }
        public bool upData(PhongBanObjL pbObj)
        {
            return pbMod.UpDate(pbObj);
        }
        public bool delData(string ma)
        {
            return pbMod.DelData(ma);
        }
    }
}
