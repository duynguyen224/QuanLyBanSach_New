using QuanLyBanSach_new.DAO;
using QuanLyBanSach_new.Entities;
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
            var tenPhieuNhap = "";
            PhieuNhapDao dao = new PhieuNhapDao();
            PhieuNhap pn = new PhieuNhap();
            pn.TongTien = int.Parse(textBoxAmount.Text);
            pn.TieuDe = textBoxTitle.Text;
            tenPhieuNhap = pn.TieuDe;
            pn.MoTa = richTextBoxDes.Text;
            dao.insertPhieuNhap(pn);
            var idPhieuNhap = dao.getIdPhieuNhap_fromName(tenPhieuNhap);
            this.Hide();
            Form_UpdateQuantity_AddNewBook f_uq = new Form_UpdateQuantity_AddNewBook(idPhieuNhap);

            f_uq.ShowDialog();
            f_uq.Closed += (s, args) => this.Close();
            

        }
    }
}
