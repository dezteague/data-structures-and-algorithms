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
        public static bool Unique(string input)
        {
            //instanitate a new hashtable
            Hashtable set = new Hashtable(1024);

            for(int i = 0; i < input.Length; i++ )
            {
                string inputCharacter = Convert.ToString(input[i]);
            
                //if the hashset already contains the character, it is a duplicate.  Therefore returns false
                if(set.Contains(inputCharacter))
                {
                    return false;
                }

                //if the hashset does not contain the character, add it.  
                else
                {
                    set.Add(inputCharacter, inputCharacter);
                }
            }

            return true;
        }
    }
}
