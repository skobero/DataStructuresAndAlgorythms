using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsTests
{
    public class QuickSortTest
    {
        [Fact]
        public void TestQuicksortWithRandomArray()
        {
            // Arrange
            int[] arr = new int[] { 11, 1, 4, 8, 10, 9, 2, 6, 7, 3, 5 };
            int[] expected = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11 };

            // Act
            Algorithms.QuickSort_06.QuickSort(arr, 0, arr.Length - 1);

            // Assert
            Assert.Equal(expected, arr);
        }

        [Fact]
        public void TestQuicksortWithEmptyArray()
        {
            // Arrange
            int[] arr = new int[0];

            // Act
            Algorithms.QuickSort_06.QuickSort(arr, 0, arr.Length - 1);

            // Assert
            Assert.Empty(arr);
        }

        [Fact]
        public void TestQuicksortWithAlreadySortedArray()
        {
            // Arrange
            int[] arr = new int[] { 1, 2, 3, 4, 5 };
            int[] expected = new int[] { 1, 2, 3, 4, 5 };

            // Act
            Algorithms.QuickSort_06.QuickSort(arr, 0, arr.Length - 1);

            // Assert
            Assert.Equal(expected, arr);
        }

        [Fact]
        public void TestQuicksortWithArrayWithDuplicateValues()
        {
            // Arrange
            int[] arr = new int[] { 5, 2, 8, 2, 1, 5, 8, 5, 9, 1, 2 };
            int[] expected = new int[] { 1, 1, 2, 2, 2, 5, 5, 5, 8, 8, 9 };

            // Act
            Algorithms.QuickSort_06.QuickSort(arr, 0, arr.Length - 1);

            // Assert
            Assert.Equal(expected, arr);
        }
    }
}
