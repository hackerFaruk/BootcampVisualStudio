using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleMarket
{
    internal class Ui: IUiPresenter
    {
        ShopAccount account;
        Shop shop;
        

        internal Ui(Shop shop, ShopAccount account)
        {
            this.shop = shop;
            this.account = account;

        }


         public void UiPresenter()
        {
            Console.Clear();
            this.shop.UiPresenter();
            Console.WriteLine("  ");
            this.shop.UiPresenter();
        }

        
        

    }
}
