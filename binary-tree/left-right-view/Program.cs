using System;
using System.Collections.Generic;
using static tree_traversal.Program;

namespace left_right_view
{
    public class Program
    {
        ///------------ Left view Implementation
        public static Dictionary<int,int> LeftView(Node root)
        {
            Dictionary<int,int> leftList = new Dictionary<int,int>();
            AddLeftViewstoList(root, leftList,0);
            IList<int> abc = new List<int>();
            foreach (var keyValuePair in leftList)
            {
                abc.Add(keyValuePair.Value);
            }
            return leftList;
        }

        public static void AddLeftViewstoList(Node root, Dictionary<int,int> leftList, int level)
        {
            //base condition:: if root is null simply return
            if (root == null)
            {
                return;
            }

            // Add just one left view elements for each level in our dictionary. Let see how
            // I will check in dictionary, if provided level already exists or not in our dictionary
            // if it doesn't it means it's our left view, now let's add it to our dictionary

            if (!(leftList.ContainsKey(level)))
            {
                Console.WriteLine(root.data + " ");
                // add new key-value (Level,root.data) to dictionary    
                leftList.Add(level, root.data);
            }

            // For left view, simply interchange the calling of left and right. Now, you should call left first then right
            // Now recursively let's traverse the left and right subtree to chec for further left views
            AddLeftViewstoList(root.left, leftList, level + 1);
            AddLeftViewstoList(root.right, leftList, level + 1);
        }

        ///------------ Right view Implementation
        private static void RightView(Node root)
        {
            Dictionary<int, int> rightList = new Dictionary<int, int>();
            AddRightViewstoList(root, rightList, 0);
        }
        public static void AddRightViewstoList(Node root, Dictionary<int, int> rightList, int level)
        {
            //base condition:: if root is null simply return
            if (root == null)
            {
                return;
            }

            // Add just one left view elements for each level in our dictionary. Let see how
            // I will check in dictionary, if provided level already exists or not in our dictionary
            // if it doesn't it means it's our left view, now let's add it to our dictionary

            if (!(rightList.ContainsKey(level)))
            {
                Console.WriteLine(root.data + " ");
                rightList.Add(level, root.data);
            }

            // For right view, simply interchange the calling of left and right. Now, you should call right first then left
            // Now recursively let's traverse the left and right subtree to chec for further right views
            AddLeftViewstoList(root.right, rightList, level + 1);
            AddLeftViewstoList(root.left, rightList, level + 1);

        }
        static void Main(string[] args)
        {
            Node root = new Node(12);
            root.left = new Node(10);
            root.right = new Node(30);
            //root.left.left = new Node(7);
            //root.left.right = new Node(8); 
            root.right.right = new Node(40);
            root.right.left = new Node(20);
            //root.right.right.left = new Node(14);
            Console.WriteLine("left view of the tree");
            LeftView(root);
            Console.WriteLine("right view of the tree");
            RightView(root);
        }
    }

    public class Node
    {
        public int data;
        public Node left, right;

        public Node(int item)
        {
            data = item;
            left = right = null;
        }
    }
}
