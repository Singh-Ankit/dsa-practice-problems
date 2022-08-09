using System;
using System.Collections.Generic;

namespace level_order_traversal
{
    public class Program
    {
        public class Node
        {
            public int data { get; set; }
            public Node right { get; set; }
            public Node left { get; set; }

            public Node(int data)
            {
                this.data = data;
                right = null;
                left = null;
            }
        }

        public static class BinaryTree
        {
            static int itr = -1;

            public static Node BuildTree(int[] arr)
            {
                itr++;
                Node NewNode;
                // Coner case: checks if we have not reached the Index Out Of Boumd error

                // if at any index we get -1, we should be returning null
                if (arr[itr] == -1)
                {
                    return null;
                }

                //Create a new Node
                NewNode = new Node(arr[itr]);

                //*********** PREORDER insertion *********

                //Now recursively call above function Buildtree() --> LEFT CHILD
                NewNode.left = BuildTree(arr);
                //Now recursively call above function Buildtree() --> RIGHT CHILD
                NewNode.right = BuildTree(arr);
                return NewNode;
            }

            public static int FindHeightOfTree(Node root)
            {
                if (root == null)
                {
                    return 0;
                }

                return Math.Max(FindHeightOfTree(root.left), FindHeightOfTree(root.right)) + 1;
            }

            public static void PrintCurrentLevel(Node root, int level)
            {
                if (root == null)
                {
                    Console.WriteLine("Null");
                }
                if (level == 1)
                {
                    Console.WriteLine(root.data + " ");
                }
                else
                {
                    PrintCurrentLevel(root.left, level - 1);
                    PrintCurrentLevel(root.right, level - 1);
                }

            }

            /*
             * Big O(n) : Naive solutiion. Iterative thorugh each level and print elements in that level. 
             * Not a best solution
             */
            public static void LevelOrderTraversalIterativeApproach(Node root)
            {
                int level = FindHeightOfTree(root);
                // calculating the height of the tree
                for (int i = 0; i < level; i++)
                {
                    PrintCurrentLevel(root, i);
                }
            }

            public static void LevelOrderTraversalQueueApproach(Node root, Queue<Node> queue)
            {
                if (root == null)
                {
                    return;
                }
                Console.WriteLine(" Inserting into Queue:- " + root.data);
                queue.Enqueue(root);
                while (queue.Count > 0)
                {
                    Node removed = queue.Dequeue();
                    Console.WriteLine(" Removed from Queue:- " + removed.data);
                   
                    if (removed.left != null)
                    {
                        queue.Enqueue(removed.left);
                    }
                    if (removed.right != null)
                    {
                        queue.Enqueue(removed.right);
                    } 
                }
            }

            public static void LevelOrderTraversalQueueApproach2(Node root, Queue<Node> queue)
            {
                if (root == null)
                {
                    return;
                }
                Console.WriteLine(" Inserting into Queue:- " + root.data);
                queue.Enqueue(root);
                while (queue.Count > 0)
                {
                    Node removed = queue.Dequeue();
                    //check if removed element is null
                    if(removed == null)
                    {
                        //if this null was the only element left in queue, no other element after. Then simply return & exit
                        if(queue == null)
                        {
                            return ;
                        }
                        //else print null and add this null to the end of queue, this end null will mark end of a level
                        queue.Enqueue(removed);
                        Console.WriteLine("\n");
                        continue;
                    }
                    Console.WriteLine(removed.data + " ");

                    if (removed.left != null)
                    {
                        queue.Enqueue(removed.left);
                    }
                    if (removed.right != null)
                    {
                        queue.Enqueue(removed.right);
                    }
                }
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Binary Tree Insertion!");

            //int[] arr = { 1, 2, -1, 4, -1, 6 };
            int[] arr = { 1, 2, 4, -1, -1, 5, -1, -1, 3, -1, 6, -1, -1 };
            Node root = BinaryTree.BuildTree(arr);
           // Console.WriteLine(root.data);
           // BinaryTree.LevelOrderTraversalIterativeApproach(root);


            //creating queue
            Queue<Node> queue = new Queue<Node>();
            BinaryTree.LevelOrderTraversalQueueApproach2(root,queue);

        }
    }
}
