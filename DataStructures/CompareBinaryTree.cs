using DataStructures.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures
{
    public class CompareBinaryTree
    {
        public static bool Compare(BinaryNode<int> A,BinaryNode<int> B)
        {
            if (A is null && B is null)
            {
                return true;
            }

            if (A is null || B is null)
            {
                return false;
            }

            if (A.Value != B.Value)
            {
                return false;
            }

            return Compare(A.Left,B.Left) && Compare(A.Right,B.Right);
        }
    }
}
