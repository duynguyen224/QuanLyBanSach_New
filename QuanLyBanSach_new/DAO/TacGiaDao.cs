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
    public class TacGiaDao
    {
        BookShopDbContext db;
        public TacGiaDao()
        {
            db = new BookShopDbContext();
        }

        public void populateAuthor(ComboBox c)
        {
            c.DataSource = db.TacGias.Select(x => x.HoTenTG).ToList();
        }

        public string getIdAuthor(string authorName)
        {
            var u = db.TacGias.Where(x => x.HoTenTG == authorName).FirstOrDefault();
            if(u == null)
            {
                return "abc";
            }
            else
            {
                return u.ID.ToString();
            }
        }

        public int insertAuthor(string hoten, string diachi, string tieusu, string dienthoai)
        {
            var h = new SqlParameter("@hoten", hoten);
            var d = new SqlParameter("@tieusu", diachi);
            var t = new SqlParameter("@diachi", tieusu);
            var dt = new SqlParameter("@dienthoai", dienthoai);

            int res = db.Database.ExecuteSqlCommand("exec proc_themTacGiaMoi @hoten, @tieusu, @diachi, @dienthoai ", h, d, t, dt);
            return res;
        }

        //public IList<AuthorNameOnly> getAuthorNameFromBookTitle(string booktitle)
        //{
        //    var bt = new SqlParameter("@bookTitle", booktitle);
        //    var res = db.Database.SqlQuery<AuthorNameOnly>("proc_getAuthorNamrFromBookTitle @bookTitle", bt).ToList();
        //    return res;
        //}
    }
}
