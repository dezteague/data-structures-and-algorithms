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
            //assert the top value is 1
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
            //assert the top value is 2
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
            //assert the top value is 3
            Assert.Equal(3, stack.Top.Value);
        }

        [Fact]
        public void PopThirdNodeFromStackTest()
        {
            //instantiate new stack
            Stack stack = new Stack();
            //push in the value 
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            //invoke pop method
            stack.Pop();
            //new top value is 2
            Assert.Equal(2, stack.Top.Value);
        }

        [Fact]
        public void PopSecondNodeFromStackTest()
        {
            //instantiate new stack
            Stack stack = new Stack();
            //push in the value 
            stack.Push(1);
            stack.Push(2);
            //invoke pop method
            stack.Pop();
            //new top value is 1
            Assert.Equal(1, stack.Top.Value);
        }

        [Fact]
        public void PopSingleNodeFromStackTest()
        {
            //instantiate new stack
            Stack stack = new Stack();
            //push in the value 
            stack.Push(1);
            //invoke pop method
            stack.Pop();
            //new top value is null
            Assert.True(stack.Top == null);
        }

        [Fact]
        public void PeekFirstNodeInStackTest()
        {
            //instantiate new stack
            Stack stack = new Stack();
            //push in the value 
            stack.Push(1);
            //invoke peek method
            Node p = stack.Peek();
            //new peek value is 1
            Assert.Equal(1, p.Value);
        }

        [Fact]
        public void PeekSecondPushToStackTest()
        {
            //instantiate new stack
            Stack stack = new Stack();
            //push in the value 
            stack.Push(1);
            stack.Push(2);
            //invoke peek method
            Node p = stack.Peek();
            //new peek value is 2
            Assert.Equal(2, p.Value);
        }

        [Fact]
        public void PeekThirdPushToStackTest()
        {
            //instantiate new stack
            Stack stack = new Stack();
            //push in the value 
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            //invoke peek method
            Node p = stack.Peek();
            //new peek value is 3
            Assert.Equal(3, p.Value);
        }

        [Fact]
        public void EnqueueFirstNodeTest()
        {
            //instantiate new node with int value
            Node node = new Node(1);
            //instantiate new queue, pass in the value of the node
            Queue queue = new Queue(node);
            //add in the value 
            queue.Enqueue(1);
            //new rear value is 1
            Assert.Equal(1, queue.Front.Value);
        }

        [Fact]
        public void EnqueueSecondNodeTest()
        {
            //instantiate new node with int value (only need one value to start)
            Node node = new Node(1);
            //instantiate new queue, pass in the value of the node
            Queue queue = new Queue(node);
            //add in the value 
            queue.Enqueue(2);
            //new rear value is 2
            Assert.Equal(2, queue.Rear.Value);
        }

        [Fact]
        public void EnqueueThirdNodeTest()
        {
            //instantiate new node with int value
            Node node = new Node(1);
            //instantiate new queue, pass in the value of the node
            Queue queue = new Queue(node);
            //add in the values
            queue.Enqueue(2);
            queue.Enqueue(3);
            //new rear value is 3
            Assert.Equal(3, queue.Rear.Value);
        }

        [Fact]
        public void DequeueSingleNodeTest()
        {
            //instantiate new node with int value
            Node node = new Node(1);
            //instantiate new queue, pass in the value of the node
            Queue queue = new Queue(node);
            //remove the value
            queue.Dequeue();
            //new front value 
            Assert.True(queue.Front == null);
        }

        [Fact]
        public void DequeueOneOfTwoNodesTest()
        {
            //instantiate new node with int value
            Node node = new Node(1);
            //instantiate new queue, pass in the value of the node
            Queue queue = new Queue(node);
            //add in the values
            queue.Enqueue(2);
            //remove the front value
            queue.Dequeue();
            //new front value 
            Assert.Equal(2, queue.Front.Value);
        }
   
        [Fact]
        public void DequeueTwoofThreeNodesTest()
        {
            //instantiate new node with int value
            Node node = new Node(1);
            //instantiate new queue, pass in the value of the node
            Queue queue = new Queue(node);
            //add in the values
            queue.Enqueue(2);
            queue.Enqueue(3);
            //remove the front values
            queue.Dequeue();
            queue.Dequeue();
            //new front value 
            Assert.Equal(3, queue.Front.Value);
        }

        [Fact]
        public void PeekNodeInQueueTest()
        {
            //instantiate new node with int value
            Node node = new Node(1);
            //instantiate new stack
            Queue queue = new Queue(node);
            //push in the value 
            queue.Enqueue(2);
            queue.Enqueue(3);
            //invoke peek method
            Node p = queue.Peek();
            //new peek value is 1
            Assert.Equal(1, p.Value);
        }

        [Fact]
        public void SecondPeekNodeInQueueTest()
        {
            //instantiate new node with int value
            Node node = new Node(4);
            //instantiate new stack
            Queue queue = new Queue(node);
            //push in the value 
            queue.Enqueue(5);
            queue.Enqueue(6);
            //invoke peek method
            Node p = queue.Peek();
            //new peek value is 1
            Assert.Equal(4, p.Value);
        }

        [Fact]
        public void ThirdPeekNodeInQueueTest()
        {
            //instantiate new node with int value
            Node node = new Node(7);
            //instantiate new stack
            Queue queue = new Queue(node);
            //push in the value 
            queue.Enqueue(8);
            queue.Enqueue(9);
            //invoke peek method
            Node p = queue.Peek();
            //new peek value is 1
            Assert.Equal(7, p.Value);
        }
    }
}
