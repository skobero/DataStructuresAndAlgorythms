using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    public class BinarySearch_02
    {
        public static bool BinarySearch(int[] haystack, int needle)
        {
            int low = 0;
            int high = haystack.Length;

            do
            {
                int middle = low + (high - low) / 2;
                int value = haystack[middle];

                if (value == needle)
                {
                    return true;
                }
                else if (value > needle)
                {
                    high = middle;
                }
                else
                {
                    low = middle + 1;
                }

            } while (low < high);

            return false;
        }
    }
}
