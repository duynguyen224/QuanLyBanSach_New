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

            richTextBoxDes.Text = "";
        }
        private void button3_Click(object sender, EventArgs e)
        {
            clearAll();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var tenPhieuNhap = "";
            var time = DateTime.Now.ToString();
            PhieuNhapDao dao = new PhieuNhapDao();
            PhieuNhap pn = new PhieuNhap();
            pn.TieuDe = textBoxTitle.Text + " " + time;
            tenPhieuNhap = pn.TieuDe;
            pn.MoTa = richTextBoxDes.Text;
            pn.TongTien = 0;
            pn.TrangThai = false;
            dao.insertPhieuNhap(pn);
            //var idPhieuNhap = dao.getIdPhieuNhap_fromName(tenPhieuNhap);
            var idPhieuNhap = dao.getNewestId();
            this.Hide();
            //Form_Update_AddNew f_uq = new Form_Update_AddNew(idPhieuNhap);
            Form_UpdateQty_AddNewBook f_uq = new Form_UpdateQty_AddNewBook(idPhieuNhap, pn.TieuDe, pn.TongTien.GetValueOrDefault());
            f_uq.ShowDialog();
            f_uq.Closed += (s, args) => this.Close();

        }

        //private void button1_Click(object sender, EventArgs e)
        //{
        //    var tenPhieuNhap = "";
        //    var time = DateTime.Now.ToString();
        //    PhieuNhapDao dao = new PhieuNhapDao();
        //    PhieuNhap pn = new PhieuNhap();
        //    pn.TieuDe = textBoxTitle.Text + " " + time;
        //    tenPhieuNhap = pn.TieuDe;
        //    pn.MoTa = richTextBoxDes.Text;
        //    pn.TongTien = 0;
        //    dao.insertPhieuNhap(pn);
        //    //var idPhieuNhap = dao.getIdPhieuNhap_fromName(tenPhieuNhap);
        //    var idPhieuNhap = dao.getNewestId();
        //    this.Hide();
        //    Form_UpdateQty_AddNewBook f_uq = new Form_UpdateQty_AddNewBook(idPhieuNhap);
        //    f_uq.ShowDialog();
        //    f_uq.Closed += (s, args) => this.Close();
        //}
    }
}

