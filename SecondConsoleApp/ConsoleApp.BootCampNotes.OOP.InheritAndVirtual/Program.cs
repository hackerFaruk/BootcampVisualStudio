namespace ConsoleApp.BootCampNotes.OOP.InheritAndVirtual
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cat neco = new Cat();
            neco.MakeSound();  // overridelı olduğu için cat içindeki çalışttı
            neco.Run();    // run oveeride olmadığı için animal içi çalıştı 
        }
    }


    internal class Animal
    {
        // virtul allows for override
        public virtual void MakeSound()
        {
            Console.WriteLine( "This soun made by an animal");
        } 
        public void Run()
        {
            Console.WriteLine("this animal runs on 4 legs");
        }
    }

    internal class Cat : Animal
    {
public override void MakeSound()
        {
            Console.WriteLine("MEOoow");
        }

        // override olmadığı için inheritlenen şey çalışıor 
        public  void Run()
        {
            Console.WriteLine("this animal runs on 4 legs");
        }
    }
}
