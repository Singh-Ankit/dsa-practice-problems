using single_linked_list;
using System;

namespace reverse_linked_list
{
    /*  Q. Given pointer to the head node of a linked list, the task is to reverse the linked list. 
     *  We need to reverse the list by changing the links between nodes.
     *
     *  Approach 1: ------------ Using 3 pointer --------------
     *  use PREV, CURR and NEXT pointer, Traverse all nodes first creat copy of existing currNode.next node in nextNode variable.
     *  Then set this cuurNode.next with prev node. this is where we are reversing just by changing durection of arrow  from this -> to <-.
     *  Now, your existing node will be previous node so set prev = currNode. then currentNode to created copy of node value
     *  
     *                           Complexity Analysis
     *  Time complexity : O(n) one traversal of loop is needed for size 'n'
     *  Space complexity : O(1) no space required.
     */

    //TODO::: Approach 2 using Stack , Approach 3 using Array and Approach 4 using Recursion
    public class ReverseLinkedList
    {
        public static void Reverse(SingleLinkedList.Node head)
        {
            //1. Initialize three pointers prev as NULL, curr as head and next as NULL.
            SingleLinkedList.Node prevNode = null, currNode = head, nextNode = null;
            Console.WriteLine("next of head is: "+head.next.data);
            //2. Traverse the linkedlist, untill curr != null
            while (currNode != null)
            {
                //Before changing next of current,store next node 
                nextNode = currNode.next;
                //Now change next of current. This is where actual reversing happens 
                // store prev value in curr.next
                // 4 -> 5 -> 6 now it will be 4 <- 5 6
                currNode.next = prevNode;
               
                //Move prev and curr one step forward
                prevNode = currNode;
                currNode = nextNode;
            }
            //while loop will exit when currNode will be null, so in that case our linkedlist is allmost reversed
            //now just set prev of null or currNode as HEAD
            head = prevNode;
        }
        static void Main(string[] args)
        {
            SingleLinkedList linkedlist = new SingleLinkedList();
            linkedlist.addFirst("1");
            linkedlist.addFirst("2");
            linkedlist.addFirst("3");
            linkedlist.addFirst("4");
            linkedlist.addFirst("5");

            Reverse(linkedlist.head);
          
        }
    }
}
