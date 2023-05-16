using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsTests
{
    public class RingBuffer<T>
    {
        private T[] buffer;
        private int start;
        private int end;
        private int capacity;
        private int count;

        public RingBuffer(int capacity)
        {
            this.buffer = new T[capacity];
            this.start = 0;
            this.end = 0;
            this.capacity = capacity;
            this.count = 0;
        }

        public void Enqueue(T item)
        {
            if (this.count == this.capacity)
            {
                // if we've reached the capacity, create a new, larger buffer and copy the current values over
                T[] newBuffer = new T[this.capacity * 2];
                if (this.end > this.start)
                {
                    Array.Copy(this.buffer, this.start, newBuffer, 0, this.count);
                }
                else
                {
                    Array.Copy(this.buffer, this.start, newBuffer, 0, this.capacity - this.start);
                    Array.Copy(this.buffer, 0, newBuffer, this.capacity - this.start, this.end);
                }
                this.buffer = newBuffer;
                this.capacity *= 2;
                this.start = 0;
                this.end = this.count;
            }
            this.buffer[this.end] = item;
            this.end = (this.end + 1) % this.capacity;
            this.count++;
        }

        public T Dequeue()
        {
            if (this.count == 0)
            {
                throw new InvalidOperationException("Buffer is empty");
            }
            T item = this.buffer[this.start];
            this.buffer[this.start] = default(T);
            this.start = (this.start + 1) % this.capacity;
            this.count--;
            return item;
        }

        public T Peek()
        {
            if (this.count == 0)
            {
                throw new InvalidOperationException("Buffer is empty");
            }
            return this.buffer[this.start];
        }

        public int Count
        {
            get { return this.count; }
        }

        public int Capacity
        {
            get { return this.capacity; }
        }

        public bool IsEmpty
        {
            get { return this.count == 0; }
        }

        public bool IsFull
        {
            get { return this.count == this.capacity; }
        }
    }
}
