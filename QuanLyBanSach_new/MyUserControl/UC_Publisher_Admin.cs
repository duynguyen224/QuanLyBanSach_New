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
    public partial class UC_Publisher_Admin : UserControl
    {
        public UC_Publisher_Admin()
        {
            InitializeComponent();
            bindDataToGrid();

        }
        private void bindDataToGrid()
        {
            NhaXuatBanDao dao = new NhaXuatBanDao();
            dataGridViewPublisher.DataSource = dao.listPublishher();
        }

        private void clearAll()
        {
            textBoxPubName.Text = "";
            textBoxAddress.Text = "";
            textBoxID.Text = "";
            textBoxPhone.Text = "";
        }

        private void dataGridViewAuthor_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            textBoxID.Text = dataGridViewPublisher.SelectedRows[0].Cells[0].Value.ToString();
            textBoxPubName.Text = dataGridViewPublisher.SelectedRows[0].Cells[1].Value.ToString();
            textBoxAddress.Text = dataGridViewPublisher.SelectedRows[0].Cells[2].Value?.ToString();
            textBoxPhone.Text = dataGridViewPublisher.SelectedRows[0].Cells[3].Value?.ToString();

        }

        private void label4_Click(object sender, EventArgs e)
        {
            clearAll();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var name = textBoxPubName.Text;
            if (name == "")
            {
                MessageBox.Show("Hãy nhập tên nhầ xuất bản !");
            }
            else
            {
                NhaXuatBan nxb = new NhaXuatBan()
                {
                    TenNXB = textBoxPubName.Text,
                    DiaChi = textBoxAddress.Text,
                    DienThoai = textBoxPhone.Text,
                };
                NhaXuatBanDao nxbDao = new NhaXuatBanDao();
                var res = nxbDao.insertPublisher(nxb.TenNXB, nxb.DiaChi, nxb.DienThoai);
                if (res > 0)
                {
                    MessageBox.Show("Thêm nhầ xuất bản thành công !");
                }
                bindDataToGrid();
                clearAll();

            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var ten = textBoxPubName.Text;
            var dc = textBoxAddress.Text;
            var dt = textBoxPhone.Text;
            if (ten == "")
            {
                MessageBox.Show("Hãy chọn 1 nhà xuất bản để sửa !");
            }
            else
            {
                var id = int.Parse(textBoxID.Text);

                NhaXuatBanDao dao = new NhaXuatBanDao();
                var res = dao.updatePublisher(id, ten, dc, dt);
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
                MessageBox.Show("Hãy chọn 1 nhà xuất bản để XÓA !");
            }
            else
            {
                if (MessageBox.Show("Xóa nhà xuất bản ??", "Xóa nhà xuất bản", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    NhaXuatBanDao dao = new NhaXuatBanDao();
                    int id = int.Parse(textBoxID.Text);
                    var check = dao.deletePublisher(id);
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
