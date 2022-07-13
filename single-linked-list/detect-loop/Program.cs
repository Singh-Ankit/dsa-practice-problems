using System;
using System.Collections.Generic;
using single_linked_list;

namespace detect_loop
{
    /*  Q. Given a linked list, check if the linked list has loop or not
     *  
     *  Approach 1: ------ Hashing --------
     *  traverse the nodes in linked list one by one and keep visited node in a Hash Table.
     *  If at any point, NULL is reached return FALSE. 
     *  Else if next of current node points to any of the already visited node return TRUE
     *               Complexity Analysis
     *  Time complexity : O(n) one traversal of loop is needed off size 'n'
     *  Space complexity : O(n) space required to store value in hashmap.
     * 
     *  TODO >> Approach 2: ------ Node with flag property --------
     *  
     */
    public class Program
    {
        public static bool ApproachOneDetectLoop(SingleLinkedList.Node node)
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

            if (ApproachOneDetectLoop(linkedList.head))
            {
                Console.WriteLine("It's a Loop!!");
            }
            else
            {
                Console.WriteLine("No Loop!!");
            }

            Console.ReadLine();
        }
    }
}
