using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.Helpers
{
    public class BinaryNode<T>
    {
        public T Value { get; set; }
        public BinaryNode<T> Left { get; set; }
        public BinaryNode<T> Right { get; set; }

        public BinaryNode(T value)
        {
            Value = value;
            Left = null;
            Right = null;
        }
    }
}
