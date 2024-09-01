using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmartMart
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.FormClosed += Form1_FormClosed;
        }

        private void btnSeller_Click(object sender, EventArgs e)
        {
            AddUserForm form = new AddUserForm(1);
            form.ShowDialog();
        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {
            AddUserForm form = new AddUserForm(2);
            form.ShowDialog();
        }

        private void btnSellerLogin_Click(object sender, EventArgs e)
        {
            Seller seller = Program.AdminInstance.ValidateSeller(tbSellerName.Text, tbSellerPassword.Text);
            if (seller != null)
            {
                this.Hide();
                SellerForm form = new SellerForm(seller);
                form.FormClosed += Form2_FormClosed;
                form.Show();
                lbError.Text = "";
                tbSellerName.Clear();
                tbSellerPassword.Clear();
                return;
            }
            lbError.Text = "Wrong Username or Password";
        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }

        private void btnCustomerLogin_Click(object sender, EventArgs e)
        {
            Buyer buyer = Program.AdminInstance.ValidateBuyer(tbCustomerName.Text, tbCustomerPassword.Text);
            if (buyer != null)
            {
                this.Hide();
                BuyerForm form = new BuyerForm(buyer);
                form.FormClosed += Form2_FormClosed;
                form.Show();
                lbError.Text = "";
                tbCustomerName.Clear();
                tbCustomerPassword.Clear();
                return;
            }
            lbError.Text = "Wrong Username or Password";
        }
        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Program.AdminInstance.SaveData();
        }

        private void btnAllSellers_Click(object sender, EventArgs e)
        {
            AllDetailsForm form = new AllDetailsForm(1);
            form.ShowDialog();
        }

        private void btnAllBuyers_Click(object sender, EventArgs e)
        {
            AllDetailsForm form = new AllDetailsForm(2);
            form.ShowDialog();
        }
    }
}
