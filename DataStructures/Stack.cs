using DataStructures.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures
{
    internal interface IStack<T>
    {
        void Push(T? item);
        T? Pop();
        T? Peek();
    }

    public class Stack<T> : IStack<T>
    {
        public int Length { get; set; }
        private Node<T>? _head;

        public Stack()
        {
            this._head = null;
            this.Length = 0;
        }

        public T? Peek()
        {
            if (this._head is null)
            {
                return default(T);
            }

            return this._head.Value;
        }

        public void Push(T? item)
        {
            this.Length++;

            Node<T>? temp = new Node<T>();
            temp.Value = item;

            if (this._head is null)
            {
                this._head = temp;
                return;
            }

            temp.Next = this._head;
            this._head = temp;
        }

        public T? Pop()
        {
            this.Length = Math.Max(0, this.Length - 1);

            if (this._head is null)
            {
                return default(T);
            }

            Node<T>? temp = this._head;
            this._head = this._head.Next;
            temp.Next = null;

            return temp.Value;
        }
    }
}
