using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
   public class TraPhong
    {
       private string mathuephong;
        private string matraphong;
        private decimal tongtien;
        private DateTime ngaytra;
        private string manhanvien;
        private string thongtin;

        public string Mathuephong { get; set; }
        public string Matraphong { get; set; }
        public decimal Tongtien { get; set; }
        public DateTime Ngaytra { get; set; }
        public string Manhanvien { get; set; }
        public string Thongtin { get; set; }
    }
}
