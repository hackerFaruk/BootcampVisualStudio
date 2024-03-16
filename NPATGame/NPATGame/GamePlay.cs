using System;
using System.Collections.Generic;
using System.Formats.Asn1;
using System.Linq;
using System.Linq.Expressions;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace NPATGame
{
    internal class GamePlay
    {
        internal char Letter;

        internal int CurrentStage = 0;

        internal string[] stageNames = { "İsim", "Yer", "Hayvan", "Eşya" };

        public static char[] possibleChars =
        {
            'a',
            'b',
            'c',
            'd',
            'e',
            'f',
            'g',
            'h',
            'i',
            'j',
            'k',
            'l',
            'm',
            'n',
            'o',
            'p',
            'q',
            'r',
            's',
            't',
            'u',
            'v',
            'w',
            'x',
            'y',
            'z'
        };

        static string[] turns = { "Name", "Place", "Animal", "Thing" };

        int letterAmount = possibleChars.Length;

        static int playerCount = 0;

        Random rand = new Random();

        /// <summary>
        /// This Method Allows You Select a Letter For Game and Stroes it in to Letter
        /// </summary>
        internal void SelectLetter()
        {
            int randomNumber = rand.Next(letterAmount);
            Letter = possibleChars[randomNumber];
        }

        /// <summary>
        /// This method gets amount of players and stores it in playerCount
        /// </summary>
        internal bool GetPlayerCount()
        {
            Console.WriteLine("Enter How Many Players You Will Have");
            playerCount = ReadIntFromConsole();

            if (playerCount == 0)
            {

                return true;
            }
            return false;
        }



        /// <summary>
        /// This function ensures an integer is read from console if not return 0
        /// </summary>
        /// <returns> int  IntFromConsole </returns>
        internal int ReadIntFromConsole()
        {
            string? read = Console.ReadLine();
            int result = 0;

            if (read == "exit")
            {
                return 0;
            }

            try
            {
                result = int.Parse(read);
            }
            catch
            {
                Console.WriteLine(" Int vermedin, ya int ver ya exit yaz");
                ReadIntFromConsole();
            }

            return result;
        }

        /// <summary>
        ///  gets user names from console and returns an array of names
        /// </summary>
        /// <returns>  resturns array of user names </returns>
        internal string[] GetPlayerNames()
        {
            string?[] memorizer = new string[playerCount];

            Console.Clear();

            for (int i = 0; i < playerCount; i++)
            {
                Console.WriteLine($"Oyuncu {i + 1} için isim giriniz");
                memorizer[i] = Console.ReadLine();
                Console.Clear();
            }

            return memorizer;
        }

        internal Player[] CreatePlayers(string[] playerNames)
        {
            Player[] playerList = new Player[playerCount];

            for (int i = 0; i < playerCount; i++)
            {
                playerList[i] = new Player();
                playerList[i].name = playerNames[i];
            }

            return playerList;
        }

        internal void StartGame()
        {
            Console.Clear();
            Console.WriteLine("NPAT Game is about to start");
            Console.WriteLine("When you are ready press any key ");
            Console.ReadKey();
            Console.Clear();

        }

        internal void StageManager(Player[] playerList)
        {

            answerTable answerTable = new answerTable(playerCount);
            string input = "";

            for (int j = 0; j < 4; j++)
            {
                string stage = turns[j];

                for (int i = 0; i < playerList.Length; i++)
                {

                    Console.WriteLine($"Seçili Harf {Letter}");
                    Console.WriteLine(
                        $"{Letter} harfi ile başlayan bir {stage} söylemeniz lazım"
                    );
                    Console.WriteLine($" Şuan Sıra sende {playerList[i].name}, cevabını yaz ve entera bas");
                    // read answers and assign them in to a table here 
                    input = Console.ReadLine();
                    answerTable.assignAnswer(j, i, input);
                    Console.Clear();

                    // then just calculate points by table and declare thems


                }
            }

            int[] playerPoint = answerTable.calculatePoints();
            for(int i = 0 ; i < playerCount; i++){
                Console.WriteLine($" {playerList[i].name} : {playerPoint[i]}");
            }
        }

        public void Play()
        {
            SelectLetter();
            bool isPlayerCountZero = GetPlayerCount();
            if (isPlayerCountZero)
            {
                Console.WriteLine("ending game due to zero player count ");
                return;
            }
            string[] playerNames = GetPlayerNames();
            Player[] playerList = CreatePlayers(playerNames);
            StartGame();
            StageManager(playerList);
        }
    }
}
