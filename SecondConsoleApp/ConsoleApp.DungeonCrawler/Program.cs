﻿using System;
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
        internal static void movementControls(int heroX =4 ,int heroY=4, int dungeonX=7, int dungeonY=7 ) {
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

            int XMin = 2; // due to wall being in zero 
            int XMax = dungeonX-1;

            int YMax = dungeonY-1;
            int YMin = 2;

            string key;
            int command;



            do {
                Console.WriteLine("Press the Escape (Esc) key to quit: \n");
                cki = Console.ReadKey();
                Console.Clear();
                key = cki.Key.ToString();

                if (movementButtons.ContainsKey(key))
                {
                    command= movementButtons[key];
                }
                else
                {
                   command= 99;
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
                if(heroX>XMax) heroX = XMax;
                if(heroY>YMax) heroY = YMax;
                if(heroX<XMin) heroX = XMin;
                if(heroY<YMin) heroY = YMin;


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