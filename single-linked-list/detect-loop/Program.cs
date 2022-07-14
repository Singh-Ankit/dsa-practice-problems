using System;
using System.Collections.Generic;
using single_linked_list;

namespace detect_loop
{
    /*  Q. Given a linked list, check if the linked list has loop or not
     *  
     *  Approach 1: ------ Hashing -------------------------------- slow method
     *  Traverse the nodes in linked list one by one and keep visited node in a Hash Table.
     *  If at any point, NULL is reached return FALSE. 
     *  Else if next of current node points to any of the already visited node return TRUE
     *               Complexity Analysis
     *  Time complexity : O(n) one traversal of loop is needed for size 'n'
     *  Space complexity : O(n) space required to store value in hashmap.
     * 
     *  Approach 2: ------ Floyd’s Cycle-Finding Algorithm -------- fastest method
     *  uses SLOW and FAST pointer.
     *  Traverse linked list using two pointers. Move SLOW pointer by one jump and move FAST pointer by two jumps, i.e (slow.next & fast.next.next)
     *  If these two pointer at any point meet at the same node, It's a loop return TRUE. 
     *  Else, it's linear no loop return FALSE.
     *              Complexity Analysis
     *  Time complexity : O(n) one traversal of loop is needed for size 'n'
     *  Space complexity : O(1) no space required.
     *  LINK: https://www.geeksforgeeks.org/how-does-floyds-slow-and-fast-pointers-approach-work/
     *  
     */
    public class Program
    {
        public static bool ApproachOneUsingHashDetectLoop(SingleLinkedList.Node node)
        {
            //1. create a hashset of type node 
            HashSet<SingleLinkedList.Node> visitedNode = new HashSet<SingleLinkedList.Node>();

            //2. Iterate to traverse linkedlist, this is the case when no node is null
            while(node != null)
            {
                //if, node already exists in hash, which means we have already visited this node. So it's loop
                if(visitedNode.Contains(node))
                {
                    return true;
                }
                // else, seeing node for first time, add this in hash
                visitedNode.Add(node);
                // and move loop to next node
                node = node.next;
            }
            //3. else linkedlist is linear, it has null 
            return false;
        }
        public static bool ApproachTwoUsingFloydCycleDetectLoop(SingleLinkedList.Node node)
        {
            //1.Declare and initialise pointers of type node
            SingleLinkedList.Node slow = node, fast = node;

            //2.Traverse linkedlist using two pointer, until any pointer is not null
            while(slow != null && fast !=null && fast.next!=null)
            {
                // keep incrementing slow pointer by one jump
                slow = slow.next;
                // keep incrementing fast pointer by two jump
                fast = fast.next.next;

                //3. check if slow and fast pointer meet at a node. Based on this return true or false
                if(slow == fast)
                {
                    //It's a loop
                    return true;
                }
            }
            //It's not a loop
            return false;
        }
       
        // Main Driver function
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

            if (ApproachOneUsingHashDetectLoop(linkedList.head))
            {
                Console.WriteLine("Approach 1, It's a Loop!!");
            }
            else
            {
                Console.WriteLine("Approach 1, No Loop!!");
            }

            if (ApproachTwoUsingFloydCycleDetectLoop(linkedList.head))
            {
                Console.WriteLine("Approach 2, It's a Loop!!");
            }
            else
            {
                Console.WriteLine("Approach 2, No Loop!!");
            }

            Console.ReadLine();
        }
    }
}
