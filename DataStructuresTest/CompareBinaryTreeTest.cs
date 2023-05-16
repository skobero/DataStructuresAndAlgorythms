using DataStructures.Helpers;
using DataStructures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresTest
{
    public class CompareBinaryTreeTest
    {
        [Fact]
        public void CBT_AreSame()
        {
            // Arrange
            BinaryNode<int> T1Node1 = new BinaryNode<int>(1);
            BinaryNode<int> T1Node2 = new BinaryNode<int>(2);
            BinaryNode<int> T1Node3 = new BinaryNode<int>(3);
            BinaryNode<int> T1Node4 = new BinaryNode<int>(4);
            BinaryNode<int> T1Node5 = new BinaryNode<int>(5);

            T1Node1.Left = T1Node2;
            T1Node1.Right = T1Node3;
            T1Node2.Left = T1Node4;
            T1Node2.Right = T1Node5;

            BinaryNode<int> T2Node1 = new BinaryNode<int>(1);
            BinaryNode<int> T2Node2 = new BinaryNode<int>(2);
            BinaryNode<int> T2Node3 = new BinaryNode<int>(3);
            BinaryNode<int> T2Node4 = new BinaryNode<int>(4);
            BinaryNode<int> T2Node5 = new BinaryNode<int>(5);

            T2Node1.Left = T2Node2;
            T2Node1.Right = T2Node3;
            T2Node2.Left = T2Node4;
            T2Node2.Right = T2Node5;


            // Act
            var result = CompareBinaryTree.Compare(T1Node1, T2Node1);

            // Assert
            Assert.True(result);
        }

        [Fact]
        public void CBT_AreNotSame()
        {
            // Arrange
            BinaryNode<int> T1Node1 = new BinaryNode<int>(1);
            BinaryNode<int> T1Node2 = new BinaryNode<int>(2);
            BinaryNode<int> T1Node3 = new BinaryNode<int>(3);
            BinaryNode<int> T1Node4 = new BinaryNode<int>(4);
            BinaryNode<int> T1Node5 = new BinaryNode<int>(5);

            T1Node1.Left = T1Node2;
            T1Node1.Right = T1Node3;
            T1Node2.Left = T1Node4;
            T1Node2.Right = T1Node5;

            BinaryNode<int> T2Node1 = new BinaryNode<int>(1);
            BinaryNode<int> T2Node2 = new BinaryNode<int>(2);
            BinaryNode<int> T2Node3 = new BinaryNode<int>(3);
            BinaryNode<int> T2Node4 = new BinaryNode<int>(4);
            BinaryNode<int> T2Node5 = new BinaryNode<int>(5);

            T2Node1.Left = T2Node2;
            T2Node1.Right = T2Node3;
            T2Node2.Left = T2Node5;
            T2Node2.Right = T2Node4;


            // Act
            var result = CompareBinaryTree.Compare(T1Node1, T2Node1);

            // Assert
            Assert.False(result);
        }
    }
}
