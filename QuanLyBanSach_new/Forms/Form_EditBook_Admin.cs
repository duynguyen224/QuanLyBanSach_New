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
    public partial class Form_EditBook_Admin : Form
    {
        public string tensach;
        public int giaban;
        public int soluongton;
        public string hotentg;
        public string tencd;
        public string tennxb;

        public int idAuthor;
        public int idCate;
        public int idPub;
        public Form_EditBook_Admin(string _tensach, int _giaban, int _soluongton, string _hotentg, string _tencd, string _tennxb)
        {
            InitializeComponent();
            fillCombobox();
            clearAll();
            // 
            tensach = _tensach;
            giaban = _giaban;
            soluongton = _soluongton;
            hotentg = _hotentg;
            tencd = _tencd;
            tennxb = _tennxb;

            // 
            bindDataToTextBox();

            //
            idAuthor = int.Parse(textBoxAuthorID.Text);
            idCate = int.Parse(textBoxCategoryID.Text);
            idPub = int.Parse(textBoxPublisherID.Text);

        }

        public void clearAll()
        {
            textBoxBookTitle.Text = "";
            comboBoxAuthor.SelectedIndex = -1;
            textBoxAuthorID.Text = "";
            comboBoxPublisher.SelectedIndex = -1;
            textBoxPublisherID.Text = "";
            comboBoxCategory.SelectedIndex = -1;
            textBoxCategoryID.Text = "";
            textBoxPrice.Text = "";
            textBoxQuantity.Text = "";
            richTextBox.Text = "";
            textBoxBookID.Text = "";
        }


        private void bindDataToTextBox()
        {
            SachDao dao = new SachDao();
            textBoxBookTitle.Text = tensach;
            comboBoxAuthor.Text = hotentg;
            comboBoxPublisher.Text = tennxb;
            comboBoxCategory.Text = tencd;
            textBoxPrice.Text = giaban.ToString();
            textBoxQuantity.Text = soluongton.ToString(); 
            textBoxBookID.Text = dao.getIdBookByName(tensach).ToString();

        }

        private void comboBoxAuthor_SelectedValueChanged(object sender, EventArgs e)
        {
            string name = comboBoxAuthor.Text;
            TacGiaDao dao = new TacGiaDao();
            var res = dao.getIdAuthor(name);
            textBoxAuthorID.Text = res;

        }

        private void comboBoxPublisher_SelectedValueChanged(object sender, EventArgs e)
        {
            string name = comboBoxPublisher.Text;
            NhaXuatBanDao dao = new NhaXuatBanDao();
            var res = dao.getIdPublisher(name);
            textBoxPublisherID.Text = res;

        }

        private void comboBoxCategory_SelectedValueChanged(object sender, EventArgs e)
        {
            string name = comboBoxCategory.Text;
            ChuDeDao dao = new ChuDeDao();
            var res = dao.getIdCategory(name);
            textBoxCategoryID.Text = res;


        }

        public void fillCombobox()
        {
            TacGiaDao daotacgia = new TacGiaDao();
            daotacgia.populateAuthor(comboBoxAuthor);
            ChuDeDao daochude = new ChuDeDao();
            daochude.populateCategory(comboBoxCategory);
            NhaXuatBanDao daonxb = new NhaXuatBanDao();
            daonxb.populatePublisher(comboBoxPublisher);

        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            clearAll();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            // Dựa vào các cái id mà update lại cho phù hợp
            if(textBoxBookTitle.Text != tensach)
            {
                SachDao sDao = new SachDao();
                sDao.updateBooktitle(int.Parse(textBoxBookID.Text), textBoxBookTitle.Text);
            }
            if(comboBoxAuthor.Text != hotentg)
            {
                TacGiaDao tgDao = new TacGiaDao();
                tgDao.updateAuthorName(idAuthor, comboBoxAuthor.Text);
            }
            if(comboBoxPublisher.Text != tennxb)
            {
                NhaXuatBanDao nxbDao = new NhaXuatBanDao();
                nxbDao.updatePublisherName(idPub, comboBoxPublisher.Text);
            }
            if(comboBoxCategory.Text != tencd)
            {
                ChuDeDao cdDao = new ChuDeDao();
                cdDao.updateCategoryName(idCate, comboBoxCategory.Text);
            }
            if(textBoxPrice.Text != giaban.ToString())
            {
                SachDao ssDao = new SachDao();
                ssDao.updatePrice(int.Parse(textBoxBookID.Text), int.Parse(textBoxPrice.Text));
            }
            MessageBox.Show("Thành công !");
        }

        private void buttonAddNewAuthor_Click(object sender, EventArgs e)
        {
            using (Form_AddNewAuthor f = new Form_AddNewAuthor())
            {
                f.ShowDialog();
                fillCombobox();
                comboBoxAuthor.SelectedIndex = -1;
                //clearAllExceptTitle();
            }

        }

        private void buttonAddNewPublisher_Click(object sender, EventArgs e)
        {
            using (Form_AddNewPublisher f = new Form_AddNewPublisher())
            {
                f.ShowDialog();
                fillCombobox();
                comboBoxPublisher.SelectedIndex = -1;

                //learAllExceptTitle();

            }

        }

        private void buttonNewCategory_Click(object sender, EventArgs e)
        {
            using (Form_AddNewCategory f = new Form_AddNewCategory())
            {
                f.ShowDialog();
                fillCombobox();
                comboBoxCategory.SelectedIndex = -1;

                //clearAllExceptTitle();

            }

        }
    }
}
