namespace BTL_CNPM.Data
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class RM_Context : DbContext
    {
        public RM_Context()
            : base("name=RM_Context")
        {
        }

        public virtual DbSet<BANAN> BANANs { get; set; }
        public virtual DbSet<CHITIETHOADON> CHITIETHOADONs { get; set; }
        public virtual DbSet<CHITIETNHAP> CHITIETNHAPs { get; set; }
        public virtual DbSet<HOADON> HOADONs { get; set; }
        public virtual DbSet<KHO> KHOes { get; set; }
        public virtual DbSet<KHUVUCBAN> KHUVUCBANs { get; set; }
        public virtual DbSet<LOAIMATHANG> LOAIMATHANGs { get; set; }
        public virtual DbSet<MATHANG> MATHANGs { get; set; }
        public virtual DbSet<NHANVIEN> NHANVIENs { get; set; }
        public virtual DbSet<PHIEUNHAP> PHIEUNHAPs { get; set; }
        public virtual DbSet<THONGTINNHAHANG> THONGTINNHAHANGs { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<HOADON>()
                .HasMany(e => e.CHITIETHOADONs)
                .WithRequired(e => e.HOADON)
                .WillCascadeOnDelete(false);
        }
    }
}
