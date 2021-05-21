using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBanSach_new.SupportClass
{
    public class Expense
    {
        //pn.TieuDe, pn.TongTien, pn.NgayNhap, pn.MoTa
        public int ID { get; set; }
        public string TieuDe { get; set; }
        public int TongTien { get; set; }
        public DateTime NgayNhap { get; set; }
        public string MoTa { get; set; }
    }
}
