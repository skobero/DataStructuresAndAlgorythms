using DataStructures.Helpers;
using DataStructures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresTest
{
    public class BreathFirstSearchTest
    {
        [Fact]
        public void BFS_ValueExists()
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


            // Act
            var result = BreathFirstSearch.Find(node1,5);

            // Assert
            Assert.True(result);
        }

        [Fact]
        public void BFS_ValueDoesntExists()
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


            // Act
            var result = BreathFirstSearch.Find(node1, 6);

            // Assert
            Assert.False(result);
        }

        [Fact]
        public void BFS_ListAllValues()
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

            var expected = new int[] { 1, 2, 3, 4, 5 };

            // Act
            var result = BreathFirstSearch.ListAllValues(node1);

            // Assert
            Assert.Equal(expected,result);
        }
    }
}
