using DataStructures.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures
{
    public class DijkstrasShortestPath
    {
        public int[] Dijkstra_list(WeightedAdjacencyList graph,int source,int sink)
        {
            var seen = new bool[graph.Length];
            var previous = new int[graph.Length];
            var dists = new int[graph.Length];

            Array.Fill(seen, false);
            Array.Fill(previous, -1);
            Array.Fill(dists, int.MaxValue);
            
            dists[source] = 0;

            while (HasUnvisited(seen, dists))
            {
                var curr = GetLowestUnvisited(seen, dists);
                seen[curr] = true;

                var adjs = graph[curr];

                for (int i = 0; i < adjs.Length; i++)
                {
                    var edge = adjs[i];
                    if (seen[edge.to])
                    {
                        continue;
                    }

                    var dist = dists[curr] + edge.weight;
                    if (dist < dists[edge.to])
                    {
                        dists[edge.to] = dist;
                        previous[edge.to] = curr;
                    }
                }
            }

            var outPath = ExtractPath(sink, previous);
            outPath.Add(source);
            outPath.Reverse();

            return outPath.ToArray();

        }

        private static List<int> ExtractPath(int sink, int[] previous)
        {
            var outPath = new List<int>();
            var curr = sink;

            while (previous[curr] != -1)
            {
                outPath.Add(curr);
                curr = previous[curr];
            }

            return outPath;
        }

        private int GetLowestUnvisited(bool[] seen, int[] dist)
        {
            var idx = -1;
            var lowesDistance = int.MaxValue;

            for (int i = 0; i < seen.Length; i++)
            {
                if (seen[i])
                {
                    continue;
                }

                if (lowesDistance > dist[i])
                {
                    lowesDistance = dist[i];
                    idx = i;
                }
            }

            return idx;

        }

        private bool HasUnvisited(bool[] seen, int[] dist)
        {
            var has = false;

            for (int i = 0; i < seen.Length; i++)
            {
                if (!seen[i] && dist[i] < int.MaxValue)
                {
                    has = true;
                    break;
                }
            }

            return has;
        }
    }
}
