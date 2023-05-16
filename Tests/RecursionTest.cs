using Algorithms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsTests
{
    public class RecursionTest
    {
        [Fact]
        public void RecursionSuccess()
        {
            string[] maze = {"########## #",
                             "#        # #",
                             "#        # #",
                             "# ######## #",
                             "#          #",
                             "# ##########"};

            Point start = new Point() { x = 10, y = 0 };
            Point end = new Point() { x = 1, y = 5 };

            Stack<Point> path = new Algorithms.Recursion_05().solve(maze, '#',start,end);

            Stack<Point> expected = new Stack<Point>();
            expected.Push(new Point {x = 10, y = 0 });
            expected.Push(new Point { x = 10, y = 1 });
            expected.Push(new Point { x = 10, y = 2 });
            expected.Push(new Point { x = 10, y = 3 });
            expected.Push(new Point { x = 10, y = 4 });
            expected.Push(new Point { x = 9, y = 4 });
            expected.Push(new Point { x = 8, y = 4 });
            expected.Push(new Point { x = 7, y = 4 });
            expected.Push(new Point { x = 6, y = 4 });
            expected.Push(new Point { x = 5, y = 4 });
            expected.Push(new Point { x = 4, y = 4 });
            expected.Push(new Point { x = 3, y = 4 });
            expected.Push(new Point { x = 2, y = 4 });
            expected.Push(new Point { x = 1, y = 4 });
            expected.Push(new Point { x = 1, y = 5 });


            Assert.Equal(expected,path);
        }
    }
}
