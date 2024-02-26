using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Text;

namespace ConsoleApp.BootCampNotes
{
    internal class Program
    {
        internal static Dictionary<int, string> dayNumbers = new Dictionary<int, string>()
        {
            { 1, "Monday" },
            { 2, "Tuesday" },
            { 3, "Thursday" },
            { 4, "Wednesday" },
            { 5, "Friday" },
            { 6, "Saturday" },
            { 7, "Sunday" },
        };

        internal static Dictionary<string, int> dayNames = new Dictionary<string, int>()
        {
            { "Monday", 1 },
            { "Tuesday", 2 },
            { "Thursday", 3 },
            { "Wednesday", 4 },
            { "Friday", 5 },
            { "Saturday", 6 },
            { "Sunday", 7 },
        };

        static void Main(string[] args) {
            
            stringSwitch();

        }

        // i am gonna overloead that witch
        static int dayNum()
        {
            Console.WriteLine("haftanın kaçıncı günü ");
            int dayNum = 0;

            try {  dayNum = Convert.ToInt32(Console.ReadLine()); }

            catch { Console.WriteLine("kanka sayı girmeyi beceremedin ben senin yerine 3 gridm "); dayNum = 3;    }
                  

            Console.WriteLine(dayNumbers[dayNum]);
            return dayNum;
        }

        static void dayNum(int daynum)
        {
            switch (daynum)
            {
                case 1:
                    Console.WriteLine("sendrom günü");
                    break;
                case 2:
                    Console.WriteLine("salı sallanır");
                    break;
                case 3:
                    Console.WriteLine(" - what a week \n  + captain it is only thursday");
                    break;
                case 4:
                    Console.WriteLine("çarlamba ama from wish.com");
                    break;
                case 5:
                    Console.WriteLine("haytırlı cumalarrrrr");
                    break;
                case 6:
                    Console.WriteLine(" başım ağrrıyor ");
                    break;
                case 7:
                    Console.WriteLine("domates biber patlıcaaan");
                    break;
                default:
                    Console.WriteLine("kanka naotın kaka");
                    break;
            }
        }


        static void numGen()
        {
            int say;
            for (int i = 0; i < 10; i++)
            {
                Random randomObj = new Random();

                say=randomObj.Next(100, 200);
                Console.WriteLine(say);
            }
        }

        static void stringSwitch(){
            System.Console.WriteLine(" selam ya da melam yaz");
            string ans = Console.ReadLine();
            switch(ans){
                case "melam":
                    System.Console.WriteLine("melamın meleyküm");
                    break;
                case "selam":
                    System.Console.WriteLine("as kanka");
                    break;
                default:
                System.Console.WriteLine("sanki bi typo olduk be ");
                break;
            }


        }


    }
}
