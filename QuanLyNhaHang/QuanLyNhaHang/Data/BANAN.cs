namespace BTL_CNPM.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("BANAN")]
    public partial class BANAN
    {
        public int ID { get; set; }

        public string TEN { get; set; }

        public int? SOCHO { get; set; }

        public string VITRI { get; set; }

        public int? TRANGTHAI { get; set; }

        public int? HOADONID { get; set; }

        public int? KHUVUCBANID { get; set; }

        public virtual HOADON HOADON { get; set; }

        public virtual KHUVUCBAN KHUVUCBAN { get; set; }
    }
}
