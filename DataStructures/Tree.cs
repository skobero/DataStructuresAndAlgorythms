using DataStructures.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures
{
    public class Tree
    {
        public int[] PreOrderSearch(BinaryNode<int> head)
        {
            List<int> path = new List<int>();
            WalkPreOrder(head, path);
            return path.ToArray();
        }

        private void WalkPreOrder(BinaryNode<int> curr, List<int> path)
        {
            if (curr is null)
            {
                return;
            }

            //pre
            path.Add(curr.Value);
            //recurse
            WalkPreOrder(curr.Left, path);
            WalkPreOrder(curr.Right, path);
            //post

        }

        public int[] InOrderSearch(BinaryNode<int> head)
        {
            List<int> path = new List<int>();
            WalkInOrder(head, path);
            return path.ToArray();
        }

        private void WalkInOrder(BinaryNode<int> curr, List<int> path)
        {
            if (curr is null)
            {
                return;
            }


            WalkInOrder(curr.Left, path);
            path.Add(curr.Value);
            WalkInOrder(curr.Right, path);

        }

        public int[] PostOrderSearch(BinaryNode<int> head)
        {
            List<int> path = new List<int>();
            WalkPostOrder(head, path);
            return path.ToArray();
        }

        private void WalkPostOrder(BinaryNode<int> curr, List<int> path)
        {
            if (curr is null)
            {
                return;
            }

            WalkPostOrder(curr.Left, path);
            WalkPostOrder(curr.Right, path);
            path.Add(curr.Value);

        }
    }
}
