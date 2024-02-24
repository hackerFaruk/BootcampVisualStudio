using System;
using System.Collections.Generic;
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

            dungeonCrawlerGame.movementControls();
        }
    }

    public class dungeonCrawlerGame
    {



        // game settings
        private static int heroX = 4;
        private static int heroY = 4;
        private static int dungeonX = 17;
        private static int dungeonY = 7;

        private static int[] heroPosition = [heroX, heroY];
        private static int[] endPortalPositions = [dungeonX - 2, dungeonY - 2];






        public static void dungeonCrawler()
        {


            // it also consist gameplay currently but i want to add some systerm for it to  
            movementControls() ;

        }

        /// <summary>
        ///  Developed hero controls. Now your hero cant move out of dungeon border 
        /// </summary>
       
        internal static void movementControls()
        {
            // it has default values of 4 4 on hero location
            // in here wasd will be converted to hero location but it will also prevent moveing to walls
            // so if dungeon x*y  maks movement range 1 to x-1 and 1 to y-1


       
            int heroX = dungeonCrawlerGame.heroX;
            int heroY = dungeonCrawlerGame.heroY;
            int dungeonX = dungeonCrawlerGame.dungeonX;
            int dungeonY = dungeonCrawlerGame.dungeonY;

            ConsoleKeyInfo cki;

            Dictionary<string, int> movementButtons = new Dictionary<string, int>()
            {
                { "W", 1 },
                { "A", 2 },
                { "S", 3 },
                { "D", 4 },
            };

            int XMin = 2; // due to wall being in zero
            int XMax = dungeonX - 1;

            int YMax = dungeonY - 1;
            int YMin = 2;

            string key;
            int command;

            do
            {
               
                cki = Console.ReadKey();
                Console.Clear();
                Console.WriteLine("Press the Escape (Esc) key to quit: \n");
                key = cki.Key.ToString();

                if (movementButtons.ContainsKey(key))
                {
                    command = movementButtons[key];
                }
                else
                {
                    command = 99;
                }

                // instead of making key.tostring in each if switch case allows one transform
                switch (command)
                {
                    case 1:
                        // W pressed upwards movement
                        heroY--;
                        break;
                    case 2:
                        // A pressed letf movement
                        heroX--;
                        break;
                    case 3:
                        // S pressed down movement
                        // increased y means lower position
                        heroY++;
                        break;
                    case 4:
                        // S pressed right movement
                        heroX++;
                        break;
                    default:
                        // beeps if another key pressed
                        Console.Beep();
                        break;
                }

                // hero position limit check
                if (heroX > XMax)
                    heroX = XMax;
                
                if (heroY > YMax)
                    heroY = YMax;
                
                if (heroX < XMin)
                    heroX = XMin;
                
                if (heroY < YMin)
                    heroY = YMin;


                //printDungeon(heroX, heroY);
                renderDungeon(heroX, heroY);
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
            char endPortal = '0';

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
            Console.WriteLine($"hero pos x: {heroX}    y: {heroY} ");
        }


        internal static void renderDungeon(int heroX = 4, int heroY = 4)
        {
            // it need to take matrice and print it on screen

            // Define the dimensions playable area inside dungeon
            int rows = dungeonX - 2;
            int cols = dungeonY - 2;

            string horizontalWall = new string('-', dungeonX * 2 - 1);
            char verticalWall = '|';

            string currentLine = "";
            char hero = '@';
            char endPortal = '0';

            // Create a 2D array (matrix) with the specified dimensions
            char[,] dungeonSpace = new char[rows, cols];


            // Initialize the matrix with '_' characters using nested loops
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    dungeonSpace[i, j] = '_';
                }
            }


            // set hero position 
            // herox 2 heroy 2 en sol üst köşe
            // herox dungeonx-1 heroy dungeon-1 en sağ alt köşe


            dungeonSpace[heroX - 2, heroY - 2] = hero;
           




            // üst duvar 
            Console.WriteLine(horizontalWall);


            // get length 0 is rows 
            //get length 1 is cols 

            for (int j = 0; j < dungeonSpace.GetLength(1); j++)
            {
                currentLine = "| ";
                for (int i = 0; i < dungeonSpace.GetLength(0); i++)
                {
                    currentLine = currentLine + dungeonSpace[ i,j ] +" " ;
                }
                currentLine = currentLine + verticalWall;
                Console.WriteLine(currentLine);
            }

            //alt duvar
            Console.WriteLine(horizontalWall);
            Console.WriteLine($"hero pos x: {heroX}    y: {heroY} ");

        }


    }
}
