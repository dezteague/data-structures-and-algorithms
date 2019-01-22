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
        public void PopFirstNodeFromStackTest()
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
        public void PeekFirstNodeFromStackTest()
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
        public void PeekSecondNodeFromStackTest()
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
        public void PeekThirdNodeFromStackTest()
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
            Assert.Equal(1, queue.Rear.Value);
        }

        [Fact]
        public void EnqueueSecondNodeTest()
        {
            //instantiate new node with int value
            Node node = new Node(1);
            Node node2 = new Node(2);
            //instantiate new queue, pass in the value of the node
            Queue queue = new Queue(node);
            Queue queue2 = new Queue(node2);
            //add in the value 
            queue.Enqueue(1);
            queue.Enqueue(2);
            //new rear value is 2
            Assert.Equal(2, queue.Rear.Value);
        }

        [Fact]
        public void EnqueueThirdNodeTest()
        {
            //instantiate new node with int value
            Node node = new Node(1);
            Node node2 = new Node(2);
            Node node3 = new Node(3);
            //instantiate new queue, pass in the value of the node
            Queue queue = new Queue(node);
            Queue queue2 = new Queue(node2);
            Queue queue3 = new Queue(node3);
            //add in the value 
            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);
            //new rear value is 3
            Assert.Equal(3, queue.Rear.Value);
        }
    }
}
