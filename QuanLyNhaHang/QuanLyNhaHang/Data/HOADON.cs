namespace BTL_CNPM.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("HOADON")]
    public partial class HOADON
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public HOADON()
        {
            BANANs = new HashSet<BANAN>();
            CHITIETHOADONs = new HashSet<CHITIETHOADON>();
        }

        public int ID { get; set; }

        public string MAHOADON { get; set; }

        public DateTime? NGAYNHAP { get; set; }

        public int? NHANVIENID { get; set; }

        public int? TONGTIEN { get; set; }

        public int? KHUYENMAI { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BANAN> BANANs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CHITIETHOADON> CHITIETHOADONs { get; set; }

        public virtual NHANVIEN NHANVIEN { get; set; }
    }
}
