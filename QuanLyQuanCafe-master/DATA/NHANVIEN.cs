namespace QuanLyQuanCafe.DATA
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("NHANVIEN")]
    public partial class NHANVIEN
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public NHANVIEN()
        {
            HOADONBANs = new HashSet<HOADONBAN>();
            HOADONNHAPs = new HashSet<HOADONNHAP>();
        }

        [Key]
        public int MANV { get; set; }

        [StringLength(100)]
        public string TENNV { get; set; }

        [StringLength(100)]
        public string GIOITINH { get; set; }

        [StringLength(100)]
        public string DIACHI { get; set; }

        public int? NAMSINH { get; set; }

        [StringLength(100)]
        public string SDT { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HOADONBAN> HOADONBANs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HOADONNHAP> HOADONNHAPs { get; set; }
    }
}
