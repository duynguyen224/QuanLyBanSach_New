using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBanSach_new.SupportClass
{
    public class DonHang_KhachHang
    {
        public int ID { get; set; }
        public string HoTen { get; set; }
        public DateTime? NgayDat { get; set; }
        public DateTime? NgayGiao { get; set; }
        public int TongTien { get; set; }
    }
}
