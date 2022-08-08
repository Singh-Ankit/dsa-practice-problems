using System;

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

            public static Node BuildTree (int[] arr)
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


            public static void LevelOrderTraversalApproachOne(Node root)
            {

            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Binary Tree Insertion!");

            //int[] arr = { 1, 2, -1, 4, -1, 6 };
            int[] arr = { 6, 2, 4, -1, -1, 5, -1, -1, 3, -1, 6, -1, -1 };
            Node root = BinaryTree.BuildTree(arr);
            Console.WriteLine(root.data);
        }
    }
}
