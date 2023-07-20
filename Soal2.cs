using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace main
{
    class Soal2
    {
        public static List<int> GITSRank(List<int> currentRank, List<int> gitsScore)
        { 
            currentRank.Sort();
            currentRank.Reverse();

            // merge current leaderboard score with gits score to get total leaderboard status
            List<int> mergeScore = new List<int> {  };
            mergeScore.AddRange(currentRank);
            // mergeScore.AddRange(gitsScore);
            mergeScore.Sort();
            mergeScore.Reverse();

            // remove the duplicate score
            mergeScore = mergeScore.Distinct().ToList();

            List<int> gitsEndRank = new List<int> { };

            // get the rank of each gits score
            gitsScore.ForEach((i) =>
            {
                foreach(int j in mergeScore)
                {
                    if (i >= j)
                    {
                        gitsEndRank.Add(mergeScore.IndexOf(j) + 1);
                        break;
                    }

                    if(i < j && mergeScore.IndexOf(j) == mergeScore.Count - 1)
                    {
                        gitsEndRank.Add(mergeScore.Count + 1);
                    }
                }
            });

            return gitsEndRank;
        }
    }
}