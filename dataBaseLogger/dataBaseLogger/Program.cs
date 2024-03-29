namespace dataBaseLogger
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            databaseConnector connector = new databaseConnector();
            connector.makeConnection();

        }
    }
}
