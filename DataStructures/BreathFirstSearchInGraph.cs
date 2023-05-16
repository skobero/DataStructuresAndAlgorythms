using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using DataStructures.Helpers;

namespace DataStructures
{
    public class BreathFirstSearchInGraph
    {
        public static int[] BFS(WeightedAdjacencyMatrix graph,int source,int needle)
        {
            bool[] seen = new bool[graph.Length];
            Array.Fill<bool>(seen, false);

            int[] previous = new int[graph.Length];
            Array.Fill<int>(previous, -1);

            seen[source] = true;
            List<int> queue = new List<int>();
            queue.Add(source);
            

            do
            {
               var curr = queue.First();
                queue.RemoveAt(0);

                if (curr == needle)
                {
                    break;
                }

                var adjs = graph[curr];
                for (int i = 0; i < adjs.Length; i++)
                {
                    if (adjs[i] == 0)
                    {
                        continue;
                    }

                    if (seen[i])
                    {
                        continue;
                    }

                    seen[i] = true;
                    previous[i] = curr;
                    queue.Add(i);
                }
                seen[curr] = true;

            } while (queue.Count > 0);

            if (previous[needle] == -1)
            {
                return Array.Empty<int>();
            }

            //build it backwards
            var currN = needle;
            var outArray = new List<int>();

            while (previous[currN] != -1)
            {
                outArray.Add(currN);
                currN = previous[currN];
            }

            outArray.Add(source);
            outArray.Reverse();

            return outArray.ToArray();
        }
    }
}
