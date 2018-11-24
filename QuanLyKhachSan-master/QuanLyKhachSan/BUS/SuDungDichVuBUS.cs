using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class SuDungDichVuBUS
    {
        public bool ThemChiTietSuDungDichVu(string masudungdichvu, string madichvu, int soluong, decimal thanhtien)
        {
            SuDungDichVuDAL sdDAL = new SuDungDichVuDAL();
            return sdDAL.ThemChiTietSuDungDichVu(masudungdichvu, madichvu, soluong, thanhtien);
        }
        public List<SuDungDichVu> DanhSachDVPhongSD(string masudungdichvu)
        {
            SuDungDichVuDAL sdDAL = new SuDungDichVuDAL();
            return sdDAL.DanhSachDVPhongSD(masudungdichvu);
        }
        public bool XoaChiTietSuDungDichVu(string masudungdichvu, string madichvu)
        {
            SuDungDichVuDAL sdDAL = new SuDungDichVuDAL();
            return sdDAL.XoaChiTietSuDungDichVu(masudungdichvu, madichvu);
        }
        public bool CapNhatChiTietSuDungDichVu(string masudungdichvu, string madichvu, int soluong, decimal thanhtien)
        {
            SuDungDichVuDAL sdDAL = new SuDungDichVuDAL();
            return sdDAL.CapNhatChiTietSuDungDichVu(masudungdichvu, madichvu, soluong, thanhtien);
        }
        public decimal TongTienDichVu(string masudungdichvu)
        {
            SuDungDichVuDAL sdDAL = new SuDungDichVuDAL();
            return sdDAL.TongTienDichVu(masudungdichvu);
        }
    }
}
