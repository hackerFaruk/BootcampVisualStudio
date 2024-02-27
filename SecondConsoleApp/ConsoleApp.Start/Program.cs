using System;
using System.Diagnostics;
using System.Text;
using ConsoleApp.DungeonCrawler; //  porjeme ters tıklayıp add project refrence diyince usingde öneri olarak geldi bu

// DungeonCrawler game içindeki dungeon crawler static olduğu için objesisz çağırıyom




namespace ConsoleApp.Start
{
    internal class Program
    {
        internal static Dictionary<int, string> opertaionsList = new Dictionary<int, string>();

        private static string appName = " Thats Second Version of My App";

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

            // ctrl k s yapıp zınk diye yazım koddu 
            for (int i = 0; i < 3; i++)
            {

                Console.WriteLine("bi isim giriniz ");

                string isimInput = Console.ReadLine();

                if (isimInput == "") { Console.WriteLine("iisim girmeyene loop yok agaaa breaktım gittim bb "); break; }

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


                isimInput = isimInput.Remove(0, 1);
                Console.WriteLine(isimInput); 
            }



         
        }



        static void stringMakerStudio()
        {
            // unlike python csharp need s some speciality to append
            // basically it is a linked list 

            StringBuilder myStringBuilder = new StringBuilder("Hello World!");
            Console.WriteLine(myStringBuilder);
            myStringBuilder.Append(" What a beautiful day!");
            Console.WriteLine(myStringBuilder);
            myStringBuilder.Append(" What a beautiful day!");
            Console.WriteLine(myStringBuilder);

            // bu append line işine bi bak hacım ya o yürümedi 
            myStringBuilder.AppendLine(" What a beautiful day.");
            Console.WriteLine(myStringBuilder.ToString());


            myStringBuilder.Remove(5, 7);
            Console.WriteLine(myStringBuilder);


            myStringBuilder.Replace('!', '?');
            Console.WriteLine(myStringBuilder);
           
        }
    }
}
