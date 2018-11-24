using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanCafe.DTO
{
    public class BanAnDTO
    {
        public int MaBA { get; set; }
        public string TenBA { get; set; }
        public int SoCho { get; set; }
        public int TrangThai { get; set; }
        public string ViTri { get; set; }
        public int MaHDB { get; set; }

        public BanAnDTO(DataRow row)
        {
            this.MaBA = (int) row["MABA"];
            this.TenBA = row["TENBA"].ToString();
            this.SoCho = (int)row["SOCHO"];
            this.TrangThai = (int)row["TRANGTHAI"];
            this.ViTri = row["VITRI"].ToString();
            this.MaHDB = (int) row["MAHDB"];
        }
    }
}
