using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using QuanLyBanSach_new.Entities;


namespace QuanLyBanSach_new.DAO
{
    public class ChiTietDonHangDao
    {
        BookShopDbContext db;
        public ChiTietDonHangDao()
        {
            db = new BookShopDbContext();
        }

        public void insertChiTietDonHang(ChiTietDonHang ctdh)
        {
            db.ChiTietDonHangs.Add(ctdh);
            db.SaveChanges();
        }

    }
}
