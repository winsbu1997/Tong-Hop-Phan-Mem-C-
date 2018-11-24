using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
   public class ThuePhong
    {
        private string mathuephong;
        private string makhachhang;
        private string manhanvien;
        private string masudungdichvu;
        private DateTime ngaythue;

        public string Mathuephong
        {
            get
            {
                return mathuephong;
            }

            set
            {
                mathuephong = value;
            }
        }

        public string Makhachhang
        {
            get
            {
                return makhachhang;
            }

            set
            {
                makhachhang = value;
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

        public string Masudungdichvu
        {
            get
            {
                return masudungdichvu;
            }

            set
            {
                masudungdichvu = value;
            }
        }

        public DateTime Ngaythue
        {
            get
            {
                return ngaythue;
            }

            set
            {
                ngaythue = value;
            }
        }
    }
}
