using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures
{
    public class MinHeap
    {
        public int Length { get; set; }
        private List<int> data;

        public MinHeap()
        {
            this.Length = 0;
            this.data = new List<int>();
        }

        public void Insert(int value)
        {
            this.data.Insert(this.Length, value);
            this.HeapifyUp(this.Length);
            this.Length++;
        }

        public int Delete()
        {
            if (this.Length == 0)
            {
                return -1;
            }

            int outV = this.data[0];
            this.Length--;
            if (this.Length == 0)
            {
                this.data.Clear();
                return outV;
            }

            this.data[0] = this.data[this.Length];
            this.HeapifyDown(0);

            return outV;
        }

        private int Parent(int idx)
        {
            return (idx - 1) / 2;
        }

        private int LeftChild(int idx)
        {
            return idx * 2 + 1;
        }

        private int RightChild(int idx)
        {
            return idx * 2 + 2;
        }

        private void HeapifyUp(int idx)
        {
            if (idx == 0)
            {
                return;
            }

            int parent = this.Parent(idx);
            int parentValue = this.data[parent];
            int value = this.data[idx];

            if (parentValue > value)
            {
                this.data[idx] = parentValue;
                this.data[parent] = value;
                HeapifyUp(parent);
            }

        }

        private void HeapifyDown(int idx)
        {
            if (idx >= this.Length)
            {
                return;
            }

            int leftIdx = this.LeftChild(idx);
            int rightIdx = this.RightChild(idx);

            if (leftIdx >= this.Length)
            {
                return;
            }

            int leftValue = this.data[leftIdx];
            int rightValue = this.data[rightIdx];
            int value = this.data[idx];

            if (leftValue > rightValue && value > rightValue)
            {
                this.data[idx] = rightValue;
                this.data[rightIdx] = value;
                this.HeapifyDown(rightIdx);
            }
            else if (rightValue > leftValue && value > leftValue)
            {
                this.data[idx] = leftValue ;
                this.data[leftIdx] = value;
                this.HeapifyDown(leftIdx);
            }
        }
    }
}
