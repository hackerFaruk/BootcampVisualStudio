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
        public string? Name { get; set; }
        public int Id { get; set; }

        public Category(int Id, string name)
        {
            this.Id = Id;
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


    public class Compute
    {
        public virtual int basicCompute()
        {
            return 3 - 5;
        }
    }

    public class Calculator : Compute {

        public override int basicCompute()
        {
            return base.basicCompute() *43 ; // base.MethodName runs base virtual method so this abstract can built on it 
        }
    }

}
