using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using QuanLyBanSach_new.Entities;
using QuanLyBanSach_new.SupportClass;

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

        public int allBookSold()
        {
            int sl = 0;
            var res = db.Database.SqlQuery<SoLuong>("proc_soldBooks").ToList();
            foreach (var item in res)
            {
                sl = item.soluong;
            }
            return sl;
        }

        public IList<Sach_ChiTietDH> getDetails(int idDonHang)
        {
            var mdh = new SqlParameter("@madh", idDonHang);
            var res = db.Database.SqlQuery<Sach_ChiTietDH>("proc_info_details @madh", mdh);
            return res.ToList();
        }
    }
}
