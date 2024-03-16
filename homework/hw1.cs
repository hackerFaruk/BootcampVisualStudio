

namespace Homework
{
    internal class Homework
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            Freelancer memo = new Freelancer();
            MonthlyPaid tarık = new MonthlyPaid();
            ProjectWorker veli = new ProjectWorker();

            BaseWorker[] staff = new BaseWorker[] { veli, tarık, memo };

            foreach (BaseWorker worker in staff)
            {
                worker.WhoAmI();
            }



        }



        // bu class  çalışanın temel özelliklerini kapsar
        internal class Player()
        {

        }






        // sadece bir clas inheritler ama limitsiz Interface alır
        internal class PlayerAdress
        {

        }


    }
}
