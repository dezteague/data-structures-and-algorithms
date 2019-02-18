using System;
using System.Collections.Generic;
using System.Text;

namespace Hashtables.Classes
{
    class Hashtable
    {
        //Properties: 
        //storage container for the nodes
        public Node[] Htable { get; set; }
        
        //number of buckets
        public int Buckets { get; set; }

        //constructor
        public Hashtable(int buckets)
        {
            //the number of buckets sets the length of the table "array"
            Htable = new Node[buckets];
            Buckets = buckets;
        }

        /// <summary>
        /// takes in an arbitrary key as a string, conducts the hash, and returns an index in the array
        /// </summary>
        /// <param name="key"></param>
        /// <returns>index</returns>
        public int Hash(string key)
        {
            int indexValue = 0;

            //add the ASCII value of each character
            for (int i = 0; i < key.Length; i++)
            {
                indexValue += key[i];
            }
      
            //divide the value by the number of buckets
            indexValue = indexValue % Buckets;
            
            //return the index integer
            return indexValue;
        }
    }
}
