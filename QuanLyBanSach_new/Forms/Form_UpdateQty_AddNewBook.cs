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
using QuanLyBanSach_new.MyUserControl;

namespace QuanLyBanSach_new.Forms
{

    public partial class Form_UpdateQty_AddNewBook : Form
    {
        public int idPhieuNhap;

        public Form_UpdateQty_AddNewBook(int _idPhieuNhap, string title, int tongtien)
        {
            InitializeComponent();
            idPhieuNhap = _idPhieuNhap;
            fillCombobox();
            clearAllNewBook();
            bindDataToGrid(dataGridView1, dataGridView2);
            labelnhaphang.Text = title;
            labelnhaphang1.Text = title;
            labelAmount1.Text = tongtien.ToString() ;
            labelAmount2.Text = tongtien.ToString() ;
        }


        private void bindDataToGrid(DataGridView d1, DataGridView d2)
        {
            ChiTietPhieuNhapDao dao = new ChiTietPhieuNhapDao();
            var res = dao.ExpenseDetails(idPhieuNhap);
            d1.DataSource = res;
            d2.DataSource = res;
        }
        public void fillCombobox()
        {
            TacGiaDao daotacgia = new TacGiaDao();
            daotacgia.populateAuthor(comboBoxAuthor);
            ChuDeDao daochude = new ChuDeDao();
            daochude.populateCategory(comboBoxCategory);
            NhaXuatBanDao daonxb = new NhaXuatBanDao();
            daonxb.populatePublisher(comboBoxPublisher);

        }

        public void clearAllNewBookExceptTitle()
        {
            comboBoxAuthor.SelectedIndex = -1;
            textBoxAuthorID.Text = "";
            comboBoxPublisher.SelectedIndex = -1;
            textBoxPublisherID.Text = "";
            comboBoxCategory.SelectedIndex = -1;
            textBoxCategoryID.Text = "";
            textBoxPrice.Text = "";
            textBoxQuantity.Text = "";
            richTextBox.Text = "";
            textBoxBookID.Text = "";

        }


        public void clearAllNewBook()
        {
            textBoxBookTitle.Text = "";
            comboBoxAuthor.SelectedIndex = -1;
            textBoxAuthorID.Text = "";
            comboBoxPublisher.SelectedIndex = -1;
            textBoxPublisherID.Text = "";
            comboBoxCategory.SelectedIndex = -1;
            textBoxCategoryID.Text = "";
            textBoxPrice.Text = "";
            textBoxQuantity.Text = "";
            richTextBox.Text = "";
            textBoxBookID.Text = "";
        }

        private void clearAllUpdateQuantity()
        {
            textBoxSearchBookuq.Text = "";
            comboBoxBookTitleuq.SelectedIndex = -1;
            textBoxAuthoruq.Text = "";
            textBoxPublisheruq.Text = "";
            textBoxStockuq.Text = "";
            textBoxPriceuq.Text = "";
            textBoxQuantityuq.Text = "";
            textBoxIDuq.Text = "";
        }
        private void buttonClear_Click(object sender, EventArgs e)
        {
            clearAllNewBook();
        }

        private void buttonAddNewAuthor_Click(object sender, EventArgs e)
        {
            using (Form_AddNewAuthor f = new Form_AddNewAuthor())
            {
                f.ShowDialog();
                fillCombobox();
                clearAllNewBookExceptTitle();
            }

        }

        private void buttonAddNewPublisher_Click(object sender, EventArgs e)
        {
            using (Form_AddNewPublisher f = new Form_AddNewPublisher())
            {
                f.ShowDialog();
                fillCombobox();
                clearAllNewBookExceptTitle();

            }

        }

        private void buttonNewCategory_Click(object sender, EventArgs e)
        {
            using (Form_AddNewCategory f = new Form_AddNewCategory())
            {
                f.ShowDialog();
                fillCombobox();
                clearAllNewBookExceptTitle();

            }

        }

        private void comboBoxAuthor_SelectedValueChanged(object sender, EventArgs e)
        {
            string name = comboBoxAuthor.Text;
            TacGiaDao dao = new TacGiaDao();
            var res = dao.getIdAuthor(name);
            textBoxAuthorID.Text = res;

        }

        private void comboBoxPublisher_SelectedValueChanged(object sender, EventArgs e)
        {
            string name = comboBoxPublisher.Text;
            NhaXuatBanDao dao = new NhaXuatBanDao();
            var res = dao.getIdPublisher(name);
            textBoxPublisherID.Text = res;

        }

        private void comboBoxCategory_SelectedValueChanged(object sender, EventArgs e)
        {
            string name = comboBoxCategory.Text;
            ChuDeDao dao = new ChuDeDao();
            var res = dao.getIdCategory(name);
            textBoxCategoryID.Text = res;

        }

        private void buttonSave_Click(object sender, EventArgs e)
        {

            if (textBoxBookTitle.Text == "" || comboBoxAuthor.Text == "" || comboBoxCategory.Text == "" || comboBoxPublisher.Text == "" || textBoxPrice.Text == "" || textBoxQuantity.Text == "")
            {
                MessageBox.Show("Hãy nhập đủ thông tin !");
            }
            else if (int.TryParse(textBoxPrice.Text, out _) == false)


            {
                MessageBox.Show("Dữ liệu cho Price cần là số ! !");
                textBoxPrice.Text = "";
            }else if(int.TryParse(textBoxQuantity.Text, out _) == false)
            {
                MessageBox.Show("Dữ liệu cho Quantity cần là số !");
                textBoxQuantity.Text = "";
            }
            else
            {
                SachDao dao = new SachDao();
                var book = new Sach()
                {
                    TenSach = textBoxBookTitle.Text,
                    GiaBan = int.Parse(textBoxPrice.Text),
                    SoLuongTon = int.Parse(textBoxQuantity.Text),
                    MaNXB = int.Parse(textBoxPublisherID.Text),
                    MaCD = int.Parse(textBoxCategoryID.Text)
                };
                var res = dao.insertBook(book.TenSach, book.GiaBan, book.SoLuongTon, book.MaNXB, book.MaCD);

                textBoxBookID.Text = dao.getIdBookByName(book.TenSach).ToString();
                // return về cái BookID and AuthorID de tao ThamGia
                ThamGiaDao tgd = new ThamGiaDao();
                var ress = tgd.insertThamGia(int.Parse(textBoxBookID.Text), int.Parse(textBoxAuthorID.Text));


                // Bây giờ tạo thêm ChiTietPhieuNhap
                ChiTietPhieuNhapDao ctpnDao = new ChiTietPhieuNhapDao();
                ChiTietPhieuNhap ctpn = new ChiTietPhieuNhap()
                {
                    MaPhieuNhap = idPhieuNhap,
                    MaSach = int.Parse(textBoxBookID.Text),
                    SoLuong = int.Parse(textBoxQuantity.Text)
                };
                var resss = ctpnDao.insertChiTietPhieuNhap(ctpn.MaPhieuNhap, ctpn.MaSach, ctpn.SoLuong);


                bindDataToGrid(dataGridView1, dataGridView2);

                // update tong tien
                SachDao sDao = new SachDao();
                var bookPrice1 = sDao.getPriceById(ctpn.MaSach);
                var soluong1 = ctpn.SoLuong;
                PhieuNhapDao pnDao = new PhieuNhapDao();
                pnDao.updateAmount(idPhieuNhap, (bookPrice1 * soluong1).GetValueOrDefault());


                labelAmount1.Text = pnDao.getAmountById(idPhieuNhap).ToString();
                labelAmount2.Text = pnDao.getAmountById(idPhieuNhap).ToString();

            }
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            SachDao dao = new SachDao();
            var res = dao.sellBookSearchToCombobox(textBoxSearchBookuq.Text);
            comboBoxBookTitleuq.DataSource = res;
            comboBoxBookTitleuq.DisplayMember = "TenSach";

        }

        private void comboBoxBookTitleuq_SelectedValueChanged(object sender, EventArgs e)
        {
            string booktitle = "";
            textBoxSearchBookuq.Text = "";

            SachDao dao = new SachDao();
            var res = dao.bindDataFromTextBoxSearchToOthers(comboBoxBookTitleuq.Text);
            foreach (var item in res)
            {
                textBoxAuthoruq.Text = item.HoTenTG;
                textBoxPublisheruq.Text = item.TenNXB;
                textBoxStockuq.Text = item.SoLuongTon.ToString();
                textBoxPriceuq.Text = item.GiaBan.ToString();
                booktitle = comboBoxBookTitleuq.Text;
                textBoxIDuq.Text = dao.getIdBookByName(booktitle).ToString();

            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBoxBookTitleuq.Text == "" || textBoxQuantityuq.Text == "")
            {
                MessageBox.Show("Hãy nhập đủ thông tin !");
            }
            var qty = int.TryParse(textBoxQuantityuq.Text, out _);
            if (qty == false)
            {
                MessageBox.Show("Kiểm tra số lượng nhập !");
            }
            else
            {
                // Bây giờ tạo thêm ChiTietPhieuNhap
                ChiTietPhieuNhapDao ctpnDao = new ChiTietPhieuNhapDao();
                ChiTietPhieuNhap ctpn = new ChiTietPhieuNhap()
                {
                    MaPhieuNhap = idPhieuNhap,
                    MaSach = int.Parse(textBoxIDuq.Text),
                    SoLuong = int.Parse(textBoxQuantityuq.Text)
                };
                var resss = ctpnDao.insertChiTietPhieuNhap(ctpn.MaPhieuNhap, ctpn.MaSach, ctpn.SoLuong);


                // update lại số lượng tồn
                SachDao sDao = new SachDao();
                sDao.updateQuantity(ctpn.MaSach, ctpn.SoLuong);






                bindDataToGrid(dataGridView1, dataGridView2);

                // update tong tien
                var bookPrice = sDao.getPriceById(ctpn.MaSach);
                var soluong = ctpn.SoLuong;
                PhieuNhapDao pnDao = new PhieuNhapDao();
                pnDao.updateAmount(idPhieuNhap, (bookPrice * soluong).GetValueOrDefault());

                labelAmount1.Text = pnDao.getAmountById(idPhieuNhap).ToString();
                labelAmount2.Text = pnDao.getAmountById(idPhieuNhap).ToString();

                clearAllUpdateQuantity();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Đã hoàn thành việc nhập và thoát phiên làm việc ? ", "Exit ", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Close();

            }

        }
    }
}
