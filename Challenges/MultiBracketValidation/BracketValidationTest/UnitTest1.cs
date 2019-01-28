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
    }
}
