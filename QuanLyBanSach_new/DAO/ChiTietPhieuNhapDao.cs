using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using QuanLyBanSach_new.SupportClass;
using QuanLyBanSach_new.Entities;
using System.Data.SqlClient;

namespace QuanLyBanSach_new.DAO
{
    class ChiTietPhieuNhapDao
    {


        BookShopDbContext db;
        public ChiTietPhieuNhapDao()
        {
            db = new BookShopDbContext();
        }

        public int insertChiTietPhieuNhap(int idPhieuNhap, int idSach, int? soLuong)
        {
            var idPhieu = new SqlParameter("@idphieunhap", idPhieuNhap);
            var idsach = new SqlParameter("@idsach", idSach);
            var sl = new SqlParameter("@soluong", soLuong);
            int res = db.Database.ExecuteSqlCommand("proc_insertChiTietPhieuNhap @idphieunhap, @idsach, @soluong", idPhieu, idsach, sl);
            return res;
        }

        public List<Expense> allExpense()
        {
            var res = db.Database.SqlQuery<Expense>("proc_expense").ToList();
            return res;
        }

        public List<ExpenseDetails> ExpenseDetails(int id)
        {
            var i = new SqlParameter("@maphieunhap", id);
            var res = db.Database.SqlQuery<ExpenseDetails>("proc_expenseDetails @maphieunhap", i);
            return res.ToList();
        }

        public int purchasedBook()
        {
            //proc_purchasedBooks
            int sl = 0;
            var res = db.Database.SqlQuery<SoLuong>("proc_purchasedBooks").ToList();
            foreach (var item in res)
            {
                sl = item.soluong;
            }
            return sl;

        }


    }
}
