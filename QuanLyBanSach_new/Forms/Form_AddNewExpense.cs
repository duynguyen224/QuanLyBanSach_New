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
    public partial class Form_AddNewExpense : Form
    {
        public Form_AddNewExpense()
        {
            InitializeComponent();
        }

        private void clearAll()
        {
            textBoxTitle.Text = "";
            textBoxAmount.Text = "";
            richTextBoxDes.Text = "";
        }
        private void button3_Click(object sender, EventArgs e)
        {
            clearAll();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
