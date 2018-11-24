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
    class HeSoLuongCtrl
    {
        public static DataTable GetData()
        {
            return HeSoLuongMod.GetData();
        }
        public static int InsertProfile(HeSoLuong qh)
        {
            return HeSoLuongMod.InsertProfile(qh);
        }

        public static int UpdateProfile(HeSoLuong qh)
        {
            return HeSoLuongMod.UpdateProfile(qh);
        }

        public static int DeleteProfile(HeSoLuong qh)
        {
            return HeSoLuongMod.DeleteProfile(qh);
        }
    }
}
