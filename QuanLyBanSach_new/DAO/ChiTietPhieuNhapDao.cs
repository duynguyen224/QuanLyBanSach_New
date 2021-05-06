using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using QuanLyBanSach_new.SupportClass;
using QuanLyBanSach_new.Entities;


namespace QuanLyBanSach_new.DAO
{
    class ChiTietPhieuNhapDao
    {


        BookShopDbContext db;
        public ChiTietPhieuNhapDao()
        {
            db = new BookShopDbContext();
        }


    }
}
