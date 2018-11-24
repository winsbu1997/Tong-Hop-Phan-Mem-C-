namespace BTL_CNPM.Data
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

        public string TEN { get; set; }

        public string DIACHI { get; set; }
    }
}
