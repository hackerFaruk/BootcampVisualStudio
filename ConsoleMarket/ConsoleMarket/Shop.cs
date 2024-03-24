using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleMarket
{
    internal class Shop
    {
        public string Name { get; private set; }

        private List<Seller> SellerList = new List<Seller>();

        // adds all sellers

        private List<Product> ShopFront = new List<Product>();

        public Shop(string name)
        {
            Name = name;
        }

        public void AddSeller(params Seller[] sellerList) { }

        // takes from list of sellers to shop list doesnt allows someone from outside adding
        // any products only sellers can add
        private void AddProduct()
        {
            foreach (Seller seller in SellerList)
            {
                foreach (Product product in seller.ProductList)
                {
                    ShopFront.Add(product);
                }
            }
        }
    }
}
