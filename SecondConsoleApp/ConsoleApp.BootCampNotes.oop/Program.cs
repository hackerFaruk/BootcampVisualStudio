using System;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Channels;
using static System.Net.Mime.MediaTypeNames;

namespace ConsoleApp.BootCampNotes.oop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Advanced.TreeMaker(); /// inheritlediği için bu var 
            Advanced.StumpTreeMaker();
            
        }
    }

    public class Test
    {
        // test clasında bir değişken oluşturduk
        public static string name = "alp";

        

    }

    public class Basics
    {
        public static void TreeMaker()
        {

            string line = "";
            char leaf = '*';

            for (int i = 0; i < 10; i++)
            {
                string currentLine = new string(leaf, i);
                string whiteSpace = new string(' ', 10 - i);
                line += whiteSpace;
                line += currentLine;
                line += leaf; // for mid linee
                line += currentLine;

                Console.WriteLine(line);
                line = "";
            }
        }
    }

    public  class Advanced:Basics
    {
        public static void StumpTreeMaker()
        {
            TreeMaker(); // inheritlediği için direkt çağrıyo
            string stumpLine = new string('*', 3);
            string whiteSpace = new string(' ', 9);
            for (int i = 0;i < 4; i++)
            {
                Console.WriteLine(whiteSpace+stumpLine);
            }
        }
    }


    internal class Inherter : Test
    {

        // test clasının inheritleyen bu yapı name değişkenine ulaştı 
        static void master()
        {
        Console.WriteLine(name);
        }
    }
}
