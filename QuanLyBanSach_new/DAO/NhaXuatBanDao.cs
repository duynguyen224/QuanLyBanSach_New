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
    public class NhaXuatBanDao
    {

        BookShopDbContext db;
        public NhaXuatBanDao()
        {
            db = new BookShopDbContext();
        }

        public void populatePublisher(ComboBox c)
        {
            c.DataSource = db.NhaXuatBans.Select(x => x.TenNXB).ToList();
        }

        public string getIdPublisher(string publisherName)
        {
            var u = db.NhaXuatBans.Where(x => x.TenNXB == publisherName).FirstOrDefault();
            if (u == null)
            {
                return "abc";
            }
            else
            {
                return u.ID.ToString();
            }
        }

        public int insertPublisher(string tennxb, string diachi, string dienthoai)
        {
            var h = new SqlParameter("@tennxb", tennxb);
            var d = new SqlParameter("@diachi", diachi);
            var dt = new SqlParameter("@dienthoai", dienthoai);

            int res = db.Database.ExecuteSqlCommand("exec proc_themNhaXuatBanMoi @tennxb, @diachi, @dienthoai ", h, d, dt);
            return res;
        }

    }
}
