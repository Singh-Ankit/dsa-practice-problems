using System;
using Node = tree_traversal.Program.Node;
using BinaryTree = tree_traversal.Program.BinaryTree;

namespace min_max_node_binary_tree
{
    /*
    *  Q. Given a binary tree find it's MAX and Min node
    *  
    *  Approach: Using Recursion
    *   we must visit every node to figure out maximum. Recursilvely we must find max/min node in a left subtree and then in right subtree
    *   At any given node suppose it is null return the most min number of an integer or - infinity.
    *   
    *  Time complexity : O(n) all node visited once
    *  Space Complexity: O(H) will be visiting all nodes, but at a time will go 'H' height deeper in our call stack using recursion. All depends on MAX height.
    */

    public class Program
    {
        public static int FindMaxNode(Node root)
        {
            if(root == null)
            {
                //at any point when curent node is null, set it as a min value
                return int.MinValue;
            }
            int max = Math.Max(root.data, Math.Max(FindMaxNode(root.left), FindMaxNode(root.right)));
            return max;
        }
        public static int FindMinNode(Node root) 
        {
            if (root == null)
            {
                //at any point when curent node is null, set it as a max value
                return int.MaxValue;
            }
            int min = Math.Min(root.data, Math.Min(FindMinNode(root.left), FindMinNode(root.right)));
            return min;
        }

        //---- another simple code
        public static int findmin(Node root)
        {
            if (root == null)
            {
                return int.MaxValue;
            }

            int data = root.data;
            int leftdata = findmin(root.left);
            int rightdata = findmin(root.right);

            if (leftdata < data)
            {
                data = leftdata;
            }
            if (rightdata < data)
            {
                data = rightdata;
            }
            return data;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            //int[] arr = { 1, 2, -1, 4, -1, 6 };
            int[] arr = { 6, 2, 4, -1, -1, 5, -1, -1, 3, -1, 8, -1, -1 };
            Node root = BinaryTree.BuildTree(arr);

            Console.WriteLine("Max of Binary Tree: " + FindMaxNode(root));
            Console.WriteLine("min of Binary Tree: " + FindMinNode(root));
            Console.WriteLine("Another approach min of Binary Tree: " + findmin(root));
        }
    }
}
