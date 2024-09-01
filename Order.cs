using System;
using System.Collections.Generic;
using System.Linq;

namespace SmartMart
#pragma warning disable CS0659
{
    [Serializable]
    internal class Order
    {
        public List<Product> Products;
        public int ProductCount;
        public double TotalPrice;
        public Buyer Buyer;

        public Order(Cart cart, Buyer buyer)
        {
            this.Products = cart.GetProducts();
            this.ProductCount =  cart.GetProductCount();
            this.TotalPrice = cart.GetTotalPrice();
            this.Buyer = buyer;
        }

        public Order(List<Product> products, int productCount, double totalPrice, Buyer buyer)
        {
            this.Products = products;
            this.ProductCount = productCount;
            this.TotalPrice = totalPrice;
            this.Buyer = buyer;
        }

        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }

            Order other = (Order)obj;
            return TotalPrice == other.TotalPrice && Buyer.Equals(other.Buyer) && Products.SequenceEqual(other.Products);
        }
        public override string ToString()
        {
            string productsString = "";
            for (int i = 0; i < ProductCount; i++)
            {
                productsString = productsString + Products[i].ToString() + ", ";
            }
            return $"Products:\n{productsString}\nTotal Price: {TotalPrice}$\n\n";
        }
    }
}
