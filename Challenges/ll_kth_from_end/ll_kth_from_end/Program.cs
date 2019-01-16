using System;
using LinkedList.Classes;

namespace ll_kth_from_end
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            
            //instantiate linked list and inserted values
            LList list = new LList();
            list.Insert(4);
            list.Insert(8);
            list.Insert(15);
            list.Insert(23);
            list.Insert(31);
            list.Insert(44);
            list.Print();
            //invoke the method using list and k as parameters
            Console.WriteLine($"{FindKthFromEnd(list, 0)}");

            Console.ReadLine();
        }

        public static int FindKthFromEnd(LList list, int k)
        {
            list.Current = list.Head;
            Node Traversal = list.Head;
            int counter = 0; 
            while (list.Current.Next != null)
            {
                counter++;
                if( counter > k)
                {
                    Traversal = Traversal.Next;
                }
                list.Current = list.Current.Next;
            }
            if (k > counter)
            {

                Console.WriteLine("Sorry");
                return 0;
            }
            else
            {

            }
            return Traversal.Value;
        }
    }
}
