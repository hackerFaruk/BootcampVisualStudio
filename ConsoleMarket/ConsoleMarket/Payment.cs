using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleMarket
{
    internal class Payment
    {
        public double Price = 0;
        public ShopAccount Account;

        public Payment(double price, ShopAccount account)
        {
            this.Price = price;
            this.Account = account;
        }
    }
}
