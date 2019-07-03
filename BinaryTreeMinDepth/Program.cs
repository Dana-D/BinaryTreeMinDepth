using System;

namespace BinaryTreeMinDepth
{
    class Program
    {
        static void Main(string[] args)
        {
            BinaryTree binaryTree = new BinaryTree();
            binaryTree.root = new Node(1);
            binaryTree.root.left = new Node(2);
            binaryTree.root.right = new Node(3);
            binaryTree.root.left.left = new Node(4);
            binaryTree.root.left.right = new Node(5);

            binaryTree.root.right.left = new Node(6);
            binaryTree.root.right.right = new Node(7);
            binaryTree.root.right.right.left = new Node(8);
            binaryTree.root.right.right.right = new Node(9);

            Console.WriteLine("The minimum depth of binary tree is : " + binaryTree.minDepth());
            Console.WriteLine("The maximum depth of binary tree is : " + binaryTree.depth(binaryTree.root));
        }
    }

    public class BinaryTree
    {
        public Node root;

        public BinaryTree() { }

        public int minDepth()
        {
            int depth = 0;

            depth = minDepthHelper(root);

            return depth;
        }

        public int minDepthHelper(Node node)
        {
            int left = 0;
            int right = 0;

            if(isLeaf(node))
            {
                //Console.WriteLine("Node: " + node.value + " is a leaf");
                return 1;
            }

            if(node.left != null)
            {
                //Console.WriteLine("Going left...");
                left = minDepthHelper(node.left);
                
            }

            if(node.right != null)
            {
                //Console.WriteLine("Going right...");
                right = minDepthHelper(node.right);
            }

            //Console.WriteLine("Node: " + node.value + ", left: " + left + ", right: " + right);
            return Math.Min(left, right) + 1;
        }

        public int depth(Node node)
        {
            int left = 0;
            int right = 0;

            if (isLeaf(node))
            {
                return 1;
            }

            if (node.left != null)
            {
                left = depth(node.left);
            }

            if (node.right != null)
            {
                right = depth(node.right);
            }

            return Math.Max(left, right) + 1;
        }

        public bool isLeaf(Node node)
        {
            if(node.left == null && node.right == null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }

    public class Node
    {
        public Node left;
        public Node right;
        public int value;

        public Node(int data)
        {
            value = data;
            left = null;
            right = null;
        }
    }
}
