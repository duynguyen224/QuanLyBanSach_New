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

namespace QuanLyBanSach_new.Forms
{
    public partial class Form_Login : Form
    {
        public Form_Login()
        {
            InitializeComponent();
        }

        private void clearAll()
        {
            textBoxUsername.Text = "";
            textBoxPassword.Text = "";
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string username = textBoxUsername.Text;
            string password = textBoxPassword.Text;
            UserDao dao = new UserDao();
            var check = dao.login(username, password);
            if (check == "admin")
            {
                Form_Admin_DashBoard f = new Form_Admin_DashBoard(textBoxUsername.Text);
                f.ShowDialog();
            }
            else if (check == "employee")
            {
                Form_Employee_DashBoard f = new Form_Employee_DashBoard(textBoxUsername.Text);
                f.ShowDialog();
            }
            else
            {
                MessageBox.Show("Sai tài khoản hoặc mật khẩu");
                clearAll();
            }
            clearAll();
        }

    }
}
