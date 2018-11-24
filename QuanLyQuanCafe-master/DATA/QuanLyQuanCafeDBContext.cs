namespace QuanLyQuanCafe.DATA
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class QuanLyQuanCafeDBContext : DbContext
    {
        public QuanLyQuanCafeDBContext()
            : base("name=QuanLyQuanCafeDBContext")
        {
        }

        public virtual DbSet<BANAN> BANANs { get; set; }
        public virtual DbSet<CHITIETBAN> CHITIETBANs { get; set; }
        public virtual DbSet<CHITIETNHAP> CHITIETNHAPs { get; set; }
        public virtual DbSet<HOADONBAN> HOADONBANs { get; set; }
        public virtual DbSet<HOADONNHAP> HOADONNHAPs { get; set; }
        public virtual DbSet<KHOHANG> KHOHANGs { get; set; }
        public virtual DbSet<MATHANG> MATHANGs { get; set; }
        public virtual DbSet<NHANVIEN> NHANVIENs { get; set; }
        public virtual DbSet<TAIKHOAN> TAIKHOANs { get; set; }
        public virtual DbSet<THONGTINNHAHANG> THONGTINNHAHANGs { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
