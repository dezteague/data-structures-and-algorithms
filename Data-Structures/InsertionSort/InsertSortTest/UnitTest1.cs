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

        [Fact]
        public void SortedArrayReturnsSortedTest()
        {
            int[] array = new int[5] { 0, 1, 3, 4, 6 };
            int[] results = new int[5] { 0, 1, 3, 4, 6 };
            Assert.Equal(results, Program.InsertionSort(array));
        }

        [Fact]
        public void BackwardsArrayReturnsSortedTest()
        {
            int[] array = new int[5] { 6, 4, 3, 1, 0 };
            int[] results = new int[5] { 0, 1, 3, 4, 6 };
            Assert.Equal(results, Program.InsertionSort(array));
        }

        [Fact]
        public void EmptyArrayReturnsEmptyTest()
        {
            int[] array = new int[] { };
            int[] results = new int[] { };
            Assert.Equal(results, Program.InsertionSort(array));
        }

        [Fact]
        public void SingleElementArrayReturnsOneTest()
        {
            int[] array = new int[1] { 6};
            int[] results = new int[1] {6 };
            Assert.Equal(results, Program.InsertionSort(array));
        }
    }
}
