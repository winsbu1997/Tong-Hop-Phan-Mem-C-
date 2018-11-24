namespace BTL_CNPM.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("MATHANG")]
    public partial class MATHANG
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public MATHANG()
        {
            CHITIETHOADONs = new HashSet<CHITIETHOADON>();
            CHITIETNHAPs = new HashSet<CHITIETNHAP>();
            KHOes = new HashSet<KHO>();
        }

        public int ID { get; set; }

        public string TEN { get; set; }

        public string DONVITINH { get; set; }

        public int? GIABAN { get; set; }

        public string THANHPHAN { get; set; }

        [Column(TypeName = "image")]
        public byte[] ANH { get; set; }

        public int? LOAIMATHANGID { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CHITIETHOADON> CHITIETHOADONs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CHITIETNHAP> CHITIETNHAPs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<KHO> KHOes { get; set; }

        public virtual LOAIMATHANG LOAIMATHANG { get; set; }
    }
}
