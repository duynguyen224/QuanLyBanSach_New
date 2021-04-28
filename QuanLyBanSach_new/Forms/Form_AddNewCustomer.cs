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
using QuanLyBanSach_new.DAO;
using System.Diagnostics;

namespace QuanLyBanSach_new.Forms
{
    public partial class Form_AddNewCustomer : Form
    {
        public Form_AddNewCustomer()
        {
            InitializeComponent();
        }

        private void clearAll()
        {
            textBoxCustomerName.Text = "";
            textBoxCustomerAddress.Text = "";
            textBoxCustomerPhone.Text = "";
        }

        private void Form_AddNewCustomer_Load(object sender, EventArgs e)
        {

        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            clearAll();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            KhachHang kh = new KhachHang();
            kh.HoTen = textBoxCustomerName.Text;
            kh.DiaChi = textBoxCustomerAddress.Text;
            kh.DienThoai = textBoxCustomerPhone.Text;
            KhachHangDao dao = new KhachHangDao();
            var res = dao.insertCustomer(kh);
            if(res > 0)
            {
                MessageBox.Show("Thêm mới khách hàng thành công, ID: " + res);
                clearAll();
                
            }
            else
            {
                MessageBox.Show("Thêm không thành công");
            }
            
        }
    }
}
