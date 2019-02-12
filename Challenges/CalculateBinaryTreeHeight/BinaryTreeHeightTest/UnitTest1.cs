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
    }
}
