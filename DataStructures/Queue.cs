using DataStructures.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures
{
    internal interface IQueue<T>
    {
        void Enqueue(T? item);
        T? Dequeue();
        T? Peek();
    }

    public class Queue<T> : IQueue<T>
    {
        public int Length { get; set; }
        private Node<T>? _head;
        private Node<T>? _tail;

        public Queue()
        {
            this._head = null;
            this._tail = null;
            this.Length = 0;
        }

        public T? Dequeue()
        {
            if (this._head is null)
            {
                return default(T);
            }

            this.Length--;

            Node<T>? temp = this._head;
            this._head = this._head.Next;

            if (this._head is null)
            {
                this._tail = null;
            }

            temp.Next = null;

            return temp.Value;
        }

        public void Enqueue(T? item)
        {
            this.Length++;

            Node<T>? temp = new Node<T>();
            temp.Value = item;

            if (this._tail is null)
            {
                this._head = temp;
                this._tail = temp;
                return;
            }

            this._tail.Next = temp;
            this._tail = temp;
        }

        public T? Peek()
        {
            if (this._head is null)
            {
                return default(T);
            }

            return this._head.Value;
        }

    }
}
