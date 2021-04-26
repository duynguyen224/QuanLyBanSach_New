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

        public int searchByBookTitle(string someText)
        {
            var st = new SqlParameter("@text", someText);
            var res = db.Database.SqlQuery<XemTatCaSach>("proc_bookSearchByTitle @text", st);
            return 1;
        }

        public int searchByAuthor(string someText)
        {


            return 1;
        }

        public int searchByPublisher(string someText)
        {


            return 1;
        }

    }
}
