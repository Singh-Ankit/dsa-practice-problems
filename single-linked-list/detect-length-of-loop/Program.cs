using System;
using single_linked_list;

namespace detect_length_of_loop
{
    /*  Question.
        *  Write a function that checks whether a given Linked List contains loop 
        *  and if loop is present then returns count of nodes in loop else return 0.
        *  
        *  Solution
        *  Approach: -------- Floyd’s Cycle detection algorithm --------------
        *  uses SLOW and FAST pointer.
        *  Traverse linked list using two pointers. Move SLOW pointer by one jump and move FAST pointer by two jumps, i.e (slow.next & fast.next.next)
        *  Store the address of this common point when slow and fast ptr are at same node, in variable.
        *  initialize a counter and start from the common point and keeps on visiting the next node and increasing the counter
        *  till the common pointer is reached again. 
        *  
        *              Complexity Analysis
        *  Time complexity : O(n) one traversal of loop is needed for size 'n'
        *  Space complexity : O(1) no space required.
        * 
        */
    public class Program
    {

        // This function recieves common point as a input called 'startingNode'
        public static int CountNodesInLoop(SingleLinkedList.Node startingNode)
        {
            // counter variable
            int count = 0;
            // currentNode variable is used to iterate compete cycle
            var currentNode = startingNode;

            //Exist condition: keeps on visiting the next node and increasing the counter
            //till common pointer called startingPoint reached again
            while (currentNode.next != startingNode)
            {
                count++;
                currentNode = currentNode.next;
            }
            return count;
        }
        public static int DetectLoop(SingleLinkedList.Node node)
        {
            //1. declare two variable SLOW and FAST where slow jumps one step and fast jumps two step
            SingleLinkedList.Node slow = node, fast = node;

            //2. Iterate the linkedlist
            while(slow != null && fast != null && fast.next != null)
            {
                // keep incrementing slow pointer by one jump
                slow = slow.next;
                // keep incrementing fast pointer by two jump
                fast = fast.next.next;

                //When there is a loop, i.e now slow and fast pointer are now at same node
                if (slow == fast)
                {
                    return CountNodesInLoop(slow);
                }
            }
            //In case when here is no loop in linkedList
            return 0;
        }

        //Main Driver function
        static void Main(string[] args)
        {
            //Preparing our linkedlist
            SingleLinkedList linkedList = new SingleLinkedList();
            linkedList.addFirst("1");
            linkedList.addFirst("2");
            linkedList.addFirst("3");
            linkedList.addFirst("4");

            //Manually creating loop in linkedlist
            linkedList.head.next.next.next.next = linkedList.head;

            int result = DetectLoop(linkedList.head);

            if (result > 0)
                Console.WriteLine("It's Loop and count is: "+result);
            else  
                Console.WriteLine("No Loop! and count is 0"); 
            Console.ReadLine();
        }
    }
}
