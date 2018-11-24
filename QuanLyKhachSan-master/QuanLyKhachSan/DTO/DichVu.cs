using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
   public class DichVu
    {
        private string madichvu;
        private string tendichvu;
        private decimal dongia;

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
    }
}
