using DataStructures.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures
{
    public class DepthFirstSearchInGraph
    {
        private static bool Walk(WeightedAdjacencyList graph,int current,int needle, bool[] seen, List<int> path)
        {
            if (seen[current])
            {
                return false;
            }

            seen[current] = true;

            path.Add(current);

            if (current == needle)
            {
                return true;
            }

            //pre
            

            //recurese
            var list = graph[current];

            for (int i = 0; i < list.Length; i++)
            {
                var edge = list[i];
                if (Walk(graph,edge.to,needle,seen,path))
                {
                    return true;
                }
            }

            //post
            path.RemoveAt(path.Count - 1);

            return false;
        }

        public static int[] DFS(WeightedAdjacencyList graph, int source, int needle)
        {
            bool[] seen = new bool[graph.Length];
            List<int> path = new List<int>();

            Walk(graph,source,needle,seen,path);

            return path.ToArray();
        }
    }
}
