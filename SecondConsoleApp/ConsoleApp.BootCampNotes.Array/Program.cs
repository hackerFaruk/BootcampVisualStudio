using System.Runtime.CompilerServices;

namespace ConsoleApp.BootCampNotes.Array
{
    internal class Program
    {

        // array verileri dip dibe oluşturur array tek bir blok halinde içinde farklı verriler tutar.



        // int[] sayilar = new int[2]   iki int koymalık alanı tanımlar 
        static internal int[] intValues = new int[2];
        

        // içindekileri biliyorsan süslü parantez ile eklme yapabilirsin 
        static internal int[] myNum = { 10, 20, 30, 40 };




        static internal void ArrayMaker()
        {
            int[] numx;
            numx = new int[2];


        }

        // Array eleman sayısını ister liste ise eleman sayısı olmadan rahatça hareket eder
        // diyelim ki  kaç eleman kullancan bilmiyrosun 

        static internal List<int> myList = new List<int>();

        static internal void ListLister() {
            myList.Add(1);
            Console.WriteLine("listemin ilk hali");
            foreach (int i in myList) { Console.WriteLine(i); }
            myList.Add(14);
            myList.Add(13);
            myList.Add(12);
            Console.WriteLine("listemin yeni hali");
            foreach (int i in myList) { Console.WriteLine(i); }
        }



        static void Main(string[] args)
        {
            // sayilar[sayilar.lenth -1 ] son eleman
            Console.WriteLine(myNum[myNum.Length-1]);

            coolOneLiner(3);
          
        }


        static void learnMethos()
        {
            string name = "hallo-mein-name-ist";

            string[] spell = name.Split('-'); // split by - 

            for (int i  = 0; i < spell.Length; i++) { Console.WriteLine(spell[i]); }
            foreach (string i in spell) {  Console.WriteLine(i); }


        }


        static void learnNullables()
        {
            //  si keskin  diilinde sayısal deeğerler null olmaz default değerleri sıfırdır
            int[] numx;
            numx = new int[2];
            Console.WriteLine(numx[1]);
            // sıfırı yazar null değer almaz çünkü int 

            int? myNullableint= null;
            // soru işareti koyunca nullable oldu bak 
            Console.WriteLine("here is my null val:");
            Console.WriteLine(myNullableint);

            int?[] myNuılalbleintarr = new int?[2];
            Console.WriteLine("here is my null val:");
            Console.WriteLine(myNuılalbleintarr[1]);
        }


        static void OrAndCombo()
        {

            if( true & (true || false))
            {
                Console.WriteLine("koşulları parantezle kombolomak mümkün");
            }
        }


        static void coolOneLiner(int num)
        {
            string result = "";

            result = (num % 2 == 0) ? "çifttir" : "tektir";

            Console.WriteLine(result);

            int[] numbers = { 2, 3, 4, 5 };
            var squaredNumbers = numbers.Select(x => x * num);
            Console.WriteLine(string.Join(" ", squaredNumbers));


            Console.WriteLine((num % 2 == 0) ? "çifttir" : "tektir");

        }

    }
}
