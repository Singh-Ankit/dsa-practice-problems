using System;
using Node = tree_traversal.Program.Node;
using BinaryTree = tree_traversal.Program.BinaryTree;

namespace height_or_depth_tree
{
    /*
     * Given a binary tree, find height of it. Height of empty tree is -1, height of tree with one node is 0 and height of below tree is 2. 
     */
    internal class Program
    {
        public static int Height(Node root)
        {
            if (root == null)
            {
                return 0;
            }

            return Math.Max(Height(root.left), Height(root.right)) +1;
        }
        
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            //int[] arr = { 1, 2, -1, 4, -1, 6 };
            int[] arr = { 6, 2, 4, -1, -1, 5, -1, -1, 3, -1, 6, -1, -1 };
            Node root = BinaryTree.BuildTree(arr);
            Console.WriteLine("Height Of tree: "+Height(root));
        }
    }
}
