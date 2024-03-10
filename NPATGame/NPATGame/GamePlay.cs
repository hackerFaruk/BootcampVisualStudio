﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace NPATGame
{
    internal class GamePlay
    {
        public char Letter;

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

        public int letterAmount = possibleChars.Length;

        int playerCount = 0;

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
        internal void GetPlayerCount()
        {
            Console.WriteLine("Oyuna Başlamadan Önce Lütfen Kaç kişi");
            playerCount = ReadIntFromConsole();

            if (playerCount == 0)
            {
                Console.WriteLine("Oyuncu olmadığı için Oyun Bitiriliyor ");
                return;
            }
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
    

       
        internal string[] GetPlayerNames() { }

    }
}