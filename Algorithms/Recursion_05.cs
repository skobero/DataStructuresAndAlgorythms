using System.Runtime.CompilerServices;
using System.Security.AccessControl;
using System.Security.Cryptography.X509Certificates;

namespace Algorithms
{
    public class Recursion_05
    {
        private int[][] directions = {
                    new int[] {-1, 0 },
                    new int[] { 1, 0 },
                    new int[] { 0,-1 },
                    new int[] { 0, 1 }
        };

        private bool walk(string[] maze, char wall, Point curr, Point end, bool[,] seen, Stack<Point> path)
        {
            if (curr.x < 0 || curr.x > maze[0].Length ||
                curr.y < 0 || curr.y > maze.Length)
            {
                return false;
            }

            if (maze[curr.y][curr.x] == wall)
            {
                return false;
            }

            if (curr.y == end.y && curr.x == end.x)
            {
                path.Push(end);
                return true;
            }

            if (seen[curr.y,curr.x])
            {
                return false;
            }

            seen[curr.y,curr.x] = true;

            path.Push(curr);

            for (int i = 0; i < directions.Length; i++)
            {
                (int x, int y) dir = (directions[i][0], directions[i][1]);
                Point point = new Point() {x= curr.x + dir.x,y=curr.y + dir.y };

                if(walk(maze, wall, point, end, seen, path))
                {
                    return true;
                }
                
            }

            path.Pop();

            return false;
        }

        public Stack<Point> solve(string[] maze,char wall,Point curr,Point end)
        {
            bool[,] seen = new bool[maze.Length, maze[0].Length];
            Stack<Point> path = new Stack<Point>();

            walk(maze, wall, curr, end, seen, path);

            return path;
        }
    }

    public struct Point
    {
        public int x;
        public int y;
    }
}
