using InsertionSort;
using System;
using Xunit;

namespace InsertSortTest
{
    public class UnitTest1
    {
        [Fact]
        public void CanSortRandomArrayTest()
        {
            int[] array = new int[5]{ 6, 0, 3, 4, 1 };
            int[] results = new int[5] { 0, 1, 3, 4, 6 };
            Assert.Equal(results, Program.InsertionSort(array));
        }
    }
}