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

            Console.WriteLine(CalculateBinaryTreeHeight(root));
        }

        public static int CalculateBinaryTreeHeight(Node root)
        {
            int height = 0;
            int leftHeight = 0;
            int rightHeight = 0;

            if (root == null)
            {
                return 0;
            }
            if (root != null)
            {
                leftHeight = Math.Abs(CalculateBinaryTreeHeight(root.LeftChild));
                rightHeight = Math.Abs(CalculateBinaryTreeHeight(root.RightChild));

            }
            if (leftHeight > rightHeight)
            {
                height= leftHeight;
            }
            if (rightHeight> leftHeight)
            {
                height= rightHeight;
            }
            return height;
        }
    }
}
