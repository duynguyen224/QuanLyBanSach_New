using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using QuanLyBanSach_new.Entities;
using QuanLyBanSach_new.DAO;

namespace QuanLyBanSach_new.Forms
{
    public partial class Form_UpdateQuantity_AddNewBook : Form
    {
        public int idPhieuNhap;
        public Form_UpdateQuantity_AddNewBook(int _idPhieuNhap)
        {
            InitializeComponent();
            idPhieuNhap = _idPhieuNhap;
            label3.Text = idPhieuNhap.ToString();
        }

        public void clearAll()
        {
            textBoxSearchBook.Text = "";
            comboBoxBookTitle.SelectedIndex = -1;
            textBoxAuthor.Text = "";
            textBoxPublisher.Text = "";
            textBoxStock.Text = "";
            textBoxPrice.Text = "";
            textBoxQuantity.Text = "";
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

        private void comboBoxBookTitle_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // update lại số lượng tồn
            SachDao dao = new SachDao();
            var i = dao.getIdBookByName(comboBoxBookTitle.Text);
            var sl = int.Parse(textBoxQuantity.Text);
            dao.updateQuantity(i, sl);
            MessageBox.Show("Update số lượng thành công !");
            clearAll();
            
        }
    }
}
