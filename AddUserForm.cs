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
    public partial class AddUserForm : Form
    {
        private int type;
        public AddUserForm(int type)
        {
            this.type = type;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ((type == 1 && Program.AdminInstance.SellerExists(tbName.Text)) || (type == 2 && Program.AdminInstance.BuyerExists(tbName.Text)))
            {
                lbError.Text = $"Username '{tbName.Text}' is already taken.";
                return;
            }
            lbError.Text = "";

            try
            {
                int result;
                if(!int.TryParse(tbBuilding.Text, out result))
                {
                    throw new Exception("Valid Building Number is required.");
                }

                Address address = new Address
                {
                    Street = tbStreet.Text,
                    City = tbCity.Text,
                    BuildingNumber = result,
                    Country = tbCountry.Text
                };

                if (type == 1)
                {
                    Seller seller = new Seller
                    {
                        Username = tbName.Text,
                        Password = tbPassword.Text,
                        Residence = address
                    };
                    Program.AdminInstance += seller;
                }
                else if (type == 2)
                {
                    Buyer buyer = new Buyer
                    {
                        Username = tbName.Text,
                        Password = tbPassword.Text,
                        Residence = address,
                        cart = new Cart(),
                        orderHistory = new List<Order>()
                    };
                    Program.AdminInstance += buyer;
                }
            }
            catch (Exception ex)
            {
                lbError.Text = ex.Message;
                return;
            }
            this.Close();
        }
    }
}
