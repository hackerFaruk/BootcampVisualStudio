using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleMarket
{
    internal class Ui
    {
        ShopAccount account;
        Shop shop;
        string commandInput = "";

        enum Page
        {
            shop,
            payment,
        }

        Page current = Page.shop;

        internal Ui(Shop shop, ShopAccount account)
        {
            this.shop = shop;
            this.account = account;
        }

        public void StartUi()
        {
            DisplayShopPage();
            GetCommands();
        }

        public void ShopUiPresenter()
        {
            this.shop.UiPresenter();
            Console.WriteLine("  ");
            this.account.UiPresenter();
            Console.WriteLine("  ");
        }

        public void HelpLine()
        {
            Console.WriteLine(
                "Type prodcut number to add to basket, clr to clear basket and pay to proceed with basker"
            );
        }

        public void DisplayShopPage()
        {
            Console.Clear();
            this.ShopUiPresenter();
            this.HelpLine();
        }

        public void GetCommands()
        {
            commandInput = Console.ReadLine().ToLowerInvariant();

            if (commandInput == "clr")
            {
                account.ClearChart();
                DisplayShopPage();
            }
            else if (isPossibleProductNum(commandInput))
            {
                account.AddToChart(shop.SelectProductByNumber(int.Parse(commandInput)));
                DisplayShopPage();
            }
            else if (commandInput == "pay")
            {
                if (this.account.UserChart.TotalPrice > 0)
                {
                    DisplayShopPage();
                    Console.WriteLine(" pending ");
                }
                else if (this.account.UserChart.TotalPrice == 0)
                {
                    DisplayShopPage();
                    Console.WriteLine(" you dont have anything on your basket ");
                }
            }
            else
            {
                DisplayShopPage();
                Console.WriteLine("unknown command ");
            }
            this.GetCommands();
        }

        private bool isPossibleProductNum(string numInput)
        {
            try
            {
                if (int.Parse(numInput) > shop.maksProdutNum)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
