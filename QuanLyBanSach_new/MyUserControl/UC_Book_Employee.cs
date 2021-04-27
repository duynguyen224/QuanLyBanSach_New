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
using QuanLyBanSach_new.Forms;
using QuanLyBanSach_new.SupportClass;

namespace QuanLyBanSach_new.MyUserControl
{
    public partial class UC_Book_Employee : UserControl
    {
        public UC_Book_Employee()
        {
            InitializeComponent();

            SachDao dao = new SachDao();
            dao.displayAllBook(dataGridViewBook);
        }

        public void clearAll()
        {
            comboBoxSearchBy.SelectedIndex = -1;
            textBoxSearch.Text = "";
        }
        private void btnAddNewBooks_Click(object sender, EventArgs e)
        {
            using(Form_AddNewBook anb = new Form_AddNewBook())
            {
                anb.ShowDialog();
            }
        }

        private void UC_Book_Employee_Load(object sender, EventArgs e)
        {
            SachDao dao = new SachDao();
            dao.displayAllBook(dataGridViewBook);
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            var bookTitle = "Book Title";
            var auth = "Author";
            var pub = "Publisher";
            var cat = "Category";

            if (comboBoxSearchBy.Text.Trim().ToLower() == bookTitle.Trim().ToLower())
            {
                SachDao dao = new SachDao();
                var res = dao.searchByBookTitle(textBoxSearch.Text);
                dataGridViewBook.DataSource = res;
            }
            else if(comboBoxSearchBy.Text.Trim().ToLower() == auth.Trim().ToLower())
            {
                SachDao dao = new SachDao();
                var res = dao.searchByAuthor(textBoxSearch.Text);
                dataGridViewBook.DataSource = res;
            }
            else if (comboBoxSearchBy.Text.Trim().ToLower() == pub.Trim().ToLower())
            {
                SachDao dao = new SachDao();
                var res = dao.searchByPublisher(textBoxSearch.Text);
                dataGridViewBook.DataSource = res;
            }
            else if (comboBoxSearchBy.Text.Trim().ToLower() == cat.Trim().ToLower())
            {
                SachDao dao = new SachDao();
                var res = dao.searchByCategory(textBoxSearch.Text);
                dataGridViewBook.DataSource = res;
            }

        }
    }
}
