namespace ConsoleApp.BootCampNotes.OOP.GetterSetter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Worker worker = new Worker();
            worker.Salary = 100;  // this is setter
            Console.WriteLine(worker.Salary);  // this runs getter
            worker.Salary = -100; // setter prevents values lower than zero
            Console.WriteLine(worker.Salary);  // this runs getter
        }
    }

    internal class Worker
    {
        private int _salary; // bu private başına alt çizgi alışkanlık pitonda gibi anlamlı değil



        public int Salary
        { // bu da genel version
            get { return _salary; }
            set { _salary = (value > 0) ? value : 0; }
        }
    }
}
