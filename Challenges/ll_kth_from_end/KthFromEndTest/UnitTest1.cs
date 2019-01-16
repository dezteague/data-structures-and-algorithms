using System;
using Xunit;
using LinkedList.Classes;
using ll_kth_from_end;

namespace KthFromEndTest
{
    public class UnitTest1
    {
        [Fact]
        public void FirstFromEnd()
        {
            LList list = new LList();
            list.Insert(4);
            list.Insert(8);
            list.Insert(15);
            list.Insert(23);
            list.Insert(31);
            list.Insert(44);
            Assert.Equal(4, Program.FindKthFromEnd(list, 0));
        }

        [Fact]
        public void SecondFromEnd()
        {
            LList list = new LList();
            list.Insert(4);
            list.Insert(8);
            list.Insert(15);
            list.Insert(23);
            list.Insert(31);
            list.Insert(44);
            Assert.Equal(8, Program.FindKthFromEnd(list, 1));
        }

        [Fact]
        public void ThirdFromEnd()
        {
            LList list = new LList();
            list.Insert(4);
            list.Insert(8);
            list.Insert(15);
            list.Insert(23);
            list.Insert(31);
            list.Insert(44);
            Assert.Equal(15, Program.FindKthFromEnd(list, 2));
        }
    }
}
