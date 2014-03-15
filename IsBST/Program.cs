using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsBST
{
    class Program
    {
        static void Main(string[] args)
        {
            Node root = new Node(7);
            root.Left = new Node(6);
            root.Right = new Node(9);
            root.Left.Right = new Node(8);

            Console.WriteLine("Is tree a BST : {0}", IsBST(root));
        }

        static bool IsBST(Node root)
        {
            return IsBSTHelper(root, Int32.MinValue, Int32.MaxValue); 
        }

        static bool IsBSTHelper(Node root, int min, int max)
        {
            if (root == null)
            { 
                return true;
            }
            else
            {
                if (min <= root.Data && root.Data < max)
                {
                    return IsBSTHelper(root.Left, min, root.Data) && IsBSTHelper(root.Right, root.Data, max);
                }

                return false;
            }
        }

    }


    class Node
    {
        public Node(int data)
        {
            Data = data;
        }

        public int Data { get; private set; }

        public Node Left { get; set; }

        public Node Right { get; set; }
    }
}
