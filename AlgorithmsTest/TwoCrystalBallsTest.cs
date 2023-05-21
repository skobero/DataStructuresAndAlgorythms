using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsTests
{
    public class TwoCrystalBallsTest
    {
        [Fact]
        public void TwoCrystalBalls_Found_ReturnsCorrectIndex()
        {
            // Arrange
            bool[] breaks = { false, false, false, false, false, true, true, true, true, true };
            int expectedIndex = 5;

            // Act
            int result = Algorithms.TwoCrystalBallProblem_03.TwoCrystalBalls(breaks);

            // Assert
            Assert.Equal(expectedIndex, result);
        }

        [Fact]
        public void TwoCrystalBalls_NotFound_ReturnsNegativeOne()
        {
            // Arrange
            bool[] breaks = { false, false, false, false, false, false, false, false, false, false };
            int expectedIndex = -1;

            // Act
            int result = Algorithms.TwoCrystalBallProblem_03.TwoCrystalBalls(breaks);

            // Assert
            Assert.Equal(expectedIndex, result);
        }
    }
}
