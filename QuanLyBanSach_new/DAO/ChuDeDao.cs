using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyBanSach_new.Entities;


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
    }
}
