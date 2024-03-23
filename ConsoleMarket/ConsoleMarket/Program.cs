using System.Security.Cryptography.X509Certificates;

namespace ConsoleMarket
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }

        static  void createSellers()
        {
            Product Shovel = new Product("Shovel" , 15.0);
            Product Flash = new Product("ProFlashLight", 7.5);
            Product Radio = new Product("Radio", 10.0);
            Product Ladder = new Product("Ladder", 20.0);


            Seller Company = new Seller("Company");
            Seller Merchant = new Seller("The Merchant");


            Company.Products.Add(Shovel);
            Company.Products.Add(Flash);

            Merchant.Products.Add(Radio);   
            Merchant.Products.Add(Ladder);






        }


    }
}
