using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    public class Matrix
    {
        public static string LongestCommonSubstring(string string1, string string2)
        {
            int[,] matrix = new int[string1.Length + 1, string2.Length + 1];
            int maxLength = 0;
            int maxI = 0;
            int maxJ = 0;

            for (int i = 1; i <= string1.Length; i++)
            {
                for (int j = 1; j <= string2.Length; j++)
                {
                    if (string1[i - 1] == string2[j - 1])
                    {
                        matrix[i, j] = matrix[i - 1, j - 1] + 1;
                        if (matrix[i, j] > maxLength)
                        {
                            maxLength = matrix[i, j];
                            maxI = i;
                            maxJ = j;
                        }
                    }
                }
            }

            return string1.Substring(maxI - maxLength, maxLength);
        }
    }
}
