using System;
using single_linked_list;
using System.Collections.Generic;

namespace delete_loop
{
    /* Q. Write a function that removes loop from the linkedlist. Return TRUE if removed otherwise FALSE
     * 
     * Approach 1: ------ Hashing ---------------------------- slow method
     * use three variable prev, curr, next and use Floyd Cycle Detection algorithm to detect if there is a loop. 
     * Traverse the linkedlist and store visited node in an unordered hash collection called 'HashSet'. With this we can check if node is already 
     * visited. If it is, we have reached a node that already exists by a cycle, hence we need to make the last node’s next pointer NULL. i.e: prev.next = null
     *                    Complexity Analysis
     *                    
     *  Time complexity : O(n) one traversal of loop is needed for size 'n'
     *  Space complexity : O(n) space required to store value in hashmap. 
     */
    //TODO:: Better approach to be added
    public class DeleteLoop
    {
        public static bool RemoveLoop(SingleLinkedList.Node node)
        {
            //using this variable for readability purpose
            var currNode = node;
            // 1. Create a hashset to keep track of nodes visited
            HashSet<SingleLinkedList.Node> visitedNode = new HashSet<SingleLinkedList.Node>();
            // 2. Decalre and initialise prev node as null, this variable will be used to unlink the node which causes loop
            SingleLinkedList.Node prev = null;

            //3. Traverse the nodes
            while (currNode != null)
            {
                if(visitedNode.Contains(currNode))
                {
                    prev.next = null;
                    return true; 
                }
                else {
                    // If we are seeing the node for the first time, insert it in hash
                    visitedNode.Add(currNode);
                    prev = currNode;
                    currNode = currNode.next;
                }
            }
            return false ;
        }
        static void Main(string[] args)
        {
            SingleLinkedList linkedlist = new SingleLinkedList();
            linkedlist.addFirst("1");
            linkedlist.addFirst("2");
            linkedlist.addFirst("3");
            linkedlist.addFirst("4");
            linkedlist.addFirst("5");

            //manually creating loop
            linkedlist.head.next.next.next.next.next = linkedlist.head.next.next;

            //check if loop exists
            bool isLoop = detect_loop.Program.ApproachTwoUsingFloydCycleDetectLoop(linkedlist.head);
            if (isLoop)
            {
                // calling our actual REMOVAL logic here.
                RemoveLoop(linkedlist.head);
                Console.WriteLine("It's a loop!"+isLoop);
            }
            //after removal again checking if remove logic has executed properly.
            Console.WriteLine("Is it a loop? "+ detect_loop.Program.ApproachTwoUsingFloydCycleDetectLoop(linkedlist.head));
            linkedlist.printList(linkedlist.head);
        }
    }
}
