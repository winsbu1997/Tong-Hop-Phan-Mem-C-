namespace QuanLyQuanCafe.DATA
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("HOADONBAN")]
    public partial class HOADONBAN
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public HOADONBAN()
        {
            CHITIETBANs = new HashSet<CHITIETBAN>();
        }

        [Key]
        public int MAHDB { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NGAY { get; set; }

        public int? MANV { get; set; }

        public int? MABA { get; set; }

        public int? STATUS { get; set; }

        public virtual BANAN BANAN { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CHITIETBAN> CHITIETBANs { get; set; }

        public virtual NHANVIEN NHANVIEN { get; set; }
    }
}
