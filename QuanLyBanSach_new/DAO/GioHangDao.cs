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
    public class GioHangDao
    {
        BookShopDbContext db;
        public GioHangDao()
        {
            db = new BookShopDbContext();
        }

        public void insertToCart(string bookTitle, int qty, int amount, int price, int stock)
        {
            GioHang g = new GioHang();
            g.BookTitle = bookTitle;
            g.Qty = qty;
            g.Amount = amount;
            g.Price = price;
            g.Stock = stock;
            db.GioHangs.Add(g);
            db.SaveChanges();
        }

        public void deleteAllCartRecord()
        {
            db.Database.ExecuteSqlCommand("delete from GioHang");
            db.SaveChanges();
        }

        public IList<Cart> bindDataToGridCart()
        {
            var res = db.Database.SqlQuery<Cart>("proc_bindDataToCart").ToList();
            return res;
        }

        public void deleteOneRecord(string booktitle)
        {
            var g = db.GioHangs.Where(x => x.BookTitle.Trim().ToLower() == booktitle.Trim().ToLower()).FirstOrDefault() ;

            db.GioHangs.Remove(g);
            db.SaveChanges();
        }

        public void addIdCustomerToAllRecord(int id)
        {
            foreach(var item in db.GioHangs)
            {
                item.CustomerID = id;
            }
            db.SaveChanges();
        }

        public double netAmount()
        {
            var myTable = db.GioHangs.ToList();
            var netAmount_ = 0;
            foreach(var myRow in myTable)
            {
                netAmount_ += myRow.Amount;
            }
            return netAmount_;
        }
        

    }
}
