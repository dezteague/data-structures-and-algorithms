using System;
using Hashtables.Classes;

namespace EC_UniqueCharacters
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        public bool Unique(string input)
        {
            Hashtable set = new Hashtable(1024);

            for(int i = 0; i < input.Length; i++ )
            {
            
                if(set.Contains(input[i]))
                {
                    return false;
                }
                else
                {
                    set.Add(input[i]);
                }
            }
        }
    }
}
