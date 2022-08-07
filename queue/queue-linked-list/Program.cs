using System;

namespace queue_linked_list
{
    internal class Program
    {
        public class Node
        {
            public string data { get; set; }
            public Node next { get; set; }

            public Node(string data)
            {
                this.data = data;
                next = null;
            }
        }
        public static class Queue
        {
            // creating two node
            //1. Front node
            static Node head = null;
            //2. Rear node
            static Node tail = null;

            public static Boolean IsEmpty()
            {
                return head == null & tail == null;
            }

            // No need to implement this we can assume that we have enough heap memory
            // public static Boolean isFull() { }

            public static void Enqueue(string data)
            {
                // INSERTION IS ALWAYS DONE ON TAIL or REAR side
                Node newNode = new Node(data);
                
                if (tail == null)
                {
                    // when tail is null which means there were no nodes previously, will add our first node.
                    // for first and only node, head and tail will point to this new node
                    head = tail = newNode;
                    return;
                }

                // else if, some nodes are already present. Then point existing tail node's next to new node from null and
                // newNode becomes our new tail node
                tail.next = newNode;
                tail = newNode;
            }

            public static string Dequeue()
            {
                // DELETION IS ALWAYS DONE ON FRONT side

                // first check if queue is empty, if it is, then there is nothing to delete.
                if (IsEmpty())
                {
                    return "-1";
                }

                // else, delete front element and return it's value
                var deletedData = head.data;

                //CHECK!! incase if head and and tall are at same node, i.e when only one element. Tail should be set to null
                if(head == tail)
                {
                    tail = null;
                } 
                head = head.next;
                return deletedData;
            }

            public static string peek()
            {
                if (IsEmpty())
                {
                    return "-1";
                }
                return tail.data;
            }

        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Queue.Enqueue("a");
            Queue.Enqueue("b");
            Queue.Enqueue("c");
            Queue.Enqueue("d");
            Console.WriteLine("Peek: "+ Queue.peek());
            Console.WriteLine("Deleting: " + Queue.Dequeue());
            Console.WriteLine("Deleting: " + Queue.Dequeue());
            Console.WriteLine("Deleting: " + Queue.Dequeue());
            Console.WriteLine("Deleting: " + Queue.Dequeue());
            Console.WriteLine("Peek: " + Queue.peek());
        }
    }
}
