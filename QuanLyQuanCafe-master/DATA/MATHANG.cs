namespace QuanLyQuanCafe.DATA
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
            CHITIETBANs = new HashSet<CHITIETBAN>();
            CHITIETNHAPs = new HashSet<CHITIETNHAP>();
            KHOHANGs = new HashSet<KHOHANG>();
        }

        [Key]
        public int MAMH { get; set; }

        [StringLength(100)]
        public string TENMH { get; set; }

        [StringLength(100)]
        public string DVTINH { get; set; }

        public int? DONGIA { get; set; }

        public byte[] HINHANH { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CHITIETBAN> CHITIETBANs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CHITIETNHAP> CHITIETNHAPs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<KHOHANG> KHOHANGs { get; set; }
    }
}
