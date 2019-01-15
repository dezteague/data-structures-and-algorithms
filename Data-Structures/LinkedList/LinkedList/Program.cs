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
            /*
            Console.WriteLine("Hello World!");
            //instantiate a new list
            LList list = new LList();
            //using these values
            int[] arrayofValues = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            for (int i =0; i < arrayofValues.Length; i++)
            {
                list.Insert(arrayofValues[i]);
            }*/

            static void NodeExample()
            {
                Node node = new Node(8);
                Console.WriteLine(node.Value);
                LList list = new LList();
                list.Insert(4);
                list.Insert(8);
                list.Insert(15);

                Console.WriteLine($"Does 8 exist?{list.Includes(8)}");
                Console.WriteLine($"Does 18 exist?{list.Includes(18)}");

                list.Print();
        }
            
        }  
    }

