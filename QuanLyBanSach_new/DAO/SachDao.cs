using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyBanSach_new.Entities;
using QuanLyBanSach_new.SupportClass;

namespace QuanLyBanSach_new.DAO
{
    public class SachDao
    {
        BookShopDbContext db;
        public SachDao()
        {
            db = new BookShopDbContext();
        }

        public void populateBook(ComboBox c)
        {
            c.DataSource = db.Saches.Select(x => x.TenSach).ToList();
        }

        public int insertBook(string tensach, int? giaban, int? soluongton, int? manxb, int? machude)
        {

            var t = new SqlParameter("@tensach", tensach);
            var g = new SqlParameter("@giaban", giaban);
            var s = new SqlParameter("@soluongton", soluongton);
            var mnxb = new SqlParameter("@manxb", manxb);
            var mcd = new SqlParameter("@machude", machude);

            int res = db.Database.ExecuteSqlCommand("exec proc_themSachMoi @tensach, @giaban, @soluongton, @manxb, @machude", t, g, s, mnxb, mcd);
            return res;
        }

        public void displayAllBook(DataGridView gridview)
        {
            gridview.DataSource = db.Database.SqlQuery<XemTatCaSach>("exec proc_xemTatCaSach").ToList() ;
        }

        public IList<XemTatCaSach> searchByBookTitle(string someText)
        {
            var st = new SqlParameter("@text", someText);
            var res = db.Database.SqlQuery<XemTatCaSach>("proc_bookSearchByTitle @text", st).ToList();
            return res;
        }

        public IList<XemTatCaSach> searchByAuthor(string someText)
        {
            var st = new SqlParameter("@text", someText);
            var res = db.Database.SqlQuery<XemTatCaSach>("proc_bookSearchByAuthor @text", st).ToList();
            return res;
        }

        public IList<XemTatCaSach> searchByPublisher(string someText)
        {
            var st = new SqlParameter("@text", someText);
            var res = db.Database.SqlQuery<XemTatCaSach>("proc_bookSearchByPublisher @text", st).ToList();
            return res;
        }
        public IList<XemTatCaSach> searchByCategory(string someText)
        {
            var st = new SqlParameter("@text", someText);
            var res = db.Database.SqlQuery<XemTatCaSach>("proc_bookSearchByCategory @text", st).ToList();
            return res;
        }

        public IList<XemTatCaSach> searchByStock()
        {
            var res = db.Database.SqlQuery<XemTatCaSach>("proc_bookSearchByStock").ToList();
            return res;
        }

        public IList<BookTitleOnly> sellBookSearchToCombobox(string sometext)
        {
            var st = new SqlParameter("@text", sometext);
            var res = db.Database.SqlQuery<BookTitleOnly>("proc_bookSearchToCombobox @text", st).ToList() ;
            return res;
        }

        public IList<SellBook> bindDataFromTextBoxSearchToOthers(string booktitle)
        {
            var bt = new SqlParameter("@text", booktitle);
            var res = db.Database.SqlQuery<SellBook>("proc_bookSearchToSell @text", bt).ToList();
            return res;
        }

        public int getIdBookByName(string booktitle)
        {
            var res = db.Saches.Where(x => x.TenSach.Trim().ToLower() == booktitle.Trim().ToLower()).FirstOrDefault() ;
            if(res == null)
            {
                return 0;
            }
            else
            {
                return res.ID;
            }
        }

        public void updateStock(int idBook, int soluong)
        {
            var bt = new SqlParameter("@id", idBook);
            var sl = new SqlParameter("@soluong", soluong);
            var res = db.Database.ExecuteSqlCommand("proc_updateSoLuongTon @id, @soluong", bt, sl);
        }

        public void updateQuantity(int idBook, int? soluong)
        {
            var bid = new SqlParameter("@id", idBook);
            var sl = new SqlParameter("@soluong", soluong);
            db.Database.ExecuteSqlCommand("proc_updateSoLuongTon_nhapHang @id, @soluong", bid, sl);
            
        }

        public void updateBooktitle(int id, string newName)
        {
            var res = db.Saches.Where(x => x.ID == id).FirstOrDefault();
            res.TenSach = newName;
            db.SaveChanges();
        }

        public void updatePrice(int id, int price)
        {
            var res = db.Saches.Where(x => x.ID == id).FirstOrDefault();
            res.GiaBan = price;
            db.SaveChanges();

        }

        public void deleteBook(int id)
        {
            var i = new SqlParameter("@id", id);
            db.Database.ExecuteSqlCommand("proc_deleteSach @id", i);
        }

        public int getPriceById(int id){
            return db.Saches.Where(x => x.ID == id).FirstOrDefault().GiaBan.GetValueOrDefault();
        }

    }
}
