using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        public class Node
        {
            public int data;
            public Node left, right;

            public Node(int data)
            {
                this.data = data;
                left = right = null;
            }
        }

        public class BinaryTree
        {
            public Node root;

            public static int findMax(Node node)
            {
                if (node == null)
                {
                    return int.MinValue;
                }

                int res = node.data;
                int firstCheckres = findMax(node.left);
                int secondCheckres = findMax(node.right);

                if (firstCheckres > res)
                {
                    res = firstCheckres;
                }
                if (secondCheckres > res)
                {
                    res = secondCheckres;
                }
                return res;
            }

            static void Main(string[] args)
            {
                BinaryTree tree = new BinaryTree();
                tree.root = new Node(10);
                tree.root.left = new Node(20);
                tree.root.right = new Node(30);
                tree.root.left.right = new Node(40);
                tree.root.left.right.left = new Node(50);
                tree.root.left.right.right = new Node(60);
                tree.root.right.right = new Node(70);
                tree.root.right.right.left = new Node(99);

                Console.WriteLine("Max element is " + BinaryTree.findMax(tree.root));
            }
        }
    }
}