namespace QuanLyQuanCafe.DATA
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CHITIETBAN")]
    public partial class CHITIETBAN
    {
        [Key]
        public int MACTB { get; set; }

        public int? MAHDB { get; set; }

        public int? MAMH { get; set; }

        public int? SOLUONG { get; set; }

        public int? THANHTIEN { get; set; }

        public virtual HOADONBAN HOADONBAN { get; set; }

        public virtual MATHANG MATHANG { get; set; }
    }
}
