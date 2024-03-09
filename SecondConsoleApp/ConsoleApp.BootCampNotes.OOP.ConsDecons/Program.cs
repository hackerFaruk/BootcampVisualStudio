namespace ConsoleApp.BootCampNotes.OOP.ConsDecons
{
    internal class Program
    {
        public static int counter = 0;
        static void Main(string[] args)
        {
            Person mahmut = new Person();
            Person memo = new Person("memo");

            mahmut.Salut();
            memo.Salut();

            GC.Collect(); // call garbage collector 

            // tuuş basılana kadar beklesin

            for(int i = 0; i < 10; i++) {
                
                Person memoli = new Person();
              
            }
            // GArbage collector cağırak çop toplamyı istedik her toplama counter arttırdı
            // ancak kod çok hızlı yürüdüğü için sayacaı göremedik 
            // console ready key bize bekleme şansı verdi
            GC.Collect();
            Console.WriteLine(counter);
            Console.ReadKey();
            Console.WriteLine(counter);

        }
    }

    internal class Person
    {
        public string Name { get; set; }
        public Person()
        {
            Console.WriteLine("Default Constructor was called.");
            Name = "default";
        }

        public Person(string name)
        {
            Console.WriteLine($"Parameterized Constructor was called for {name}");
            Name  = name;
        }

        ~Person()
        {
            Program.counter++;
            Console.WriteLine($"Destructor was called for {Name} Person .");
        }
        public void Salut()
        {

            Console.WriteLine($"hello i am {Name}");
        }

    }



}
