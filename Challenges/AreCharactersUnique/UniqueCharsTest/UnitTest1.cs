using System;
using Xunit;
using AreCharactersUnique;

namespace UniqueCharsTest
{
    public class UnitTest1
    {
        [Fact]
        public void DuplicatesReturnFalseTest()
        {
            string numbers = "2263321";
            Assert.False(Program.AreCharactersUnique(numbers));
        }
    }
}
