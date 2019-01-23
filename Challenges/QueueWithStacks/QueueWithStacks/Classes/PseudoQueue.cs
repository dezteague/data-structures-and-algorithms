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

        public void Dequeue(Stack StackOne, Stack StackTwo)
        {
            //if stack two is not empty
            if (StackTwo != null)
            {
                //Pop the values from StackTwo
                StackTwo.Pop();
            }
            else
            {
                while(StackOne != null)
                {
                    //pop the values from stack one and push them into stack two
                    StackTwo.Push(StackOne.Pop().Value);
                }
            }
            //in the end, pop the values from stack two
            StackTwo.Pop();
        }
    }
}
