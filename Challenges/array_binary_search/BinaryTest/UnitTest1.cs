using System;
using Xunit;
using array_binary_search;

namespace BinaryTest
{
    public class UnitTest1
    {
        [Fact]
        public void CanReturnNegativeOneTest()
        {
            int[] binaryArray = { 2, 4, 6, 8, 10, 11 };
            int integer = 3;
            Assert.Equal(-1, Program.BinarySearch(binaryArray, integer));
        }

        [Theory]
        [InlineData(new int[] { 1, 12, 39, 40, 52, 60 }, 40, 3)]
        [InlineData(new int[] { 11, 22, 35, 44, 56, 65 }, 22, 1)]
        public void CanReturnIntegerIndexTest(int[] binaryArray, int integer, int expectedIndex)
        {
            Assert.Equal(expectedIndex, Program.BinarySearch(binaryArray, integer));
        }
    }
}
