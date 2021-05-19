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
        //Update by Kien
        public int insertUser(User u)
        {
            db.Users.Add(u);
            db.SaveChanges();
            return u.ID;
        }
        //Update by Kien
        public int updateUser(int id, string fullname, string username, string password, string role)
        {
            var u = db.Users.Where(x => x.ID == id).FirstOrDefault();
            u.Fullname = fullname;
            u.Username = username;
            u.Password = password;
            u.Role = role;
            db.SaveChanges();
            return u.ID;
        }
        //Update by Kien
        public int deleteUser(int id)
        {
            var u = db.Users.Where(x => x.ID == id).FirstOrDefault();
            db.Users.Remove(u);
            db.SaveChanges();
            return u.ID;
        }
        //Update by Kien
        public void populateUser(DataGridView gridview)
        {
            gridview.DataSource = db.Users.ToList();
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
