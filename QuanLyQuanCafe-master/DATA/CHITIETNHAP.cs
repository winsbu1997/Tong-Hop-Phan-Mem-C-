namespace QuanLyQuanCafe.DATA
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CHITIETNHAP")]
    public partial class CHITIETNHAP
    {
        [Key]
        public int MACTN { get; set; }

        public int? MAHDN { get; set; }

        public int? MAMH { get; set; }

        public int? SOLUONG { get; set; }

        public int? DONGIA { get; set; }

        public int? THANHTIEN { get; set; }

        public virtual HOADONNHAP HOADONNHAP { get; set; }

        public virtual MATHANG MATHANG { get; set; }
    }
}
