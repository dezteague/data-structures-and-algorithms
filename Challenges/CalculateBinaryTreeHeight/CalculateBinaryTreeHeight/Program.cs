using System;
using Tree.Classes;

namespace CalculateBinaryTreeHeight
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Node node = new Node(10);
            node.LeftChild = new Node(20);
            node.RightChild = new Node(30);
            node.RightChild.LeftChild = new Node(40);
            node.RightChild.RightChild = new Node(50);
        }
    }
}
