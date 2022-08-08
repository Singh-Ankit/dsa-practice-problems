using System;
using single_linked_list;

namespace find_mid_node
{
    public class Program
    {
        public static SingleLinkedList.Node FindMid(SingleLinkedList.Node head)
        {
            //1. slow and fast variable for hopping
            SingleLinkedList.Node slow = head, fast = head; 
            

            //2. Traverse 
            while (fast!= null && fast.next != null)
            {
                slow = slow.next;
                fast = fast.next.next;
            }
            return null;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            SingleLinkedList ll = new SingleLinkedList();
            ll.addFirst("7");
            ll.addFirst("6");
            ll.addFirst("5");
            ll.addFirst("4");
            ll.addFirst("3");
            ll.addFirst("2");
            ll.addFirst("1");

        }
    }
}
