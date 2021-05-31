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
        public int idPhieuNhap;
        public string tieude;
        public int tongtien;
        public List<int> falseStatus = new List<int>();
        public UC_Expense_Employee()
        {
            InitializeComponent();
            // bind data to gridview
            populateGridViewLeft();
            populateGridViewRight();
            markFalseStatus(dataGridViewExpense);
        }

        public void markFalseStatus(DataGridView d) // red background
        {
            ChiTietPhieuNhapDao dao = new ChiTietPhieuNhapDao();
            var res = dao.allExpenseWithStatus();
            foreach(var item in res)
            {
                if(item.TrangThai == false)
                {
                    falseStatus.Add(item.ID);
                }
            }

            foreach(DataGridViewRow row in d.Rows)
            {
                foreach(var i in falseStatus)
                {
                    if(i == Convert.ToInt32(row.Cells[0].Value))
                    {
                        row.DefaultCellStyle.BackColor = Color.Red;
                    }
                }
            }
        }
        public void populateGridViewLeft()
        {
            ChiTietPhieuNhapDao dao = new ChiTietPhieuNhapDao();
            var res = dao.allExpense();
            dataGridViewExpense.DataSource = res;
        }

        public void populateGridViewRight(int id = 0)
        {
            if (id == 0)
            {
                dataGridViewDetails.DataSource = null;

            }
            else
            {
                ChiTietPhieuNhapDao dao = new ChiTietPhieuNhapDao();
                var res = dao.ExpenseDetails(id);
                dataGridViewDetails.DataSource = res;

            }
        }

        private void btnAddNewBooks_Click(object sender, EventArgs e)
        {
            markFalseStatus(dataGridViewExpense);
            using (Form_AddNewExpense ane = new Form_AddNewExpense())
            {
                ane.ShowDialog();
            }
        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            populateGridViewLeft();
            populateGridViewRight();
            markFalseStatus(dataGridViewExpense);
        }

        private void dataGridViewExpense_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            idPhieuNhap = int.Parse(dataGridViewExpense.SelectedRows[0].Cells[0].Value.ToString());
            populateGridViewRight(idPhieuNhap);
            tieude = dataGridViewExpense.SelectedRows[0].Cells[1].Value.ToString();
            tongtien = int.Parse(dataGridViewExpense.SelectedRows[0].Cells[2].Value.ToString());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            bool check = false;
            foreach(var item in falseStatus)
            {
                if (idPhieuNhap == item)
                    check = true;
            }
            if (check == true)
            {
                var tenPhieuNhap = "";
                var time = DateTime.Now.ToString();
                PhieuNhapDao dao = new PhieuNhapDao();
                PhieuNhap pn = new PhieuNhap();
                pn.TieuDe = tieude;
                tenPhieuNhap = pn.TieuDe;

                pn.TongTien = tongtien;
                //var idPhieuNhap = dao.getIdPhieuNhap_fromName(tenPhieuNhap);

                this.Hide();
                //Form_Update_AddNew f_uq = new Form_Update_AddNew(idPhieuNhap);
                Form_UpdateQty_AddNewBook f_uq = new Form_UpdateQty_AddNewBook(idPhieuNhap, pn.TieuDe, pn.TongTien.GetValueOrDefault());
                f_uq.ShowDialog();
            }
            else {
                MessageBox.Show("Phiếu nhập đã hoàn thành, không thể sửa !");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            bool check = false;
            foreach (var item in falseStatus)
            {
                if (idPhieuNhap == item)
                    check = true;
            }
            if (check == true)
            {
                if (MessageBox.Show("Xóa phiếu nhập ??", "Xóa phiếu nhập", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    // xoa phieu nhap
                    PhieuNhapDao dao = new PhieuNhapDao();
                    var res = dao.deletePhieuNhap(idPhieuNhap);
                    if(res > 0)
                    {
                        MessageBox.Show("Đã xóa phiếu nhập !");
                        populateGridViewLeft();
                    }
                    else
                    {
                        MessageBox.Show("Xóa không thành công !");
                    }
                }

            }
            else
            {
                MessageBox.Show("Phiếu nhập đã hoàn thành, không thể xóa !");
            }

        }
    }
}
