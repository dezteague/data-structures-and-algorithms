using System;
using LinkedList.Classes;

namespace RemoveDuplications
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Node node = new Node(1);
            LList list = new LList();
            list.Insert(1);
            list.Insert(2);
            list.Insert(2);
            list.Insert(3);
            list.Insert(3);

            
        }

        /// <summary>
        /// remove duplicate nodes from a linked list
        /// </summary>
        /// <param name="node"></param>
        //public static void RemoveDuplicates(Node node)
        //{
        //    var startingNode = node;
           
        //    while (startingNode != null)
        //    {
        //        var next = startingNode;
        //        while(next.Next != null)
        //        {
        //            if (next.Next.Value.Equals(startingNode.Value))
        //            {
        //                next.Next = next.Next.Next;
        //            }
        //            else next = next.Next;
        //        }
        //        startingNode = startingNode.Next;
        //    }
           
        //}
    }
}
