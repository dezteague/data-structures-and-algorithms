using System;
using Xunit;
using Tree.Classes;
using CalculateBinaryTreeHeight;

namespace BinaryTreeHeightTest
{
    public class UnitTest1
    {
        [Fact]
        public void ReturnsHeightTestOne()
        {
            Node root = new Node(10);
            root.LeftChild = new Node(20);
            root.RightChild = new Node(30);

            int height = Program.CalculateBinaryTreeHeight(root);

            Assert.Equal(2, height);
        }

        [Fact]
        public void ReturnsHeightTestTwo()
        {
            Node root = new Node(10);
            root.LeftChild = new Node(20);
            root.RightChild = new Node(30);
            root.RightChild.LeftChild = new Node(40);
            root.RightChild.RightChild = new Node(50);

            int height = Program.CalculateBinaryTreeHeight(root);

            Assert.Equal(3, height);
        }

        [Fact]
        public void ReturnsHeightTestThree()
        {
            Node root = new Node(10);
            root.LeftChild = new Node(20);
            root.RightChild = new Node(30);
            root.RightChild.LeftChild = new Node(40);
            root.RightChild.RightChild = new Node(50);
            root.RightChild.LeftChild.LeftChild = new Node(60);

            int height = Program.CalculateBinaryTreeHeight(root);

            Assert.Equal(4, height);
        }

    }
}
