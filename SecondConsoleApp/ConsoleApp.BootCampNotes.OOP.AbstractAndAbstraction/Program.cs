namespace ConsoleApp.BootCampNotes.OOP.AbstractAndAbstraction
{


    // abstraction dedinlen şeyi psuedo code gibi düşün
    // kural belirlemek için diyoki aga bunlar olacak olamzsa kalbini kırarım diyo 
    


    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }



    // bu class bir workerin sahip olması gereken özellikleri yazar 
    abstract class BasicWorker
    {
        public abstract double CalculatePayment();

        public abstract void Work();

        public abstract string Report();
    }


    // takım arkadşın bir Forklift srücü yapacak diyelim senin abstract worker clasından almaso lazım dedik 
    // kural olarak

    internal class ForkliftWorker : BasicWorker
    {
        // eğer abstractta istenen methodları yazmasan hata verir 
        // abstract emthodları override ata ata yazdık hepsi var artık

        public  override double  CalculatePayment()
        {
            Console.WriteLine("hesap yaptım maaşı");
            return 4.4;

        }

        public override void Work()
        {
            Console.WriteLine("büznıs büznıs");
        }

        public override string Report(
            )
        { Console.WriteLine(" reporting for duty");
            return "daily report";
        }


    }

}
