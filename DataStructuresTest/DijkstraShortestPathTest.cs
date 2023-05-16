using DataStructures.Helpers;
using DataStructures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresTest
{
    public class DijkstraShortestPathTest
    {
        [Fact]
        public void DijksPathSuccess()
        {
            //Arrange

            GraphEdge[][] graph = new GraphEdge[][]
            {
                new GraphEdge[]{ new GraphEdge {from=0,to=1,weight=1 },new GraphEdge {from=0,to=2,weight=5 } },
                new GraphEdge[]{ new GraphEdge {from=1,to=2,weight=7 },new GraphEdge {from=1,to=3,weight=3 } },
                new GraphEdge[]{ new GraphEdge {from=2,to=4,weight=1 } },
                new GraphEdge[]{ new GraphEdge {from=3,to=1,weight=1 }, new GraphEdge {from=3,to=2,weight=2 } },
                new GraphEdge[]{  }
            };

            var graphObject = new WeightedAdjacencyList(graph);
            var expected = new int[] { 0, 2, 4 };

            var djk = new DijkstrasShortestPath();
            //Act
            var result = djk.Dijkstra_list(graphObject, 0, 4);

            //Assert
            Assert.Equal(3, result.Length);
            Assert.Equal(expected, result);
        }
    }
}
