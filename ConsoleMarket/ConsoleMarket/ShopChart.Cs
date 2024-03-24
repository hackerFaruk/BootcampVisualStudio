using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleMarket
{
    internal class ShopChart
    {
        private List<Product> ProductList = new List<Product>();

        public void AddToChart(params Product[] products)
        {
            foreach (Product product in products)
            {
                ProductList.Add(product);
            }
        }
    }
}
