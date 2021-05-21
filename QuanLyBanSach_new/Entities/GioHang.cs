namespace QuanLyBanSach_new.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("GioHang")]
    public partial class GioHang
    {
        [Key]
        [StringLength(50)]
        public string BookTitle { get; set; }

        public int Qty { get; set; }

        public int Amount { get; set; }

        public int Price { get; set; }

        public int? CustomerID { get; set; }

        public int? Stock { get; set; }
    }
}
