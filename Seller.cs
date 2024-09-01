using System;
using System.Linq;

namespace SmartMart
#pragma warning disable CS0659
{
    [Serializable]
    internal class Seller : User
    {
        private Product[] products;
        private int productCount;

        public Seller() : base() { }
        public Seller(string username, string password, Address residence)
            : base(username, password, residence)
        {
            products = new Product[2];
            productCount = 0;
        }
        public void AddProduct(Product product)
        {
            if (products == null)
            {
                products = new Product[4]; 
                productCount = 0; 
            }

            if (productCount >= products.Length)
            {
                Array.Resize(ref products, products.Length * 2);
            }
            products[productCount++] = product;
            Console.WriteLine("Product added successfully!\n");
        }
        public Product[] GetProducts()
        {
            if (products == null)
            {
                return new Product[0]; 
            }

            return products.Take(productCount).ToArray();
        }
        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }

            Seller other = (Seller)obj;
            return Username == other.Username && Password == other.Password && Residence.Equals(other.Residence);
        }

        public string StringView()
        {
            string productString = string.Join(", \n", GetProducts().Select(p => p.ToString()));
            if (productCount == 0)
            {
                productString = "There are no available products!";
            }
            return $"Seller Name: {Username}\nPassword: {Password}\nAddress: {Residence}\n\nProducts:\n{productString}\n";
        }

        public override string ToString()
        {
            return $"{Username} ({productCount})";
        }
    }
}
