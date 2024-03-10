using System.Threading.Channels;
using System.Xml;

namespace ConsoleApp.BootCampNotes.OOP.Interfaces
{



    // Bu programda Interface bakcaz 
    // diyelim ki 3 farklı tipte ödeme alan çalışnlar için bi ödeme alt yapısı kurcaz 
    // 3 farklı ödeme tipi için calslar lazım

    // freelancer çalıştığı saat başına 

    // monthlyPaid aylık düzende çalışan

    // projectPaid  proje bazlı anlaşma ile çalışan


    // Hepsinde ortak olan  getPaid fonksiyonu hepsinde parayı ibana atıyor bu yüzden normal inheritlenebilir


    // ancak hepsinin maaşını hepsaplayan farklı methodlar lazım.
    // bunları kolayca hatırlkamak için hepsinin adının aynı olmasını sağlicaz bu interface ilel oluyr 




    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            Freelancer memo = new Freelancer();
            MonthlyPaid tarık = new MonthlyPaid();
            ProjectWorker veli = new ProjectWorker();

            BaseWorker[] staff = new BaseWorker[] { veli,tarık,memo };

            foreach (BaseWorker worker in staff)
            {
                worker.WhoAmI();
            }



        }



        // bu class  çalışanın temel özelliklerini kapsar
        internal class BaseWorker()
        {
          internal void GetPaid()
            {
                Console.WriteLine("OOO maaşlar yatttıııı");
            }

          internal void Work()
            {
                Console.WriteLine("iş yapılıyor....");
            }

            internal virtual void WhoAmI()
            {
                Console.WriteLine(" I am a Worker");
            } 
        }




        // Biz sistemi ekip halinde yazıyoruz ve herkesin CalculatePayment Methodunu içermesini ü
        // istiyoruz o zaman interface oluşturmamız lazım
        // 

         internal interface  IPayment
        {
            // hiç bir body  yok sadece bu isimde bir method olmasını zorunlu kılar 
            public int CalculatePayment();
        }


        // sadece bir clas inheritler ama limitsiz Interface alır
        internal class Freelancer:BaseWorker , IPayment
        {
            internal override void WhoAmI()
            {
                base.WhoAmI();
                Console.WriteLine("I work freelance get paid on hourly basis ");

            }
            public int CalculatePayment()
            {
                Console.WriteLine("this method aaded by I");
                return 0 ;
            }
        }

        internal class MonthlyPaid:BaseWorker
        {
            internal override void WhoAmI()
            {
                Console.WriteLine("I work 9 to 5 and get paid on monthly basis ");

            }
        }

        internal class ProjectWorker:BaseWorker
        {
            internal override void WhoAmI()
            {
                Console.WriteLine("I work on project basis and get paid whenever project is done  ");
            }
        }


    }
}
