using System;
using ConsoleApp.DungeonCrawler; //  porjeme ters tıklayıp add project refrence diyince usingde öneri olarak geldi bu

// DungeonCrawler game içindeki dungeon crawler static olduğu için objesisz çağırıyom




namespace ConsoleApp.Start
{
    internal class Program
    {
        internal static Dictionary<int, string> opertaionsList = new Dictionary<int, string>();

        private static string appName = " Thats Second Version of My app";

        static void Main(string[] args)
        {
            Console.WriteLine(appName);
            nameChechker();
        }

        static void keyDetetc()
        {
            ConsoleKeyInfo cki;

            do
            {
                cki = Console.ReadKey();
                Console.Clear();
                Console.WriteLine("şuan basılan tuş");
                Console.WriteLine(cki.Key.ToString());
                ;
            } while (cki.Key != ConsoleKey.Escape);
        }

        /// <summary>
        /// ders uygulması ders 6
        /// </summary>
        static void nameChechker()
        {
            Console.WriteLine("bi isim giriniz ");

            string isimInput = Console.ReadLine();

            if (isimInput.Length > 7)
            {
                Console.Beep();
                Console.WriteLine("isimin cok uzun ben  sana ke diycem");
                Console.Beep();
            }
            else if (isimInput == "alp")
            {
                Console.WriteLine("sen ben misin");
            }
            else
            {
                Console.WriteLine("akılda turması kolay isim");
            }
        }
    }
}
