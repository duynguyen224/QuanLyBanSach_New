using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using QuanLyBanSach_new.Entities;
using QuanLyBanSach_new.SupportClass;


namespace QuanLyBanSach_new.DAO
{
    public class DonHangDao
    {
        BookShopDbContext db;
        public DonHangDao()
        {
            db = new BookShopDbContext();
        }

        public string insertDonHang(DonHang dh)
        {
            dh.DaThanhToan = true;
            dh.TinhTrangGiaoHang = true;
            dh.NgayDat = DateTime.Now;
            dh.NgayGiao = DateTime.Now;
            db.DonHangs.Add(dh);
            db.SaveChanges();
            return dh.ID.ToString();
        }
        
        // lay thong tin KhachHang va DonHang
        public IList<DonHang_KhachHang> getInfo()
        {
            var res = db.Database.SqlQuery<DonHang_KhachHang>("proc_info");
            return res.ToList();
        } 

        public int month_amount(int month)
        {
            // Tính tổng tiền thu dược của tháng
            int tongTien = 0;
            var m = new SqlParameter("@month", month);
            var res = db.Database.SqlQuery<SoLuong>("proc_monthAmount @month", m).ToList();
            if(res == null)
            {
                return 0;
            }
            else
            {
                foreach (var item in res)
                {
                    tongTien += item.soluong;
                }
                return tongTien;

            }
        }
    }
}
