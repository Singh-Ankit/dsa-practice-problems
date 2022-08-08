using System;
using single_linked_list;

namespace delete_alternate_node
{
    public class DeleteAlternateNode
    {
        public static void DeleteAlternate(SingleLinkedList.Node head)
        {
            var curr = head.next;
            head = new SingleLinkedList.Node("");
            head = curr;
           
            SingleLinkedList.Node prev = null;

            //if (head.next == null)
            //{
            //    Console.WriteLine("single node");
            //    return;
            //}
            //head = null;
            while (curr != null)
            {

                prev = curr;
                var temp = curr.next.next;
                prev.next = temp;
                curr = temp;
                //prev = 
            }
           // head = head.next;
           // sbc.printList(head);
        }
        static void Main(string[] args)
        {
            SingleLinkedList linkedlist = new SingleLinkedList();
            linkedlist.addFirst("5");
            linkedlist.addFirst("4");
            linkedlist.addFirst("3");
            linkedlist.addFirst("2");
            linkedlist.addFirst("1");

            // linkedlist.printList(linkedlist);
            DeleteAlternate(linkedlist.head);
            linkedlist.printList(linkedlist.head);
            Console.WriteLine();
        }
    }
}
