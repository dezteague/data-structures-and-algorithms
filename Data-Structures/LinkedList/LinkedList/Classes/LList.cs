using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedList.Classes
{
    class LList
    {
        //properties of Linked List Class: Head, Current
        public Node Head { get; set; }
        public Node Current { get; set; }

        public LList(Node node)
        {
            Head = node;
        }
        
        //to add a new value
        public void Insert(int value)
        {
            //create a new node 
            Node node = new Node(value);
            //set the "Next" of a new node to the head
            node.Next = Head;
            //then move the Head to point to the new Node
            Head = node;
        }

        //to traverse through the data structure and see if a value exists. pass in a value to check
        //method will return true or false
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

        public void Print()
        {
            Console.Write("Head ->");
            Node Current = Head;
            while (Current.Next != null)
            {
                Current = Current.Next;
                Console.Write(Current.Value);
                Console.Write("->");
            }
            Console.Write("null");
        }
    }
}
