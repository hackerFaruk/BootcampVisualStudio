using System;
using System.Collections.Generic;
using System.Linq;
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


        public answerTable(int player_num)
        {

            string[]?[] allAnswers = { nameStage, placeStage, animalStage, thingStage };

            for (int i = 0; i < 4; i++)
            {
                allAnswers[i] = new string[player_num];
            }
            playerPoints = new int[player_num];

        }
        public void calculatePoint() { }







    }
}
