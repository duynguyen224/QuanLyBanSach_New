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
    public partial class Form_Finish_Order : Form
    {
        public Form_Finish_Order()
        {
            InitializeComponent();
        }

        private void Form_Finish_Order_Load(object sender, EventArgs e)
        {

        }

        private void buttonAddNewCustomer_Click(object sender, EventArgs e)
        {
            using(Form_AddNewCustomer f = new Form_AddNewCustomer())
            {
                f.ShowDialog();

            }
        }
    }
}
