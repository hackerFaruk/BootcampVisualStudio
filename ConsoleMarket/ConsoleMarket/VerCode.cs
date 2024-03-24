using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.Text;

namespace ConsoleMarket
{
    internal static class VerCode
    {


        public static void hashTest()
        {
            string input = "Hello, world!";
            string hashedString = ComputeSHA256Hash(input);
            Console.WriteLine("Input string: " + input);
            Console.WriteLine("SHA256 hash: " + hashedString);
        }

        static string ComputeSHA256Hash(string input)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] inputBytes = Encoding.UTF8.GetBytes(input);
                byte[] hashBytes = sha256.ComputeHash(inputBytes);

                // Convert the byte array to a hexadecimal string
                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < hashBytes.Length; i++)
                {
                    builder.Append(hashBytes[i].ToString("x2"));
                }
                return builder.ToString();
            }
        }







           public static void FileTest()
        {
            // Define the path for the text file
            string filePath = "../../../test.txt";

            // Write to a text file
            WriteToFile(filePath);

            // Read from the text file
            ReadFromFile(filePath);
        }

        static void WriteToFile(string filePath)
        {
            try
            {
                // Write some content to the file
                using (StreamWriter writer = new StreamWriter(filePath))
                {
                    writer.WriteLine("Hello, this is some text written to a file.");
                    writer.WriteLine("This is another line.");
                    writer.WriteLine("And one more line for good measure.");
                }
                Console.WriteLine("Text written to file successfully.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred while writing to the file: {ex.Message}");
            }
        }

        static void ReadFromFile(string filePath)
        {
            try
            {
                // Read content from the file
                using (StreamReader reader = new StreamReader(filePath))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        Console.WriteLine(line); Console.WriteLine("REadinggg");
                    }
                }
                Console.WriteLine("Text read from file successfully.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred while reading from the file: {ex.Message}");
            }
        }



    }
}
