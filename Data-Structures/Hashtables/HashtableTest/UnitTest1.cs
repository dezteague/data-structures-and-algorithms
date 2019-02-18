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
            Hashtable table = new Hashtable(2);

            //add (string key, object value)
            table.Add("Hello  World", 1);

            Assert.True(table.Contains("Hello World"));
        }
    }
}
