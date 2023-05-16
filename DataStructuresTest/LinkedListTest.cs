using ds = DataStructures;

namespace DataStructuresTest
{
    public class LinkedListTest
    {
        [Fact]
        public void Test_GetLength_EmptyList_ReturnsZero()
        {
            // Arrange
            ds.LinkedList<int> list = new ds.LinkedList<int>();

            // Act
            int length = list.GetLength();

            // Assert
            Assert.Equal(0, length);
        }

        [Fact]
        public void Test_InsertAt_InsertsItemAtCorrectIndex()
        {
            // Arrange
            ds.LinkedList<int> list = new ds.LinkedList<int>();
            list.Append(1);
            list.Append(3);

            // Act
            list.InsertAt(2, 1);

            // Assert
            Assert.Equal(1, list.Get(0));
            Assert.Equal(2, list.Get(1));
            Assert.Equal(3, list.Get(2));
        }

        [Fact]
        public void Test_Remove_RemovesItemFromList()
        {
            // Arrange
            ds.LinkedList<int> list = new ds.LinkedList<int>();
            list.Append(1);
            list.Append(2);
            list.Append(3);

            // Act
            int removed = list.Remove(2);

            // Assert
            Assert.Equal(2, removed);
            Assert.Equal(1, list.Get(0));
            Assert.Equal(3, list.Get(1));
        }

        [Fact]
        public void Test_RemoveAt_RemovesItemAtCorrectIndex()
        {
            // Arrange
            ds.LinkedList<int> list = new ds.LinkedList<int>();
            list.Append(1);
            list.Append(2);
            list.Append(3);

            // Act
            int removed = list.RemoveAt(1);

            // Assert
            Assert.Equal(2, removed);
            Assert.Equal(1, list.Get(0));
            Assert.Equal(3, list.Get(1));
        }

        [Fact]
        public void Test_Append_AddsItemToEndOfList()
        {
            // Arrange
            ds.LinkedList<int> list = new ds.LinkedList<int>();
            list.Append(1);
            list.Append(2);

            // Act
            list.Append(3);

            // Assert
            Assert.Equal(1, list.Get(0));
            Assert.Equal(2, list.Get(1));
            Assert.Equal(3, list.Get(2));
        }

        [Fact]
        public void Test_Prepend_AddsItemToBeginningOfList()
        {
            // Arrange
            ds.LinkedList<int> list = new ds.LinkedList<int>();
            list.Append(1);
            list.Append(2);

            // Act
            list.Prepend(0);

            // Assert
            Assert.Equal(0, list.Get(0));
            Assert.Equal(1, list.Get(1));
            Assert.Equal(2, list.Get(2));
        }

        [Fact]
        public void Test_Get_ReturnsItemAtIndex()
        {
            // Arrange
            ds.LinkedList<int> list = new ds.LinkedList<int>();
            list.Append(1);
            list.Append(2);
            list.Append(3);

            // Act
            int item = list.Get(1);

            // Assert
            Assert.Equal(2, item);
        }
    }
}