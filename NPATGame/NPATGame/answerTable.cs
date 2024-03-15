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

        int[]? playerPoints = null;
        string[]?[] allAnswers = new string[]?[4];


        public answerTable(int player_num)
        {

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
        public void calculatePoints()
        {

            Dictionary<string, int> answers = new Dictionary<string, int>(); ;
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


            }




        }







    }
}
