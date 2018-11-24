using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using QuanLyNhanSu.Object;
namespace QuanLyNhanSu.Model
{
    class NhanVienModTr
    {
        public static DataTable GetListNhanVien()
        {
            return ConnetctToSQLTr.GetData("select NhanVien.MaNV, HoTen,NgaySinh,GioiTinh,SoCMND,NhanVien.SDT,TenCV,TenPB,TenHD  from NhanVien,PhongBan,ChucVu,HopDong where NhanVien.MaCV=ChucVu.MaCV and  NhanVien.MaPB=PhongBan.MaPB and NhanVien.MaHD=HopDong.MaHD");
        }
        public static int InsertNhanVien(NhanVienObjTr ctd)
        {
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@manv",ctd.maNV),
                new SqlParameter("@hoten", ctd.HoTen),
                new SqlParameter("@ngaysinh", ctd.NgaySinh),
                new SqlParameter("@gioitinh",ctd.GioiTinh),
                new SqlParameter("@socmnd",ctd.SoCMND),
                new SqlParameter("@sdt",ctd.SDT),
                new SqlParameter("@macv",ctd.MaCV),
                  new SqlParameter("@mapb",ctd.MaPB),
                    new SqlParameter("@mahd",ctd.MaHD)



            };
            return ConnetctToSQLTr.ExecuteNonQuery("ThemNhanVien", para);
        }

        public static int UpdateNhanVien(NhanVienObjTr ctd)
        {

            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@manv",ctd.maNV),
                new SqlParameter("@hoten", ctd.HoTen),
                new SqlParameter("@ngaysinh", ctd.NgaySinh),
                new SqlParameter("@gioitinh",ctd.GioiTinh),
                new SqlParameter("@socmnd",ctd.SoCMND),
                new SqlParameter("@sdt",ctd.SDT),
                new SqlParameter("@macv",ctd.MaCV),
                  new SqlParameter("@mapb",ctd.MaPB),
                    new SqlParameter("@mahd",ctd.MaHD)


            };
            return ConnetctToSQLTr.ExecuteNonQuery("SuaNhanVien", para);
        }

        public static int DeleteNhanVien(NhanVienObjTr ctd)
        {
            SqlParameter[] para = new SqlParameter[]
            {

                new SqlParameter("@manv",ctd.maNV)

          };
            return ConnetctToSQLTr.ExecuteNonQuery("XoaNhanVien", para);

        }
    }
}
