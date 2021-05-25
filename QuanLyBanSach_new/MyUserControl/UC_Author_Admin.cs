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



    }
}
