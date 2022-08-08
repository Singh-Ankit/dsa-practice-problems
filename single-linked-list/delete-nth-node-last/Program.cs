using System;
using single_linked_list;

namespace delete_nth_node_last
{
    public class Program
    {
        public static SingleLinkedList.Node RemoveFromLast(SingleLinkedList.Node head, int n)
        {
            // BASIC CORNER CASES
            if(head == null)
            {
                Console.WriteLine("L. List is null");
                return null;
            }
            if (head.next == null)
            {
                Console.WriteLine("Single element!!");
                return null;
            }

            //STEP:1 calculate size
            SingleLinkedList.Node curr = head;
            int size = 0;
            while (curr != null)
            {
                size++;
                curr = curr.next;
            }
            Console.WriteLine("Size: "+size);

            //STEP:2 delete nth node now
            int prevNodeCount = (size - n);
            SingleLinkedList.Node prev = head;
            int i = 0;
            while(i < prevNodeCount)
            {
                prev = prev.next;
                i++;
            }

            prev.next = prev.next.next;
            return head;
        }
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            SingleLinkedList linked_List = new SingleLinkedList();
            linked_List.addFirst("5");
            linked_List.addFirst("4");
            linked_List.addFirst("3");
            linked_List.addFirst("2");
            linked_List.addFirst("1");
            Console.WriteLine("Before removal");
            linked_List.printList(linked_List.head);

            SingleLinkedList.Node newNode = RemoveFromLast(linked_List.head, 2);
            Console.WriteLine("After removal");
            linked_List.printList(newNode);
        }
    }
}
