using DataStructures;
using DataStructures.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresTest
{
    public class BreathFirstSearchInGraphTest
    {
        [Fact]
        public void BFSNodeExists()
        {
            //Arrange
            int[][] graph = new int[][]
            {
               new[] {0,1,4,5,0},
               new[] {1,0,0,0,0},
               new[] {0,0,0,2,0},
               new[] {0,0,0,0,5},
               new[] {0,0,0,0,0},
            };

            var graphObject = new WeightedAdjacencyMatrix(graph);
            var expected = new int[] {0,3,4 };

            //Act
            var result = BreathFirstSearchInGraph.BFS(graphObject, 0, 4);

            //Assert
            Assert.Equal(3, result.Length);
            Assert.Equal(expected, result);
        }

    }
}
