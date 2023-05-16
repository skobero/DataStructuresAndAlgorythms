using DataStructures.Helpers;
using DataStructures;

namespace DataStructuresTest
{
    public class TreeTest
    {
        [Fact]
        public void PreOrderSearch_ReturnsCorrectPath_WhenTreeIsNotEmpty()
        {
            // Arrange
            BinaryNode<int> node1 = new BinaryNode<int>(1);
            BinaryNode<int> node2 = new BinaryNode<int>(2);
            BinaryNode<int> node3 = new BinaryNode<int>(3);
            BinaryNode<int> node4 = new BinaryNode<int>(4);
            BinaryNode<int> node5 = new BinaryNode<int>(5);

            node1.Left = node2;
            node1.Right = node3;
            node2.Left = node4;
            node2.Right = node5;

            Tree tree = new Tree();

            // Act
            int[] result = tree.PreOrderSearch(node1);

            // Assert
            int[] expected = new int[] { 1, 2, 4, 5, 3 };
            Assert.Equal(expected, result);
        }

        [Fact]
        public void PreOrderSearch_ReturnsEmptyArray_WhenTreeIsEmpty()
        {
            // Arrange
            Tree tree = new Tree();

            // Act
            int[] result = tree.PreOrderSearch(null);

            // Assert
            int[] expected = new int[] { };
            Assert.Equal(expected, result);
        }

        [Fact]
        public void InOrderSearch_ReturnsCorrectPath_WhenTreeIsNotEmpty()
        {
            // Arrange
            BinaryNode<int> node1 = new BinaryNode<int>(1);
            BinaryNode<int> node2 = new BinaryNode<int>(2);
            BinaryNode<int> node3 = new BinaryNode<int>(3);
            BinaryNode<int> node4 = new BinaryNode<int>(4);
            BinaryNode<int> node5 = new BinaryNode<int>(5);

            node1.Left = node2;
            node1.Right = node3;
            node2.Left = node4;
            node2.Right = node5;

            Tree tree = new Tree();

            // Act
            int[] result = tree.InOrderSearch(node1);

            // Assert
            int[] expected = new int[] { 4, 2, 5, 1, 3 };
            Assert.Equal(expected, result);
        }

        [Fact]
        public void PostOrderSearch_ReturnsCorrectPath_WhenTreeIsNotEmpty()
        {
            // Arrange
            BinaryNode<int> node1 = new BinaryNode<int>(1);
            BinaryNode<int> node2 = new BinaryNode<int>(2);
            BinaryNode<int> node3 = new BinaryNode<int>(3);
            BinaryNode<int> node4 = new BinaryNode<int>(4);
            BinaryNode<int> node5 = new BinaryNode<int>(5);

            node1.Left = node2;
            node1.Right = node3;
            node2.Left = node4;
            node2.Right = node5;

            Tree tree = new Tree();

            // Act
            int[] result = tree.PostOrderSearch(node1);

            // Assert
            int[] expected = new int[] { 4, 5, 2, 3, 1 };
            Assert.Equal(expected, result);
        }
    }
}
