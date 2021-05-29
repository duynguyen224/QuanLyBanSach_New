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
    public class ChuDeDao
    {

        BookShopDbContext db;
        public ChuDeDao()
        {
            db = new BookShopDbContext();
        }

        public void populateCategory(ComboBox c)
        {
            c.DataSource = db.ChuDes.Select(x => x.TenCD).ToList();
        }

        public List<Cate> listCategory()
        {
            return db.Database.SqlQuery<Cate>("proc_listCategory").ToList();
        }

        public string getIdCategory(string categoryName)
        {
            var u = db.ChuDes.Where(x => x.TenCD == categoryName).FirstOrDefault();
            if (u == null)
            {
                return "abc";
            }
            else
            {
                return u.ID.ToString();
            }
        }

        public int insertCategory(string tencd)
        {
            var t = new SqlParameter("@tencd", tencd);

            int res = db.Database.ExecuteSqlCommand("exec proc_themChuDeMoi @tencd", t);

            return res;
        }

        public int updateCategoryName(int id, string newname)
        {
            var res = db.ChuDes.Where(x => x.ID == id).FirstOrDefault();
            res.TenCD = newname;
            db.SaveChanges();
            return res.ID;
        }

        public int deleteCategory(int id)
        {
            var res = db.ChuDes.Where(x => x.ID == id).FirstOrDefault();
            db.ChuDes.Remove(res);
            db.SaveChanges();
            return res.ID;
        }


    }
}
