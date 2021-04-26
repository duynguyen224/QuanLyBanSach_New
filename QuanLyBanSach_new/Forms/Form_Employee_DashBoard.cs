using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using QuanLyBanSach_new.MyUserControl;

namespace QuanLyBanSach_new.Forms
{
    public partial class Form_Employee_DashBoard : Form
    {
        int panelWidth;
        bool isCollapsed;

        public Form_Employee_DashBoard(string welcomeName)
        {
            InitializeComponent();

            panelWidth = panelLeft.Width;
            isCollapsed = false;

            labelEmployeename.Text = welcomeName;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (isCollapsed)
            {
                panelLeft.Width = panelLeft.Width + 3;
                if (panelLeft.Width >= panelWidth)
                {
                    timer1.Stop();
                    isCollapsed = false;
                    this.Refresh();
                }
            }
            else
            {
                panelLeft.Width = panelLeft.Width - 3;
                if (panelLeft.Width <= 59)
                {
                    timer1.Stop();
                    isCollapsed = true;
                    this.Refresh();
                }
            }
        }

        private void AddControlsToPanel(Control c)
        {
            c.Dock = DockStyle.Fill;
            panelControl.Controls.Clear();
            panelControl.Controls.Add(c);
        }

        private void moveSidePanel(Control btn)
        {
            panelSide.Top = btn.Top;
            panelSide.Height = btn.Height;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void Form_Employee_DashBoard_Load(object sender, EventArgs e)
        {

        }

        private void panelControl_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            moveSidePanel(btnSale);
            UC_Sale_Employee ucse = new UC_Sale_Employee();
            AddControlsToPanel(ucse);

        }

        private void btnBook_Click(object sender, EventArgs e)
        {
            moveSidePanel(btnBook);
            UC_Book_Employee uce = new UC_Book_Employee();
            AddControlsToPanel(uce);
        }

        private void btnExpense_Click(object sender, EventArgs e)
        {
            moveSidePanel(btnExpense);
            UC_Expense_Employee ucexpense = new UC_Expense_Employee();
            AddControlsToPanel(ucexpense);
        }
    }
}
