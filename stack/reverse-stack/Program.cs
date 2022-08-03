using System;
using System.Collections.Generic;
namespace reverse_stack
{
    public class Program
    {
        protected static void ReverseStackNaiveApproach(Stack<Int32> stack, int data)
        {
            Stack<Int32> tempStack = new Stack<Int32>();

            while (stack.Count > 0)
            {
                int ele = stack.Pop();
                Console.WriteLine("ele is : " + ele);
                tempStack.Push(ele);
            }

            Console.WriteLine(tempStack.Peek());
        }
        static void Main(string[] args)
        {
            Stack<Int32> stack = new Stack<Int32>();    
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);

           

            
        }
    }
}
