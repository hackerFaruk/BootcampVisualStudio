using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleMarket
{
    internal class Shop
    {
        public string Name{get; private set; }

        List<Seller> SellerList = new List<Seller>();
        // adds all sellers 

        List<Product> ShopFront = new List<Product>();

        public Shop(string name)
        {
            Name = name;
        }
    }
}
