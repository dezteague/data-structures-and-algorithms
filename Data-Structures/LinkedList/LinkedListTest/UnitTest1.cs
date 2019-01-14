using System;
using Xunit;
using LinkedList.Classes;

namespace LinkedListTest
{
    public class UnitTest1
    {
        [Fact]
        public void InsertValueTest()
        {
            int num = 5;
            LList test = new LList();
            test.Insert(num);
            Assert.Equal(5, test.Head.Value);
        }

        [Fact]
        public void IncluedesValueTest()
        {
            int num = 5;
            LList test = new LList();
            test.Insert(num);
            Assert.True(test.Includes(num));
        }
    }
}
