using System;
using LinkedList.Classes;

namespace ll_kth_from_end
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            
            //instantiate linked list and insert values
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
            //assign the current to head
            list.Current = list.Head;
            //create new node to traverse through list
            Node Traversal = list.Head;
            //set counter to zero
            int counter = 0; 
            //run this loop while have not reached the end of the list (reference is not null)
            while (list.Current.Next != null)
            {
                counter++;
                //if the counter is greater than k, the traversal node will start to increment
                if( counter > k)
                {
                    Traversal = Traversal.Next;
                }

                list.Current = list.Current.Next;
            }
            //if the kth value is out of bounds for the list, the return value will be zero
            if (k > counter)
            {
                Console.WriteLine("Sorry, out of bounds! value does not exist in the list");
                return 0;
            }
            else
            {
                //this is the value of k
                return Traversal.Value;
            }
            
        }
    }
}
