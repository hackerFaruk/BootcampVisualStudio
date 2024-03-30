using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleMarket
{

    internal class ShopAccount : AccountBase
    {
        public string adress { get; private set; }
        public ShopChart userChart {  get; private set; }
        public string userId { get; private set; }
        public Person accountOwner {  get; private set; }


        /// <summary>
        /// Generates chart for user, holds user values like adrress information
        /// </summary>
        /// <param name="accountOwner"> gets a  person and it is inherited from account base </param>
        /// <param name="adress"> it has a default value if not give n during creation </param>
        public ShopAccount( Person accountOwner, string adress = "İzmir, KSK" ) : base(accountOwner)
        {
            this.userChart = new ShopChart();
            this.adress = adress;
            this.accountOwner = accountOwner;
            this.userId = Guid.NewGuid().ToString();

        }

       

    }
}
