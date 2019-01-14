using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedList.Classes
{
    public class Node
    {
        //has two properties: value and next
        public int Value { get; set; }

        public Node Next { get; set; }

        //constructor method
        public Node(int value)
        {
            Value = value;
        }
    }
}
