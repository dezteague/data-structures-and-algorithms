using System;
using System.Collections.Generic;
using System.Text;

namespace StacksAndQueues.Classes
{
    class Stack
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
        /// </summary>
        public Stack(Node node)
        {
            Top = node;
        }

        /// <summary>
        /// Add a new node to the top
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
    }
}
