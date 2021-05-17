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
                buttonSearchCustomer_Click(null, null);
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
            if(textBoxCustomerID.Text == "" || textBoxCustomerID.Text == null)
            {
                MessageBox.Show("Hãy nhập thông tin khách hàng !");
            }
            else
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
                foreach (var item in dao.listGioHang())
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

                    // Update lại số lượng tồn của Sach
                    sachDao.updateStock(ctdh.MaSach, (int)ctdh.SoLuong);
                }
                // Clear all
                clearAll();


                // Xóa hết bảng GioHang
                dao.deleteAllCartRecord();
                MessageBox.Show("Thành công !");

            }
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
            //var netAmount = int.Parse(textBoxNetAmount.Text);
            //var discount = int.Parse(textBoxDiscount.Text);
            //var total = netAmount - netAmount * discount / 100;
            //textBoxTotalAmount.Text = total.ToString();

            //var total1 = int.Parse(textBoxTotalAmount.Text);
            //var refund = int.Parse(textBoxPaidAmount.Text) - total1;
            //labelRefundAmount.Text = refund.ToString();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            var isNumericDiscount = int.TryParse(textBoxDiscount.Text, out _);
            var isNumericPaid = int.TryParse(textBoxPaidAmount.Text, out _);
            var total = 0;
            if (isNumericDiscount == true && isNumericPaid == true) // kiem tra alphabet 
            {
                var netAmount = int.Parse(textBoxNetAmount.Text);
                var discount = int.Parse(textBoxDiscount.Text);
                if (discount >= 0 && discount <= 100) // discount (0,100)
                {
                    total = netAmount - netAmount * discount / 100;
                    textBoxTotalAmount.Text = total.ToString();

                    var total1 = int.Parse(textBoxTotalAmount.Text);
                    var refund = int.Parse(textBoxPaidAmount.Text) - total1;
                    if(refund < 0)
                    {
                        MessageBox.Show("Số tiền trả chưa đủ !");
                    }
                    else
                    {
                        labelRefundAmount.Text = refund.ToString();
                    }

                }
                else
                {
                    MessageBox.Show("Discount nằm trong khoảng 0-100%");
                }

            }
            else
            {
                MessageBox.Show("Hãy kiểm tra lại Discount hoặc Paid amount !");
            }

        }
    }
}
