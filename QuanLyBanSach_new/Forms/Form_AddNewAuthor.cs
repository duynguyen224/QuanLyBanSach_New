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
    public partial class Form_AddNewAuthor : Form
    {
        public Form_AddNewAuthor()
        {
            InitializeComponent();
        }

        private void clearAll()
        {
            textBoxAuthorName.Text = "";
            textBoxAuthorAddress.Text = "";
            textBoxAuthorPhone.Text = "";
            textBoxAuthorBackground.Text = "";
        }
        private void buttonClear_Click(object sender, EventArgs e)
        {
            clearAll();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            var author = new TacGia()
            {
                HoTenTG = textBoxAuthorName.Text,
                DiaChi = textBoxAuthorAddress.Text,
                DienThoai = textBoxAuthorPhone.Text,
                TieuSu = textBoxAuthorBackground.Text
            };

            TacGiaDao dao = new TacGiaDao();
            var res = dao.insertAuthor(author.HoTenTG, author.DiaChi, author.TieuSu, author.DienThoai);
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
