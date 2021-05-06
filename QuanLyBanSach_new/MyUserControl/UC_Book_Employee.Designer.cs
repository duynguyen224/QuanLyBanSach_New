
namespace QuanLyBanSach_new.MyUserControl
{
    partial class UC_Book_Employee
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_Book_Employee));
            this.btnAddNewBooks = new System.Windows.Forms.Button();
            this.comboBoxSearchBy = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.dataGridViewBook = new System.Windows.Forms.DataGridView();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBook)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAddNewBooks
            // 
            this.btnAddNewBooks.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnAddNewBooks.FlatAppearance.BorderSize = 0;
            this.btnAddNewBooks.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddNewBooks.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddNewBooks.ForeColor = System.Drawing.Color.White;
            this.btnAddNewBooks.Image = ((System.Drawing.Image)(resources.GetObject("btnAddNewBooks.Image")));
            this.btnAddNewBooks.Location = new System.Drawing.Point(0, 0);
            this.btnAddNewBooks.Name = "btnAddNewBooks";
            this.btnAddNewBooks.Size = new System.Drawing.Size(193, 77);
            this.btnAddNewBooks.TabIndex = 0;
            this.btnAddNewBooks.Text = "   Add New Book";
            this.btnAddNewBooks.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAddNewBooks.UseVisualStyleBackColor = true;
            this.btnAddNewBooks.Click += new System.EventHandler(this.btnAddNewBooks_Click);
            // 
            // comboBoxSearchBy
            // 
            this.comboBoxSearchBy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxSearchBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSearchBy.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxSearchBy.FormattingEnabled = true;
            this.comboBoxSearchBy.Items.AddRange(new object[] {
            "Book Title",
            "Author",
            "Publisher",
            "Category"});
            this.comboBoxSearchBy.Location = new System.Drawing.Point(515, 26);
            this.comboBoxSearchBy.Name = "comboBoxSearchBy";
            this.comboBoxSearchBy.Size = new System.Drawing.Size(138, 26);
            this.comboBoxSearchBy.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(422, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 19);
            this.label5.TabIndex = 4;
            this.label5.Text = "Search By:";
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxSearch.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSearch.Location = new System.Drawing.Point(659, 25);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(179, 26);
            this.textBoxSearch.TabIndex = 5;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.panel5.Controls.Add(this.buttonSearch);
            this.panel5.Controls.Add(this.textBoxSearch);
            this.panel5.Controls.Add(this.label5);
            this.panel5.Controls.Add(this.comboBoxSearchBy);
            this.panel5.Controls.Add(this.btnAddNewBooks);
            this.panel5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel5.Location = new System.Drawing.Point(53, 34);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(885, 77);
            this.panel5.TabIndex = 11;
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
            this.buttonSearch.Location = new System.Drawing.Point(841, 19);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(44, 38);
            this.buttonSearch.TabIndex = 32;
            this.buttonSearch.UseVisualStyleBackColor = false;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // dataGridViewBook
            // 
            this.dataGridViewBook.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewBook.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBook.Location = new System.Drawing.Point(53, 129);
            this.dataGridViewBook.Name = "dataGridViewBook";
            this.dataGridViewBook.RowHeadersWidth = 62;
            this.dataGridViewBook.Size = new System.Drawing.Size(885, 405);
            this.dataGridViewBook.TabIndex = 12;
            // 
            // UC_Book_Employee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridViewBook);
            this.Controls.Add(this.panel5);
            this.Name = "UC_Book_Employee";
            this.Size = new System.Drawing.Size(1009, 547);
            this.Load += new System.EventHandler(this.UC_Book_Employee_Load);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBook)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAddNewBooks;
        private System.Windows.Forms.ComboBox comboBoxSearchBy;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.DataGridView dataGridViewBook;
        private System.Windows.Forms.Button buttonSearch;
    }
}
