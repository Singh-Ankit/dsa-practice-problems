using System;

namespace stack_using_array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            CustomStack stack = new CustomStack(5);
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            stack.Push(4);

            Console.WriteLine("Peek: " + stack.Peek());

            stack.Pop();
            Console.WriteLine("Peek: " + stack.Peek());
            stack.Pop();
            Console.WriteLine("Peek: " + stack.Peek());
            stack.Push(5);
            Console.WriteLine("Peek: " + stack.Peek());
            stack.Pop();
            stack.Pop();
            stack.Pop();
            stack.Pop();
            stack.Pop();
            stack.Push(1);
            Console.WriteLine("Peek: " + stack.Peek());
            DynamicStack stack2 = new DynamicStack();
            stack2.Push(1);
            stack2.Push(2);
            stack2.Push(3);
            stack2.Push(4);
        }
    }
}
