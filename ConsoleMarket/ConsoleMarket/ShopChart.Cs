using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleMarket
{
    internal class ShopChart
    {
        
        private Dictionary<Product,int> UserChart= new Dictionary<Product, int>();

        public void AddToChart(params Product[] products)
        {
            foreach (Product product in products)
            {
                
                if (UserChart.ContainsKey(product))
                {
                    UserChart[product]++;
                }
                else { UserChart[product] = 1; }
            }
        }

        public void ChartUiPresenter()
        {
            Console.WriteLine("Prodcut Name  Amount");

            foreach(Product product in UserChart.Keys) { 
                Console.WriteLine(product.Name + "  "+ UserChart[product]);
            }
        }
    }
}
