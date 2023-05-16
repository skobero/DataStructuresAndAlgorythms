using AlgorithmsTests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresTest
{
    public class RingBufferTest
    {
        [Fact]
        public void Enqueue_AddsElementToBuffer()
        {
            // Arrange
            var buffer = new RingBuffer<int>(5);

            // Act
            buffer.Enqueue(1);

            // Assert
            Assert.Equal(1, buffer.Count);
        }

        [Fact]
        public void Dequeue_RemovesElementFromBuffer()
        {
            // Arrange
            var buffer = new RingBuffer<int>(5);
            buffer.Enqueue(1);

            // Act
            var element = buffer.Dequeue();

            // Assert
            Assert.Equal(1, element);
            Assert.Equal(0, buffer.Count);
        }

        [Fact]
        public void Peek_ReturnsNextElementWithoutRemoving()
        {
            // Arrange
            var buffer = new RingBuffer<int>(5);
            buffer.Enqueue(1);
            buffer.Enqueue(2);

            // Act
            var element = buffer.Peek();

            // Assert
            Assert.Equal(1, element);
            Assert.Equal(2, buffer.Count);
        }

        [Fact]
        public void Enqueue_WrapsAroundBuffer()
        {
            // Arrange
            var buffer = new RingBuffer<int>(3);
            buffer.Enqueue(1);
            buffer.Enqueue(2);
            buffer.Enqueue(3);

            // Act
            buffer.Enqueue(4);

            // Assert
            Assert.Equal(4, buffer.Count);
            Assert.Equal(1, buffer.Dequeue());
            Assert.Equal(2, buffer.Dequeue());
            Assert.Equal(3, buffer.Dequeue());
        }
    }
}
