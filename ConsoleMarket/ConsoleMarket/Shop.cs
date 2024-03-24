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

        private List<Seller> SellerList = new List<Seller>();
        // adds all sellers 

        private List<Product> ShopFront = new List<Product>();

        public Shop(string name)
        {
            Name = name;
        }


        public void AddSeller( params Seller[] sellerList)
        {

        }
    }
}
