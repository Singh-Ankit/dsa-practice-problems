using System;
using System.Collections.Generic;

namespace push_element_at_bottom
{
    public class Program
    {
        protected static void PushAtBottom(Stack<Int32> s, int data)
        {
            //2. There will b a time in recursive call when all elements are removed and stack is empty
            //   This is te time when new element/data is to be inserted. So, that it appears at the end
            if(s.Count == 0)
            {
                s.Push(data);
                // below return exits recursion 
                return;
            }
            //1. [Recursion] remove elements one by one from stack, i.e pop out top elements then push them again in the 
            int currElementAtTop = s.Pop();
            PushAtBottom(s, data);
            //3. Below line executes when new element gets added to the end i.e when recursive call ends
            //   and all previously poped elements will be added in the stack in the same order as it was earlier
            s.Push(currElementAtTop);
        }
        protected static void PushAtBottomNoRecursion(Stack<Int32> s, int data)
        {

        }
        static void Main(string[] args)
        {
            Stack<Int32> stack = new Stack<Int32>();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);

            //new element to be pushed at the bottom of the stack
            int data = 8;
            PushAtBottom(stack, data);

            //To print elements of the stack
            while (stack.Count>0)
            {
                Console.WriteLine(stack.Pop());
            }
        }
    }
}
