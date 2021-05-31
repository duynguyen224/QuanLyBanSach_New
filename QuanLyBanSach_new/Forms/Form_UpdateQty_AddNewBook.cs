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
using QuanLyBanSach_new.MyUserControl;

namespace QuanLyBanSach_new.Forms
{

    public partial class Form_UpdateQty_AddNewBook : Form
    {
        public int idPhieuNhap;
        public Form_UpdateQty_AddNewBook(int _idPhieuNhap, string title, int tongtien)
        {
            InitializeComponent();
            idPhieuNhap = _idPhieuNhap;
            bindDataToGrid(dataGridView2);
            labelnhaphang1.Text = title;
            labelAmount2.Text = tongtien.ToString() ;
        }
        private void bindDataToGrid(DataGridView d2)
        {
            ChiTietPhieuNhapDao dao = new ChiTietPhieuNhapDao();
            var res = dao.ExpenseDetails(idPhieuNhap);
            d2.DataSource = res;
        }
        private void clearAllUpdateQuantity()
        {
            textBoxSearchBookuq.Text = "";
            comboBoxBookTitleuq.SelectedIndex = -1;
            textBoxAuthoruq.Text = "";
            textBoxPublisheruq.Text = "";
            textBoxStockuq.Text = "";
            textBoxPriceuq.Text = "";
            textBoxQuantityuq.Text = "";
            textBoxIDuq.Text = "";
        }
        private void buttonSearch_Click(object sender, EventArgs e)
        {
            SachDao dao = new SachDao();
            var res = dao.sellBookSearchToCombobox(textBoxSearchBookuq.Text);
            comboBoxBookTitleuq.DataSource = res;
            comboBoxBookTitleuq.DisplayMember = "TenSach";

        }
        private void comboBoxBookTitleuq_SelectedValueChanged(object sender, EventArgs e)
        {
            string booktitle = "";
            textBoxSearchBookuq.Text = "";

            SachDao dao = new SachDao();
            var res = dao.bindDataFromTextBoxSearchToOthers(comboBoxBookTitleuq.Text);
            foreach (var item in res)
            {
                textBoxAuthoruq.Text = item.HoTenTG;
                textBoxPublisheruq.Text = item.TenNXB;
                textBoxStockuq.Text = item.SoLuongTon.ToString();
                textBoxPriceuq.Text = item.GiaBan.ToString();
                booktitle = comboBoxBookTitleuq.Text;
                textBoxIDuq.Text = dao.getIdBookByName(booktitle).ToString();

            }

        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBoxBookTitleuq.Text == "" || textBoxQuantityuq.Text == "")
            {
                MessageBox.Show("Hãy nhập đủ thông tin !");
            }
            var qty = int.TryParse(textBoxQuantityuq.Text, out _);
            if (qty == false)
            {
                MessageBox.Show("Kiểm tra số lượng nhập !");
            }
            else
            {
                // Bây giờ tạo thêm ChiTietPhieuNhap
                ChiTietPhieuNhapDao ctpnDao = new ChiTietPhieuNhapDao();
                ChiTietPhieuNhap ctpn = new ChiTietPhieuNhap()
                {
                    MaPhieuNhap = idPhieuNhap,
                    MaSach = int.Parse(textBoxIDuq.Text),
                    SoLuong = int.Parse(textBoxQuantityuq.Text)
                };
                var resss = ctpnDao.insertChiTietPhieuNhap(ctpn.MaPhieuNhap, ctpn.MaSach, ctpn.SoLuong);


                // update lại số lượng tồn
                SachDao sDao = new SachDao();
                sDao.updateQuantity(ctpn.MaSach, ctpn.SoLuong);






                bindDataToGrid(dataGridView2);

                // update tong tien
                var bookPrice = sDao.getPriceById(ctpn.MaSach);
                var soluong = ctpn.SoLuong;
                PhieuNhapDao pnDao = new PhieuNhapDao();
                pnDao.updateAmount(idPhieuNhap, (bookPrice * soluong).GetValueOrDefault());

                labelAmount2.Text = pnDao.getAmountById(idPhieuNhap).ToString();

                clearAllUpdateQuantity();
            }
        }
        private void button5_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Đã hoàn thành việc nhập và thoát phiên làm việc ? ", "Exit ", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                PhieuNhapDao dao = new PhieuNhapDao();
                dao.updateStatusTrue(idPhieuNhap);
                this.Close();
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Đã hoàn thành việc nhập và thoát phiên làm việc ? ", "Exit ", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Close();

            }

        }
    }
}
