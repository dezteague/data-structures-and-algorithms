using System;
using System.Collections.Generic;
using System.Text;

namespace Hashtables.Classes
{
    public class Hashtable
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

        /// <summary>
        /// Add a node to the table and set its key:value properties.  If there is a collision, create linked list
        /// </summary>
        /// <param name="key"></param>
        /// <param name="value"></param>
        public void Add(string key, object value)
        {
            //instantiate a new node
            Node newAddition = new Node(key, value);

            //use the Hash method to get the key's hash index
            int keyIndex = Hash(key);

            //if there is no pre-existing value, assign it to the table
            if(Htable[keyIndex]==null)
            {
                Htable[keyIndex] = newAddition;
            }

            //if there is a collision, create linked list
            else
            {
                Node current = Htable[keyIndex];
                while(current.Next != null)
                {
                    current = current.Next;
                }
                //new node is chained 
                current.Next = newAddition;
            }
        }

        /// <summary>
        /// Determines whether or not a key exists in a hashtable
        /// </summary>
        /// <param name="key"></param>
        /// <returns>true/false</returns>
        public bool Contains(string key)
        {
            int keyIndex = Hash(key);

            //return true if the key property matches the input key
            if (Htable[keyIndex].Key == key)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// takes in the key and returns the value from the table.
        /// </summary>
        /// <param name="key"></param>
        /// <returns>value for the input key</returns>
        public object Get(string key)
        {
            int keyIndex = Hash(key);
            
            //if the key does not exist, return null
            if (Htable[keyIndex].Key == null)
            {
                return null;
            }

            //if the input key is equal to a key in the table, return its value pair
            else if (Htable[keyIndex].Key == key)
            {
                return Htable[keyIndex].Value;
            }
            else
            {
                //in case of a collision
                Node current = Htable[keyIndex];
                while(current.Key != key)
                {
                    current = current.Next;
                }
                //return the value from a node in the linked list
                return current.Value;
            }
        }
    }
}
