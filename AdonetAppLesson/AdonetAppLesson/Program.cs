using System.Data.SqlClient;



namespace AdonetAppLesson
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // sql server object explorerdan aldık bunu
            // Trust server certifacte önmeli
            // initial catalog ve trust cefrtificate elle eklendi
            string connectionString = "Data Source=HACQER-FARUK\\SQLEXPRESS;Integrated Security=True;Connect Timeout=30;Encrypt=True;TrustServerCertificate=True;Initial Catalog=testDataOne";

            string queryString = " SELECT * from first_table";

            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();


            // sorgu çalıştır 
            SqlCommand command = new SqlCommand(queryString, connection);


            SqlDataReader reader = command.ExecuteReader();
            Console.WriteLine("Bağlanılıyor");
            while (reader.Read())
            {

                Console.WriteLine($"ad {reader["userName"]}");
            }



        }
    }
}
