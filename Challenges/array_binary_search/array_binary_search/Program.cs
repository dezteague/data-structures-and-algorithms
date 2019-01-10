using System;

namespace array_binary_search
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] binaryArray = new int[] { 4, 8, 15, 16, 23, 42 };
    
            int integer = 15;

            //int indexOfSortedArray = Method(parameters)
        }

        static int BinarySearch(int[] binaryArray, int integer)
        {
            int midpoint = binaryArray.Length/2;

            if (integer == binaryArray[midpoint])
            {
                return midpoint;
            }

            int arrayStart = binaryArray[0];
            //int arrayFinish = binaryArray.Length -1;

            if (integer < binaryArray[midpoint])
            {
                //return BinarySearch (binaryArray(from 0 to midpoint), integer)
            }
            else
            {
                //int offsetIndex = BinarySearch (binaryArray(from midpoint to end), integer)
                if 
            }
        }
    }
}
