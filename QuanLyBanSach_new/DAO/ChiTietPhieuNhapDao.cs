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

        public List<PhieuNhap_ChiTiet> PhieuNhap_ChiTiet()
        {
            var res = db.Database.SqlQuery<PhieuNhap_ChiTiet>("proc_gridExpense").ToList();
            return res;
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
