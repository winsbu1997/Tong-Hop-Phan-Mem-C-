using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyNhanSu.Object;
using QuanLyNhanSu.Model;
using System.Data;

namespace QuanLyNhanSu.Control
{
    class HopDongCtrl
    {
        public static DataTable GetData()
        {
            return HopDongMod.GetData();
        }
        public static int InsertProfile(HopDongObj qh)
        {
            return HopDongMod.InsertProfile(qh);
        }

        public static int UpdateProfile(HopDongObj qh)
        {
            return HopDongMod.UpdateProfile(qh);
        }

        public static int DeleteProfile(HopDongObj qh)
        {
            return HopDongMod.DeleteProfile(qh);
        }
    }
}
