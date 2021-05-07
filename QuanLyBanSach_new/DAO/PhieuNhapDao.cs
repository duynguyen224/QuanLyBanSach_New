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
    public class PhieuNhapDao
    {


        BookShopDbContext db;
        public PhieuNhapDao()
        {
            db = new BookShopDbContext();
        }

        public void insertPhieuNhap(PhieuNhap pn)
        {
            var tongtien = new SqlParameter("@tongtien", pn.TongTien);
            var tieude = new SqlParameter("@tieude", pn.TieuDe);
            var mota = new SqlParameter("@mota", pn.MoTa);
            db.Database.ExecuteSqlCommand("proc_insertPhieuNhap @tongtien, @tieude, @mota", tongtien, tieude, mota);
        }

        public int getIdPhieuNhap_fromName(string name)
        {
            var res = db.PhieuNhaps.Where(x => x.TieuDe.Trim().ToLower() == name.Trim().ToLower()).FirstOrDefault();
            return res.ID;

        }
    }
}
