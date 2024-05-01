using EFAppHw.Models;

namespace EFAppHw
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using NorthwindContext context = new NorthwindContext();

            Show show = new Show(context);

            show.CustomerByRegion("s");



        }
    }
}
