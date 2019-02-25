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
    }
}
