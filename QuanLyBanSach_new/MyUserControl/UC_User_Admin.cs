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


    }
}
