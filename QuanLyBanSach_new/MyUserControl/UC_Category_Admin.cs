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
using QuanLyBanSach_new.SupportClass;

namespace QuanLyBanSach_new.MyUserControl
{
    public partial class UC_Category_Admin : UserControl
    {
        public UC_Category_Admin()
        {
            InitializeComponent();
            bindDataToGrid();

        }

        private void bindDataToGrid()
        {
            ChuDeDao dao = new ChuDeDao();
            dataGridViewCategory.DataSource = dao.listCategory();
        }

        private void clearAll()
        {
            textBoxID.Text = "";
            textBoxCatName.Text = "";

        }

        private void dataGridViewAuthor_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            textBoxID.Text = dataGridViewCategory.SelectedRows[0].Cells[0].Value.ToString();
            textBoxCatName.Text = dataGridViewCategory.SelectedRows[0].Cells[1].Value.ToString();

        }

        private void label4_Click(object sender, EventArgs e)
        {
            clearAll();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var name = textBoxCatName.Text;
            if (name == "")
            {
                MessageBox.Show("Hãy nhập tên chủ đề để thêm !");
            }
            else
            {
                ChuDe cd = new ChuDe()
                {
                    TenCD = textBoxCatName.Text,
                };
                ChuDeDao dao = new ChuDeDao();
                var res = dao.insertCategory(cd.TenCD);
                if (res > 0)
                {
                    MessageBox.Show("Thêm chủ đề thành công !");
                }
                bindDataToGrid();
                clearAll();

            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var name = textBoxCatName.Text;
            if (name == "")
            {
                MessageBox.Show("Hãy chọn 1 chủ đề để sửa !");
            }
            else
            {
                var id = int.Parse(textBoxID.Text);

                ChuDeDao dao = new ChuDeDao();
                var res = dao.updateCategoryName(id, name);
                if (res > 0)
                {
                    MessageBox.Show("Sửa thông tin thành công !");
                }
                bindDataToGrid();
                clearAll();

            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            var textId = textBoxID.Text;

            if (textId == "")
            {
                MessageBox.Show("Hãy chọn 1 chủ đề để XÓA !");
            }
            else
            {
                if (MessageBox.Show("Xóa chủ đề ??", "Xóa chủ đề", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    ChuDeDao dao = new ChuDeDao();
                    int id = int.Parse(textBoxID.Text);
                    var check = dao.deleteCategory(id);
                    if (check > 0)
                    {
                        MessageBox.Show("Xóa thành công !");
                        bindDataToGrid();
                        clearAll();
                    }
                }

            }

        }
    }
}
