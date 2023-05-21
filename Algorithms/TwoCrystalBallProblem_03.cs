using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    public class TwoCrystalBallProblem_03
    {
        public static int TwoCrystalBalls(bool[] breaks)
        {
            int jumpAmount = (int)Math.Floor(Math.Sqrt(breaks.Length));

            int i = jumpAmount;

            for (; i < breaks.Length; i += jumpAmount)
            {
                if (breaks[i])
                {
                    break;
                }
            }

            i -= jumpAmount;

            for (int j = 0; j < jumpAmount && i < breaks.Length; ++j,++i)
            {
                if (breaks[i])
                {
                    return i;
                }
            }

            return -1;
        }
    }
}
