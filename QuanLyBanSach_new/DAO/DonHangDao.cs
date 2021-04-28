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

    }
}
