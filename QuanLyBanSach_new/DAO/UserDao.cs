using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using QuanLyBanSach_new.Entities;

namespace QuanLyBanSach_new.DAO
{
    public class UserDao
    {
        BookShopDbContext db;
        public UserDao()
        {
            db = new BookShopDbContext();
        }



        // login theo Proc


        // login cua Kien:
        public string login(string username, string password)
        {
            var u = db.Users.Where(x => x.Username == username && x.Password == password).FirstOrDefault();
            if (u == null)
            {
                return "abc";
            }
            else
            {
                return u.Role.Trim().ToLower();
            }
        }


    }
}
