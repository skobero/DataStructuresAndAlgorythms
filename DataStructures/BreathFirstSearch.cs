using DataStructures.Helpers;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures
{
    public class BreathFirstSearch
    {
        public static bool Find(BinaryNode<int> head, int needle)
        {
            Queue<BinaryNode<int>> queue = new Queue<BinaryNode<int>>();
            queue.Enqueue(head);

            while (queue.Length > 0)
            {
                var curr = queue.Dequeue();
                if (curr is null)
                {
                    continue;
                }

                if (curr.Value == needle)
                {
                    return true;
                }

                
                queue.Enqueue(curr.Left);
                queue.Enqueue(curr.Right);
                
            }

            return false;
        }

        public static int[] ListAllValues(BinaryNode<int> head)
        {
            var list = new List<int>();
            var q = new Queue<BinaryNode<int>>();
            q.Enqueue(head);

            while (q.Length > 0)
            {
                var curr = q.Dequeue();
                list.Add(curr.Value);

                if (curr.Left is not null)
                {
                    q.Enqueue(curr.Left);   
                }

                if (curr.Right is not null)
                {
                    q.Enqueue(curr.Right);
                }

            }

            
            return list.ToArray();

        }
    }
}
