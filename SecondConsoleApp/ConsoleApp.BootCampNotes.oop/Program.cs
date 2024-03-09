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
        }
    }

    internal class Test
    {
        // test clasında bir değişken oluşturduk
        public static string name = "alp";
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
