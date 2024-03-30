using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleMarket
{

    internal class ShopAccount : AccountBase , IUiPresenter
    {
        public string Adress { get; private set; }
        public ShopChart UserChart {  get; private set; }
        public string UserId { get; private set; }
        //public Person AccountOwner  this is inherited bu account base so no need to declare here s


        /// <summary>
        /// Generates chart for user, holds user values like adrress information
        /// Manages ShopChart
        /// </summary>
        /// <param name="accountOwner"> gets a  person and it is inherited from account base </param>
        /// <param name="adress"> it has a default value if not give n during creation </param>
        public ShopAccount( Person accountOwner, string adress = "İzmir, KSK" ) : base(accountOwner) // account owner data passed to account base ss
        {
            this.UserChart = new ShopChart();
            this.Adress = adress;
            
            this.UserId = Guid.NewGuid().ToString();

        }

       public void AddToChart(params Product[] products)
        {
            this.UserChart.AddToChart(products);
        }

        public void ShowChart()
        {
           this.UserChart.UiPresenter();
        }

        public void UiPresenter()
        {
            this.UserChart.UiPresenter();
        }


    }
}
