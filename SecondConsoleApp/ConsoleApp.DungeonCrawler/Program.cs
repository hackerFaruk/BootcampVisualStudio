using System;


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