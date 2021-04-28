using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;


using QuanLyBanSach_new.SupportClass;
using QuanLyBanSach_new.Entities;

namespace QuanLyBanSach_new.DAO
{
    public class KhachHangDao
    {
        BookShopDbContext db;
        public KhachHangDao()
        {
            db = new BookShopDbContext();
        }

        public IList<CustomerNameOnly> bindNameCustomerToCombobox(string name)
        {
            var n = new SqlParameter("@name", name);
            var res = db.Database.SqlQuery<CustomerNameOnly>("proc_searchCustomerName @name", n).ToList();
            return res;
        }

        public string getIdFromCustomerName(string name)
        {
            //var res = db.KhachHangs.(x => x.HoTen.Trim().ToLower() == name.Trim().ToLower()).FirstOrDefault();
            var u = db.KhachHangs.Where(x => x.HoTen == name).FirstOrDefault();
            if (u == null)
            {
                return "abc";
            }
            else
            {
                return u.ID.ToString();
            }
        }

        public int insertCustomer(KhachHang kh)
        {
            db.KhachHangs.Add(kh);
            db.SaveChanges();
            return kh.ID ;
        }
    }
}
