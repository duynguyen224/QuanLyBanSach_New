using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBanSach_new.SupportClass
{
    public class PhieuNhap_ChiTiet
    {
        //pn.TieuDe, pn.TongTien, pn.NgayNhap, ctpn.MaSach, ctpn.SoLuong
        public string TieuDe { get; set; }
        public int TongTien { get; set; }
        public DateTime NgayNhap { get; set; }
        public string TenSach { get; set; }
        public int SoLuong { get; set; }
    }
}
