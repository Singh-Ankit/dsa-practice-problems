using System;

namespace stack_using_linkedlist
{
    public class Program
    {
        // this is our linkedlist node class LinkeList[DATA|Next]
        public class Node
        {
            public int data { get; set; }
            public Node next { get; set; }
            public Node(int data)
            {
                this.data = data;
                this.next = null;
            }
        }
        static class Stack 
        {
            //creating static Node head because, we just want one single head avaiable across 
            public static Node head;

            //adds element at head node, checks for empty list if found then simple adds a new node as head
            //if not found, then sets newly created node's next pointer to existing head.
            //and updated curr head to point to newly added node
            public static void Push(int data)
            {
                //creating a node which will be inserted with incoming data
                Node node = new Node(data);
                if(isEmpty())
                {
                    head = node;
                    return;
                }

                node.next = head;
                head = node;
                return;
            }

            public static int Pop()
            {
                if (isEmpty())
                {
                    Console.WriteLine("Stack is already empty!!");
                    return -1;
                }
                int topdataToBeRemoved = head.data;
                head = head.next;
                return topdataToBeRemoved;
            }

            public static int Peek()
            {
                if (isEmpty())
                {
                    Console.WriteLine("Stack is empty!!");
                    return -1;
                }
                return head.data;
            }
            public static Boolean isEmpty()
            {
                return head == null;
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Stack.Push(1);
            Stack.Push(2);
            Stack.Push(3);

            Console.WriteLine("Peek: " + Stack.Peek());
            Stack.Push(4);

            Console.WriteLine("Peek: " + Stack.Peek());
            Console.WriteLine("Pop");
            Stack.Pop();
            Console.WriteLine("Peek: " + Stack.Peek());

        }
    }
}
