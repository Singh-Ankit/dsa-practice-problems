using System;
using System.Collections.Generic;
using System.Text;

namespace single_linked_list
{
    public class SingleLinkedList : ISingleLinkedList
    {
        public Node head { get; set; }
        static int linkedListSize { get; set; }
        static SingleLinkedList()
        {
            linkedListSize = 0;
        }

        public class Node
        {
            public string data { get; set; }
            public Node next { get; set; }
            public Node(string data)
            {
                this.data = data;
                //BY DEFAULT: whenever a new node is created, it's next is always null. This means that it's just a single node not a list of nodes
                this.next = null;
                // increase size when new node is created
                linkedListSize++;
            }
        }

        public void addFirst(string data)
        {
            Node newNode = new Node(data);

            if(head != null)
            {
                newNode.next = head;
                head = newNode;
                return;
            }
            head = newNode; 
        }

        public void printList(Node head)
        {
            if (head == null)
            {
                Console.WriteLine("List is empty");
                return;
            }

            Node curr = head;
            while(curr != null)
            {
                Console.WriteLine(curr.data +"->");
                curr = curr.next;
            }
            // when it's last node, i.e currentNode.next is null.Simply print NULL.
            Console.WriteLine("NULL");
        }
    }
}
