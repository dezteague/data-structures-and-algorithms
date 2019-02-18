using System;
using System.Collections.Generic;
using System.Text;

namespace Hashtables.Classes
{
    class Node
    {
        //Node properties

        public string Key { get; set; }
        public object Value { get; set; }
        
        //next node works as a solution to collision by creating a linked list
        public Node Next { get; set; }

        /// <summary>
        /// Node constructor takes in a key and value 
        /// </summary>
        /// <param name="key"></param>
        /// <param name="value"></param>
        public Node(string key, object value)
        {
            Key = key;
            Value = value;
        }
    }
}
