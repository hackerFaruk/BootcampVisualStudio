using System.Net;
using System.Security.Cryptography;

namespace ConsoleApp.BootCampNotes.OOP.Hw1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<Player> playerList = new List<Player>();
            string nameMem;
            string surnameMem;
            string scoreMem;


            Console.WriteLine(" 5 oyuncu için isim, soyisim ve skor girmelisin ");

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($" {i+1} numaralı oyuncu için isim giriniz   ");
                nameMem = Console.ReadLine();
                Console.WriteLine($" {nameMem}  için soy isim giriniz   ");
                surnameMem = Console.ReadLine();
                Console.WriteLine($" {nameMem} {surnameMem}  için skor giriniz   ");
                scoreMem = Console.ReadLine();

                Player player = new Player(nameMem,surnameMem,scoreMem);
                playerList.Add(player);

                Console.Clear();

            }

            Console.WriteLine("girilen bilgiler");

            foreach (Player player in playerList)
            {
                Console.WriteLine(   $" {player.Name}   {player.Surname}   {player.Score}"       );
            }


        }


    }

    internal class Player
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Score { get; set; }
        public PlayerAddres Address { get; set; }
        public Player() : this("Alp", "Arslan", "5", new PlayerAddres { City = "İzmir", Country = "Turkey" })
        { }

        public Player(string name, string surname, string score, PlayerAddres address)
        {
            Name = name;
            Surname = surname;
            Score = score;
            Address = address;
        }

        public Player(string name, string surname, string score )
        {
            Name = name;
            Surname = surname;
            Score = score;
            Address = new PlayerAddres { City = "İzmir", Country = "Turkey" };
        }

        public Player(string name, string surname, string score, string city,string country)
        {
            Name = name;
            Surname = surname;
            Score = score;
            Address = new PlayerAddres { City = city, Country = country };
        }


    }

    internal class PlayerAddres {
        public string City { get; set; }
        public string Country { get; set; }

    }


}
