using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using QuanLyBanSach_new.Forms;

namespace QuanLyBanSach_new.MyUserControl
{
    public partial class UC_Expense_Employee : UserControl
    {
        public UC_Expense_Employee()
        {
            InitializeComponent();
        }

        private void btnAddNewBooks_Click(object sender, EventArgs e)
        {
            using(Form_AddNewExpense ane = new Form_AddNewExpense())
            {
                ane.ShowDialog();
            }
        }
    }
}
