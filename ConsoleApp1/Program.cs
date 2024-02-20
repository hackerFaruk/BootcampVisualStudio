using System.Data.Common;
using System.Text.RegularExpressions;
using System;
using System.Runtime.CompilerServices;

internal class Program
{

    // needs to be static for methods reach it 
    public static string name = "My Great Console";
 


    private static void Main(string[] args)
    {
        var options = new Dictionary<string, int>()
        {
            { "help", 0 },
            { "comparetwo", 1 },
            { "sumfive", 2 },
            { "exit", 3 },
            { "sumoddeven", 4 },
            {"keydetect" ,5 },
            
        };

        bool isRecall = true;


        Console.WriteLine(name);
        
        Console.WriteLine("uygulama adı veriniz yada help yazarak uygulamaları görün");
        string choice = ""; // prevents nulll
        choice = Console.ReadLine();


        // for test purposes autocomplete runs for each input and provides  result
        autoComplete(choice, options);




        int selection = options[choice];
       //  Console.Clear();  // clear is closed to see auto complete performance 
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
            case 5:
                keydetect();
                break;
            
        }

        if (isRecall)
        {
            // if exit command is given isRecal becomes false preventing recursion and 
            // ending this applciation 
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



    public static void keydetect()
    {
        ConsoleKeyInfo cki;
        // Prevent example from ending if CTL+C is pressed.
        Console.TreatControlCAsInput = true;

        Console.WriteLine("Press any combination of CTL, ALT, and SHIFT, and a console key.");
        Console.WriteLine("Press the Escape (Esc) key to quit: \n");
        do
        {
            cki = Console.ReadKey();
            Console.Write(" --- You pressed ");
            if ((cki.Modifiers & ConsoleModifiers.Alt) != 0) Console.Write("ALT+");
            if ((cki.Modifiers & ConsoleModifiers.Shift) != 0) Console.Write("SHIFT+");
            if ((cki.Modifiers & ConsoleModifiers.Control) != 0) Console.Write("CTL+");
            Console.WriteLine(cki.Key.ToString());
        } while (cki.Key != ConsoleKey.Escape);
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
                Console.WriteLine("sayı girmedin ki sen " + e);
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
                Console.WriteLine("sayı girmedin ki sen " + e);
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
    private static void autoComplete( string userInput, Dictionary<string, int> options)
    {
        // user input is input given  by user 
        // dictonary is list of functions we provide 
        // this funntion returns case number from options hashmap to use in switch case loop

        // to ensure being case insensitive
        userInput = userInput.ToLower();

        // takes possible options in array so i can move easier in 
        string[] keywords = options.Keys.ToArray();

        // to asses porrisblity of each match we give points 
        int[] possiblity =  new int[keywords.Length];


        


        // create regex here

        foreach ( var key in keywords)
        {
            

            if (key.StartsWith(userInput))
            {
                Console.WriteLine("Pattern found at " + key);
                break;

            }
            else { Console.WriteLine("cantt find"); }

            // during this loop also create points 
            if (key.Length == userInput.Length)
            {
                Console.WriteLine("exact length match ");
            }
            else if( key.Length* 0.8 <= userInput.Length  && userInput.Length <= key.Length *1.2   )
            { Console.WriteLine("lenght match found "); }
            


        }


        

    }


}
