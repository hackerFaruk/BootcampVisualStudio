using System.Runtime.CompilerServices;

namespace ConsoleApp.BootCampNotes.Array
{
    internal class Program
    {

        // array verileri dip dibe oluşturur array tek bir blok halinde içinde farklı verriler tutar.



        // int[] sayilar = new int[2]   iki int koymalık alanı tanımlar 
        static public int[] intValues = new int[2];
        

        // içindekileri biliyorsan süslü parantez ile eklme yapabilirsin 
        static public int[] myNum = { 10, 20, 30, 40 };

        // Array eleman sayısını ister liste ise eleman sayısı olmadan rahatça hareket eder
        // 

        static void Main(string[] args)
        {
            // sayilar[sayilar.lenth -1 ] son eleman
            Console.WriteLine(myNum[myNum.Length-1]);
        }


    }
}
