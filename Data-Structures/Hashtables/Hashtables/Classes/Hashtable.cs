using System;
using System.Collections.Generic;
using System.Text;

namespace Hashtables.Classes
{
    class Hashtable
    {
        //Property: storage container for the nodes
        public Node[] Htable { get; set; }

        //constructor
        public Hashtable(int buckets)
        {
            //the number of buckets sets the length of the table "array"
            Htable = new Node[buckets];
        }
    }
}
