using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleMarket
{

    internal class ShopAccount
    {
        public string adress { get; private set; }
        public ShopChart userChart {  get; private set; }
        public string userId { get; private set; }
        public Person user {  get; private set; }


        /// <summary>
        /// Generates chart for user, holds user values like adrress information
        /// </summary>
        /// <param name="userChart"></param>
        /// <param name="user"></param>
        /// <param name="adress"></param>
        public ShopAccount( ShopChart userChart, Person user , string adress = "İzmir, KSK" )
        {
            this.userChart = new ShopChart();
            this.adress = adress;
            this.user= user;
            this.userId = Guid.NewGuid().ToString();

        }

       

    }
}
