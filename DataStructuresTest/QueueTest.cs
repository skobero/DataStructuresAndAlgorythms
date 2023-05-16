using ds = DataStructures;

namespace DataStructuresTest
{
    public class QueueTest
    {
        [Fact]
        public void Enqueue_AddsItemToQueue()
        {
            // Arrange
            ds.Queue<int> queue = new ds.Queue<int>();

            // Act
            queue.Enqueue(1);

            // Assert
            Assert.Equal(1, queue.Length);
            Assert.Equal(1, queue.Peek());
        }

        [Fact]
        public void Dequeue_RemovesItemFromQueue()
        {
            // Arrange
            ds.Queue<int> queue = new ds.Queue<int>();
            queue.Enqueue(1);
            queue.Enqueue(2);

            // Act
            int item = queue.Dequeue();

            // Assert
            Assert.Equal(1, item);
            Assert.Equal(1, queue.Length);
            Assert.Equal(2, queue.Peek());
        }

        [Fact]
        public void Dequeue_RemovesAddsItemsFromQueue()
        {
            // Arrange
            ds.Queue<int> queue = new ds.Queue<int>();
            queue.Enqueue(1);
            var first = queue.Dequeue();
            queue.Enqueue(2);
            

            queue.Enqueue(3);

            // Act
            
            int second = queue.Dequeue();

            // Assert
            Assert.Equal(1, first);
            Assert.Equal(2, second);
            Assert.Equal(1, queue.Length);
            Assert.Equal(3, queue.Peek());
        }

        [Fact]
        public void Peek_ReturnsFirstItemInQueue()
        {
            // Arrange
            ds.Queue<int> queue = new ds.Queue<int>();
            queue.Enqueue(1);
            queue.Enqueue(2);

            // Act
            int item = queue.Peek();

            // Assert
            Assert.Equal(1, item);
            Assert.Equal(2, queue.Length);
        }
    }
}
