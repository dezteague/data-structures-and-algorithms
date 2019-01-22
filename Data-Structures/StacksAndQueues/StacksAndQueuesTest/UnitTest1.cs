using System;
using Xunit;
using StacksAndQueues.Classes;

namespace StacksAndQueuesTest
{
    public class UnitTest1
    {
        [Fact]
        public void PushNodeToStackTest()
        {
            //instantiate new stack
            Stack stack = new Stack();
            //push in the value 
            stack.Push(1);
            //assert the top value is one
            Assert.Equal(1, stack.Top.Value);
        }

        [Fact]
        public void PushSecondNodeToStackTest()
        {
            //instantiate new stack
            Stack stack = new Stack();
            //push in the value 
            stack.Push(1);
            stack.Push(2);
            //assert the top value is two
            Assert.Equal(2, stack.Top.Value);
        }

        [Fact]
        public void PushThirdNodeToStackTest()
        {
            //instantiate new stack
            Stack stack = new Stack();
            //push in the value 
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            //assert the top value is three
            Assert.Equal(3, stack.Top.Value);
        }
    }
}
