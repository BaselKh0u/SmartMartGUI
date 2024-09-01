namespace SmartMart
{
    partial class BuyerForm
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
            this.cbSeller = new System.Windows.Forms.ComboBox();
            this.cbProduct = new System.Windows.Forms.ComboBox();
            this.btnCart = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnOrderHistory = new System.Windows.Forms.Button();
            this.btnPurchase = new System.Windows.Forms.Button();
            this.listCart = new System.Windows.Forms.ListBox();
            this.lbCart = new System.Windows.Forms.Label();
            this.lbError = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(41, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select Seller";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(41, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(209, 36);
            this.label2.TabIndex = 1;
            this.label2.Text = "Select Product";
            // 
            // cbSeller
            // 
            this.cbSeller.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSeller.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSeller.FormattingEnabled = true;
            this.cbSeller.Location = new System.Drawing.Point(46, 78);
            this.cbSeller.Name = "cbSeller";
            this.cbSeller.Size = new System.Drawing.Size(1406, 48);
            this.cbSeller.TabIndex = 2;
            this.cbSeller.SelectedIndexChanged += new System.EventHandler(this.cbSeller_SelectedIndexChanged);
            // 
            // cbProduct
            // 
            this.cbProduct.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbProduct.FormattingEnabled = true;
            this.cbProduct.Location = new System.Drawing.Point(46, 185);
            this.cbProduct.Name = "cbProduct";
            this.cbProduct.Size = new System.Drawing.Size(1406, 48);
            this.cbProduct.TabIndex = 3;
            // 
            // btnCart
            // 
            this.btnCart.Location = new System.Drawing.Point(46, 272);
            this.btnCart.Name = "btnCart";
            this.btnCart.Size = new System.Drawing.Size(350, 80);
            this.btnCart.TabIndex = 4;
            this.btnCart.Text = "Add to Cart";
            this.btnCart.UseVisualStyleBackColor = true;
            this.btnCart.Click += new System.EventHandler(this.btnCart_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(46, 830);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(175, 71);
            this.btnLogout.TabIndex = 5;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnOrderHistory
            // 
            this.btnOrderHistory.Location = new System.Drawing.Point(46, 581);
            this.btnOrderHistory.Name = "btnOrderHistory";
            this.btnOrderHistory.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnOrderHistory.Size = new System.Drawing.Size(195, 72);
            this.btnOrderHistory.TabIndex = 6;
            this.btnOrderHistory.Text = "Orders History";
            this.btnOrderHistory.UseVisualStyleBackColor = true;
            this.btnOrderHistory.Click += new System.EventHandler(this.btnOrderHistory_Click);
            // 
            // btnPurchase
            // 
            this.btnPurchase.Location = new System.Drawing.Point(1277, 674);
            this.btnPurchase.Name = "btnPurchase";
            this.btnPurchase.Size = new System.Drawing.Size(175, 65);
            this.btnPurchase.TabIndex = 7;
            this.btnPurchase.Text = "Purchase";
            this.btnPurchase.UseVisualStyleBackColor = true;
            this.btnPurchase.Click += new System.EventHandler(this.btnPurchase_Click);
            // 
            // listCart
            // 
            this.listCart.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listCart.FormattingEnabled = true;
            this.listCart.ItemHeight = 36;
            this.listCart.Location = new System.Drawing.Point(445, 272);
            this.listCart.Name = "listCart";
            this.listCart.Size = new System.Drawing.Size(1007, 364);
            this.listCart.TabIndex = 8;
            // 
            // lbCart
            // 
            this.lbCart.AutoSize = true;
            this.lbCart.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCart.Location = new System.Drawing.Point(437, 674);
            this.lbCart.Name = "lbCart";
            this.lbCart.Size = new System.Drawing.Size(297, 48);
            this.lbCart.TabIndex = 9;
            this.lbCart.Text = "🛒 Cart Items:";
            // 
            // lbError
            // 
            this.lbError.AutoSize = true;
            this.lbError.ForeColor = System.Drawing.Color.Firebrick;
            this.lbError.Location = new System.Drawing.Point(30, 381);
            this.lbError.Name = "lbError";
            this.lbError.Size = new System.Drawing.Size(0, 29);
            this.lbError.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label3.Location = new System.Drawing.Point(1084, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(368, 29);
            this.label3.TabIndex = 11;
            this.label3.Text = "seller name (number of products)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label4.Location = new System.Drawing.Point(932, 153);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(520, 29);
            this.label4.TabIndex = 12;
            this.label4.Text = "product name (product price + packaging price)";
            // 
            // BuyerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1503, 1068);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbError);
            this.Controls.Add(this.lbCart);
            this.Controls.Add(this.listCart);
            this.Controls.Add(this.btnPurchase);
            this.Controls.Add(this.btnOrderHistory);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnCart);
            this.Controls.Add(this.cbProduct);
            this.Controls.Add(this.cbSeller);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "BuyerForm";
            this.Text = "BuyerForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbSeller;
        private System.Windows.Forms.ComboBox cbProduct;
        private System.Windows.Forms.Button btnCart;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnOrderHistory;
        private System.Windows.Forms.Button btnPurchase;
        private System.Windows.Forms.ListBox listCart;
        private System.Windows.Forms.Label lbCart;
        private System.Windows.Forms.Label lbError;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}