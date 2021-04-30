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
using QuanLyBanSach_new.SupportClass;

namespace QuanLyBanSach_new.Forms
{
    public partial class Form_Finish_Order : Form
    {
        public Form_Finish_Order()
        {
            InitializeComponent();
        }

        public void clearAll()
        {
            textBoxNetAmount.Text = "";
            textBoxDiscount.Text = "";
            textBoxTotalAmount.Text = "";
            textBoxPaidAmount.Text = "";
            labelRefundAmount.Text = "";
            textBoxSearchCustomer.Text = "";
            comboBoxCustomerName.SelectedIndex = -1;
            textBoxCustomerID.Text = "";
        }
        private void Form_Finish_Order_Load(object sender, EventArgs e)
        {
            // Tính tổng tiền bằng Foreach() từ bảng GioHang
            GioHangDao dao = new GioHangDao();
            textBoxNetAmount.Text = dao.netAmount().ToString();
        }

        private void buttonAddNewCustomer_Click(object sender, EventArgs e)
        {
            using (Form_AddNewCustomer f = new Form_AddNewCustomer())
            {
                f.ShowDialog();
            }
        }

        private void buttonSearchCustomer_Click(object sender, EventArgs e)
        {
            KhachHangDao dao = new KhachHangDao();
            comboBoxCustomerName.DataSource = dao.bindNameCustomerToCombobox(textBoxSearchCustomer.Text);
            comboBoxCustomerName.DisplayMember = "HoTen";
        }

        private void comboBoxCustomerName_SelectedValueChanged(object sender, EventArgs e)
        {
            KhachHangDao dao = new KhachHangDao();
            textBoxCustomerID.Text = dao.getIdFromCustomerName(comboBoxCustomerName.Text).ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GioHangDao dao = new GioHangDao();
            // thêm id khách hàng vào trong bảng GioHang
            dao.addIdCustomerToAllRecord(int.Parse(textBoxCustomerID.Text));

            // Tạo Record trong bảng DonHang
            DonHang d = new DonHang();
            d.MaKH = int.Parse(dao.getIdCustomer());
            d.TongTien = dao.netAmount();
            DonHangDao donhangDao = new DonHangDao();
            var idDonHang = donhangDao.insertDonHang(d);

            // Tạo Record trong bảng ChiTietDonHang
            foreach(var item in dao.listGioHang())
            {
                var tensach = item.BookTitle;
                var soluong = item.Qty;
                var dongia = item.Price;
                SachDao sachDao = new SachDao();
                // Tạo 1 ChiTietDonHang và thêm các thuộc tính vào
                ChiTietDonHang ctdh = new ChiTietDonHang();
                ctdh.MaDH = int.Parse(idDonHang);
                ctdh.MaSach = sachDao.getIdBookByName(tensach);
                ctdh.SoLuong = soluong;
                ctdh.DonGia = dongia;

                // Insert record vào ChiTietDonHang
                ChiTietDonHangDao ctdhDao = new ChiTietDonHangDao();
                ctdhDao.insertChiTietDonHang(ctdh);

            }
            // Clear all
            clearAll();


            // Xóa hết bảng GioHang
            dao.deleteAllCartRecord();
            MessageBox.Show("Thành công !");
        }

        private void textBoxDiscount_TextChanged(object sender, EventArgs e)
        {
            //var netAmount = int.Parse(textBoxNetAmount.Text);
            //var discount = int.Parse(textBoxDiscount.Text);
            //var total = netAmount - netAmount * discount / 100;
            //textBoxTotalAmount.Text = total.ToString();
        }

        private void textBoxPaidAmount_TextChanged(object sender, EventArgs e)
        {
            //var total = int.Parse(textBoxTotalAmount.Text);
            //var refund = int.Parse(textBoxPaidAmount.Text) - total;
            //labelRefundAmount.Text = refund.ToString();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            var netAmount = int.Parse(textBoxNetAmount.Text);
            var discount = int.Parse(textBoxDiscount.Text);
            var total = netAmount - netAmount * discount / 100;
            textBoxTotalAmount.Text = total.ToString();

            var total1 = int.Parse(textBoxTotalAmount.Text);
            var refund = int.Parse(textBoxPaidAmount.Text) - total1;
            labelRefundAmount.Text = refund.ToString();

        }
    }
}
