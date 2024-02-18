using System.Data.Common;

internal class Program
{
    private static void Main(string[] args)
    {
        var options = new Dictionary<string, int>()
        {
            { "help", 0 },
            { "comparetwo", 1 },
            { "sumfive", 2 },
            { "exit", 3 },
            { "sumoddeven", 4 },
        };

        bool isRecall = true;

        Console.WriteLine("uygulama adı veriniz yada help yazarak uygulamaları görün");
        string choice = Console.ReadLine();
        int selection = options[choice];
        Console.Clear();
        switch (selection)
        {
            case 0:
                help(options);
                break;
            case 1:
                compare();
                break;
            case 2:
                sumoffive();
                break;
            case 3:
                isRecall = false;
                break;
            case 4:
                sumoddeven();
                break;
        }

        if (isRecall)
        {
            Main(args);
        }
    }

    private static void help(Dictionary<string, int> options)
    {
        Console.WriteLine("mevcut uygulamar");
        foreach (var option in options)
        {
            Console.WriteLine(option.Key);
        }
    }

    private static void compare()
    {
        int num1;
        int num2;

        Console.WriteLine("ilk sayıyı veriniz");
        try
        {
            num1 = int.Parse(Console.ReadLine());
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
            return;
        }
        Console.WriteLine("ikinci sayıyı veriniz");

        try
        {
            num2 = int.Parse(Console.ReadLine());
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
            return;
        }

        if (num1 > num2)
        {
            Console.WriteLine("sayi 1 büyük ");
        }
        else if (num1 < num2)
        {
            Console.WriteLine("sayı 2 büyük");
        }
        else
        {
            Console.WriteLine("sayılar eşit");
        }
    }

    private static void sumoffive()
    {
        Console.WriteLine("5 adet sayı giriniz ");
        int sum = 0;
        int inp = 0;

        for (int i = 0; i < 5; i++)
        {
            try
            {
                inp = int.Parse(Console.ReadLine());
                sum += inp;
            }
            catch (Exception e)
            {
                Console.WriteLine("sayı girmedin ki sen");
                return;
            }
        }
        Console.WriteLine(sum);
    }



    private static void sumoddeven()
    {

        /// <summary>
        /// Auto Complete method  <c>Draw</c>  calculates sum of numbers provided by users .
        /// </summary>
        /// 
        int evenSum = 0;
        int oddSum = 0;
        int totalSum = 0;
        int inp = 0;
        int evenCounter = 0;
        int oddCounter = 0;
        int stepAmount = 0;

        Console.WriteLine(
            " please provide some input your evens and odds numbers will summ separtely"
        );

        for (int i = 0; i < stepAmount; i++)
        {
            try
            {
                inp = int.Parse(Console.ReadLine());
                totalSum += inp;

                if (inp % 2 == 0)
                {
                    evenSum = evenSum + inp;
                    evenCounter++;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("sayı girmedin ki sen");
                return;
            }

            oddCounter = stepAmount - evenCounter;
            oddSum = totalSum - evenSum;
            Console.WriteLine("girilen  sayıların toplamı: " + totalSum);

            Console.WriteLine(
                "girilen tek sayı sayısı: " + oddCounter + "   bu sayıların toplamı: " + oddSum
            );
            Console.WriteLine(
                "girilen çift sayı sayısı: " + evenCounter + "   bu sayıların toplamı: " + evenSum
            );
        }
    }


    /// <summary>
    /// Auto Complete method  <c>Draw</c>  Aims to midigate  user typos while input for program selected is provided by user.
    /// </summary>
    private static int autoComplete( string userInput, Dictionary<string, int> options)
    {
        // user input is input given  by user 
        // dictonary is list of functions we provide 
        // this funntion returns case number from options hashmap to use in switch case loop

        // to ensure being case insensitive
        userInput = userInput.ToLower();


        foreach ( var option in options)
        {
           // foreach possible selection in options we need a check to see if our query match any of them 
        }

    }


}
