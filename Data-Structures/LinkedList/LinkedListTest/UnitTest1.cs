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
        public void IncludesValueTest()
        {
            int num = 5;
            LList test = new LList();
            test.Insert(num);
            Assert.True(test.Includes(num));
        }

        [Fact]
        public void NonExistentValueTest()
        {
            
            LList test = new LList();
            test.Insert(55);
            Assert.False(test.Includes(5));
        }

        [Fact]
        public void PrintAllValuesTest()
        {
            
            LList test = new LList();
            test.Insert(10);
            test.Insert(20);
            test.Insert(30);
            Assert.True(test.Print());
        }
    }
}
