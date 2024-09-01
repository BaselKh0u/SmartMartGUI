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
    internal partial class SellerForm : Form
    {
        private Seller seller;
        public SellerForm(Seller seller)
        {
            this.seller = seller;
            InitializeComponent();
            this.Text = $"SmartMart | Seller ({seller.Username})";
            cbCategory.Items.Clear();
            cbCategory.Items.Add(Product.ProductCategory.Electronics);
            cbCategory.Items.Add(Product.ProductCategory.Clothing);
            cbCategory.Items.Add(Product.ProductCategory.Children);
            cbCategory.Items.Add(Product.ProductCategory.Office);
            cbCategory.SelectedIndex = 0;
            RefreshProducts();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                int price;
                if (!int.TryParse(tbPrice.Text, out price))
                {
                    throw new Exception("Kindly Enter A valid Price.");
                }

                int pprice;
                if (!int.TryParse(tbPackagingPrice.Text, out pprice))
                {
                    throw new Exception("Kindly Enter A valid Packaging Price.");
                }

                Product product = new Product
                {
                    Name = tbName.Text,
                    Price = price,
                    Category = (Product.ProductCategory)cbCategory.SelectedItem,
                    SpecialPackaging = cbSpecialPackaging.Checked,
                    PackagingPrice = pprice
                };

                seller.AddProduct(product);
                MessageBox.Show("Product Added Successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                RefreshProducts();
            }
            catch (Exception ex)
            {
                lbError.Text = ex.Message;
            }
        }

        private void cbSpecialPackaging_CheckedChanged(object sender, EventArgs e)
        {
            if (cbSpecialPackaging.Checked)
            {
                tbPackagingPrice.Enabled = true;
            }
            else
            {
                tbPackagingPrice.Text = "0";
                tbPackagingPrice.Enabled = false;
            }
        }

        void RefreshProducts()
        {
            listProducts.Items.Clear();
            foreach (var item in seller.GetProducts())
            {
                listProducts.Items.Add(item);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
