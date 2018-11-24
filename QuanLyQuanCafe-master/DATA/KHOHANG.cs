namespace QuanLyQuanCafe.DATA
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("KHOHANG")]
    public partial class KHOHANG
    {
        public int ID { get; set; }

        public int? MAMH { get; set; }

        public int? SOLUONGNHAP { get; set; }

        public int? SOLUONGBAN { get; set; }

        public int? SOLUONGXUATKHO { get; set; }

        public int? SOLUONGTONKHO { get; set; }

        public virtual MATHANG MATHANG { get; set; }
    }
}
