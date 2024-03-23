namespace ConsoleApp.BootCampNotes.OOP.ReferencedObjects
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }

    public class Catagory
    {
        public string Name { get; set; }
        public int id { get; set; }

        public Catagory(int id, string name)
        {
            this.id = id;
            this.Name = name;
        }

        public Catagory() { }
    }

    public class Product
    {
        string id = Guid.NewGuid().ToString(); // this creates a specific  id for each object making all unique
    }
}
