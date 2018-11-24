namespace QuanLyQuanCafe.DATA
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("HOADONNHAP")]
    public partial class HOADONNHAP
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public HOADONNHAP()
        {
            CHITIETNHAPs = new HashSet<CHITIETNHAP>();
        }

        [Key]
        public int MAHDN { get; set; }

        public DateTime? NGAY { get; set; }

        public int? MANV { get; set; }

        public int? TONGTIEN { get; set; }

        [StringLength(100)]
        public string NOINHAP { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CHITIETNHAP> CHITIETNHAPs { get; set; }

        public virtual NHANVIEN NHANVIEN { get; set; }
    }
}
