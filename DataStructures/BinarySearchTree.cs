using DataStructures.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures
{
    public class BinarySearchTree
    {
        public static bool Find(BinaryNode<int> head,int needle)
        {
            if (head is null)
            {
                return false;
            }

            if (head?.Value == needle)
            {
                return true;
            }

            if (head?.Value < needle)
            {
                return Find(head.Right, needle);
            }

            return Find(head.Left, needle);

        }

    }
}
