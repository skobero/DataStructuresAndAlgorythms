using ds = DataStructures;

namespace DataStructuresTest
{
    public class StackTest
    {
        [Fact]
        public void Push_AddsItemToStack()
        {
            // Arrange
            ds.Stack<int> stack = new ds.Stack<int>();

            // Act
            stack.Push(1);
            stack.Push(2);

            // Assert
            Assert.Equal(2, stack.Length);
            Assert.Equal(2, stack.Peek());
        }

        [Fact]
        public void Pop_RemovesItemFromStack()
        {
            // Arrange
            ds.Stack<int> stack = new ds.Stack<int>();
            stack.Push(1);
            stack.Push(2);

            // Act
            int item = stack.Pop();

            // Assert
            Assert.Equal(2, item);
            Assert.Equal(1, stack.Length);
            Assert.Equal(1, stack.Peek());
        }

        [Fact]
        public void Peek_ReturnsFirstItemInStack()
        {
            // Arrange
            ds.Stack<int> stack = new ds.Stack<int>();
            stack.Push(1);
            stack.Push(2);

            // Act
            int item = stack.Peek();

            // Assert
            Assert.Equal(2, item);
            Assert.Equal(2, stack.Length);
        }
    }
}
