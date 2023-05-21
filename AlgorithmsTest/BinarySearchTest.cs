using Algorithms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsTests
{
    public class BinarySearchTest
    {
        [Fact]
        public void BinarySearch_Found_ReturnsTrue()
        {
            // Arrange
            int[] haystack = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int needle = 3;

            // Act
            bool result = BinarySearch_02.BinarySearch(haystack, needle);

            // Assert
            Assert.True(result);
        }

        [Fact]
        public void BinarySearch_FoundBegining_ReturnsTrue()
        {
            // Arrange
            int[] haystack = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int needle = 1;

            // Act
            bool result = BinarySearch_02.BinarySearch(haystack, needle);

            // Assert
            Assert.True(result);
        }

        [Fact]
        public void BinarySearch_FoundEnd_ReturnsTrue()
        {
            // Arrange
            int[] haystack = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int needle = 10;

            // Act
            bool result = BinarySearch_02.BinarySearch(haystack, needle);

            // Assert
            Assert.True(result);
        }

        [Fact]
        public void BinarySearch_NotFound_ReturnsFalse()
        {
            // Arrange
            int[] haystack = new int[] { 1, 2, 3, 4, 5 };
            int needle = 6;

            // Act
            bool result = BinarySearch_02.BinarySearch(haystack, needle);

            // Assert
            Assert.False(result);
        }
    }
}
