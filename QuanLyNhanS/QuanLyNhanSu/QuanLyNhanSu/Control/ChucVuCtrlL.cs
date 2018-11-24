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
    class ChucVuCtrlL
    {
        ChucVuMolL cvMod = new ChucVuMolL();
        public DataTable GetData()
        {
            return cvMod.GetData();
        }
        public bool addData(ChucVuObjL cvObj)
        {
            return cvMod.AddData(cvObj);
        }
        public bool upData(ChucVuObjL cvObj)
        {
            return cvMod.UpDate(cvObj);
        }
        public bool delData(string ma)
        {
            return cvMod.DelData(ma);
        }
    }
}
