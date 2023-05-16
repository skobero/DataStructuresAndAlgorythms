using DataStructures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresTest
{
    public class MinHeapTest
    {
        [Fact]
        public void Delete_ReturnsNegativeOne_WhenHeapIsEmpty()
        {
            // Arrange
            MinHeap heap = new MinHeap();

            // Act
            int result = heap.Delete();

            // Assert
            Assert.Equal(-1, result);
        }

        [Fact]
        public void Delete_DeletesMinimumValueFromMinHeap()
        {
            // Arrange
            MinHeap heap = new MinHeap();
            heap.Insert(5);
            heap.Insert(3);
            heap.Insert(69);
            heap.Insert(420);
            heap.Insert(4);
            heap.Insert(1);
            heap.Insert(8);
            heap.Insert(7);

            // Assert
            Assert.Equal(8, heap.Length);
            Assert.Equal(1, heap.Delete());
            Assert.Equal(3, heap.Delete());
            Assert.Equal(4, heap.Delete());
            Assert.Equal(5, heap.Delete());
            Assert.Equal(4, heap.Length);
            Assert.Equal(7, heap.Delete());
            Assert.Equal(8, heap.Delete());
            Assert.Equal(69, heap.Delete());
            Assert.Equal(420, heap.Delete());
            Assert.Equal(0, heap.Length);
        }
    }
}
