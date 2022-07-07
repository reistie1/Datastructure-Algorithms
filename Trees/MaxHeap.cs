using System;
using DatastructureAlgorithms.Trees;

namespace DatastructureAlgorithms.MaxHeap
{
    public class MaxHeaps
    {
        public TreeNode Root;
        public MaxHeaps()
        {
            this.Root = null;
        }

        public void Insert(int Key)
        {
            this.Root = InsertNode(this.Root, Key);
        }

        public void InOrder()
        {
            InOrderTraversal(this.Root);
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

        public TreeNode InsertNode(TreeNode node, int Key)
        {
            if(node == null)
            {
                return new TreeNode(Key);
            }
            if(node.Left == null)
            {
                if(Key > node.Key)
                {
                    node.Left = new TreeNode(node.Key);
                    node.Key = Key;
                }
                else
                {
                    node.Left = new TreeNode(Key);
                }
                return node;
            }
            if(node.Right == null)
            {
                if(Key > node.Key)
                {
                    node.Right = new TreeNode(node.Key);
                    node.Key = Key;
                }
                else
                {
                    node.Right = new TreeNode(Key);
                }
                return node;
            }

            if(node.Left != null)
            {
                node.Left = InsertNode(node.Left, Key);
            }
            else if(node.Right != null)
            {
                node.Right = InsertNode(node.Right, Key);
            }


            return node;
        }
    }
}