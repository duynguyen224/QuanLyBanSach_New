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
    public partial class UC_Author_Admin : UserControl
    {
        public UC_Author_Admin()
        {
            InitializeComponent();
            bindDataToGrid();
        }

        private void bindDataToGrid()
        {
            TacGiaDao dao = new TacGiaDao();
            dataGridViewAuthor.DataSource = dao.listAuthor();
        }
        //private void UC_Author_Admin_Load(object sender, EventArgs e)
        //{
        //    bindDataToGrid();
        //}

        private void clearAll()
        {
            textBoxID.Text = "";
            textBoxFullname.Text = "";
            textBoxAddress.Text = "";
            textBoxBackground.Text = "";
            textBoxPhone.Text = "";
        }

        private void dataGridViewAuthor_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //var add = dataGridViewAuthor.SelectedRows[0].Cells[2].Value.ToString();
            //var backgr = dataGridViewAuthor.SelectedRows[0].Cells[3].Value.ToString();
            //var phone = dataGridViewAuthor.SelectedRows[0].Cells[4].Value.ToString();
            textBoxID.Text = dataGridViewAuthor.SelectedRows[0].Cells[0].Value.ToString();
            textBoxFullname.Text = dataGridViewAuthor.SelectedRows[0].Cells[1].Value.ToString();
            textBoxAddress.Text = dataGridViewAuthor.SelectedRows[0].Cells[2].Value?.ToString();
            textBoxBackground.Text = dataGridViewAuthor.SelectedRows[0].Cells[3].Value?.ToString();
            textBoxPhone.Text = dataGridViewAuthor.SelectedRows[0].Cells[4].Value?.ToString();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            clearAll();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TacGia tg = new TacGia()
            {
                HoTenTG = textBoxFullname.Text,
                DiaChi = textBoxAddress.Text,
                TieuSu = textBoxBackground.Text,
                DienThoai = textBoxPhone.Text,
            };
            TacGiaDao tgDao = new TacGiaDao();
            var res = tgDao.insertAuthor(tg.HoTenTG, tg.DiaChi, tg.TieuSu, tg.DienThoai);
            if(res > 0)
            {
                MessageBox.Show("Thêm tác giả thành công !");
            }
            bindDataToGrid();
            clearAll();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var ht = textBoxFullname.Text;
            var dc = textBoxAddress.Text;
            var ts = textBoxBackground.Text;
            var dt = textBoxPhone.Text;
            var id = int.Parse(textBoxID.Text);
            TacGiaDao dao = new TacGiaDao();
            var res = dao.updateAuthor(ht, dc, ts, dt, id);
            if(res > 0)
            {
                MessageBox.Show("Sửa thông tin thành công !");
            }
            bindDataToGrid();
            clearAll();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Xóa Author ??", "Xóa Author", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                TacGiaDao dao = new TacGiaDao();
                int id = int.Parse(textBoxID.Text);
                var check = dao.deleteAuthor(id);
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
