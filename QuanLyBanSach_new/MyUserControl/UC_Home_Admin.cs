using QuanLyBanSach_new.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyBanSach_new.MyUserControl
{
    public partial class UC_Home_Admin : UserControl
    {
        public UC_Home_Admin()
        {
            InitializeComponent();
        }

        private void bunifuDataViz1_Load(object sender, EventArgs e)
        {
            button1_Click(null, null);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            displayChart();
        }

        public void displayChart()
        {
            var cnv = new Bunifu.DataViz.Canvas();
            var dataPoint = new Bunifu.DataViz.DataPoint(Bunifu.DataViz.BunifuDataViz._type.Bunifu_splineArea);
            DonHangDao dao = new DonHangDao();

            int jan = dao.month_amount(1);
            int feb = dao.month_amount(2);
            int mar = dao.month_amount(3);
            int apr = dao.month_amount(4);
            int may = dao.month_amount(5);
            int jun = dao.month_amount(6);
            int jul = dao.month_amount(7);
            int aug = dao.month_amount(8);
            int sep = dao.month_amount(9);
            int oct = dao.month_amount(10);
            int nov = dao.month_amount(11);
            int dec = dao.month_amount(12);

            dataPoint.addLabely("Jan", jan.ToString());
            dataPoint.addLabely("Feb", feb.ToString());
            dataPoint.addLabely("Mar", mar.ToString());
            dataPoint.addLabely("Apr", apr.ToString());
            dataPoint.addLabely("May", may.ToString());
            dataPoint.addLabely("Jun", jun.ToString());
            dataPoint.addLabely("Jul", jul.ToString());
            dataPoint.addLabely("Aug", aug.ToString());
            dataPoint.addLabely("Sep", sep.ToString());
            dataPoint.addLabely("Oct", oct.ToString());
            dataPoint.addLabely("Nov", nov.ToString());
            dataPoint.addLabely("Dec", dec.ToString());

            cnv.addData(dataPoint);
            bunifuDataViz1.colorSet.Add(Color.Red);
            bunifuDataViz1.Render(cnv);
        }

        private void UC_Home_Admin_Load(object sender, EventArgs e)
        {
            ChiTietDonHangDao dao = new ChiTietDonHangDao();
            labelSoldBooks.Text = dao.allBookSold().ToString();

            ChiTietPhieuNhapDao cDao = new ChiTietPhieuNhapDao();
            labelPurchasedBook.Text = cDao.purchasedBook().ToString();

            KhachHangDao khDao = new KhachHangDao();
            labelCustomer.Text = khDao.countCustomer().ToString();
        }
    }
}
