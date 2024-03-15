using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace NPATGame
{
    internal class answerTable
    {

        string[]? nameStage = null;
        string[]? placeStage = null;
        string[]? animalStage = null;
        string[]? thingStage = null;

        int[] playerPoints = [];
        string[]?[] allAnswers = new string[]?[4];

        int player_count;


        public answerTable(int player_num)
        {
            player_count = player_num;

            string[]?[] allAnswers = { nameStage, placeStage, animalStage, thingStage };

            for (int i = 0; i < 4; i++)
            {
                allAnswers[i] = new string[player_num];
            }
            playerPoints = new int[player_num];
            for (int i = 0; i < player_num; i++)
            {
                playerPoints[i] = 0;
            }

        }
        public int[] calculatePoints()
        {

            Dictionary<string, int> answers = new Dictionary<string, int>();
            string[] mem;


            for (int i = 0; i < 4; i++)
            {
                mem = allAnswers[i];

                foreach (string ans in mem)
                {
                    if (answers.ContainsKey(ans))
                    {
                        answers[ans]++;

                    }
                    else
                    {
                        answers[ans] = 1;
                    }
                }

                for (int j = 0; i < player_count; i++)
                {
                    // maksimum 10 puanı cevap veren oyuncu sayısana bölüp oyuncu puanına ekler 
                    playerPoints[j] += 10 / answers[mem[j]];
                }


            }
            return playerPoints;




        }







    }
}
