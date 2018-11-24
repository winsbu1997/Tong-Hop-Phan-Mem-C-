using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyNhanSu.Object;
using QuanLyNhanSu.Model;
using System.Data.SqlClient;
using System.Data;
namespace QuanLyNhanSu.Control
{
    class NhanVienCtrlTr
    {
        public static DataTable GetListNhanVien()
        {
            return NhanVienModTr.GetListNhanVien();

        }


        public static int InsertNhanVien(NhanVienObjTr ctd)
        {
            return NhanVienModTr.InsertNhanVien(ctd);
        }

        public static int UpdateNhanVien(NhanVienObjTr ctd)
        {
            return NhanVienModTr.UpdateNhanVien(ctd);

        }

        public static int DeleteNhanVien(NhanVienObjTr ctd)
        {
            return NhanVienModTr.DeleteNhanVien(ctd);

        }
    }
}
