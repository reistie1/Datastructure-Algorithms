using System;
using DatastructureAlgorithms.Trees;

namespace DatastructureAlgorithms.MaxHeap
{
    public class MaxHeaps
    {
        public TreeNode root;
        public MaxHeaps()
        {
            this.root = null;
        }

        public void Insert(int key)
        {
            this.root = InsertNode(this.root, key);
        }

        public void InOrder()
        {
            InOrderTraversal(this.root);
        }

        private void InOrderTraversal(TreeNode node)
        {
            if(node != null)
            {
                InOrderTraversal(node.Left);
                Console.WriteLine(node.Key + " ");
                InOrderTraversal(node.Right);
            }            
        }

        public TreeNode InsertNode(TreeNode node, int key)
        {
            if(node == null)
            {
                return new TreeNode(key);
            }
            if(node.Left == null)
            {
                if(key > node.Key)
                {
                    node.Left = new TreeNode(node.Key);
                    node.Key = key;
                }
                else
                {
                    node.Left = new TreeNode(key);
                }
                return node;
            }
            if(node.Right == null)
            {
                if(key > node.Key)
                {
                    node.Right = new TreeNode(node.Key);
                    node.Key = key;
                }
                else
                {
                    node.Right = new TreeNode(key);
                }
                return node;
            }

            if(node.Left != null)
            {
                node.Left = InsertNode(node.Left, key);
            }
            else if(node.Right != null)
            {
                node.Right = InsertNode(node.Right, key);
            }


            return node;
        }
    }
}