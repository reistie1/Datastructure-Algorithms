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
            return (node == null) ? 0 : Height(node.left) - Height(node.right);
        }

        public AVLTreeNode RotateRight(AVLTreeNode y)
        {
            AVLTreeNode x = y.left;
            AVLTreeNode z = x.right;

            x.right = y;
            y.left = z;

            UpdateHeight(y);
            UpdateHeight(x);

            return x;
        }

        public AVLTreeNode RotateLeft(AVLTreeNode y)
        {
            AVLTreeNode x = y.right;
            AVLTreeNode z = x.left;

            x.left = y;
            y.right = z;

            UpdateHeight(y);
            UpdateHeight(x);

            return x;
        }

        public AVLTreeNode mostLeftChild(AVLTreeNode node) {
            AVLTreeNode current = node;

            while (current.left != null) {
                current = current.left;
            }
            return current;
        }

        public AVLTreeNode Rebalance(AVLTreeNode z) 
        {
            UpdateHeight(z);
            int balance = GetBalance(z);

            if(balance < -1)
            {
                if(Height(z.right.right) > Height(z.right.left))
                {
                    z = RotateLeft(z);
                }
                else {
                    z.right = RotateRight(z.right);
                    z = RotateLeft(z);
                }
            }
            else if (balance > 1) 
            {
                if (Height(z.left.left) > Height(z.left.right))
                {   
                    z = RotateRight(z);
                }
                else 
                {
                    z.left = RotateLeft(z.left);
                    z = RotateRight(z);
                }
            }

            return z;
        }

        public void insert(int key)
        {
            root = Insert(this.root, key);
        }

        public AVLTreeNode Insert(AVLTreeNode node, int key) 
        {
            if (node == null) 
            {
                return new AVLTreeNode(key);
            } 
            else if (key < node.data) 
            {
                node.left = Insert(node.left, key);
            } 
            else if (key > node.data) 
            {
                node.right = Insert(node.right, key);
            } 
            else 
            {
                throw new Exception("duplicate Key!");
            }
            Console.WriteLine(node.data);
            return Rebalance(node);
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

        public AVLTreeNode delete(AVLTreeNode node, int key)
        {
            if (node == null) {
                return node;
            } else if (node.data > key) {
                node.left = delete(node.left, key);
            } else if (node.data < key) {
                node.right = delete(node.right, key);
            } else {
                if (node.left == null || node.right == null) {
                    node = (node.left == null) ? node.right : node.left;
                } else {
                    AVLTreeNode mostLeftChild = this.mostLeftChild(node.right);
                    node.data = mostLeftChild.data;
                    node.right = delete(node.right, node.data);
                }
            }
            if (node != null) {
                node = Rebalance(node);
            }

            return node;
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