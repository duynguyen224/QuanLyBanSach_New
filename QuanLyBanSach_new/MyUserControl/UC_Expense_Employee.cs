using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using QuanLyBanSach_new.Forms;
using QuanLyBanSach_new.SupportClass;
using QuanLyBanSach_new.Entities;
using QuanLyBanSach_new.DAO;

namespace QuanLyBanSach_new.MyUserControl
{
    public partial class UC_Expense_Employee : UserControl
    {
        public UC_Expense_Employee()
        {
            InitializeComponent();

            // bind data to gridview
            populateGridView();
        }

        public void populateGridView()
        {
            ChiTietPhieuNhapDao dao = new ChiTietPhieuNhapDao();
            var res = dao.PhieuNhap_ChiTiet();
            dataGridViewExpense.DataSource = res;
        }

        private void btnAddNewBooks_Click(object sender, EventArgs e)
        {
            using(Form_AddNewExpense ane = new Form_AddNewExpense())
            {
                ane.ShowDialog();
            }
        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            populateGridView();

        }
    }
}
