using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using QuanLyBanSach_new.Entities;


namespace QuanLyBanSach_new.DAO
{
    public class DonHangDao
    {
        BookShopDbContext db;
        public DonHangDao()
        {
            db = new BookShopDbContext();
        }

        public string insertDonHang(DonHang dh)
        {
            dh.DaThanhToan = true;
            dh.TinhTrangGiaoHang = true;
            dh.NgayDat = DateTime.Now;
            dh.NgayGiao = DateTime.Now;
            db.DonHangs.Add(dh);
            db.SaveChanges();
            return dh.ID.ToString();
        }
        
    }
}
