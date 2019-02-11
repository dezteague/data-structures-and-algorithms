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

        [Fact]
        public void UniqueCharsReturnTrueTest()
        {
            string letters = "abcdefg";
            Assert.True(Program.AreCharactersUnique(letters));
        }

        [Fact]
        public void CaseSensitiveTest()
        {
            string cases = "aAbBcC";
            Assert.True(Program.AreCharactersUnique(cases));
        }
    }
}
