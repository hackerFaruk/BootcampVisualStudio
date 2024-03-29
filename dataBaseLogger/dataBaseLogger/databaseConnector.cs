using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Microsoft.Data.SqlClient;


namespace dataBaseLogger
{
    internal class databaseConnector
    {

        internal void testTead()
        {
            try
            {
                SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();

                builder.DataSource = "HACQER-FARUK\\SQLEXPRESS";
                builder.UserID = "sa";
                builder.Password = "123";
                builder.InitialCatalog = "testDataOne";

                // Set TrustServerCertificate=true to bypass certificate validation it is my own server 
                builder["TrustServerCertificate"] = "true";
                

                using (SqlConnection connection = new SqlConnection(builder.ConnectionString))
                {
                    Console.WriteLine("\nQuery data example:");
                    Console.WriteLine("=========================================\n");

                    connection.Open();

                    String sql = "SELECT userName FROM first_table";

                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Console.WriteLine("{0}", reader.GetString(0)); // Only retrieve the userName column
                            }
                        }
                    }
                }
            }
            catch (SqlException e)
            {
                Console.WriteLine(e.ToString());
            }
            Console.WriteLine("\nDone. Press enter.");
            Console.ReadLine();
       
        
        
        }
       


    }
}
