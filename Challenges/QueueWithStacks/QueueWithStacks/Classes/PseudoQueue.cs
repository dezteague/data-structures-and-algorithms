using System;
using System.Collections.Generic;
using System.Text;
using StacksAndQueues.Classes;

namespace QueueWithStacks.Classes
{
    public class PseudoQueue
    {
     
        public void Enqueue(Stack StackOne, int value)
        {
            //demonstrate enqueue by pushing values into stack one
            StackOne.Push(value);
        }

        public void Dequeue()
        {

        }
    }
}
