using System;

namespace AreCharactersUnique
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        public static bool AreCharactersUnique(string str)
        {
            char[] chararray = str.ToCharArray();
            for (int i = 0; i < chararray.Length; i++)
            {
                for (int j = i; j < chararray.Length; j++)
                {
                    if (chararray[i] == chararray[j])
                    {
                        return false;
                    }
                    else
                    {
                        return true;
                    }
                }
                
            }
        }
    }
}
