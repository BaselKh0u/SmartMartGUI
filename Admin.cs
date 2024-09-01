using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;

namespace SmartMart
{
    internal class Admin
    {
        private string description;
        public List<Buyer> buyers;
        public List<Seller> sellers;

        public Admin(List<Buyer> buyers, List<Seller> sellers, string description)
        {
            this.description = description;
            this.buyers = buyers;
            this.sellers = sellers;
        }

        public void SaveData()
        {
            using (FileStream fs = new FileStream("buyers.dat", FileMode.Create))
            {
                BinaryFormatter formatter = new BinaryFormatter();
                formatter.Serialize(fs, buyers);
            }

            using (FileStream fs = new FileStream("sellers.dat", FileMode.Create))
            {
                BinaryFormatter formatter = new BinaryFormatter();
                formatter.Serialize(fs, sellers);
            }
        }

        public void FetchData()
        {
            try
            {
                if (File.Exists("buyers.dat"))
                {
                    using (FileStream fs = new FileStream("buyers.dat", FileMode.Open))
                    {
                        BinaryFormatter formatter = new BinaryFormatter();
                        buyers = (List<Buyer>)formatter.Deserialize(fs);
                    }
                }


                if (File.Exists("sellers.dat"))
                {
                    using (FileStream fs = new FileStream("sellers.dat", FileMode.Open))
                    {
                        BinaryFormatter formatter = new BinaryFormatter();
                        sellers = (List<Seller>)formatter.Deserialize(fs);
                    }
                }

            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.ToString());
            }
        }

        public Admin()
        {
            description = "No Name";
            buyers = new List<Buyer>();
            sellers = new List<Seller>();
        }

        public Admin(string description)
        {
            this.description = description;
            buyers = new List<Buyer>();
            sellers = new List<Seller>();
        }

        public void AddBuyer(string username, string password, Address address)
        {
            buyers.Add(new Buyer(username, password, address));
        }

        public void AddSeller(string username, string password, Address address)
        {
            sellers.Add(new Seller(username, password, address));
        }

        public void AddProductToSeller(string sellerUsername, string productName, double price, Product.ProductCategory category, bool specialPackaging)
        {
            Seller seller = sellers.FirstOrDefault(s => s != null && s.Username == sellerUsername);
            if (seller == null)
            {
                Console.WriteLine("Error, seller not found.");
                return;
            }
            if (seller.GetProducts().Any(p => p.Name == productName))
            {
                Console.WriteLine("Error, this product/item already exists in your product selling items.");
                return;
            }

            Product product;
            if (specialPackaging)
            {
                product = new SpecialProduct(productName, price, category);
            }
            else
            {
                product = new Product(productName, price, category);
            }
            seller.AddProduct(product);
        }

        public void AddProductToBuyerCart(string buyerUsername, string productName)
        {
            Buyer buyer = buyers.FirstOrDefault(b => b != null && b.Username == buyerUsername);
            if (buyer == null)
            {
                Console.WriteLine("Error, buyer not found.");
                return;
            }
            if (buyer.cart == null)
            {
                buyer.cart = new Cart();
            }
            Seller seller = sellers.FirstOrDefault(s => s != null && s.GetProducts().Any(p => p.Name == productName));
            if (seller == null)
            {
                Console.WriteLine("Error, this product does not exist!");
                return;
            }
            Product product = seller.GetProducts().FirstOrDefault(p => p.Name == productName);
            if (product != null)
            {
                buyer.cart.AddProduct(product);
                Console.WriteLine($"Product has been added successfully to {buyerUsername}'s cart.");
            }
        }

        public void PayForOrder(string buyerUsername)
        {
            Buyer buyer = buyers.FirstOrDefault(b => b != null && b.Username == buyerUsername);
            double totalPrice = buyer.cart.GetTotalPrice();
            if (buyer == null)
            {
                Console.WriteLine("Error, buyer not found.");
                return;
            }

            else if (buyer.cart == null || buyer.cart.GetProductCount() <= 1)
            {
                Console.WriteLine("Sorry, you can't pay with 1 product in your cart");
                return;
            }

            else if (totalPrice > 0)
            {
                Order order = new Order(buyer.cart, buyer);
                buyer.AddOrder(order);
                buyer.cart = new Cart();
                Console.WriteLine($"Order paid successfully. Total price: ${totalPrice}");
                Console.WriteLine("Items in the order:");
                foreach (var product in order.Products)
                {
                    Console.WriteLine($"- {product.Name} (${product.Price})");
                }
            }

            else
            {
                Console.WriteLine("The cart is empty");
            }
        }

        public void DisplayBuyers()
        {
            if (buyers == null || buyers.Count == 0)
            {
                Console.WriteLine("There are no buyers");
                return;
            }

            foreach (Buyer buyer in buyers)
            {
                if (buyer == null)
                {
                    Console.WriteLine("Encountered a null buyer.");
                }
                else
                {
                    Console.WriteLine(buyer.ToString());
                }
            }
        }

        public void DisplaySellers()
        {
            if (sellers.Count == 0)
            {
                Console.WriteLine("There are no sellers");
                return;
            }
            foreach (var seller in sellers.OrderByDescending(s => s.GetProducts().Count()))
            {
                Console.WriteLine(seller.ToString());
            }
        }

        public void DisplayAvailableProducts()
        {
            foreach (var seller in sellers)
            {
                Console.WriteLine($"Seller name: {seller.Username}\n");
                foreach (var product in seller.GetProducts())
                {
                    Console.WriteLine(product.ToString());
                }
            }
        }

        public bool BuyerExists(string buyerUsername)
        {
            return buyers.Any(b => b != null && b.Username == buyerUsername);
        }

        public bool SellerExists(string sellerUsername)
        {
            return sellers.Any(s => s != null && s.Username == sellerUsername);
        }

        public bool ProductExists(string productName)
        {
            return sellers.Any(s => s != null && s.GetProducts().Any(p => p.Name == productName));
        }
        public List<Buyer> GetBuyers()
        {
            return buyers;
        }
        public List<Seller> GetSellers()
        {
            return sellers;
        }
        public int GetBuyersCounter()
        {
            return buyers.Count;
        }
        public int GetSellersCounter()
        {
            return sellers.Count;
        }
        public string GetDescription()
        {
            return description;
        }

        public Seller ValidateSeller(string username, string password)
        {
            foreach (var seller in sellers)
            {
                if (username == seller.Username && password == seller.Password)
                {
                    return seller;
                }
            }
            return null;
        }

        public Buyer ValidateBuyer(string username, string password)
        {
            foreach (var buyer in buyers)
            {
                if (username == buyer.Username && password == buyer.Password)
                {
                    return buyer;
                }
            }
            return null;
        }

        public static Admin operator +(Admin admin, Buyer buyer)
        {
            admin.buyers.Add(buyer);
            Console.WriteLine("A new buyer added successfully!");
            return admin;
        }

        public static Admin operator +(Admin admin, Seller seller)
        {
            admin.sellers.Add(seller);
            Console.WriteLine("A new seller added successfully!");
            return admin;
        }
    }
}
