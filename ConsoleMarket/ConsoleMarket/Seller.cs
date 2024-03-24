using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleMarket
{
    /// <summary>
    /// Seller has list of Products 
    /// </summary>
    internal class Seller
    {
        public String Name { get; private set; } // allows every one to see name but only constructor to set it
        
        private List<Product> Products = new List<Product>();
        // private because i want you to use add method below

        public Seller(string name)
        {
            this.Name = name;
        }

        public Seller(string name, params Product[] products)
        {
            this.Name = name; 
            this.AddProduct(products);
        }

        public void AddProduct(Product product)
        {
            Products.Add(product);
            product.SellerName = this.Name;
        }

        public void AddProduct(params Product[] products)
        {
            foreach (Product product in products) {
                Products.Add(product);
                product.SellerName = this.Name;
            }
           
        }



    }
}
