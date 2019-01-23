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
        public void EnqueueFirstNodeTest()
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
        public void EnqueueSecondNodeTest()
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
        public void EnqueueThirdNodeTest()
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

        [Fact]
        public void DequeueFirstNodeTest()
        {
            //arrange- instantiate new stacks
            Stack StackOne = new Stack();
            Stack StackTwo = new Stack();
            //instantiate psuedoqueue object
            PseudoQueue pseudoQueue = new PseudoQueue();

            //act- input the value 25 top of stack one (rear of queue)
            pseudoQueue.Enqueue(StackOne, 10);
            pseudoQueue.Enqueue(StackOne, 15);
            pseudoQueue.Enqueue(StackOne, 20);
            pseudoQueue.Enqueue(StackOne, 25);

            pseudoQueue.Dequeue(StackOne, StackTwo);

            //assert- new top simulates FIFO
            Assert.Equal(15, StackTwo.Top.Value);
        }

        [Fact]
        public void DequeueSecondNodeTest()
        {
            //arrange- instantiate new stacks
            Stack StackOne = new Stack();
            Stack StackTwo = new Stack();
            //instantiate psuedoqueue object
            PseudoQueue pseudoQueue = new PseudoQueue();

            //act- input the value 25 top of stack one (rear of queue)
            pseudoQueue.Enqueue(StackOne, 15);
            pseudoQueue.Enqueue(StackOne, 20);
            pseudoQueue.Enqueue(StackOne, 25);

            pseudoQueue.Dequeue(StackOne, StackTwo);

            //assert- new top simulates FIFO
            Assert.Equal(20, StackTwo.Top.Value);
        }

        [Fact]
        public void DequeueThirdNodeTest()
        {
            //arrange- instantiate new stacks
            Stack StackOne = new Stack();
            Stack StackTwo = new Stack();
            //instantiate psuedoqueue object
            PseudoQueue pseudoQueue = new PseudoQueue();

            //act- input the value 25 top of stack one (rear of queue)
            pseudoQueue.Enqueue(StackOne, 20);
            pseudoQueue.Enqueue(StackOne, 25);

            pseudoQueue.Dequeue(StackOne, StackTwo);

            //assert- new top simulates FIFO
            Assert.Equal(25, StackTwo.Top.Value);
        }
    }
}
