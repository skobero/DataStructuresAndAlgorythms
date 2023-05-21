using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    public class QuickSort_06
    {

        public static void QuickSort(int[] array, int low,int high )
        {
            if (low > high)
            {
                return;
            }

            int pivotIdx = partition(array, low, high);

            QuickSort(array, low, pivotIdx - 1);
            QuickSort(array, pivotIdx + 1, high);
        }

        private static int partition(int[] array,int low,int high)
        {
            int pivot = array[high];
            int idx = low -1;

            for (int i = low; i < high; i++)
            {
                if (array[i] < pivot)
                {
                    idx++;

                    int temp = array[i];
                    array[i] = array[idx];
                    array[idx] = temp;
                }
            }

            idx++;
            array[high] = array[idx];
            array[idx] = pivot;

            return idx;
        }
    }
}
