using System;

namespace AreCharactersUnique
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Console.WriteLine("Does my nickname 'Dezi' have all unique characters?");
            string nickname = "Dezi";
            AreCharactersUnique(nickname);

            Console.WriteLine("Does my real name 'Deziree' have all unique characters?");
            string realname = "Deziree";
            AreCharactersUnique(realname);
        }

        /// <summary>
        /// Tests for unique characters in a string
        /// </summary>
        /// <param name="str">string</param>
        /// <returns>true or false</returns>
        public static bool AreCharactersUnique(string str)
        {
            char[] chararray = str.ToCharArray();
            for (int i = 0; i < chararray.Length; i++)
            {
                for (int j = i + 1; j < chararray.Length; j++)
                {
                    if (chararray[i] == chararray[j])
                    {
                        Console.WriteLine("Nope");
                        return false;
                    }
                }           
            }
            Console.WriteLine("Yes");
            return true;
        }
    }
}
