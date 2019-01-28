using System;
using System.Collections.Generic;
using System.Text;

namespace Tree.Classes
{
    public class Node
    {
        public int Value { get; set; }
        public int LeftChild { get; set; }
        public int RightChild { get; set; }

        public Node()
        {

        }

        public Node(int value)
        {
            Value = value;
        }
    }
}
