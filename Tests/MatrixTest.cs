using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsTests
{
    public class MatrixTest
    {
        [Fact]
        public void MatrixSuccess()
        {
            string sentance1 = "I am first sentence.";
            string sentace2 = "I am second sentence.";

            string result = Algorithms.Matrix.LongestCommonSubstring(sentance1, sentace2);

            Assert.Equal(" sentence.", result);
        }
        


    }
}
