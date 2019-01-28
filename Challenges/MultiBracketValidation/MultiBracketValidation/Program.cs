using System;
using StacksAndQueues.Classes;

namespace MultiBracketValidation
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            string teststring = "({})";
            MultiBracketValidation(teststring);
        }

        public static bool MultiBracketValidation(string input)
        {
            //instantiate a stack to hold the opening brackets
            Stack openingBracketStack = new Stack();

            //loop through the string of input
            for (int i = 0; i < input.Length; i++)
            {
                //if the string has opening brackets, push them into the stack
                if (input[i] == '(' || input[i] == '[' || input[i] == '{')
                {
                    openingBracketStack.Push(input[i]);
                }

                //if there is a matching closing bracket, pop the opening bracket out of the stack
                if (input[i] == ')')
                {
                    if (openingBracketStack.Top != null && openingBracketStack.Top.Value == '(')
                    {
                        openingBracketStack.Pop();
                    }
                    else
                    {
                        return false;
                    }
                }

                //if there is a matching closing bracket, pop the opening bracket out of the stack
                if (input[i] == ']')
                {
                    if (openingBracketStack.Top != null && openingBracketStack.Top.Value == '[')
                    {
                        openingBracketStack.Pop();
                    }
                    else
                    {
                        return false;
                    }
                }

                //if there is a matching closing bracket, pop the opening bracket out of the stack
                if (input[i] == '}')
                {
                    if (openingBracketStack.Top != null && openingBracketStack.Top.Value == '{')
                    {
                        openingBracketStack.Pop();
                    }
                    else
                    {
                        return false;
                    }
                }
            }
                //if the stack is empty, all the brackets have been matched
                if (openingBracketStack.Top == null)
                {
                    return true;
                }
                else
                {
                    return false;
                }
             
        }
    }
}
