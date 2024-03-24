using System.Security.Cryptography.X509Certificates;


namespace ConsoleMarket
{
    internal class Program
    {

        // to do
        //  Shop +
        //  Customer ( Bank Card  Chart)
        //   Payment ( Bank Shop)



        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

           ShopChart chart = new ShopChart();
           

            Shop MaketPlace = createShop();

            
        }



       public static Shop createShop()
        {
            Product Shovel = new Product("Shovel" , 15.0);
            Product Flash = new Product("ProFlashLight", 7.5);
            Product Radio = new Product("Radio", 10.0);
            Product Ladder = new Product("Ladder", 20.0);
            Product Spray = new Product("Spray Paint", 5.0);
            Product Horn = new Product("Loud Horn", 3.0);

            // sellers can be created and then add products
            Seller Company = new Seller("Company");
            Seller Merchant = new Seller("The Merchant");

            // you can add products one by one or as many as you want
            Company.AddProduct(Shovel);
            Company.AddProduct(Flash);
            Merchant.AddProduct(Ladder, Radio);

            // or seller can be created and added products at the same time 
            Seller Porkrind = new Seller("Porkrind",Spray,Horn);

            Shop MarketPlace = new Shop("AllInHere", Company,Merchant,Porkrind);
            return MarketPlace;
        }
        

    }
        
}
