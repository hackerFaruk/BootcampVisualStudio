using System.Collections;
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
            //Console.WriteLine(myNum[myNum.Length-1]);

            //coolOneLiner(3);
            //winnerofThree();
            variableArrayCount();
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

        static  void doubleQuestionMark()
        {
            // ?? 
            // The Null Coalescing Operator (??)
            // is a binary operator that returns the left-hand operand if it is not null;
            // otherwise, it returns the right-hand operand.
            // bu şu demek x ?? y eğer x null değilse x al eğer x null ise y al

            string data = null;
            string lastData = data ?? "new data ";
        }



        static void winnerofThree()
        {
            var rand = new Random();

            int tug=rand.Next(200);
            Console.WriteLine($"Tug değeri {tug}");

            int esr = rand.Next(200);
            Console.WriteLine($"Esr değeri {esr}");

            int kasa = rand.Next(200);
            Console.WriteLine($"Kasa değeri {kasa}");


            int maxVal = 0;
            int maxPos = 0;

            int[] values = {tug, esr, kasa};

            for (int i = 0; i < values.Length; i++)
            {
               if (values[i] > maxVal)
                {
                    maxVal = values[i];
                    maxPos = i;
                }
            }


            switch(maxPos)
            {
                case 0:
                    Console.WriteLine("Tug kazanır");
                break;
                case 1:
                    Console.WriteLine("Esr kazanır");
                break;
                case 2:
                    Console.WriteLine("Kasa kazanır");
                break;

            }

        }
    
        static void variableArrayCount()
        {

            // rastgele sayıda array üretip tutmak için 

            var rand = new Random();

            int arraycount = rand.Next(2,5);
            

            int[] randomNumbers = new int[arraycount];

            ArrayList allNumbers = new ArrayList();

            for (int i = 0; i < arraycount; i++)
            {
                for (int j = 0; j < arraycount; j++)
                {
                    randomNumbers[j] = rand.Next(100);
                }
                allNumbers.Add(randomNumbers);
            }


            int counter = 0;
            foreach(int[] item in allNumbers)
            {
                Console.WriteLine($"array num {counter}");
                counter++;
                Console.WriteLine("array içeriği");
                
                foreach(int i in item)
                {
                    Console.WriteLine(i);
                }
            }
            

        }
    
    }
}
