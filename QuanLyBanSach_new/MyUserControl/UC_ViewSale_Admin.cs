using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


using QuanLyBanSach_new.DAO;
using QuanLyBanSach_new.Entities;

namespace QuanLyBanSach_new.MyUserControl
{

    public partial class UC_ViewSale_Admin : UserControl
    {
        public int idDonHang;
        public UC_ViewSale_Admin()
        {
            InitializeComponent();
            populateGridInfo();
            populateGridDetails(idDonHang);
        }

        public void populateGridInfo()
        {
            DonHangDao dao = new DonHangDao();

            dataGridViewDonHang.DataSource = dao.getInfo();
        }

        public void populateGridDetails(int idDonHang = 1)
        {
            if(idDonHang == 0)
            {
                dataGridViewChiTietDH.DataSource = null;

            }
            else
            {
                ChiTietDonHangDao dao = new ChiTietDonHangDao();
                dataGridViewChiTietDH.DataSource = dao.getDetails(idDonHang);

            }
        }

        private void dataGridViewDonHang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string a;
            a = dataGridViewDonHang.SelectedRows[0].Cells[0].Value.ToString();
            idDonHang = int.Parse(a);
            populateGridDetails(idDonHang);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            idDonHang = 0;
            populateGridDetails(idDonHang);

        }
    }
}
