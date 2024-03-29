﻿using System;

namespace tree_traversal
{
    public class Program
    {
        public class Node
        {
            public int data { get; set; }
            public Node right { get; set; }
            public Node left { get; set; }

            // When a new node is created initially there will be no right and left child 
            public Node(int data)
            {
                this.data = data;
                right = null;
                left = null;
            }
        }

        public static class BinaryTree
        {
            // will need a variable to keep count of index where our new node should be inserted.
            static int idx = -1;

            //This function will build tree using preorder technoque and in the end it will return the result as a head node.
            public static Node BuildTree(int[] arr)
            {
                //keep post incrementing the index count 'idx' by +1. Also, peek elements from the array one by one and insert it into tree.
                idx++;

                //-1 at any index in array represents null node or leaf node. So,now execution will move back to immediate parent node
                if (idx < arr.Length && arr[idx] == -1)
                {
                    return null;
                }

                //Create new node
                Node node = new Node(arr[idx]);

                //*********** PREORDER insertion *********

                //Now recursively call above function Buildtree() --> LEFT CHILD
                node.left = BuildTree(arr);
                //Now recursively call above function Buildtree() --> RIGHT CHILD
                node.right = BuildTree(arr);

                return Object.ReferenceEquals(node, null) ? null : node;
            }

            // Tree traversal
            public static void PreOrderTraversal(Node root)
            {
                // 1.Root subtree ----> 2.Left -----> 3.Right 

                //CORNER CASE : when a node is null, simply return 
                if (root == null) { return; }

                //Let's print nodes
                Console.WriteLine(root.data + "");

                //Left subtree
                PreOrderTraversal(root.left);
                //Right subtree
                PreOrderTraversal(root.right);
            }

            //Time complexity: O(n)
            public static void InOrderTravrsal(Node root) 
            {
                // 1.Left subtree ----> 2.Root -----> 3.Right subtree
                
                //CORNER CASE : when a node is null, simply return 
                if (root == null) { return; }

                InOrderTravrsal(root.left);
                //root in middle
                Console.WriteLine(root.data+ "");
                InOrderTravrsal(root.right);    
            }

            //Time complexity: O(n)
            public static void PostOrderTraversal(Node root)
            {

                // 1.Left subtree ----> 2.Right subtree -----> 3.Root 

                //CORNER CASE : when a node is null, simply return 
                if (root == null) { return; }

                PostOrderTraversal(root.left);
                PostOrderTraversal(root.right);
                //root in last
                Console.WriteLine(root.data + "");
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Binary Tree Insertion!");

            //int[] arr = { 1, 2, -1, 4, -1, 6 };
            int[] arr = { 1, 2, 4, -1, -1, 5, -1, -1, 3, -1, 6, -1, -1 };
            Node root = BinaryTree.BuildTree(arr);
            Console.WriteLine(root.data);
            Console.WriteLine("Pre-Order Let's Traverser Now");
            BinaryTree.PreOrderTraversal(root);
            Console.WriteLine("In-Order Let's Traverser Now");
            BinaryTree.InOrderTravrsal(root);
            Console.WriteLine("Post - Order Let's Traverser Now");
            BinaryTree.PostOrderTraversal(root);
        }
    }
}
