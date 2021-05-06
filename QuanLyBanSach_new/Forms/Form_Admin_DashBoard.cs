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
    public partial class Form_Admin_DashBoard : Form
    {
        int panelWidth;
        bool isCollapsed;
        public Form_Admin_DashBoard(string welcomeName)
        {
            InitializeComponent();

            panelWidth = panelLeft.Width;
            isCollapsed = false;
            UC_Home_Admin uch = new UC_Home_Admin();
            AddControlsToPanel(uch);

            labelAdminname.Text = welcomeName;
            
        }


        private void button8_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick_1(object sender, EventArgs e)
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

       

        private void moveSidePanel(Control btn)
        {
            panelSide.Top = btn.Top;
            panelSide.Height = btn.Height;
        }

        private void AddControlsToPanel(Control c)
        {
            c.Dock = DockStyle.Fill;
            panelControls.Controls.Clear();
            panelControls.Controls.Add(c);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            moveSidePanel(btnSettings);
        }

        private void btnHome_Click_1(object sender, EventArgs e)
        {

            moveSidePanel(btnHome);
            UC_Home_Admin ucHome = new UC_Home_Admin();
            AddControlsToPanel(ucHome);

        }

        private void btnUsers_Click_1(object sender, EventArgs e)
        {

            moveSidePanel(btnUsers);
            UC_User_Admin ucUser = new UC_User_Admin();
            AddControlsToPanel(ucUser);

        }

        private void btnViewSales_Click_1(object sender, EventArgs e)
        {

            moveSidePanel(btnViewSales);
            UC_ViewSale_Admin ucViewSale = new UC_ViewSale_Admin();
            AddControlsToPanel(ucViewSale);
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            moveSidePanel(btnSettings);
        }

        private void panelControls_Paint(object sender, PaintEventArgs e)
        {

        }

        private void buttonAuthor_Click(object sender, EventArgs e)
        {
            moveSidePanel(buttonAuthor);
            UC_Author_Admin ucAuthor = new UC_Author_Admin();
            AddControlsToPanel(ucAuthor);

        }

        private void buttonBook_Click(object sender, EventArgs e)
        {
            moveSidePanel(buttonBook);
            UC_Book_Admin ucBook = new UC_Book_Admin();
            AddControlsToPanel(ucBook);

        }
    }
}
