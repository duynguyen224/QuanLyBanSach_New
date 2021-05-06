using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

using QuanLyBanSach_new.SupportClass;
using QuanLyBanSach_new.Entities;


namespace QuanLyBanSach_new.DAO
{
    public class PhieuNhapDao
    {


        BookShopDbContext db;
        public PhieuNhapDao()
        {
            db = new BookShopDbContext();
        }

        public void insertPhieuNhap(PhieuNhap pn)
        {
            db.PhieuNhaps.Add(pn);
            db.SaveChanges();
        }


    }
}
