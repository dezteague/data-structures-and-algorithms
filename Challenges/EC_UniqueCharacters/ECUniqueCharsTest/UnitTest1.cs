using System;
using Xunit;
using Hashtables.Classes;
using EC_UniqueCharacters;

namespace ECUniqueCharsTest
{
    public class UnitTest1
    {
        [Fact]
        public void UniqueCharsTest()
        {
            string input = "hola";
            Assert.True(Program.Unique(input));
        }

        [Fact]
        public void DuplicateCharsTest()
        {
            string input = "hello";
            Assert.False(Program.Unique(input));
        }

        [Fact]
        public void CaseSensitivityTest()
        {
            //lower case and upper case versions of the same letter are considered unique
            string input = "ABCabc";
            Assert.True(Program.Unique(input));
        }
    }
}
