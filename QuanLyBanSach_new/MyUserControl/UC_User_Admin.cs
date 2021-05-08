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
using System.Data.Entity.Migrations;
using QuanLyBanSach_new.DAO;
namespace QuanLyBanSach_new.MyUserControl
{
    public partial class UC_User_Admin : UserControl
    {
        public UC_User_Admin()
        {
            InitializeComponent();

            // READONLY textbox ID
            UserDao dao = new UserDao();
            dao.populateUser(dataGridViewUser);

        }

        private void clearAll()
        {
            textBoxID.Text = "";
            textBoxUsername.Text = "";
            textBoxPassword.Text = "";
            textBoxFullname.Text = "";
            comboBoxRole.SelectedIndex = -1;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            UserDao dao = new UserDao();
            var fullname = textBoxFullname.Text;
            var username = textBoxUsername.Text;
            var pass = textBoxPassword.Text;

            if (fullname == "" || username == "" || pass == "" )
            {
                MessageBox.Show("Hãy nhập đủ thông tin !");
            }
            else
            {
                var u = new User()
                {
                    Fullname = fullname,
                    Username = username,
                    Password = pass,
                    Role = comboBoxRole.SelectedItem.ToString().Trim().ToLower()
                };

                var check = dao.insertUser(u);
                if (check > 0)
                {
                    MessageBox.Show("Thêm thành công !");
                }
                dao.populateUser(dataGridViewUser);

            }
        }

        private void UC_User_Admin_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            clearAll();
        }

        private void dataGridViewUser_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            textBoxID.Text = dataGridViewUser.SelectedRows[0].Cells[0].Value.ToString();
            textBoxUsername.Text = dataGridViewUser.SelectedRows[0].Cells[1].Value.ToString();
            textBoxPassword.Text = dataGridViewUser.SelectedRows[0].Cells[2].Value.ToString();
            textBoxFullname.Text = dataGridViewUser.SelectedRows[0].Cells[3].Value.ToString();
            comboBoxRole.Text = dataGridViewUser.SelectedRows[0].Cells[4].Value.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Xóa User ??", "Xóa User", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                UserDao dao = new UserDao();
                int id = int.Parse(textBoxID.Text);
                var check = dao.deleteUser(id);
                if (check > 0)
                {
                    MessageBox.Show("Xóa thành công !");
                    dao.populateUser(dataGridViewUser);
                    clearAll();
                }
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            UserDao dao = new UserDao();
            var check = dao.updateUser(int.Parse(textBoxID.Text), textBoxFullname.Text, textBoxUsername.Text, textBoxPassword.Text, comboBoxRole.SelectedItem.ToString().Trim().ToLower());
            if (check > 0)
            {
                MessageBox.Show("Sửa thành công !");
                dao.populateUser(dataGridViewUser);
                clearAll();
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {
            clearAll();
        }
    }
}
