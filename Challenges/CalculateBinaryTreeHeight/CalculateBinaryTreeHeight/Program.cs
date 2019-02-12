using System;
using Tree.Classes;


namespace CalculateBinaryTreeHeight
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Node root = new Node(10);
            root.LeftChild = new Node(20);
            root.RightChild = new Node(30);
            root.RightChild.LeftChild = new Node(40);
            root.RightChild.RightChild = new Node(50);

            Console.WriteLine(CalculateBinaryTreeHeight(root));

            Node testroot = new Node(10);
            testroot.LeftChild = new Node(20);
            testroot.RightChild = new Node(30);
            testroot.RightChild.LeftChild = new Node(40);
            testroot.RightChild.RightChild = new Node(50);
            testroot.RightChild.LeftChild.LeftChild = new Node(60);

            Console.WriteLine(CalculateBinaryTreeHeight(testroot));
        }

        /// <summary>
        /// Finds the height of a binary tree
        /// </summary>
        /// <param name="root"></param>
        /// <returns>height integer</returns>
        public static int CalculateBinaryTreeHeight(Node root)
        {
            int treeheight = 0;

            if (root == null)
            {
                return 0;
            }
            if (root != null)
            {
                treeheight = Math.Max(CalculateBinaryTreeHeight(root.LeftChild), CalculateBinaryTreeHeight(root.RightChild))+1;
                
            }

            return treeheight;
        }
    }
}
