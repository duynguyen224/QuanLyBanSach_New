namespace QuanLyBanSach_new.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ChiTietPhieuNhap")]
    public partial class ChiTietPhieuNhap
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID { get; set; }

        public int MaPhieuNhap { get; set; }

        public int MaSach { get; set; }

        public int? SoLuong { get; set; }

        public virtual PhieuNhap PhieuNhap { get; set; }

        public virtual Sach Sach { get; set; }
    }
}
