using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
   public class ThietBi
    {
        private string mathietbi;
        private string tenthietbi;
        private decimal giathietbi;
        private int soluong;

        public string Mathietbi
        {
            get
            {
                return mathietbi;
            }

            set
            {
                mathietbi = value;
            }
        }

        public string Tenthietbi
        {
            get
            {
                return tenthietbi;
            }

            set
            {
                tenthietbi = value;
            }
        }

        public decimal Giathietbi
        {
            get
            {
                return giathietbi;
            }

            set
            {
                giathietbi = value;
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
    }
}
