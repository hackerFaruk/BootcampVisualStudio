using System;
using ConsoleApp;
using static System.Runtime.InteropServices.JavaScript.JSType;


namespace ConsoleApp.DungeonCrawler
{
    internal class Program
    {

        private static string appName = " This is Dungeon Crawlerr";

        static void Main(string[] args)
        {
            Console.WriteLine(appName);
            dungeonCrawlerGame.dungeonCrawler();

        }
    }


    public class dungeonCrawlerGame
    {
        public static void dungeonCrawler()
        {
            ConsoleKeyInfo cki;

            int heroX = 4;
            int heroY = 4;

            do
            {
                Console.WriteLine("Press the Escape (Esc) key to quit: \n");
                cki = Console.ReadKey();
                Console.Clear();
                // since upper most line is zero this works a little diffrent in Y direction
                if (cki.Key.ToString() == "W")
                {
                    heroY--;
                }
                else if (cki.Key.ToString() == "D")
                {
                    heroX++;
                }
                else if (cki.Key.ToString() == "S")
                {
                    heroY++;
                }
                else if (cki.Key.ToString() == "A")
                {
                    heroX--;
                }
                printDungeon(heroX, heroY);
            } while (cki.Key != ConsoleKey.Escape);
        }



        /// <summary>
        /// IT is a better movement coantrol scheme that can employ obstacle avoidance
        /// </summary>
        /// <param name="heroX"> It holds horizontal position of hero </param>
        /// <param name="heroY"> It holds vertical position of hero </param>
        internal static void movementControls(int heroX =4 ,int heroY=4 ) {
            // it has default values of 4 4 on hero location 
            // in here wasd will be converted to hero location but it will also prevent moveing to walls 
            // so if dungeon x*y  maks movement range 1 to x-1 and 1 to y-1 

            ConsoleKeyInfo cki;

            Dictionary<string, int> movementButtons = new Dictionary<string, int>()
        {
            {"W", 1},
            {"A", 2},
            {"S", 3},
            {"D", 4},
            };

             string key;





            do {
                cki = Console.ReadKey();

                switch (movementButtons[cki.Key.ToString()])
                {
                    case 1:
                        // W pressed upwards movement
                        Console.WriteLine("Number is 1");
                        break;
                    case 2:
                        // A pressed letf movement
                        Console.WriteLine("Number is 2");
                        break;
                    case 3:
                        // S pressed down movement
                        Console.WriteLine("Number is 3");
                        break;
                        case 4:
                        // S pressed right movement
                        Console.WriteLine("Number is not 1, 2, or 3");
                        break;
                    default:
                        // beeps if another key pressed 
                        Console.Beep();
                        break;
                }



                // hero position limit check 

                printDungeon(heroX, heroY);

            } while (cki.Key != ConsoleKey.Escape);





            do
            {
                Console.WriteLine("Press the Escape (Esc) key to quit: \n");
                cki = Console.ReadKey();
                Console.Clear();
                // since upper most line is zero this works a little diffrent in Y direction
                if (cki.Key.ToString() == "W")
                {
                    heroY--;
                }
                else if (cki.Key.ToString() == "D")
                {
                    heroX++;
                }
                else if (cki.Key.ToString() == "S")
                {
                    heroY++;
                }
                else if (cki.Key.ToString() == "A")
                {
                    heroX--;
                }
                printDungeon(heroX, heroY);
            } while (cki.Key != ConsoleKey.Escape);



        }



        public static void printDungeon(int heroX, int heroY)
        {
            int dungeonWidth = 7;
            int dungeonHeight = 7;

            string horizontalWall = new string('-', dungeonWidth);
            // used single ' ' to indicate char
            char verticalWall = '|';
            char emptySpace = '_';
            string emptyLine = new string('_', dungeonWidth - 2);
            emptyLine = verticalWall + emptyLine + verticalWall;

            char hero = '@';

            int leftSide = heroX - 1 - 1; // -1 for wall and -1 for hero space
            int rightSide = dungeonWidth - heroX - 1; // -1 for horizontalWall

            string herorightside = new string('_', rightSide);
            string heroLine = new string('_', leftSide);
            heroLine = '|' + heroLine + hero + herorightside + '|';

            // the Dungeon Printing Part

            Console.WriteLine(horizontalWall);

            for (int i = 0; i < dungeonHeight - 2; i++)
            {
                if (i != (heroY - 2))
                {
                    Console.WriteLine(emptyLine);
                }
                else
                {
                    Console.WriteLine(heroLine);
                }
            }
            Console.WriteLine(horizontalWall);
        }
    }




}