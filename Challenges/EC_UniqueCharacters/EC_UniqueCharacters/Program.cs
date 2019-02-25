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

        /// <summary>
        /// Determine if a string has all unique characters
        /// </summary>
        /// <param name="input">input string</param>
        /// <returns>true or false</returns>
        public bool Unique(string input)
        {
            Hashtable set = new Hashtable(1024);

            for(int i = 0; i < input.Length; i++ )
            {
                string inputCharacter = Convert.ToString(input[i]);
            
                if(set.Contains(inputCharacter))
                {
                    return false;
                }
                else
                {
                    set.Add(inputCharacter, inputCharacter);
                }
            }

            return true;
        }
    }
}
