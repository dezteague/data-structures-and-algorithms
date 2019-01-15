using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedList.Classes
{
    public class LList
    {
        //properties of Linked List Class: Head, Current
        public Node Head { get; set; }
        public Node Current { get; set; }

        /// <summary>
        /// Add a new value
        /// </summary>
        /// <param name="value">value to be added</param>
        public void Insert(int value)
        {
            //create a new node 
            Node node = new Node(value);
            //set the "Next" of a new node to the head
            node.Next = Head;
            //then move the Head to point to the new Node
            Head = node;
        }

        /// <summary>
        /// traverse through the data structure and see if a value exists
        /// </summary>
        /// <param name="value">verify value exists</param>
        public bool Includes(int value)
        {
            //traversal starts at the beginning of the list, using the current node
            Current = Head;
            //!= verifies that we are not at the end of the list
            while(Current.Next != null)
            {
                //conditional will return true if you've found the value
                if(Current.Value == value)
                {
                    return true;
                }
                //move on to the Next value in the list
                Current = Current.Next;
            }
            //repeats condition applied in the while loop, just to check the very last node
            if (Current.Value == value)
            {
                return true;
            }
            //bool default
            return false;
        }

        /// <summary>
        /// Print all node values
        /// </summary>
        public bool Print()
        {
            if(Head != null)
            {
                //Console.Write("Head ->");
                Current = Head;
                //loop through the Nodes until you get to the end, where Next = null
                while (Current.Next != null)
                {
                    System.Console.WriteLine($"{Current.Value} =>");
                    Current = Current.Next;
                }
                System.Console.WriteLine($"{Current.Value} => null");
            }
            else
            {
                Console.WriteLine("Your list is empty");
            }
            return true;
        }

       
    }
}
