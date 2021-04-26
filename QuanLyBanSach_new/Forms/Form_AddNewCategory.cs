using QuanLyBanSach_new.DAO;
using QuanLyBanSach_new.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyBanSach_new.Forms
{
    public partial class Form_AddNewCategory : Form
    {
        public Form_AddNewCategory()
        {
            InitializeComponent();
        }

        public void clearAll()
        {
            textBoxCategoryName.Text = "";
        }
        private void buttonClear_Click(object sender, EventArgs e)
        {
            clearAll();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            var category = new ChuDe()
            {
                TenCD = textBoxCategoryName.Text
            };

            ChuDeDao dao = new ChuDeDao();
            var res = dao.insertCategory(category.TenCD);
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
