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

namespace QuanLyBanSach_new.Forms
{
    public partial class Form_AddNewBook : Form
    {
        public Form_AddNewBook()
        {
            InitializeComponent();

            fillCombobox();
            clearAll();
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

        public void clearAll()
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

        public void clearAllExceptTitle()
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

        // them sach moi
        private void buttonSave_Click(object sender, EventArgs e)
        {
            SachDao dao = new SachDao();
            var book = new Sach()
            {
                TenSach = textBoxBookTitle.Text,
                GiaBan = int.Parse(textBoxPrice.Text),
                //SoLuongTon = int.Parse(textBoxQuantity.Text),
                SoLuongTon = 0,
                MaNXB = int.Parse(textBoxPublisherID.Text),
                MaCD = int.Parse(textBoxCategoryID.Text)
            };
            var res = dao.insertBook(book.TenSach, book.GiaBan, book.SoLuongTon, book.MaNXB, book.MaCD);

            textBoxBookID.Text = dao.getIdBookByName(book.TenSach).ToString();
            // return về cái BookID and AuthorID de tao ThamGia
            ThamGiaDao tgd = new ThamGiaDao();
            var ress = tgd.insertThamGia(int.Parse(textBoxBookID.Text), int.Parse(textBoxAuthorID.Text));


            if (res > 0 && ress > 0)
            {
                MessageBox.Show("Thêm thành công !");
                clearAll();
            }
            else
            {
                MessageBox.Show("Chưa thêm được !");
            }

        }

        private void Form_AddNewBook_Load(object sender, EventArgs e)
        {

            clearAll();
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            clearAll();
        }

        private void comboBoxAuthor_SelectedIndexChanged(object sender, EventArgs e)
        {

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

        private void buttonAddNewAuthor_Click(object sender, EventArgs e)
        {
            using(Form_AddNewAuthor f = new Form_AddNewAuthor())
            {
                f.ShowDialog();
                fillCombobox();
                clearAllExceptTitle();
            }
        }

        private void buttonAddNewPublisher_Click(object sender, EventArgs e)
        {
            using (Form_AddNewPublisher f = new Form_AddNewPublisher())
            {
                f.ShowDialog();
                fillCombobox();
                clearAllExceptTitle();

            }
        }

        private void buttonNewCategory_Click(object sender, EventArgs e)
        {
            using(Form_AddNewCategory f = new Form_AddNewCategory())
            {
                f.ShowDialog();
                fillCombobox();
                clearAllExceptTitle();

            }
        }

        private void comboBoxPublisher_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
