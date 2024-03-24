using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleMarket
{
    internal class Product
    {
        public string Id { get; private set; } = Guid.NewGuid().ToString();

        // this line allows getting Guid of product from anywhere but you cant change product id
        public double Price;
        public string Name;

        public string? SellerName; 

        public Product(string name, double price)
        {
            this.Name = name;
            this.Price = price;
        }
    }
}
