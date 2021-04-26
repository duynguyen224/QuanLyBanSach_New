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
    public partial class Form_AddNewPublisher : Form
    {
        public Form_AddNewPublisher()
        {
            InitializeComponent();
        }
        private void clearAll()
        {
            textBoxPublisherName.Text = "";
            textBoxPublisherAddress.Text = "";
            textBoxPublisherPhone.Text = "";
        }


        private void buttonClear_Click(object sender, EventArgs e)
        {
            clearAll();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            var publisher = new NhaXuatBan()
            {
                TenNXB = textBoxPublisherName.Text,
                DiaChi = textBoxPublisherAddress.Text,
                DienThoai = textBoxPublisherPhone.Text,
            };

            NhaXuatBanDao dao = new NhaXuatBanDao();
            var res = dao.insertPublisher(publisher.TenNXB, publisher.DiaChi, publisher.DienThoai);
            if (res > 0)
            {
                MessageBox.Show("Thêm thành công !");
                clearAll();
            }
            else
            {
                MessageBox.Show("Chưa thêm được !");
            }
        }
    }
}
