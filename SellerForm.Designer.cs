namespace SmartMart
{
    partial class SellerForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbPrice = new System.Windows.Forms.TextBox();
            this.cbCategory = new System.Windows.Forms.ComboBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lbError = new System.Windows.Forms.Label();
            this.cbSpecialPackaging = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbPackagingPrice = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.listProducts = new System.Windows.Forms.ListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(33, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(358, 48);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add New Product";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(167, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Product Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 202);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(158, 29);
            this.label3.TabIndex = 2;
            this.label3.Text = "Product Price";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(35, 316);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(199, 29);
            this.label4.TabIndex = 3;
            this.label4.Text = "Product Category";
            // 
            // tbName
            // 
            this.tbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbName.Location = new System.Drawing.Point(38, 125);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(500, 55);
            this.tbName.TabIndex = 4;
            // 
            // tbPrice
            // 
            this.tbPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPrice.Location = new System.Drawing.Point(38, 234);
            this.tbPrice.Name = "tbPrice";
            this.tbPrice.Size = new System.Drawing.Size(500, 55);
            this.tbPrice.TabIndex = 5;
            // 
            // cbCategory
            // 
            this.cbCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCategory.FormattingEnabled = true;
            this.cbCategory.Location = new System.Drawing.Point(38, 348);
            this.cbCategory.Name = "cbCategory";
            this.cbCategory.Size = new System.Drawing.Size(500, 56);
            this.cbCategory.TabIndex = 6;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(38, 602);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(400, 100);
            this.btnAdd.TabIndex = 7;
            this.btnAdd.Text = "Add Product";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lbError
            // 
            this.lbError.AutoSize = true;
            this.lbError.ForeColor = System.Drawing.Color.Firebrick;
            this.lbError.Location = new System.Drawing.Point(45, 736);
            this.lbError.Name = "lbError";
            this.lbError.Size = new System.Drawing.Size(0, 29);
            this.lbError.TabIndex = 8;
            // 
            // cbSpecialPackaging
            // 
            this.cbSpecialPackaging.AutoSize = true;
            this.cbSpecialPackaging.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSpecialPackaging.Location = new System.Drawing.Point(41, 427);
            this.cbSpecialPackaging.Name = "cbSpecialPackaging";
            this.cbSpecialPackaging.Size = new System.Drawing.Size(396, 52);
            this.cbSpecialPackaging.TabIndex = 9;
            this.cbSpecialPackaging.Text = "Special Packaging";
            this.cbSpecialPackaging.UseVisualStyleBackColor = true;
            this.cbSpecialPackaging.CheckedChanged += new System.EventHandler(this.cbSpecialPackaging_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(33, 492);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(188, 29);
            this.label5.TabIndex = 10;
            this.label5.Text = "Packaging Price";
            // 
            // tbPackagingPrice
            // 
            this.tbPackagingPrice.Enabled = false;
            this.tbPackagingPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPackagingPrice.Location = new System.Drawing.Point(38, 524);
            this.tbPackagingPrice.Name = "tbPackagingPrice";
            this.tbPackagingPrice.Size = new System.Drawing.Size(500, 55);
            this.tbPackagingPrice.TabIndex = 11;
            this.tbPackagingPrice.Text = "0";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(38, 794);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(200, 60);
            this.button1.TabIndex = 12;
            this.button1.Text = "Logout";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // listProducts
            // 
            this.listProducts.FormattingEnabled = true;
            this.listProducts.ItemHeight = 29;
            this.listProducts.Location = new System.Drawing.Point(590, 125);
            this.listProducts.Name = "listProducts";
            this.listProducts.Size = new System.Drawing.Size(776, 729);
            this.listProducts.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(585, 93);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(235, 29);
            this.label6.TabIndex = 14;
            this.label6.Text = "List Of All Products";
            // 
            // SellerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1404, 885);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.listProducts);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tbPackagingPrice);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbSpecialPackaging);
            this.Controls.Add(this.lbError);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.cbCategory);
            this.Controls.Add(this.tbPrice);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "SellerForm";
            this.Text = "SmartMart | Seller";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.TextBox tbPrice;
        private System.Windows.Forms.ComboBox cbCategory;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lbError;
        private System.Windows.Forms.CheckBox cbSpecialPackaging;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbPackagingPrice;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox listProducts;
        private System.Windows.Forms.Label label6;
    }
}