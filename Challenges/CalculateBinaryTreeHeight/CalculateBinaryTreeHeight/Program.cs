using System;
using Tree.Classes;

namespace CalculateBinaryTreeHeight
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Node root = new Node(10);
            root.LeftChild = new Node(20);
            root.RightChild = new Node(30);
            root.RightChild.LeftChild = new Node(40);
            root.RightChild.RightChild = new Node(50);
        }

        public static int CalculateBinaryTreeHeight(Node root)
        {
            if (root == null)
            {
                return 0;
            }
            else
            {
                return Math.Max(CalculateBinaryTreeHeight(root.LeftChild), CalculateBinaryTreeHeight(root.RightChild));
            }
        }
    }
}
