namespace BTL_CNPM.Data
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
            HOADONs = new HashSet<HOADON>();
            PHIEUNHAPs = new HashSet<PHIEUNHAP>();
        }

        public int ID { get; set; }

        public string TEN { get; set; }

        public int? CHUCVU { get; set; }

        public DateTime? NGAYSINH { get; set; }

        public int? GIOITINH { get; set; }

        public string SDT { get; set; }

        public string EMAIL { get; set; }

        public string QUEQUAN { get; set; }

        [Column(TypeName = "image")]
        public byte[] ANH { get; set; }

        public string TAIKHOAN { get; set; }

        public string MATKHAU { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HOADON> HOADONs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PHIEUNHAP> PHIEUNHAPs { get; set; }
    }
}
