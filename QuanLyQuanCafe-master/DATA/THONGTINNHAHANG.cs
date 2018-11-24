namespace QuanLyQuanCafe.DATA
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("THONGTINNHAHANG")]
    public partial class THONGTINNHAHANG
    {
        public int ID { get; set; }

        [StringLength(100)]
        public string DIACHI { get; set; }

        [StringLength(100)]
        public string TENNH { get; set; }
    }
}
