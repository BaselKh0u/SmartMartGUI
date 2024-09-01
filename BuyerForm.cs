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
    internal partial class BuyerForm : Form
    {
        private Buyer buyer;
        private Seller seller;
        public BuyerForm(Buyer buyer)
        {
            this.buyer = buyer;
            InitializeComponent();
            this.Text = $"SmartMart | Buyer ({buyer.Username})";
            List<Seller> sellers = Program.AdminInstance.GetSellers();
            foreach (Seller seller in sellers)
            {
                cbSeller.Items.Add(seller);
            }

            if (sellers.Count > 0)
            {
                cbSeller.SelectedIndex = 0;
            }
            RefreshCart();
        }

        private void btnCart_Click(object sender, EventArgs e)
        {
            if (cbSeller.SelectedIndex == -1)
            {
                lbError.Text = "Kindly Select A Seller.";
                return;
            }

            if (cbProduct.SelectedIndex == -1)
            {
                lbError.Text = "Kindly Select A Product.";
                return;
            }
            lbError.Text = string.Empty;
            buyer.GetCart().AddProduct((Product)cbProduct.SelectedItem);
            RefreshCart();
        }

        private void RefreshCart()
        {
            lbCart.Text = $"🛒 Cart Items: {buyer.GetCartItemsCount()}\n" +
                $"  Total Price: {buyer.GetCart().GetTotalPrice()}$";

            listCart.Items.Clear();
            foreach (var item in buyer.cart.GetProducts())
            {
                listCart.Items.Add(item);
            }
        }
        private void btnOrderHistory_Click(object sender, EventArgs e)
        {
            OrderHistory form = new OrderHistory(buyer.orderHistory);
            form.ShowDialog();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnPurchase_Click(object sender, EventArgs e)
        {
            Order order = new Order(buyer.GetCart(), buyer);
            buyer.AddOrder(order);
            buyer.cart = new Cart();
            RefreshCart();
        }

        private void cbSeller_SelectedIndexChanged(object sender, EventArgs e)
        {
            seller = (Seller)cbSeller.SelectedItem;
            Product[] products = seller.GetProducts();
            cbProduct.Items.Clear();
            foreach (var product in products)
            {
                cbProduct.Items.Add(product);
            }

            if (products.Length > 0)
            {
                cbProduct.SelectedIndex = 0;
            }
            lbError.Text = string.Empty;
        }
    }
}
