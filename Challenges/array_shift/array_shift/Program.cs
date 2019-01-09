using System;

namespace array_shift
{
    class Program
    {
        static void Main(string[] args)
        {
           
            
            int[] inputArray = new int[] { 2, 4, 6, 8 };
            int addValue = 5;
            int[] outputArray = ArrayShift(inputArray, addValue);
            for (int i = 0; i < outputArray.Length; i++)
            {
                Console.WriteLine(outputArray[i]);
            }
        }
  
        static int[] ArrayShift(int[] inputArray, int addValue)
        {
            //set length of the new array
            int[] outputArray = new int[inputArray.Length + 1];

            //loop through the first half of the array
            for (int i = 0; i < inputArray.Length / 2; i++)
            {
                //assign indeces from input to output
                outputArray[i] = inputArray[i];
            }

            //insert the additional value after the midpoint
            outputArray[inputArray.Length / 2] = addValue ;

            //loop through the second half of the array
            for (int i = inputArray.Length/2 + 1; i < outputArray.Length; i++)
            {
                //assign indeces from input to output, after the midpoint
                outputArray[i] = inputArray[i-1];
            }

            return outputArray;

        }
    }
}
