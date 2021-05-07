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

        public Form_UpdateQty_AddNewBook(int _idPhieuNhap)
        {
            InitializeComponent();
            idPhieuNhap = _idPhieuNhap;
            fillCombobox();
            clearAllNewBook();
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


            if (res > 0 && ress > 0 && resss > 0)
            {
                MessageBox.Show("Thêm thành công !");
                clearAllNewBook();
            }
            else
            {
                MessageBox.Show("Chưa thêm được !");
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





            if ( resss > 0)
            {
                MessageBox.Show("Update số lượng thành công !");
                clearAllUpdateQuantity();
            }
            else
            {
                MessageBox.Show("Chưa update được !");
            }

        }
    }
}
