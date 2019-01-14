using LinkedList.Classes;
using System;

namespace LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            //instantiate a new list
            LList list = new LList();
            //using these values
            int[] arrayofValues = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            for (int i =0; i < arrayofValues.Length; i++)
            {
                list.Insert(arrayofValues[i]);
            }
            list.Print();
        }  
    }
}
