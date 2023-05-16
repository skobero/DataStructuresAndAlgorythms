using DataStructures.Helpers;
using DataStructures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresTest
{
    public class BinarySearchTreeTest
    {
        [Fact]
        public void BST_BreathFirstSearchFound()
        {
            // Arrange
            BinaryNode<int> Node1 = new BinaryNode<int>(10);
            BinaryNode<int> Node2 = new BinaryNode<int>(8);
            BinaryNode<int> Node3 = new BinaryNode<int>(15);
            BinaryNode<int> Node4 = new BinaryNode<int>(5);
            BinaryNode<int> Node5 = new BinaryNode<int>(9);
            BinaryNode<int> Node6 = new BinaryNode<int>(12);
            BinaryNode<int> Node7 = new BinaryNode<int>(16);

            Node1.Left = Node2;
            Node1.Right = Node3;
            Node2.Left = Node4;
            Node2.Right = Node5;
            Node3.Left = Node6;
            Node3.Right = Node7;
           


            // Act
            var result = BinarySearchTree.Find(Node1, 16);

            // Assert
            Assert.True(result);
        }

        [Fact]
        public void BST_BreathFirstSearchNotFound()
        {
            // Arrange
            BinaryNode<int> Node1 = new BinaryNode<int>(10);
            BinaryNode<int> Node2 = new BinaryNode<int>(8);
            BinaryNode<int> Node3 = new BinaryNode<int>(15);
            BinaryNode<int> Node4 = new BinaryNode<int>(5);
            BinaryNode<int> Node5 = new BinaryNode<int>(9);
            BinaryNode<int> Node6 = new BinaryNode<int>(12);
            BinaryNode<int> Node7 = new BinaryNode<int>(16);

            Node1.Left = Node2;
            Node1.Right = Node3;
            Node2.Left = Node4;
            Node2.Right = Node5;
            Node3.Left = Node6;
            Node3.Right = Node7;



            // Act
            var result = BinarySearchTree.Find(Node1, 20);

            // Assert
            Assert.False(result);
        }
    }
}
