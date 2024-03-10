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
        }



        internal class PaymentMaker()
        {
          internal void GetPaid()
            {
                Console.WriteLine("OOO maaşlar yatttıııı");
            }
        }



    }
}
