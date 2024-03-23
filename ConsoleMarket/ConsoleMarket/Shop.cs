using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleMarket
{
    internal class Shop
    {
       public String Name {  get; private set; }   // allows every one to see name but only constructor to set it 
       public List<Product> Products = new List<Product>();

        public Shop(string name) {
            this.Name = name;

        }
        


    }
}
