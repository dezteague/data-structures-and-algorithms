using System;
using LinkedList.Classes;

namespace ll_kth_from_end
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            //instantiate linked list and insert values
            Console.WriteLine("linked list");
            Console.WriteLine("");

            LList list = new LList();
            list.Insert(4);
            list.Insert(8);
            list.Insert(15);
            list.Insert(23);
            list.Insert(31);
            list.Insert(44);
            list.Print();
            Console.WriteLine("");

            //invoke the method using list and k as parameters
            Console.WriteLine($"1st value from the end: {FindKthFromEnd(list, 0)}");
            Console.WriteLine($"2nd value from the end: {FindKthFromEnd(list, 1)}");
            Console.WriteLine($"3rd value from the end: {FindKthFromEnd(list, 2)}");
            Console.WriteLine($"4th value from the end: {FindKthFromEnd(list, 3)}");
            Console.WriteLine($"5th value from the end: {FindKthFromEnd(list, 4)}");
            Console.WriteLine($"6th value from the end: {FindKthFromEnd(list, 5)}");

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
