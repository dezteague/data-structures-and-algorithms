using Hashtables.Classes;
using System;
using Xunit;

namespace HashtableTest
{
    public class UnitTest1
    {
        [Fact]
        public void CanAddtoHashtableTest()
        {
            //instantiate a hashtable
            Hashtable table = new Hashtable(10);

            //add (string key, object value)
            table.Add("HelloWorld", 1);

            Assert.True(table.Contains("HelloWorld"));
        }

        [Fact]
        public void KeyDoesNotExistTest()
        {
            //instantiate a hashtable
            Hashtable table = new Hashtable(10);

            //add (string key, object value)
            table.Add("HelloWorld", 1);

            Assert.False(table.Contains("ola"));
        }
    }
}
