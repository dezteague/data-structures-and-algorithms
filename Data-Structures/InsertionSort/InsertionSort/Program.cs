using System;

namespace InsertionSort
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        public static int [] InsertionSort(int [] array)
        {
            //go through the length of the input array
            for (int i = 0; i < array.Length -1; i++)
            {
                //nested for loop uses j to compare the right adjacent index
                for (int j = i + 1; j > 0; j--)
                {
                    //if the adjacent index to the left 
                    if(array[j-1] > array[j])
                    {
                        int tempvalue = array[j - 1];

                        //insert the greater value to the right
                        array[j - 1] = array[j];
                        array[j] = tempvalue;
                    }
                }
            }
            //return the sorted array
            return array;
        }
    }
}
