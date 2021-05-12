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
using DGVPrinterHelper;

namespace QuanLyBanSach_new.MyUserControl
{
    public partial class UC_Book_Admin : UserControl
    {
        //s.TenSach, s.GiaBan, s.SoLuongTon, tg.HoTenTG, cd.TenCD, nxb.TenNXB
        public string tensach;
        public int giaban;
        public int soluongton;
        public string hotentg;
        public string tencd;
        public string tennxb;
        public int idSachSelected;
        public UC_Book_Admin()
        {
            InitializeComponent();

            SachDao dao = new SachDao();
            dao.displayAllBook(dataGridViewBook);

        }

        private void populateGrid()
        {
            SachDao dao = new SachDao();
            dao.displayAllBook(dataGridViewBook);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (Form_AddNewBook anb = new Form_AddNewBook())
            {
                anb.ShowDialog();
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (Form_EditBook_Admin f = new Form_EditBook_Admin(tensach, giaban, soluongton, hotentg, tencd, tennxb))
            {
                f.ShowDialog();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Xóa Sách ??", "Xóa Sách", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                SachDao dao = new SachDao();
                dao.deleteBook(idSachSelected);
                MessageBox.Show("Xóa thành công !");
                populateGrid();
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            var bookTitle = "Book Title";
            var auth = "Author";
            var pub = "Publisher";
            var cat = "Category";
            var st = "Qty = 0";

            if (comboBoxSearchBy.Text.Trim().ToLower() == bookTitle.Trim().ToLower())
            {
                SachDao dao = new SachDao();
                var res = dao.searchByBookTitle(textBoxSearch.Text);
                dataGridViewBook.DataSource = res;
            }
            else if (comboBoxSearchBy.Text.Trim().ToLower() == auth.Trim().ToLower())
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
            else if (comboBoxSearchBy.Text.Trim().ToLower() == st.Trim().ToLower())
            {
                SachDao dao = new SachDao();
                var res = dao.searchByStock();
                dataGridViewBook.DataSource = res;
            }

        }

        private void dataGridViewBook_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            tensach = dataGridViewBook.SelectedRows[0].Cells[0].Value.ToString();
            giaban = int.Parse(dataGridViewBook.SelectedRows[0].Cells[1].Value.ToString());
            soluongton = int.Parse(dataGridViewBook.SelectedRows[0].Cells[2].Value.ToString());
            hotentg = dataGridViewBook.SelectedRows[0].Cells[3].Value.ToString();
            tencd = dataGridViewBook.SelectedRows[0].Cells[4].Value.ToString();
            tennxb = dataGridViewBook.SelectedRows[0].Cells[5].Value.ToString();
            SachDao dao = new SachDao();
            idSachSelected = dao.getIdBookByName(tensach);
        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {
            DGVPrinter printer = new DGVPrinter();
            printer.Title = comboBoxSearchBy.Text + ": " + textBoxSearch.Text;
            printer.SubTitle = string.Format($"Date: {0}", DateTime.Now.Date);
            printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
            printer.PageNumbers = true;
            printer.PageNumberInHeader = false;
            printer.PorportionalColumns = true;
            printer.HeaderCellAlignment = StringAlignment.Near;
            printer.PrintDataGridView(dataGridViewBook);
           
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {

        }
    }
}
