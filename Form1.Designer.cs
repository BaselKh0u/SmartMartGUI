namespace SmartMart
{
    partial class Form1
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
            this.btnSeller = new System.Windows.Forms.Button();
            this.btnCustomer = new System.Windows.Forms.Button();
            this.tbSellerName = new System.Windows.Forms.TextBox();
            this.tbSellerPassword = new System.Windows.Forms.TextBox();
            this.tbCustomerName = new System.Windows.Forms.TextBox();
            this.tbCustomerPassword = new System.Windows.Forms.TextBox();
            this.btnSellerLogin = new System.Windows.Forms.Button();
            this.btnCustomerLogin = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lbError = new System.Windows.Forms.Label();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.btnAllSellers = new System.Windows.Forms.Button();
            this.btnAllBuyers = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSeller
            // 
            this.btnSeller.Location = new System.Drawing.Point(29, 124);
            this.btnSeller.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSeller.Name = "btnSeller";
            this.btnSeller.Size = new System.Drawing.Size(229, 55);
            this.btnSeller.TabIndex = 0;
            this.btnSeller.Text = "Add Seller";
            this.btnSeller.UseVisualStyleBackColor = true;
            this.btnSeller.Click += new System.EventHandler(this.btnSeller_Click);
            // 
            // btnCustomer
            // 
            this.btnCustomer.Location = new System.Drawing.Point(648, 124);
            this.btnCustomer.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCustomer.Name = "btnCustomer";
            this.btnCustomer.Size = new System.Drawing.Size(229, 55);
            this.btnCustomer.TabIndex = 1;
            this.btnCustomer.Text = "Add Customer";
            this.btnCustomer.UseVisualStyleBackColor = true;
            this.btnCustomer.Click += new System.EventHandler(this.btnCustomer_Click);
            // 
            // tbSellerName
            // 
            this.tbSellerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSellerName.Location = new System.Drawing.Point(29, 303);
            this.tbSellerName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbSellerName.Name = "tbSellerName";
            this.tbSellerName.Size = new System.Drawing.Size(287, 34);
            this.tbSellerName.TabIndex = 2;
            // 
            // tbSellerPassword
            // 
            this.tbSellerPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSellerPassword.Location = new System.Drawing.Point(29, 373);
            this.tbSellerPassword.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbSellerPassword.Name = "tbSellerPassword";
            this.tbSellerPassword.Size = new System.Drawing.Size(287, 34);
            this.tbSellerPassword.TabIndex = 3;
            this.tbSellerPassword.UseSystemPasswordChar = true;
            // 
            // tbCustomerName
            // 
            this.tbCustomerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCustomerName.Location = new System.Drawing.Point(591, 303);
            this.tbCustomerName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbCustomerName.Name = "tbCustomerName";
            this.tbCustomerName.Size = new System.Drawing.Size(287, 34);
            this.tbCustomerName.TabIndex = 4;
            // 
            // tbCustomerPassword
            // 
            this.tbCustomerPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCustomerPassword.Location = new System.Drawing.Point(591, 373);
            this.tbCustomerPassword.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbCustomerPassword.Name = "tbCustomerPassword";
            this.tbCustomerPassword.Size = new System.Drawing.Size(287, 34);
            this.tbCustomerPassword.TabIndex = 5;
            this.tbCustomerPassword.UseSystemPasswordChar = true;
            // 
            // btnSellerLogin
            // 
            this.btnSellerLogin.Location = new System.Drawing.Point(29, 424);
            this.btnSellerLogin.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSellerLogin.Name = "btnSellerLogin";
            this.btnSellerLogin.Size = new System.Drawing.Size(143, 55);
            this.btnSellerLogin.TabIndex = 6;
            this.btnSellerLogin.Text = "Login";
            this.btnSellerLogin.UseVisualStyleBackColor = true;
            this.btnSellerLogin.Click += new System.EventHandler(this.btnSellerLogin_Click);
            // 
            // btnCustomerLogin
            // 
            this.btnCustomerLogin.Location = new System.Drawing.Point(734, 424);
            this.btnCustomerLogin.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCustomerLogin.Name = "btnCustomerLogin";
            this.btnCustomerLogin.Size = new System.Drawing.Size(143, 55);
            this.btnCustomerLogin.TabIndex = 7;
            this.btnCustomerLogin.Text = "Login";
            this.btnCustomerLogin.UseVisualStyleBackColor = true;
            this.btnCustomerLogin.Click += new System.EventHandler(this.btnCustomerLogin_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 238);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 29);
            this.label1.TabIndex = 8;
            this.label1.Text = "Seller Login";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(689, 238);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(197, 29);
            this.label2.TabIndex = 9;
            this.label2.Text = "Customer Login";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(26, 281);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 16);
            this.label3.TabIndex = 10;
            this.label3.Text = "Seller Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(26, 355);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 16);
            this.label4.TabIndex = 11;
            this.label4.Text = "Seller Password";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(588, 286);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 16);
            this.label5.TabIndex = 12;
            this.label5.Text = "Customer Name";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(588, 355);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(127, 16);
            this.label6.TabIndex = 13;
            this.label6.Text = "Customer Password";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Rockwell", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(269, 34);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(352, 73);
            this.label7.TabIndex = 14;
            this.label7.Text = "SmartMart";
            // 
            // lbError
            // 
            this.lbError.AutoSize = true;
            this.lbError.ForeColor = System.Drawing.Color.Firebrick;
            this.lbError.Location = new System.Drawing.Point(354, 341);
            this.lbError.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbError.Name = "lbError";
            this.lbError.Size = new System.Drawing.Size(0, 16);
            this.lbError.TabIndex = 15;
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(2, 605);
            this.splitter1.TabIndex = 16;
            this.splitter1.TabStop = false;
            // 
            // btnAllSellers
            // 
            this.btnAllSellers.Location = new System.Drawing.Point(211, 479);
            this.btnAllSellers.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAllSellers.Name = "btnAllSellers";
            this.btnAllSellers.Size = new System.Drawing.Size(200, 28);
            this.btnAllSellers.TabIndex = 17;
            this.btnAllSellers.Text = "Details Of All Sellers";
            this.btnAllSellers.UseVisualStyleBackColor = true;
            this.btnAllSellers.Click += new System.EventHandler(this.btnAllSellers_Click);
            // 
            // btnAllBuyers
            // 
            this.btnAllBuyers.Location = new System.Drawing.Point(495, 479);
            this.btnAllBuyers.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAllBuyers.Name = "btnAllBuyers";
            this.btnAllBuyers.Size = new System.Drawing.Size(200, 28);
            this.btnAllBuyers.TabIndex = 18;
            this.btnAllBuyers.Text = "Details Of All Buyers";
            this.btnAllBuyers.UseVisualStyleBackColor = true;
            this.btnAllBuyers.Click += new System.EventHandler(this.btnAllBuyers_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SmartMart.Properties.Resources.background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(905, 605);
            this.Controls.Add(this.btnAllBuyers);
            this.Controls.Add(this.btnAllSellers);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.lbError);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCustomerLogin);
            this.Controls.Add(this.btnSellerLogin);
            this.Controls.Add(this.tbCustomerPassword);
            this.Controls.Add(this.tbCustomerName);
            this.Controls.Add(this.tbSellerPassword);
            this.Controls.Add(this.tbSellerName);
            this.Controls.Add(this.btnCustomer);
            this.Controls.Add(this.btnSeller);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "SmartMart | Home";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSeller;
        private System.Windows.Forms.Button btnCustomer;
        private System.Windows.Forms.TextBox tbSellerName;
        private System.Windows.Forms.TextBox tbSellerPassword;
        private System.Windows.Forms.TextBox tbCustomerName;
        private System.Windows.Forms.TextBox tbCustomerPassword;
        private System.Windows.Forms.Button btnSellerLogin;
        private System.Windows.Forms.Button btnCustomerLogin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lbError;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Button btnAllSellers;
        private System.Windows.Forms.Button btnAllBuyers;
    }
}

