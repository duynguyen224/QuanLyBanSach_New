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

    }
}
