namespace ConsoleApp.BootCampNotes.OOP.ReferencedObjects
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }

    public class Category
    {
        public string Name { get; set; }
        public int id { get; set; }

        public Category(int id, string name)
        {
            this.id = id;
            this.Name = name;
        }

        public Category() { }
    }

    public class Product
    {

        public string id { get; private set; } = Guid.NewGuid().ToString();
        // this creates a specific  id for each object making all unique
        // private set makes it only settable within this class

        public Category Category { get; set; } = new Category(); // catagorye referance atttık
    }
}
