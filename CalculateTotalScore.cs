using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculateScore
{
    public class CalculateTotalScore
    {
        public static int GetTotalScores(int[] number)
        {
            int score = 0;

            foreach (int digit in number)
            {
                if (digit % 2 == 0)
                {
                    score += 1;
                    if (digit == 8)
                    {
                        score += 5;
                    }
                }
                else
                {
                    score += 3;
                }
            }

            return score;


        }
    }
}
