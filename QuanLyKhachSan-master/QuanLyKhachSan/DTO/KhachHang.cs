using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class KhachHang
    {
        private string makhachhang;
        private string tenkhachhang;
        private string sochungminh;
        private string sodienthoai;
        private string diadiem;
        private string gioitinh;
        private DateTime ngaysinh;
        
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

        public string Tenkhachhang
        {
            get
            {
                return tenkhachhang;
            }

            set
            {
                tenkhachhang = value;
            }
        }

        public string Sochungminh
        {
            get
            {
                return sochungminh;
            }

            set
            {
                sochungminh = value;
            }
        }

        public string Sodienthoai
        {
            get
            {
                return sodienthoai;
            }

            set
            {
                sodienthoai = value;
            }
        }

        public string Diadiem
        {
            get
            {
                return diadiem;
            }

            set
            {
                diadiem = value;
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
