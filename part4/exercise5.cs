using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Collections;

namespace part4
{
    // found help on how to solve this exercise on the internet.
    // used the site csharpstar.com/csharp-program-to-implement-binary-search-tree/
    // to get starting with this exercise.
    // got help from stackoverflow.com/questions/2597637/finding-height-in-binary-search-tree
    // on how to do the Height of the tree part
    public class BinarySearchTree
    {
        public class Node
        {
            public int value;
            public Node leftNode;
            public Node rightNode;

            public void DisplayNode()
            {
                Console.Write(value + " ");
            }


        }

        public Node root;

        public BinarySearchTree()
        {
            this.root = null;
        }
        public void Add(int x)
        {
            Node newNode = new Node();
            newNode.value = x;

            if (this.root == null)
            {
                this.root = newNode;
            }
            else
            {
                Node current = this.root;
                Node parent;

                while (true)
                {
                    parent = current;
                    if (x < current.value)
                    {
                        current = current.leftNode;
                        if (current == null)
                        {
                            parent.leftNode = newNode;
                            break;
                        }
                    }
                    else
                    {
                        current = current.rightNode;
                        if (current == null)
                        {
                            parent.rightNode = newNode;
                            break;
                        }
                    }

                }
            }

        }

        public int Height()
        {
            Node node = this.root;
            return findHeight(node);
        }

        private int findHeight(Node aNode)
        {
            if (aNode == null)
            {
                return - 1;
            }
            int heightLeftNode = -1;
            int heightRightNode = -1;

            if (aNode.leftNode != null)
            {
                heightLeftNode = findHeight(aNode.leftNode);
            }
            if (aNode.rightNode != null)
            {
                heightRightNode = findHeight(aNode.rightNode);
            }

            if (heightLeftNode > heightRightNode)
            {
                return heightLeftNode + 1;
            }
            else
            {
                return heightRightNode + 1;
            }

            
        }
    }
}