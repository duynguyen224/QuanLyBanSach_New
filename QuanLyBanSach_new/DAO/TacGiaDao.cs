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
        //fix by HHuy
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

        public int updateAuthor(string hoten, string diachi, string tieusu, string dienthoai, int id)
        {
            var u = db.TacGias.Where(x => x.ID == id).FirstOrDefault();
            u.HoTenTG = hoten;
            u.DiaChi = diachi;
            u.TieuSu = tieusu;
            u.DienThoai = dienthoai;
            db.SaveChanges();
            return u.ID;
        }

        public int deleteAuthor(int id)
        {
            var u = db.TacGias.Where(x => x.ID == id).FirstOrDefault();
            db.TacGias.Remove(u);
            db.SaveChanges();
            return u.ID;

        }

        public List<Author> listAuthor()
        {
            var res = db.Database.SqlQuery<Author>("proc_listAuthor").ToList();
            return res;
        }

        public void updateAuthorName(int id, string newName)
        {
            var res = db.TacGias.Where(x => x.ID == id).FirstOrDefault();
            res.HoTenTG = newName;
            db.SaveChanges();
        }

    }
}
