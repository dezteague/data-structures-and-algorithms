using System;
using Xunit;
using Tree;
using Tree.Classes;

namespace TreeTest
{
    public class UnitTest1
    {
        [Fact]
        public void PreOrderTest()
        {
            Node node = new Node(10);
            BinaryTree tree = new BinaryTree(node);
            node.LeftChild = new Node(20);
            node.RightChild = new Node(30);

            int[] preordertest = tree.PreOrder(node);

            Assert.Equal(10, preordertest[0]);
        }

        [Fact]
        public void InOrderTest()
        {
            Node node = new Node(10);
            BinaryTree tree = new BinaryTree(node);
            node.LeftChild = new Node(20);
            node.RightChild = new Node(30);

            int[] inordertest = tree.InOrder(node);

            Assert.Equal(10, inordertest[1]);
        }

        [Fact]
        public void PostOrderTest()
        {
            Node node = new Node(10);
            BinaryTree tree = new BinaryTree(node);
            node.LeftChild = new Node(20);
            node.RightChild = new Node(30);

            int[] postordertest = tree.PostOrder(node);

            Assert.Equal(10, postordertest[2]);
        }
    }
}
