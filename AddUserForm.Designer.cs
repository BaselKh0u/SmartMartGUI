namespace SmartMart
{
    partial class AddUserForm
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
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.tbStreet = new System.Windows.Forms.TextBox();
            this.tbBuilding = new System.Windows.Forms.TextBox();
            this.tbCity = new System.Windows.Forms.TextBox();
            this.tbCountry = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.lbError = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbName
            // 
            this.tbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbName.Location = new System.Drawing.Point(65, 59);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(500, 55);
            this.tbName.TabIndex = 0;
            // 
            // tbPassword
            // 
            this.tbPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPassword.Location = new System.Drawing.Point(65, 179);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(500, 55);
            this.tbPassword.TabIndex = 1;
            // 
            // tbStreet
            // 
            this.tbStreet.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbStreet.Location = new System.Drawing.Point(65, 303);
            this.tbStreet.Name = "tbStreet";
            this.tbStreet.Size = new System.Drawing.Size(500, 55);
            this.tbStreet.TabIndex = 2;
            // 
            // tbBuilding
            // 
            this.tbBuilding.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbBuilding.Location = new System.Drawing.Point(65, 427);
            this.tbBuilding.Name = "tbBuilding";
            this.tbBuilding.Size = new System.Drawing.Size(500, 55);
            this.tbBuilding.TabIndex = 3;
            // 
            // tbCity
            // 
            this.tbCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCity.Location = new System.Drawing.Point(65, 559);
            this.tbCity.Name = "tbCity";
            this.tbCity.Size = new System.Drawing.Size(500, 55);
            this.tbCity.TabIndex = 4;
            // 
            // tbCountry
            // 
            this.tbCountry.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCountry.Location = new System.Drawing.Point(65, 687);
            this.tbCountry.Name = "tbCountry";
            this.tbCountry.Size = new System.Drawing.Size(500, 55);
            this.tbCountry.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(65, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 29);
            this.label1.TabIndex = 6;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(65, 147);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 29);
            this.label2.TabIndex = 7;
            this.label2.Text = "Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(65, 268);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 29);
            this.label3.TabIndex = 8;
            this.label3.Text = "Street";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(70, 392);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 29);
            this.label4.TabIndex = 9;
            this.label4.Text = "Building";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(65, 524);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 29);
            this.label5.TabIndex = 10;
            this.label5.Text = "City";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(65, 652);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 29);
            this.label6.TabIndex = 11;
            this.label6.Text = "Country";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(107, 816);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(400, 100);
            this.button1.TabIndex = 12;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbError
            // 
            this.lbError.AutoSize = true;
            this.lbError.ForeColor = System.Drawing.Color.Firebrick;
            this.lbError.Location = new System.Drawing.Point(38, 775);
            this.lbError.Name = "lbError";
            this.lbError.Size = new System.Drawing.Size(0, 29);
            this.lbError.TabIndex = 13;
            // 
            // AddUserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(657, 1121);
            this.Controls.Add(this.lbError);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbCountry);
            this.Controls.Add(this.tbCity);
            this.Controls.Add(this.tbBuilding);
            this.Controls.Add(this.tbStreet);
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(this.tbName);
            this.Name = "AddUserForm";
            this.Text = "SmartMart | Add User";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.TextBox tbStreet;
        private System.Windows.Forms.TextBox tbBuilding;
        private System.Windows.Forms.TextBox tbCity;
        private System.Windows.Forms.TextBox tbCountry;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lbError;
    }
}