using System;
using System.Collections.Generic;
using System.Text;

namespace StacksAndQueues.Classes
{
    public class Queue
    {
        //top property
        public Node Front { get; set; }
        public Node Rear { get; set; }

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
            Rear = node;
        }

        /// <summary>
        /// Add a new node to the rear
        /// <param name="value">int</param>
        /// </summary>
        public void Enqueue(int value)
        {
            //create new node
            Node node = new Node(value);
            //set next of rear to the new node
            Rear.Next = node;
            //the rear becomes the new node
            Rear = node;
        }

        /// <summary>
        /// Add a new node to the rear
        /// </summary>
        /// <returns>temp</returns>
        public Node Dequeue()
        {
            //create a temp node to hold the original front
            Node temp = Front;
            //change the front refernce to next node
            Front = Front.Next;
            //clear our the next reference for the node that stands alone
            temp.Next = null;
            //return the temp node
            return temp;
        }

        /// <summary>
        /// Show the front node in the queue
        /// </summary>
        /// <returns>temp</returns>
        public Node Peek()
        {
            return Front;
        }
    }
}
