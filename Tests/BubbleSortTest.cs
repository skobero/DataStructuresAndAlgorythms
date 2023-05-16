using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsTests
{
    public class BubbleSortTest
    {
        [Fact]
        public void BubbleSortIsSorted()
        {
            // Arrange
            int[] unsortedArray = { 9, 4, 6, 2, 1, 5, 8, 7, 3 };
            int[] sortedArray = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            // Act
            Algorithms.BubbleSort_04.BubbleSort(ref unsortedArray);

            // Assert
            Assert.Equal(sortedArray, unsortedArray);
        }
    }
}
