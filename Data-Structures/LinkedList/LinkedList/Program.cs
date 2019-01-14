using LinkedList.Classes;
using System;

namespace LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            NodeExample();
        }

        static void NodeExample()
        {
            Node node = new Node(8);
            Console.WriteLine(node.Value);
            LList list = new LList(new Node(5));
            list.Insert(4);
            list.Insert(8);
            list.Insert(15);

            Console.WriteLine($"Does 8 exist?{list.Includes(8)}");
            Console.WriteLine($"Does 18 exist?{list.Includes(18)}");
        }
    }
}
