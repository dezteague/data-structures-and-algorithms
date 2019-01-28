using System;
using Xunit;
using MultiBracketValidation;

namespace BracketValidationTest
{
    public class UnitTest1
    {
        [Fact]
        public void ValidateCurlyBraces()
        {
            string test1 = "{}";
            Assert.True(Program.MultiBracketValidation(test1));
        }

        [Fact]
        public void InValidateUnmatchedBrackets()
        {
            string test2 = "{]}";
            Assert.False(Program.MultiBracketValidation(test2));
        }

        [Fact]
        public void CheckLongString()
        {
            string test3 = "[{[]()}{()}]";
            Assert.True(Program.MultiBracketValidation(test3));
        }
    }
}
