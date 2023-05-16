using DataStructures.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures
{
    public interface ILinkedList<T>
    {
        int GetLength();
        void InsertAt(T item, int index);
        T Remove(T item);
        T RemoveAt(int index);
        void Append(T item);
        void Prepend(T item);
        T Get(int index);
    }

    public class LinkedList<T> : ILinkedList<T> 
    {
        System.Collections.Generic.LinkedList<int> list;

        private int length;
        private NodeLinkedList<T> head;
        private NodeLinkedList<T> tail;

        public LinkedList()
        {
            this.head = null;
            this.tail = null;
            this.length = 0;
        }

        public void Append(T item)
        {
            this.length++;
            NodeLinkedList<T> node = new NodeLinkedList<T> { Value = item };

            if (this.tail is null)
            {
                this.tail = node;
                this.head = node;
                return;
            }

            node.Prev = this.tail;
            this.tail.Next = node;
            this.tail = node;
        }

        public T Get(int index)
        {
           var node = FindNodeAtIdx(index);

            if (node is null)
            {
                return default;
            }

            return node.Value;
        }

        public int GetLength()
        {
            return this.length;
        }

        public void InsertAt(T item, int index)
        {
            if (index == this.length)
            {
                this.Append(item);
                return;
            }
            else if (index == 0)
            {
                this.Prepend(item);
                return;
            }

            NodeLinkedList<T> curr = FindNodeAtIdx(index);

            this.length++;
            NodeLinkedList<T> node = new NodeLinkedList<T> { Value = item };

            node.Prev = curr.Prev;
            node.Next = curr;
            
            if (curr.Prev is not null)
            {
                curr.Prev.Next = node;
            }

            curr.Prev = node;
        }

        public void Prepend(T item)
        {
            NodeLinkedList<T> node = new NodeLinkedList<T> { Value = item };

            this.length++;
            if (this.head is null)
            {
                this.head = node;
                this.tail = node;
                return;
            }

            node.Next = this.head;
            this.head.Prev = node;
            this.head = node;

        }

        public T Remove(T item)
        {
            NodeLinkedList<T> curr = this.head;

            for (int i = 0; curr is not null && i < this.length; i++)
            {
                if (EqualityComparer<T>.Default.Equals(curr.Value,item))
                {
                    break;
                }
                curr = curr.Next;
            }

            if (curr is null)
            {
                return default;
            }

            return RemoveNode(curr);
        }

        public T RemoveAt(int index)
        {
            var node = FindNodeAtIdx(index);

            if (node is null)
            {
                return default;
            }

            return this.RemoveNode(node);
        }

        private T RemoveNode(NodeLinkedList<T> node)
        {
            this.length--;

            if (this.length == 0)
            {
                this.head = null;
                this.tail = null;
                return node.Value;
            }

            if (node.Prev is not null)
            {
                node.Prev.Next = node.Next;
            }

            if (node.Next is not null)
            {
                node.Next.Prev = node.Prev;
            }

            if (node == this.head)
            {
                this.head = node.Next;
            }

            if (node == this.tail)
            {
                this.tail = node.Prev;
            }

            node.Prev = null;
            node.Next = null;

            return node.Value;
        }

        private NodeLinkedList<T> FindNodeAtIdx(int idx)
        {

            if (idx > this.length)
            {
                throw new IndexOutOfRangeException("oh no");
            }

            NodeLinkedList<T> curr = this.head;

            for (int i = 0; i < idx; i++)
            {
                curr = curr.Next;
            }

            return curr;
        }
    }
}