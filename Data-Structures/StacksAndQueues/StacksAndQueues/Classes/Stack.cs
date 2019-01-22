using System;
using System.Collections.Generic;
using System.Text;

namespace StacksAndQueues.Classes
{
    public class Stack
    {
        //top property
        public Node Top { get; set; }

        /// <summary>
        /// Instantiate an empty stack
        /// </summary>
        public Stack()
        {

        }

        /// <summary>
        /// Default empty value assigned to top
        /// <param name="node">node</param>
        /// </summary>
        public Stack(Node node)
        {
            Top = node;
        }

        /// <summary>
        /// Add a new node to the top
        /// <param name="value">int</param>
        /// </summary>
        public void Push(int value)
        {
            //instantiate a new node using the value
            Node node = new Node(value);
            //set the next of the new node to the top
            node.Next = Top;
            //new node is now the top
            Top = node;
        }

        /// <summary>
        /// Remove node from the top
        /// </summary>
        /// <returns>temp</returns>
        public Node Pop()
        {
            //create a temporary node
            Node temp = Top;
            //set the top to the next node
            Top = Top.Next;
            //clear the reference to next on the temp
            temp.Next = null;
            //return the temp node
            return temp;
        }

        /// <summary>
        /// Show the top node in the stack
        /// </summary>
        /// <returns>temp</returns>
        public Node Peek()
        {
            return Top;
        }
    }
}
