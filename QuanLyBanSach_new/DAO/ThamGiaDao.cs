using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using QuanLyBanSach_new.Entities;

namespace QuanLyBanSach_new.DAO
{
    public class ThamGiaDao
    {
        BookShopDbContext db;
        public ThamGiaDao()
        {
            db = new BookShopDbContext();
        }

        public int insertThamGia(int bookID, int authorID)
        {
            ThamGia thamgia = new ThamGia()
            {
                MaSach = bookID,
                MaTG = authorID
            };
            db.ThamGias.Add(thamgia);
            db.SaveChanges();
            return thamgia.MaTG;
        }
    }
}
