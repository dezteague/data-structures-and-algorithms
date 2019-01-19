using System;
using System.Collections.Generic;
using System.Text;

namespace StacksAndQueues.Classes
{
    class Queue
    {
        //top property
        public Node Top { get; set; }
        public Node Front { get; set; }

        /// <summary>
        /// Instantiate an empty queue
        /// </summary>
        public Queue()
        {

        }

        /// <summary>
        /// Default empty value assigned to top
        /// <param name="node">node</param>
        /// </summary>
        public Queue(Node node)
        {
            Front = node;
        }
    }
}
