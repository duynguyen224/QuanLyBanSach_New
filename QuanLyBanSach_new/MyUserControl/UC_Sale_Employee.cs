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
using QuanLyBanSach_new.Forms;
using QuanLyBanSach_new.SupportClass;

namespace QuanLyBanSach_new.MyUserControl
{
    public partial class UC_Sale_Employee : UserControl
    {
        public UC_Sale_Employee()
        {
            InitializeComponent();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            dataGridViewCart.DataSource = null;
            using (Form_Finish_Order f = new Form_Finish_Order())
            {
                f.ShowDialog();
            }
        }


        private void clearAll()
        {
            textBoxSearchBook.Text = "";
            comboBoxBookTitle.SelectedIndex = -1;
            textBoxAuthor.Text = "";
            textBoxPublisher.Text = "";
            textBoxStock.Text = "";
            textBoxPrice.Text = "";
            textBoxQuantity.Text = "";
            labelTotalAmount.Text = "";

        }
        private void buttonSearch_Click(object sender, EventArgs e)
        {
            SachDao dao = new SachDao();
            var res = dao.sellBookSearchToCombobox(textBoxSearchBook.Text);
            comboBoxBookTitle.DataSource = res;
            comboBoxBookTitle.DisplayMember = "TenSach";
        }

        private void comboBoxBookTitle_SelectedValueChanged(object sender, EventArgs e)
        {
            textBoxSearchBook.Text = "";

            SachDao dao = new SachDao();
            var res = dao.bindDataFromTextBoxSearchToOthers(comboBoxBookTitle.Text);
            foreach (var item in res)
            {
                textBoxAuthor.Text = item.HoTenTG;
                textBoxPublisher.Text = item.TenNXB;
                textBoxStock.Text = item.SoLuongTon.ToString();
                textBoxPrice.Text = item.GiaBan.ToString();
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBoxBookTitle.Text == "" || comboBoxBookTitle.Text == null)
            {
                MessageBox.Show("Hãy chọn sách trước khi Add to cart !");
            }
            else if (int.Parse(textBoxQuantity.Text) < 0)
            {
                MessageBox.Show("Số lượng cần lớn hơn 0 !");
                textBoxQuantity.Text = "";
            }

            else
            {
                if (int.Parse(textBoxStock.Text) < int.Parse(textBoxQuantity.Text) )
                {
                    MessageBox.Show("Không đủ sách, chọn số lượng ít hơn !");
                    textBoxQuantity.Text = "";
                }
                else
                {
                    SachDao sDao = new SachDao();
                    // 1. insert to cart
                    GioHangDao dao = new GioHangDao();
                    if(dao.findBook(comboBoxBookTitle.Text) == 0)
                    {
                        var booktitle = comboBoxBookTitle.Text;
                        var qty = Int32.Parse(textBoxQuantity.Text);
                        var price = Int32.Parse(textBoxPrice.Text);
                        var amount = qty * price;
                        var stock = Int32.Parse(textBoxStock.Text);
                        dao.insertToCart(booktitle, qty, amount, price, stock);
                    }
                    else
                    {
                        dao.updateQuantity(comboBoxBookTitle.Text, int.Parse(textBoxQuantity.Text));
                    }

                    // bind data to GridView
                    dataGridViewCart.DataSource = dao.bindDataToGridCart();

                    //
                    clearAll();
                    // total amount
                    labelTotalAmount.Text = dao.totalAmount().ToString();
                }

            }
        }

        // Bấm Clear : xóa hết dữ liệu trong bảng GioHang đi
        // Xóa hết Textbox, xóa hết Record của bảng GioHang
        private void buttonClear_Click(object sender, EventArgs e)
        {
            clearAll();
            GioHangDao dao = new GioHangDao();
            dao.deleteAllCartRecord();
            dataGridViewCart.DataSource = dao.bindDataToGridCart();
        }

        Cart c = new Cart();



        private void dataGridViewCart_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            c.BookTitle = dataGridViewCart.SelectedRows[0].Cells[0].Value.ToString();
            c.Qty = int.Parse(dataGridViewCart.SelectedRows[0].Cells[1].Value.ToString());
            c.Amount = int.Parse(dataGridViewCart.SelectedRows[0].Cells[2].Value.ToString());

        }


        // Bấm Delete : delete 1 record trong GioHang đi (dựa vào BookTitle)
        // rồi gọi DataSource lại là oke

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (c.BookTitle == null || c.BookTitle == "" || c == null)
            {
                MessageBox.Show("Hãy chọn 1 sản phẩm cần xóa !");
            }
            else
            {
                GioHangDao dao = new GioHangDao();
                var res = dao.deleteOneRecord(c.BookTitle, c.Qty);
                if(res == 0)
                {
                    MessageBox.Show("Hãy chọn 1 sản phẩm cần xóa !");

                }
                dataGridViewCart.DataSource = dao.bindDataToGridCart();

                labelTotalAmount.Text = dao.totalAmount().ToString();

            }
        }

        private void comboBoxBookTitle_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void UC_Sale_Employee_Load(object sender, EventArgs e)
        {
            GioHangDao dao = new GioHangDao();
            dataGridViewCart.DataSource = dao.bindDataToGridCart();
            labelTotalAmount.Text = dao.totalAmount().ToString();
        }

        private void button2_Click(object sender, EventArgs e) // tru
        {
            if (c.BookTitle == null || c.BookTitle == "" || c == null)
            {
                MessageBox.Show("Hãy chọn 1 sản phẩm !");
            }
            else
            {
                GioHangDao dao = new GioHangDao();
                dao.reduceQuantity(c.BookTitle, 1);

                dataGridViewCart.DataSource = dao.bindDataToGridCart();

                labelTotalAmount.Text = dao.totalAmount().ToString();

            }

        }

        private void button3_Click(object sender, EventArgs e) // cong
        {
            if (c.BookTitle == null || c.BookTitle == "" || c == null)
            {
                MessageBox.Show("Hãy chọn 1 sản phẩm !");
            }
            else
            {
                GioHangDao dao = new GioHangDao();
                dao.updateQuantity(c.BookTitle, 1);

                dataGridViewCart.DataSource = dao.bindDataToGridCart();

                labelTotalAmount.Text = dao.totalAmount().ToString();

            }

        }

    }
}
