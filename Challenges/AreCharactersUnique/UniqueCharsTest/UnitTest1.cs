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
            //duplicates return false
            Assert.False(Program.AreCharactersUnique(numbers));
        }

        [Fact]
        public void UniqueCharsReturnTrueTest()
        {
            string letters = "abcdefg";
            //unique characters return true
            Assert.True(Program.AreCharactersUnique(letters));
        }

        [Fact]
        public void CaseSensitiveTest()
        {
            string cases = "aAbBcC";
            //lower case and upper case versions of the same letter are considered unique
            Assert.True(Program.AreCharactersUnique(cases));
        }
    }
}
