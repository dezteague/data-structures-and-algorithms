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
    }
}
