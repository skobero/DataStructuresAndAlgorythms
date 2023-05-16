using DataStructures.Helpers;
using DataStructures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresTest
{
    public class DepthFirstSearchInGraphTest
    {
        [Fact]
        public void DFSNodeExists()
        {
            //Arrange
            //int[][] graph = new int[][]
            //{
            //   new[] {0,1,4,5,0},
            //   new[] {1,0,0,0,0},
            //   new[] {0,0,0,2,0},
            //   new[] {0,0,0,0,5},
            //   new[] {0,0,0,0,0},
            //};

            GraphEdge[][] graph = new GraphEdge[][]
            {
                new GraphEdge[]{ new GraphEdge {from=0,to=1,weight=1 },new GraphEdge {from=0,to=2,weight=4 },new GraphEdge {from=0,to=3,weight=5 } },
                new GraphEdge[]{ new GraphEdge {from=1,to=0,weight=1 } },
                new GraphEdge[]{ new GraphEdge {from=2,to=3,weight=2 } },
                new GraphEdge[]{ new GraphEdge {from=3,to=4,weight=5 } },
                new GraphEdge[]{ new GraphEdge {from=4,to=-1,weight=-1 } }
            };

            var graphObject = new WeightedAdjacencyList(graph);
            var expected = new int[] { 0, 2, 3, 4 };

            //Act
            var result = DepthFirstSearchInGraph.DFS(graphObject, 0, 4);

            //Assert
            Assert.Equal(4, result.Length);
            Assert.Equal(expected, result);
        }
    }
}
