using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace minValMaxValTree
{
    class Program
    {
        public class Node
        {
            public int data;
            public Node left, right;

            public Node(int d)
            {
                data = d;
                left = right = null;
            }
        }

        public class BinaryTree
        {

            public static Node head;

            public virtual Node insert(Node node, int data)
            {
                if (node == null)
                {
                    return (new Node(data));
                }
                else
                {
                    if (data <= node.data)
                    {
                        node.left = insert(node.left, data);
                    }
                    else
                    {
                        node.right = insert(node.right, data);
                    }
                    return node;
                }
            }

            public virtual int minvalue(Node node)
            {
                Node current = node;

                while (current.left != null)
                {
                    current = current.left;
                }
                return (current.data);
            }
        }

        static void Main(string[] args)
        {
            BinaryTree tree = new BinaryTree();
            Node root = null;
            root = tree.insert(root, 5);
            tree.insert(root, 20);
            tree.insert(root, 11);
            tree.insert(root, 7);
            tree.insert(root, 8);
            tree.insert(root, 9);
            Console.WriteLine("Min value is " + tree.minvalue(root));
        }
    }
}