namespace QuanLyQuanCafe.DATA
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("BANAN")]
    public partial class BANAN
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public BANAN()
        {
            HOADONBANs = new HashSet<HOADONBAN>();
        }

        [Key]
        public int MABA { get; set; }

        [StringLength(100)]
        public string TENBA { get; set; }

        public int? SOCHO { get; set; }

        public int? TRANGTHAI { get; set; }

        [StringLength(100)]
        public string VITRI { get; set; }

        public int? MAHDB { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HOADONBAN> HOADONBANs { get; set; }
    }
}
