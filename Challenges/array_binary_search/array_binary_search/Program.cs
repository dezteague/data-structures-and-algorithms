using System;

namespace array_binary_search
{
    public class Program
    {
        static void Main(string[] args)
        {
            int[] binaryArray = new int[] { 4, 8, 15, 16, 23, 42 };
            int integer = 15;
            Console.WriteLine(BinarySearch(binaryArray, integer));
        }

        public static int BinarySearch(int[] binaryArray, int integer)
        {
            //these variables will be used in conditional 
            int min = 0;
            int max = binaryArray.Length - 1;

            //loop through the binary array until the integer is hit OR reach end of array
            while(min <= max)
            {
                int midpoint = (min + max) / 2;
                //if the integer is greater than the midpoint value, run through the right side of the binary array
                if (binaryArray[midpoint] < integer)
                {
                    min = midpoint + 1;
                }
                //if the integer is less than the midpoint value, run through the left side of the binary array
                else if (binaryArray[midpoint] > integer)
                {
                    max = midpoint - 1;
                }
                //or if the integer matches the midpoint, return the index
                else
                {
                    return midpoint;
                }
            }
            return -1;
        }
    }
}
