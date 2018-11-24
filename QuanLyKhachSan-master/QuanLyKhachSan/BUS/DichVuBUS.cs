using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class DichVuBUS
    {
        public List<DichVu> DanhSachDichVu()
        {
            return new DichVuDAL().DanhSachDichVu();
        }
        public List<DichVu> TimKiemDichVu(string chuoitimkiem)
        {
            return new DichVuDAL().TimKiemDichVu(chuoitimkiem);
        }

        public bool ThemDichVu(string madichvu, string tendichvu, decimal dongia)
        {
            return new DichVuDAL().ThemDichVu(madichvu, tendichvu, dongia);
        }

        public bool SuaDichVu(string madichvu, string tendichvu, decimal dongia)
        {
            return new DichVuDAL().SuaDichVu(madichvu, tendichvu, dongia);
        }

        public bool XoaDichVu(string madichvu)
        {
            return new DichVuDAL().XoaDichVu(madichvu);
        }
    }
}
