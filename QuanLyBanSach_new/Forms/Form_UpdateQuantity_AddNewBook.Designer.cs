
namespace QuanLyBanSach_new.Forms
{
    partial class Form_UpdateQuantity_AddNewBook
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxBookTitle = new System.Windows.Forms.ComboBox();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.textBoxStock = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.textBoxQuantity = new System.Windows.Forms.TextBox();
            this.label1Quantity = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxAuthor = new System.Windows.Forms.TextBox();
            this.textBoxPublisher = new System.Windows.Forms.TextBox();
            this.textBoxPrice = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.textBoxSearchBook = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.label4.Location = new System.Drawing.Point(274, 39);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(227, 32);
            this.label4.TabIndex = 39;
            this.label4.Text = "Update Quantity";
            // 
            // comboBoxBookTitle
            // 
            this.comboBoxBookTitle.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxBookTitle.FormattingEnabled = true;
            this.comboBoxBookTitle.Location = new System.Drawing.Point(155, 160);
            this.comboBoxBookTitle.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.comboBoxBookTitle.Name = "comboBoxBookTitle";
            this.comboBoxBookTitle.Size = new System.Drawing.Size(448, 26);
            this.comboBoxBookTitle.TabIndex = 56;
            this.comboBoxBookTitle.SelectedIndexChanged += new System.EventHandler(this.comboBoxBookTitle_SelectedIndexChanged);
            this.comboBoxBookTitle.SelectedValueChanged += new System.EventHandler(this.comboBoxBookTitle_SelectedValueChanged);
            // 
            // buttonSearch
            // 
            this.buttonSearch.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.buttonSearch.Cursor = System.Windows.Forms.Cursors.Default;
            this.buttonSearch.FlatAppearance.BorderSize = 0;
            this.buttonSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSearch.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSearch.ForeColor = System.Drawing.Color.White;
            this.buttonSearch.Image = global::QuanLyBanSach_new.Properties.Resources.search_30px;
            this.buttonSearch.Location = new System.Drawing.Point(635, 106);
            this.buttonSearch.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(41, 39);
            this.buttonSearch.TabIndex = 55;
            this.buttonSearch.UseVisualStyleBackColor = false;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // textBoxStock
            // 
            this.textBoxStock.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxStock.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxStock.Location = new System.Drawing.Point(155, 313);
            this.textBoxStock.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.textBoxStock.Name = "textBoxStock";
            this.textBoxStock.ReadOnly = true;
            this.textBoxStock.Size = new System.Drawing.Size(264, 26);
            this.textBoxStock.TabIndex = 54;
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(86, 316);
            this.label11.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(59, 19);
            this.label11.TabIndex = 53;
            this.label11.Text = "Stock:";
            // 
            // textBoxQuantity
            // 
            this.textBoxQuantity.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxQuantity.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxQuantity.Location = new System.Drawing.Point(155, 409);
            this.textBoxQuantity.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.textBoxQuantity.Name = "textBoxQuantity";
            this.textBoxQuantity.Size = new System.Drawing.Size(152, 26);
            this.textBoxQuantity.TabIndex = 52;
            // 
            // label1Quantity
            // 
            this.label1Quantity.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1Quantity.AutoSize = true;
            this.label1Quantity.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1Quantity.Location = new System.Drawing.Point(66, 412);
            this.label1Quantity.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1Quantity.Name = "label1Quantity";
            this.label1Quantity.Size = new System.Drawing.Size(79, 19);
            this.label1Quantity.TabIndex = 51;
            this.label1Quantity.Text = "Quantity:";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(429, 365);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 19);
            this.label5.TabIndex = 50;
            this.label5.Text = "VND";
            // 
            // textBoxAuthor
            // 
            this.textBoxAuthor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxAuthor.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxAuthor.Location = new System.Drawing.Point(155, 214);
            this.textBoxAuthor.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.textBoxAuthor.Name = "textBoxAuthor";
            this.textBoxAuthor.ReadOnly = true;
            this.textBoxAuthor.Size = new System.Drawing.Size(521, 26);
            this.textBoxAuthor.TabIndex = 49;
            // 
            // textBoxPublisher
            // 
            this.textBoxPublisher.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxPublisher.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPublisher.Location = new System.Drawing.Point(155, 263);
            this.textBoxPublisher.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.textBoxPublisher.Name = "textBoxPublisher";
            this.textBoxPublisher.ReadOnly = true;
            this.textBoxPublisher.Size = new System.Drawing.Size(521, 26);
            this.textBoxPublisher.TabIndex = 48;
            // 
            // textBoxPrice
            // 
            this.textBoxPrice.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxPrice.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPrice.Location = new System.Drawing.Point(155, 362);
            this.textBoxPrice.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.textBoxPrice.Name = "textBoxPrice";
            this.textBoxPrice.ReadOnly = true;
            this.textBoxPrice.Size = new System.Drawing.Size(264, 26);
            this.textBoxPrice.TabIndex = 47;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(57, 266);
            this.label8.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(88, 19);
            this.label8.TabIndex = 44;
            this.label8.Text = "Publisher:";
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(91, 365);
            this.label9.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(54, 19);
            this.label9.TabIndex = 40;
            this.label9.Text = "Price:";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(78, 217);
            this.label7.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 19);
            this.label7.TabIndex = 42;
            this.label7.Text = "Author:";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(53, 163);
            this.label6.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 19);
            this.label6.TabIndex = 41;
            this.label6.Text = "Book Title:";
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(561, 468);
            this.button1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(115, 44);
            this.button1.TabIndex = 46;
            this.button1.Text = "Update";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBoxSearchBook
            // 
            this.textBoxSearchBook.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxSearchBook.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSearchBook.Location = new System.Drawing.Point(155, 114);
            this.textBoxSearchBook.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.textBoxSearchBook.Name = "textBoxSearchBook";
            this.textBoxSearchBook.Size = new System.Drawing.Size(464, 26);
            this.textBoxSearchBook.TabIndex = 45;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(31, 117);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 19);
            this.label1.TabIndex = 43;
            this.label1.Text = "Search Book:";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(613, 163);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 19);
            this.label2.TabIndex = 57;
            this.label2.Text = "ID:";
            // 
            // textBoxID
            // 
            this.textBoxID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxID.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxID.Location = new System.Drawing.Point(641, 160);
            this.textBoxID.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.ReadOnly = true;
            this.textBoxID.Size = new System.Drawing.Size(35, 26);
            this.textBoxID.TabIndex = 58;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(544, 341);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 19);
            this.label3.TabIndex = 59;
            this.label3.Text = "label3";
            // 
            // Form_UpdateQuantity_AddNewBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(783, 525);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBoxBookTitle);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.textBoxStock);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.textBoxQuantity);
            this.Controls.Add(this.label1Quantity);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxAuthor);
            this.Controls.Add(this.textBoxPublisher);
            this.Controls.Add(this.textBoxPrice);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBoxSearchBook);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Form_UpdateQuantity_AddNewBook";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_UpdateQuantity";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBoxBookTitle;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.TextBox textBoxStock;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBoxQuantity;
        private System.Windows.Forms.Label label1Quantity;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxAuthor;
        private System.Windows.Forms.TextBox textBoxPublisher;
        private System.Windows.Forms.TextBox textBoxPrice;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBoxSearchBook;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.Label label3;
    }
}