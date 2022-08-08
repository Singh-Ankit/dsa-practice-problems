using System;
using System.Collections.Generic;
using System.Text;

namespace circular_linked_list
{
    /* Insertion in circular linked list
     * A node can be added in three ways: -
     * * Insertion in an empty list
     * * Insertion at the beginning of the list
     * * Insertion at the end of the list
     * * Insertion in between the nodes
     */
    public class CircularLinkedListInsertion
    {
        public Node last { get; set; }
        public class Node {
            public int data { get; set; }
            public Node next { get; set; }
            public Node(int data)
            {
                this.data = data;
                this.next = null;
            }
        }
    }
}
