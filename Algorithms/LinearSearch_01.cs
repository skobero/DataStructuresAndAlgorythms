using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    public class LinearSearch_01
    {
        public static bool LinearSearch(int[] array, int needle)
        {
            foreach (var item in array)
            {
                if (item == needle)
                {
                    return true;
                }
            }

            return false;
        }
    }
}
