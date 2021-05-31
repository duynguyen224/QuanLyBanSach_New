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
            var trangthai = new SqlParameter("@trangthai", pn.TrangThai);
            db.Database.ExecuteSqlCommand("proc_insertPhieuNhap @tongtien, @tieude, @mota, @trangthai", tongtien, tieude, mota, trangthai);
        }

        public int deletePhieuNhap(int id)
        {
            var res = db.PhieuNhaps.Where(x => x.ID == id).FirstOrDefault();
            if (res != null)
            {
                db.PhieuNhaps.Remove(res);
                db.SaveChanges();
                return 1;
            }
            else return 0;
        }

        public int getIdPhieuNhap_fromName(string name)
        {
            var res = db.PhieuNhaps.Where(x => x.TieuDe.Trim().ToLower() == name.Trim().ToLower()).FirstOrDefault();
            return res.ID;

        }

        public int getNewestId()
        {
            var list = db.Database.SqlQuery<IdOnly>("proc_listID_PhieuNhap").ToList();
            var res = list.Max(x => x.ID);
            return res;
        }

        public void updateAmount(int id, int soTien)
        {
            var res = db.PhieuNhaps.Where(x => x.ID == id).FirstOrDefault();
            res.TongTien += soTien;
            db.SaveChanges();
        }

        public int getAmountById(int id)
        {
            return db.PhieuNhaps.Where(x => x.ID == id).FirstOrDefault().TongTien.GetValueOrDefault();
        }

        public void updateStatusTrue(int id)
        {
            var res = db.PhieuNhaps.Where(x => x.ID == id).FirstOrDefault();
            res.TrangThai = true;
            db.SaveChanges();
        }
    }
}
