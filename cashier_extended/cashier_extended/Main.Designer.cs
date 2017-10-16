namespace cashier_extended
{
    partial class Main
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
            this.label2_bs = new System.Windows.Forms.Label();
            this.btn_SaveDetails = new System.Windows.Forms.Button();
            this.txt_cusPhone = new System.Windows.Forms.TextBox();
            this.txt_cusName = new System.Windows.Forms.TextBox();
            this.lbl_cusPhone = new System.Windows.Forms.Label();
            this.lbl_cusName = new System.Windows.Forms.Label();
            this.lbl_discTotalSale = new System.Windows.Forms.Label();
            this.lbl_totalSale = new System.Windows.Forms.Label();
            this.btn_cancelSale = new System.Windows.Forms.Button();
            this.btn_confirmSale = new System.Windows.Forms.Button();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.lbl_invoiceNum = new System.Windows.Forms.Label();
            this.lbl_prodPrice = new System.Windows.Forms.Label();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.lbl_Quantity = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_sellProduct = new System.Windows.Forms.Button();
            this.lst_products = new System.Windows.Forms.ListBox();
            this.btn_closeOfBusiness = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2_bs
            // 
            this.label2_bs.AutoSize = true;
            this.label2_bs.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2_bs.Location = new System.Drawing.Point(79, 503);
            this.label2_bs.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2_bs.Name = "label2_bs";
            this.label2_bs.Size = new System.Drawing.Size(463, 18);
            this.label2_bs.TabIndex = 38;
            this.label2_bs.Text = "Big Spender discount requires name and phone number to be entered";
            this.label2_bs.Visible = false;
            // 
            // btn_SaveDetails
            // 
            this.btn_SaveDetails.Location = new System.Drawing.Point(317, 697);
            this.btn_SaveDetails.Margin = new System.Windows.Forms.Padding(2);
            this.btn_SaveDetails.Name = "btn_SaveDetails";
            this.btn_SaveDetails.Size = new System.Drawing.Size(167, 30);
            this.btn_SaveDetails.TabIndex = 37;
            this.btn_SaveDetails.Text = "Save ";
            this.btn_SaveDetails.UseVisualStyleBackColor = true;
            this.btn_SaveDetails.Visible = false;
            this.btn_SaveDetails.Click += new System.EventHandler(this.btn_SaveDetails_Click_1);
            // 
            // txt_cusPhone
            // 
            this.txt_cusPhone.Location = new System.Drawing.Point(248, 652);
            this.txt_cusPhone.Margin = new System.Windows.Forms.Padding(2);
            this.txt_cusPhone.Name = "txt_cusPhone";
            this.txt_cusPhone.Size = new System.Drawing.Size(150, 20);
            this.txt_cusPhone.TabIndex = 36;
            this.txt_cusPhone.Visible = false;
            // 
            // txt_cusName
            // 
            this.txt_cusName.Location = new System.Drawing.Point(248, 607);
            this.txt_cusName.Margin = new System.Windows.Forms.Padding(2);
            this.txt_cusName.Name = "txt_cusName";
            this.txt_cusName.Size = new System.Drawing.Size(150, 20);
            this.txt_cusName.TabIndex = 35;
            this.txt_cusName.Visible = false;
            // 
            // lbl_cusPhone
            // 
            this.lbl_cusPhone.AutoSize = true;
            this.lbl_cusPhone.Location = new System.Drawing.Point(138, 652);
            this.lbl_cusPhone.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_cusPhone.Name = "lbl_cusPhone";
            this.lbl_cusPhone.Size = new System.Drawing.Size(88, 13);
            this.lbl_cusPhone.TabIndex = 34;
            this.lbl_cusPhone.Text = "Customer Phone:";
            this.lbl_cusPhone.Visible = false;
            // 
            // lbl_cusName
            // 
            this.lbl_cusName.AutoSize = true;
            this.lbl_cusName.Location = new System.Drawing.Point(138, 607);
            this.lbl_cusName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_cusName.Name = "lbl_cusName";
            this.lbl_cusName.Size = new System.Drawing.Size(85, 13);
            this.lbl_cusName.TabIndex = 33;
            this.lbl_cusName.Text = "Customer Name:";
            this.lbl_cusName.Visible = false;
            // 
            // lbl_discTotalSale
            // 
            this.lbl_discTotalSale.AutoSize = true;
            this.lbl_discTotalSale.ForeColor = System.Drawing.Color.Red;
            this.lbl_discTotalSale.Location = new System.Drawing.Point(246, 566);
            this.lbl_discTotalSale.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_discTotalSale.Name = "lbl_discTotalSale";
            this.lbl_discTotalSale.Size = new System.Drawing.Size(35, 13);
            this.lbl_discTotalSale.TabIndex = 32;
            this.lbl_discTotalSale.Text = "label2";
            this.lbl_discTotalSale.Visible = false;
            // 
            // lbl_totalSale
            // 
            this.lbl_totalSale.AutoSize = true;
            this.lbl_totalSale.ForeColor = System.Drawing.Color.Red;
            this.lbl_totalSale.Location = new System.Drawing.Point(243, 490);
            this.lbl_totalSale.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_totalSale.Name = "lbl_totalSale";
            this.lbl_totalSale.Size = new System.Drawing.Size(35, 13);
            this.lbl_totalSale.TabIndex = 31;
            this.lbl_totalSale.Text = "label2";
            this.lbl_totalSale.Visible = false;
            // 
            // btn_cancelSale
            // 
            this.btn_cancelSale.Location = new System.Drawing.Point(317, 522);
            this.btn_cancelSale.Margin = new System.Windows.Forms.Padding(2);
            this.btn_cancelSale.Name = "btn_cancelSale";
            this.btn_cancelSale.Size = new System.Drawing.Size(167, 30);
            this.btn_cancelSale.TabIndex = 30;
            this.btn_cancelSale.Text = "Cancel Sale";
            this.btn_cancelSale.UseVisualStyleBackColor = true;
            this.btn_cancelSale.Visible = false;
            this.btn_cancelSale.Click += new System.EventHandler(this.btn_cancelSale_Click_1);
            // 
            // btn_confirmSale
            // 
            this.btn_confirmSale.Location = new System.Drawing.Point(133, 522);
            this.btn_confirmSale.Margin = new System.Windows.Forms.Padding(2);
            this.btn_confirmSale.Name = "btn_confirmSale";
            this.btn_confirmSale.Size = new System.Drawing.Size(167, 30);
            this.btn_confirmSale.TabIndex = 29;
            this.btn_confirmSale.Text = "Confirm Sale";
            this.btn_confirmSale.UseVisualStyleBackColor = true;
            this.btn_confirmSale.Visible = false;
            this.btn_confirmSale.Click += new System.EventHandler(this.btn_confirmSale_Click_1);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(365, 450);
            this.numericUpDown1.Margin = new System.Windows.Forms.Padding(2);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(105, 20);
            this.numericUpDown1.TabIndex = 28;
            this.numericUpDown1.Visible = false;
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged_1);
            // 
            // lbl_invoiceNum
            // 
            this.lbl_invoiceNum.AutoSize = true;
            this.lbl_invoiceNum.Location = new System.Drawing.Point(138, 454);
            this.lbl_invoiceNum.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_invoiceNum.Name = "lbl_invoiceNum";
            this.lbl_invoiceNum.Size = new System.Drawing.Size(35, 13);
            this.lbl_invoiceNum.TabIndex = 26;
            this.lbl_invoiceNum.Text = "label3";
            this.lbl_invoiceNum.Visible = false;
            // 
            // lbl_prodPrice
            // 
            this.lbl_prodPrice.AutoSize = true;
            this.lbl_prodPrice.Location = new System.Drawing.Point(208, 301);
            this.lbl_prodPrice.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_prodPrice.Name = "lbl_prodPrice";
            this.lbl_prodPrice.Size = new System.Drawing.Size(71, 13);
            this.lbl_prodPrice.TabIndex = 25;
            this.lbl_prodPrice.Text = "Product Price";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // lbl_Quantity
            // 
            this.lbl_Quantity.AutoSize = true;
            this.lbl_Quantity.Location = new System.Drawing.Point(290, 454);
            this.lbl_Quantity.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Quantity.Name = "lbl_Quantity";
            this.lbl_Quantity.Size = new System.Drawing.Size(49, 13);
            this.lbl_Quantity.TabIndex = 27;
            this.lbl_Quantity.Text = "Quantity:";
            this.lbl_Quantity.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.ErrorImage = null;
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(317, 260);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(128, 92);
            this.pictureBox1.TabIndex = 24;
            this.pictureBox1.TabStop = false;
            // 
            // btn_sellProduct
            // 
            this.btn_sellProduct.Location = new System.Drawing.Point(133, 384);
            this.btn_sellProduct.Name = "btn_sellProduct";
            this.btn_sellProduct.Size = new System.Drawing.Size(167, 30);
            this.btn_sellProduct.TabIndex = 23;
            this.btn_sellProduct.Text = "Sell Product";
            this.btn_sellProduct.UseVisualStyleBackColor = true;
            this.btn_sellProduct.Click += new System.EventHandler(this.btn_sellProduct_Click);
            // 
            // lst_products
            // 
            this.lst_products.FormattingEnabled = true;
            this.lst_products.Location = new System.Drawing.Point(211, 96);
            this.lst_products.Name = "lst_products";
            this.lst_products.Size = new System.Drawing.Size(194, 134);
            this.lst_products.TabIndex = 22;
            this.lst_products.SelectedIndexChanged += new System.EventHandler(this.lst_products_SelectedIndexChanged_1);
            // 
            // btn_closeOfBusiness
            // 
            this.btn_closeOfBusiness.Location = new System.Drawing.Point(317, 384);
            this.btn_closeOfBusiness.Name = "btn_closeOfBusiness";
            this.btn_closeOfBusiness.Size = new System.Drawing.Size(167, 30);
            this.btn_closeOfBusiness.TabIndex = 21;
            this.btn_closeOfBusiness.Text = "Close of Business";
            this.btn_closeOfBusiness.UseVisualStyleBackColor = true;
            this.btn_closeOfBusiness.Click += new System.EventHandler(this.btn_closeOfBusiness_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(206, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(199, 25);
            this.label1.TabIndex = 20;
            this.label1.Text = "Bingo Office Supplies";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(621, 741);
            this.Controls.Add(this.label2_bs);
            this.Controls.Add(this.btn_SaveDetails);
            this.Controls.Add(this.txt_cusPhone);
            this.Controls.Add(this.txt_cusName);
            this.Controls.Add(this.lbl_cusPhone);
            this.Controls.Add(this.lbl_cusName);
            this.Controls.Add(this.lbl_discTotalSale);
            this.Controls.Add(this.lbl_totalSale);
            this.Controls.Add(this.btn_cancelSale);
            this.Controls.Add(this.btn_confirmSale);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.lbl_invoiceNum);
            this.Controls.Add(this.lbl_prodPrice);
            this.Controls.Add(this.lbl_Quantity);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_sellProduct);
            this.Controls.Add(this.lst_products);
            this.Controls.Add(this.btn_closeOfBusiness);
            this.Controls.Add(this.label1);
            this.Name = "Main";
            this.Text = "Bingo Office Supplies Sales Management";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2_bs;
        private System.Windows.Forms.Button btn_SaveDetails;
        private System.Windows.Forms.TextBox txt_cusPhone;
        private System.Windows.Forms.TextBox txt_cusName;
        private System.Windows.Forms.Label lbl_cusPhone;
        private System.Windows.Forms.Label lbl_cusName;
        private System.Windows.Forms.Label lbl_discTotalSale;
        private System.Windows.Forms.Label lbl_totalSale;
        private System.Windows.Forms.Button btn_cancelSale;
        private System.Windows.Forms.Button btn_confirmSale;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label lbl_invoiceNum;
        private System.Windows.Forms.Label lbl_prodPrice;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label lbl_Quantity;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_sellProduct;
        private System.Windows.Forms.ListBox lst_products;
        private System.Windows.Forms.Button btn_closeOfBusiness;
        private System.Windows.Forms.Label label1;
    }
}