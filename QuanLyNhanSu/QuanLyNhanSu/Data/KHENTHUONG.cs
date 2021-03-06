namespace QuanLyNhanSu
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("KHENTHUONG")]
    public partial class KHENTHUONG
    {
        public int ID { get; set; }

        public int? NHANVIENID { get; set; }

        public string NOIDUNG { get; set; }

        public DateTime? NGAY { get; set; }

        public virtual NHANVIEN NHANVIEN { get; set; }
    }
}
