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
    internal partial class OrderHistory : Form
    {
        private List<Order> orders;
        public OrderHistory(List<Order> orders)
        {
            this.orders = orders;
            InitializeComponent();
            listOrders.Items.Clear();
            foreach (var item in this.orders)
            {
                listOrders.Items.Add("Products:");
                foreach (var product in item.Products)
                {
                    listOrders.Items.Add(product);
                }
                listOrders.Items.Add($"Total Price: {item.TotalPrice}$");
                listOrders.Items.Add("__________________________________________________");
                listOrders.Items.Add(string.Empty);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
