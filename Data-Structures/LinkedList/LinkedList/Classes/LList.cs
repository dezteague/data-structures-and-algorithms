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

        /// <summary>
        /// Append to the end of the list
        /// </summary>
        /// <param name="value">verify value exists</param>
        public void Append(int value)
        {
            //if next is not null, we are not at the end of the list yet
            while (Current.Next != null)
            {
                Current = Current.Next;
            }
            //instantiate new node
            Node node = new Node(value);
            //current node points to new node
            Current.Next = node;
        }

        /// <summary>
        /// Insert a newValue before a given value
        /// </summary>
        /// <param name="value"></param>
        /// <param name="Newvalue"></param>
        public void InsertBefore(int value, int newValue)
        {
            //starting at the Head node
            Current = Head;
            //if you hit the desired value, go ahead and insert newValue immediately
            if(Current.Value == value)
            {
                Insert(newValue);
                return;
            }

            while(Current.Next != null)
            {
                //1. find the .Next that equals the target
                if(Current.Next.Value == value)
                {
                    //2. instantiate the new node
                    Node node = new Node(newValue);
                    //3. make node.Next = current.next
                    node.Next = Current.Next;
                    //4. make current.Next = node
                    Current.Next = node;
                    return;
                }
                Current = Current.Next;
            }
        }

        /// <summary>
        /// Insert a newValue after a given value
        /// </summary>
        /// <param name="value"></param>
        /// <param name="Newvalue"></param>
        public void InsertAfter(int value, int newValue)
        {
            Current = Head;

            while (Current.Next != null)
            {
                //1. find the given value
                if(Current.Value == value)
                {
                    //2. instantiate new node
                    Node node = new Node(newValue);
                    //3. make new node.Next = current.next
                    node.Next = Current.Next;
                    Current.Next = node;
                    return;
                }
                Current = Current.Next;
            }   
        }
    }
}
