using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinearSearch
{
    public class Program
    {
        public static void Main(string[] args)
        {
            
        }

        public static bool LinearSearch(int[] array,int needle)
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
