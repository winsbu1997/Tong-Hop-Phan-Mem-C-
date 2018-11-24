using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class NhanVien
    {
        private static NhanVien instance;
        private string manhanvien;
        private string tennhanvien;
        private string taikhoan;
        private string matkhau;
        private int quyenhan;
        private string gioitinh;
        private string quequan;
        private DateTime ngaysinh;
        private NhanVien() { }
        public static NhanVien Instance
        {
            get
            {
                if (instance == null) instance = new NhanVien();
                return instance;
            }

        set
            {

                instance = value;
            }
        }

        public string Manhanvien
        {
            get
            {
                return manhanvien;
            }

            set
            {
                manhanvien = value;
            }
        }

        public string Tennhanvien
        {
            get
            {
                return tennhanvien;
            }

            set
            {
                tennhanvien = value;
            }
        }

        public string Taikhoan
        {
            get
            {
                return taikhoan;
            }

            set
            {
                taikhoan = value;
            }
        }

        public string Matkhau
        {
            get
            {
                return matkhau;
            }

            set
            {
                matkhau = value;
            }
        }

        public int Quyenhan
        {
            get
            {
                return quyenhan;
            }

            set
            {
                quyenhan = value;
            }
        }

        public string Gioitinh
        {
            get
            {
                return gioitinh;
            }

            set
            {
                gioitinh = value;
            }
        }

        public string Quequan
        {
            get
            {
                return quequan;
            }

            set
            {
                quequan = value;
            }
        }

        public DateTime Ngaysinh
        {
            get
            {
                return ngaysinh;
            }

            set
            {
                ngaysinh = value;
            }
        }
    }
}
