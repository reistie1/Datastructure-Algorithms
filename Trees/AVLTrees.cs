using System;
using DatastructureAlgorithms.AVLTreeNodes;

namespace DatastructureAlgorithms.AVLTree
{
    public class AVLTrees
    {
        public AVLTreeNode root;
        public AVLTrees()
        {
            this.root = null;
        }

        public void UpdateHeight(AVLTreeNode node)
        {
            node.height = 1 + Math.Max(Height(node.left), Height(node.right));
        }

        public int Height(AVLTreeNode node)
        {
            return node == null ? -1 : node.height;
        }

        int GetBalance(AVLTreeNode node) {
            return (node == null) ? 0 : Height(node.right) - Height(node.left);
        }

        public AVLTreeNode RotateRight(AVLTreeNode node)
        {
            AVLTreeNode left = node.left;
            AVLTreeNode right = node.right;

            left.right = node;
            node.left = right;

            UpdateHeight(node);
            UpdateHeight(left);

            return left;
        }

        public AVLTreeNode RotateLeft(AVLTreeNode node)
        {
            AVLTreeNode left = node.left;
            AVLTreeNode right = node.right;

            right.left = node;
            node.right = left;

            UpdateHeight(node);
            UpdateHeight(right);

            return left;
        }

        public AVLTreeNode Rebalance(AVLTreeNode node) 
        {
            throw new NotImplementedException();
        }

        public AVLTreeNode insert(int key)
        {
            return Insert(this.root, key);
        }

        public AVLTreeNode Insert(AVLTreeNode node, int key) 
        {
            if (node == null) 
            {
                return new AVLTreeNode(key);
            } 
            else if (node.data > key) 
            {
                node.left = Insert(node.left, key);
            } 
            else if (node.data < key) 
            {
                node.right = Insert(node.right, key);
            } 
            else 
            {
                throw new Exception("duplicate Key!");
            }
            return node;
            //return Rebalance(node);
        }

        public void InOrder()
        {
            InOrderTraversal(this.root);
        }

        private void InOrderTraversal(AVLTreeNode node)
        {
            if(node != null)
            {
                InOrderTraversal(node.left);
                Console.WriteLine(node.data + " ");
                InOrderTraversal(node.right);
            }            
        }


        public AVLTreeNode Find(int key) 
        {
            AVLTreeNode current = this.root;

            do
            {
                if (current.data == key) 
                    break;

                current = key > current.data ? current.right : current.left;
            }while(current != null);
            
            return current;
        }
    }
}