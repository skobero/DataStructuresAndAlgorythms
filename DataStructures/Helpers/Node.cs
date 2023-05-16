using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.Helpers
{
    internal class Node<T>
    {
        public T? Value;
        public Node<T>? Next { get; set; }
    }
}
