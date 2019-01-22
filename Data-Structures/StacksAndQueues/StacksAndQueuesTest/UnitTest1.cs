using System;
using Xunit;
using StacksAndQueues.Classes;

namespace StacksAndQueuesTest
{
    public class UnitTest1
    {
        [Theory]
        [InlineData(1)]
        [InlineData(2)]
        [InlineData(3)]
        public void PushNodeToStackTest(int value)
        {
            Node node = new Node(value);
            node.Next = Top;
            //new node is now the top
            Top = node;
        }
    }
}
