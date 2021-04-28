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
using QuanLyBanSach_new.Forms;

namespace QuanLyBanSach_new.MyUserControl
{
    public partial class UC_Sale_Employee : UserControl
    {
        public UC_Sale_Employee()
        {
            InitializeComponent();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            using(Form_Finish_Order f = new Form_Finish_Order())
            {
                f.ShowDialog();
            }
        }


        private void clearAll()
        {
            textBoxSearchBook.Text = "";
            comboBoxBookTitle.SelectedIndex = -1;
            textBoxAuthor.Text = "";
            textBoxPublisher.Text = "";
            textBoxStock.Text = "";
            textBoxPrice.Text = "";
            textBoxDiscount.Text = "";
            textBoxQuantity.Text = "";
        }
        private void buttonSearch_Click(object sender, EventArgs e)
        {
            SachDao dao = new SachDao();
            var res = dao.sellBookSearchToCombobox(textBoxSearchBook.Text);
            comboBoxBookTitle.DataSource = res;
            comboBoxBookTitle.DisplayMember = "TenSach";
        }

        private void comboBoxBookTitle_SelectedValueChanged(object sender, EventArgs e)
        {
            textBoxSearchBook.Text = "";

            //NhaXuatBanDao dao = new NhaXuatBanDao();
            //var res = dao.getPublisherNameFromBookTitle(comboBoxBookTitle.Text);
            //foreach (var item in res)
            //{
            //    textBoxPublisher.Text = item.TenNXB;
            //}
            // không hiểu sao như dưới kia lại đéo được. Đm
            //textBoxPublisher.Text = res[0].TenNXB.ToString() ;

            SachDao dao = new SachDao();
            var res = dao.bindDataFromTextBoxSearchToOthers(comboBoxBookTitle.Text);
            foreach(var item in res)
            {
                textBoxAuthor.Text = item.HoTenTG;
                textBoxPublisher.Text = item.TenNXB;
                textBoxStock.Text = item.SoLuongTon.ToString();
                textBoxPrice.Text = item.GiaBan.ToString();
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(int.Parse(textBoxStock.Text) < int.Parse(textBoxQuantity.Text))
            {
                MessageBox.Show("Không đủ sách, chọn số lượng ít hơn !");
            }
            else
            {
                // bind data to GridView
                
                {
                    
                }

            }
            //clearAll();
        }
    }
}
