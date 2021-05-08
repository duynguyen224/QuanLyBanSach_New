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

        }

        Random rand = new Random();
        private void button1_Click(object sender, EventArgs e)
        {
            var cnv = new Bunifu.DataViz.Canvas();
            var dataPoint = new Bunifu.DataViz.DataPoint(Bunifu.DataViz.BunifuDataViz._type.Bunifu_splineArea);

            dataPoint.addLabely("Jan", rand.Next(0, 500).ToString());
            dataPoint.addLabely("Feb", rand.Next(0, 500).ToString());
            dataPoint.addLabely("Mar", rand.Next(0, 500).ToString());
            dataPoint.addLabely("Apr", rand.Next(0, 500).ToString());
            dataPoint.addLabely("Jun", rand.Next(0, 500).ToString());
            dataPoint.addLabely("Jul", rand.Next(0, 500).ToString());
            dataPoint.addLabely("Aug", rand.Next(0, 500).ToString());
            dataPoint.addLabely("Sep", rand.Next(0, 500).ToString());
            dataPoint.addLabely("Oct", rand.Next(0, 500).ToString());

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
        }
    }
}
