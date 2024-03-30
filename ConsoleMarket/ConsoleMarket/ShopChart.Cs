using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleMarket
{
    internal class ShopChart : IUiPresenter
    {

        private double TotalPrice = 0;

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

        public void UiPresenter()
        {
            TotalPrice = 0;
            Console.WriteLine($"User Chart");
            Console.WriteLine($"{"Prodcut Name",-20} {"Amount",-20}");

            foreach(Product product in UserChart.Keys) { 
                Console.WriteLine(product.Name + "  "+ UserChart[product]);
                TotalPrice += product.Price*UserChart[product]; // userchart[prodcut] gives amounts
            }
            Console.WriteLine($"total is : {TotalPrice}");
        }

        public void ClearChart()
        {
            UserChart.Clear();  
        }
    }
}
