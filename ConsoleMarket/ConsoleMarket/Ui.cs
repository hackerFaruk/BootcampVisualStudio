using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleMarket
{
    internal class Ui : IUiPresenter
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

        public void UiPresenter()
        {
            this.shop.UiPresenter();
            Console.WriteLine("  ");
            this.shop.UiPresenter();
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
            this.UiPresenter();
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
            }
            else
            {
                Console.WriteLine("unknown command ");
            }
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
