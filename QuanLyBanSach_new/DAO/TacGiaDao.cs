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


    }
}
