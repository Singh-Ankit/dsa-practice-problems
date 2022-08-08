using System;
using Node = tree_traversal.Program.Node;
using BinaryTree = tree_traversal.Program.BinaryTree;

namespace size_of_binary_tree
{
    /*
     *  Q. Given a binary tree find it's size or the number of nodes in the binary tree.
     *  
     *  Approach: Using Recursion
     *   Recursively calculating the number of nodes in the left subtree and the right subtree separatley. Then doing summation of the of left and right + 1 for the root node gives us 
     *   the desrired result.
     *   SUM((root.left) + (root.right)) + 1
     *  
     *  Time complexity : O(n)
     *  
     *  ex:  1, 2, 4, -1, -1, 5, -1, -1, 3, -1, -1 here max size is lefttree(3) + right(1) +1 = 5
     */
    internal class Program
    {
        //Size of a BinaryTreee refers to the no. of nodes conatained in a tree
        public static int SizeBT(Node root)
        {
            if (root == null)
            {
                return 0;
            }
            return SizeBT(root.left) + SizeBT(root.right) + 1;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int[] arr = { 1, 2, 4, -1, -1, 5, -1, -1, 3, -1, -1 };
            //int[] arr = { 6, 2, 4, -1, -1, 5, -1, -1, 3, -1, 6, -1, -1 };
            Node root = BinaryTree.BuildTree(arr);
            
            Console.WriteLine("Size of Binary Tree: "+ SizeBT(root));
        }
        /*    --- 1 -----
         *  -- 2 --- 3 ----
         *  -4  5 --- 
         */
    }
}
