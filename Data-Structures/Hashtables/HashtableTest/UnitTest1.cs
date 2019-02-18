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
            Hashtable table = new Hashtable(100);

            //add (string key, object value)
            table.Add("Hello  World", 1);

            Assert.True(table.Contains("Hello World"));
        }

        [Fact]
        public void KeyDoesNotExistTest()
        {
            //instantiate a hashtable
            Hashtable table = new Hashtable(100);

            //add (string key, object value)
            table.Add("Hello  World", 1);

            var result = table.Get("random");

            Assert.Null(result);
        }
    }
}
