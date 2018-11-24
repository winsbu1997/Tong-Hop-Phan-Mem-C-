using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class SuDungDichVu
    {
        private string masudungdichvu;
        private string madichvu;
        private string tendichvu;
        private decimal dongia;
        private int soluong;
        private decimal thanhtien;

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

        public string Madichvu
        {
            get
            {
                return madichvu;
            }

            set
            {
                madichvu = value;
            }
        }

        public string Tendichvu
        {
            get
            {
                return tendichvu;
            }

            set
            {
                tendichvu = value;
            }
        }

        public decimal Dongia
        {
            get
            {
                return dongia;
            }

            set
            {
                dongia = value;
            }
        }

        public int Soluong
        {
            get
            {
                return soluong;
            }

            set
            {
                soluong = value;
            }
        }

        public decimal Thanhtien
        {
            get
            {
                return thanhtien;
            }

            set
            {
                thanhtien = value;
            }
        }
    }
}
