using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NPATGame
{
    internal class answerTable
    {






        internal Dictionary<string, string[]> CreateAnswerHashMap(int playerCount)
        {
            Dictionary<string, string[]> answersHash = new Dictionary<string, string[]>();

            string[] placeHolder = new string[playerCount];  // a space for each players answers

            foreach (string stage in stageNames)
            {
                answersHash[stage] = placeHolder;
            }

            return answersHash;

        }



    }
}
