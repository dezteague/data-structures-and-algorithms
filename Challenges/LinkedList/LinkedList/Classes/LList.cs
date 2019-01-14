using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedList.Classes
{
    class LList
    {
        public Node Head { get; set; }
        
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
    }
}
