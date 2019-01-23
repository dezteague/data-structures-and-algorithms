using System;
using Xunit;
using QueueWithStacks.Classes;
//use the S&Q dll 
using StacksAndQueues.Classes;

namespace QueueWithStacksTest
{
    public class UnitTest1
    {
        [Fact]
        public void EnqueueOne()
        {
            //arrange- instantiate new stack
            Stack StackOne = new Stack();
            //instantiate psuedoqueue object
            PseudoQueue pseudoQueue = new PseudoQueue();

            //act- input the value 10 to stack one
            pseudoQueue.Enqueue(StackOne, 10);

            //assert- new top simuluates enqueue via rear
            Assert.Equal(10, StackOne.Top.Value);
        }

        [Fact]
        public void EnqueueTwo()
        {
            //arrange- instantiate new stack
            Stack StackOne = new Stack();
            //instantiate psuedoqueue object
            PseudoQueue pseudoQueue = new PseudoQueue();

            //act- input the value 15 as new top on stack one
            pseudoQueue.Enqueue(StackOne, 10);
            pseudoQueue.Enqueue(StackOne, 15);

            //assert- new top simulates enqueue via rear
            Assert.Equal(15, StackOne.Top.Value);
        }

        [Fact]
        public void EnqueueThree()
        {
            //arrange- instantiate new stack
            Stack StackOne = new Stack();
            //instantiate psuedoqueue object
            PseudoQueue pseudoQueue = new PseudoQueue();

            //act- input the value 20 as new top on stack one
            pseudoQueue.Enqueue(StackOne, 10);
            pseudoQueue.Enqueue(StackOne, 15);
            pseudoQueue.Enqueue(StackOne, 20);

            //assert- new top simulates enqueue via rear
            Assert.Equal(20, StackOne.Top.Value);
        }
    }
}
