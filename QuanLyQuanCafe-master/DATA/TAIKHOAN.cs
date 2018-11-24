namespace QuanLyQuanCafe.DATA
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TAIKHOAN")]
    public partial class TAIKHOAN
    {
        public int ID { get; set; }

        [StringLength(100)]
        public string TENDN { get; set; }

        [StringLength(100)]
        public string MATKHAU { get; set; }
    }
}
