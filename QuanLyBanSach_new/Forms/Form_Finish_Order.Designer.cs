
namespace QuanLyBanSach_new.Forms
{
    partial class Form_Finish_Order
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
            this.buttonDone = new System.Windows.Forms.Button();
            this.textBoxPaidAmount = new System.Windows.Forms.TextBox();
            this.textBoxTotalAmount = new System.Windows.Forms.TextBox();
            this.labelRefundAmount = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxDiscount = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxNetAmount = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.buttonAddNewCustomer = new System.Windows.Forms.Button();
            this.comboBoxCustomerName = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textBoxCustomerID = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.buttonSearchCustomer = new System.Windows.Forms.Button();
            this.textBoxSearchCustomer = new System.Windows.Forms.TextBox();
            this.label1SearchCustomerName = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonDone
            // 
            this.buttonDone.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonDone.BackColor = System.Drawing.Color.SeaGreen;
            this.buttonDone.FlatAppearance.BorderSize = 0;
            this.buttonDone.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDone.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDone.ForeColor = System.Drawing.Color.White;
            this.buttonDone.Location = new System.Drawing.Point(349, 421);
            this.buttonDone.Name = "buttonDone";
            this.buttonDone.Size = new System.Drawing.Size(131, 38);
            this.buttonDone.TabIndex = 38;
            this.buttonDone.Text = "Done";
            this.buttonDone.UseVisualStyleBackColor = false;
            this.buttonDone.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBoxPaidAmount
            // 
            this.textBoxPaidAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPaidAmount.Location = new System.Drawing.Point(159, 245);
            this.textBoxPaidAmount.Name = "textBoxPaidAmount";
            this.textBoxPaidAmount.Size = new System.Drawing.Size(195, 26);
            this.textBoxPaidAmount.TabIndex = 36;
            this.textBoxPaidAmount.TextChanged += new System.EventHandler(this.textBoxPaidAmount_TextChanged);
            // 
            // textBoxTotalAmount
            // 
            this.textBoxTotalAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTotalAmount.Location = new System.Drawing.Point(159, 203);
            this.textBoxTotalAmount.Name = "textBoxTotalAmount";
            this.textBoxTotalAmount.ReadOnly = true;
            this.textBoxTotalAmount.Size = new System.Drawing.Size(195, 26);
            this.textBoxTotalAmount.TabIndex = 35;
            // 
            // labelRefundAmount
            // 
            this.labelRefundAmount.AutoSize = true;
            this.labelRefundAmount.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRefundAmount.Location = new System.Drawing.Point(155, 289);
            this.labelRefundAmount.Name = "labelRefundAmount";
            this.labelRefundAmount.Size = new System.Drawing.Size(27, 19);
            this.labelRefundAmount.TabIndex = 32;
            this.labelRefundAmount.Text = "00";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 289);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(133, 19);
            this.label6.TabIndex = 31;
            this.label6.Text = "Refund Amount:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(36, 250);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 19);
            this.label5.TabIndex = 30;
            this.label5.Text = "Paid Amount:";
            // 
            // textBoxDiscount
            // 
            this.textBoxDiscount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDiscount.Location = new System.Drawing.Point(159, 161);
            this.textBoxDiscount.Name = "textBoxDiscount";
            this.textBoxDiscount.Size = new System.Drawing.Size(80, 26);
            this.textBoxDiscount.TabIndex = 37;
            this.textBoxDiscount.TextChanged += new System.EventHandler(this.textBoxDiscount_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(36, 208);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 19);
            this.label4.TabIndex = 29;
            this.label4.Text = "Total Amount:";
            // 
            // textBoxNetAmount
            // 
            this.textBoxNetAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNetAmount.Location = new System.Drawing.Point(159, 120);
            this.textBoxNetAmount.Name = "textBoxNetAmount";
            this.textBoxNetAmount.ReadOnly = true;
            this.textBoxNetAmount.Size = new System.Drawing.Size(195, 26);
            this.textBoxNetAmount.TabIndex = 34;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(74, 166);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 19);
            this.label3.TabIndex = 28;
            this.label3.Text = "Discount:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(48, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 19);
            this.label2.TabIndex = 27;
            this.label2.Text = "Net Amount:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(189, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 19);
            this.label1.TabIndex = 26;
            this.label1.Text = "Finalize Your Order";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox2.Image = global::QuanLyBanSach_new.Properties.Resources.books_emoji_80px;
            this.pictureBox2.Location = new System.Drawing.Point(64, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(75, 82);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 33;
            this.pictureBox2.TabStop = false;
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button2.BackColor = System.Drawing.Color.SeaGreen;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(408, 11);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(12, 392);
            this.button2.TabIndex = 39;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(603, 41);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 19);
            this.label8.TabIndex = 40;
            this.label8.Text = "Customer";
            // 
            // buttonAddNewCustomer
            // 
            this.buttonAddNewCustomer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.buttonAddNewCustomer.FlatAppearance.BorderSize = 0;
            this.buttonAddNewCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddNewCustomer.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddNewCustomer.ForeColor = System.Drawing.Color.White;
            this.buttonAddNewCustomer.Location = new System.Drawing.Point(770, 176);
            this.buttonAddNewCustomer.Name = "buttonAddNewCustomer";
            this.buttonAddNewCustomer.Size = new System.Drawing.Size(30, 29);
            this.buttonAddNewCustomer.TabIndex = 58;
            this.buttonAddNewCustomer.Text = "+";
            this.buttonAddNewCustomer.UseVisualStyleBackColor = false;
            this.buttonAddNewCustomer.Click += new System.EventHandler(this.buttonAddNewCustomer_Click);
            // 
            // comboBoxCustomerName
            // 
            this.comboBoxCustomerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxCustomerName.FormattingEnabled = true;
            this.comboBoxCustomerName.Location = new System.Drawing.Point(524, 178);
            this.comboBoxCustomerName.Name = "comboBoxCustomerName";
            this.comboBoxCustomerName.Size = new System.Drawing.Size(240, 28);
            this.comboBoxCustomerName.TabIndex = 57;
            this.comboBoxCustomerName.SelectedValueChanged += new System.EventHandler(this.comboBoxCustomerName_SelectedValueChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(456, 181);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(62, 19);
            this.label10.TabIndex = 56;
            this.label10.Text = "Name:";
            // 
            // textBoxCustomerID
            // 
            this.textBoxCustomerID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCustomerID.Location = new System.Drawing.Point(524, 220);
            this.textBoxCustomerID.Name = "textBoxCustomerID";
            this.textBoxCustomerID.ReadOnly = true;
            this.textBoxCustomerID.Size = new System.Drawing.Size(29, 26);
            this.textBoxCustomerID.TabIndex = 59;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(490, 222);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(28, 19);
            this.label9.TabIndex = 60;
            this.label9.Text = "ID:";
            // 
            // buttonSearchCustomer
            // 
            this.buttonSearchCustomer.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonSearchCustomer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.buttonSearchCustomer.Cursor = System.Windows.Forms.Cursors.Default;
            this.buttonSearchCustomer.FlatAppearance.BorderSize = 0;
            this.buttonSearchCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSearchCustomer.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSearchCustomer.ForeColor = System.Drawing.Color.White;
            this.buttonSearchCustomer.Image = global::QuanLyBanSach_new.Properties.Resources.search_30px;
            this.buttonSearchCustomer.Location = new System.Drawing.Point(770, 116);
            this.buttonSearchCustomer.Name = "buttonSearchCustomer";
            this.buttonSearchCustomer.Size = new System.Drawing.Size(30, 32);
            this.buttonSearchCustomer.TabIndex = 63;
            this.buttonSearchCustomer.UseVisualStyleBackColor = false;
            this.buttonSearchCustomer.Click += new System.EventHandler(this.buttonSearchCustomer_Click);
            // 
            // textBoxSearchCustomer
            // 
            this.textBoxSearchCustomer.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxSearchCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSearchCustomer.Location = new System.Drawing.Point(524, 117);
            this.textBoxSearchCustomer.Name = "textBoxSearchCustomer";
            this.textBoxSearchCustomer.Size = new System.Drawing.Size(240, 29);
            this.textBoxSearchCustomer.TabIndex = 62;
            // 
            // label1SearchCustomerName
            // 
            this.label1SearchCustomerName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1SearchCustomerName.AutoSize = true;
            this.label1SearchCustomerName.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1SearchCustomerName.Location = new System.Drawing.Point(447, 123);
            this.label1SearchCustomerName.Name = "label1SearchCustomerName";
            this.label1SearchCustomerName.Size = new System.Drawing.Size(71, 19);
            this.label1SearchCustomerName.TabIndex = 61;
            this.label1SearchCustomerName.Text = "Search: ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(245, 164);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(23, 19);
            this.label7.TabIndex = 64;
            this.label7.Text = "%";
            // 
            // Form_Finish_Order
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(824, 470);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.buttonSearchCustomer);
            this.Controls.Add(this.textBoxSearchCustomer);
            this.Controls.Add(this.label1SearchCustomerName);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textBoxCustomerID);
            this.Controls.Add(this.buttonAddNewCustomer);
            this.Controls.Add(this.comboBoxCustomerName);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.buttonDone);
            this.Controls.Add(this.textBoxPaidAmount);
            this.Controls.Add(this.textBoxTotalAmount);
            this.Controls.Add(this.labelRefundAmount);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxDiscount);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxNetAmount);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form_Finish_Order";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Form_Finish_Order";
            this.Load += new System.EventHandler(this.Form_Finish_Order_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonDone;
        private System.Windows.Forms.TextBox textBoxPaidAmount;
        private System.Windows.Forms.TextBox textBoxTotalAmount;
        private System.Windows.Forms.Label labelRefundAmount;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxDiscount;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxNetAmount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button buttonAddNewCustomer;
        private System.Windows.Forms.ComboBox comboBoxCustomerName;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBoxCustomerID;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button buttonSearchCustomer;
        private System.Windows.Forms.TextBox textBoxSearchCustomer;
        private System.Windows.Forms.Label label1SearchCustomerName;
        private System.Windows.Forms.Label label7;
    }
}