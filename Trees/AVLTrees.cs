using System;
using DatastructureAlgorithms.AVLTreeNodes;
using DatastructureAlgorithms.TreeBases;

namespace DatastructureAlgorithms.AVLTree
{
    public class AVLTrees
    {
        public AVLTreeNode Root;
        public AVLTrees()
        {
            this.Root = null;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="node"></param>
        public void UpdateHeight(AVLTreeNode node)
        {
            node.Height = 1 + Math.Max(Height(node.Left), Height(node.Right));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="node"></param>
        /// <returns></returns>
        public int Height(AVLTreeNode node)
        {
            return node == null ? -1 : node.Height;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="node"></param>
        /// <returns></returns>
        int GetBalance(AVLTreeNode node) {
            return (node == null) ? 0 : Height(node.Left) - Height(node.Right);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="y"></param>
        /// <returns></returns>
        public AVLTreeNode RotateRight(AVLTreeNode y)
        {
            AVLTreeNode x = y.Left;
            AVLTreeNode z = x.Right;

            x.Right = y;
            y.Left = z;

            UpdateHeight(y);
            UpdateHeight(x);

            return x;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="y"></param>
        /// <returns></returns>
        public AVLTreeNode RotateLeft(AVLTreeNode y)
        {
            AVLTreeNode x = y.Right;
            AVLTreeNode z = x.Left;

            x.Left = y;
            y.Right = z;

            UpdateHeight(y);
            UpdateHeight(x);

            return x;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="node"></param>
        /// <returns></returns>
        public AVLTreeNode mostLeftChild(AVLTreeNode node) {
            AVLTreeNode current = node;

            while (current.Left != null) {
                current = current.Left;
            }
            return current;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="z"></param>
        /// <returns></returns>
        public AVLTreeNode Rebalance(AVLTreeNode z) 
        {
            UpdateHeight(z);
            int balance = GetBalance(z);
    
            if (balance > 1) 
            {
                if (Height(z.Left.Left) > Height(z.Left.Right))
                {   
                    z = RotateRight(z);
                }
                else 
                {
                    z.Left = RotateLeft(z.Left);
                    z = RotateRight(z);
                }
            }
            else if(balance < -1)
            {
                if(Height(z.Right.Right) > Height(z.Right.Left))
                {
                    z = RotateLeft(z);
                }
                else 
                {
                    z.Right = RotateRight(z.Right);
                    z = RotateLeft(z);
                }
            }

            return z;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Key"></param>
        public void insert(int Key)
        {
            Root = Insert(this.Root, Key);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="node"></param>
        /// <param name="Key"></param>
        /// <returns></returns>
        public AVLTreeNode Insert(AVLTreeNode node, int Key) 
        {
            if (node == null) 
            {
                return new AVLTreeNode(Key);
            } 
            else if (Key < node.Data) 
            {
                node.Left = Insert(node.Left, Key);
            } 
            else if (Key > node.Data) 
            {
                node.Right = Insert(node.Right, Key);
            } 
            else 
            {
                throw new Exception("duplicate Key!");
            }
            Console.WriteLine(node.Data);
            return Rebalance(node);
        }

        public void InOrder()
        {
            InOrderTraversal(this.Root);
        }

        private void InOrderTraversal(AVLTreeNode node)
        {
            if(node != null)
            {
                InOrderTraversal(node.Left);
                Console.WriteLine(node.Data + " ");
                InOrderTraversal(node.Right);
            }            
        }

        public AVLTreeNode delete(AVLTreeNode node, int Key)
        {
            if (node == null) {
                return node;
            } else if (node.Data > Key) {
                node.Left = delete(node.Left, Key);
            } else if (node.Data < Key) {
                node.Right = delete(node.Right, Key);
            } else {
                if (node.Left == null || node.Right == null) {
                    node = (node.Left == null) ? node.Right : node.Left;
                } else {
                    AVLTreeNode mostLeftChild = this.mostLeftChild(node.Right);
                    node.Data = mostLeftChild.Data;
                    node.Right = delete(node.Right, node.Data);
                }
            }
            if (node != null) {
                node = Rebalance(node);
            }

            return node;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Key"></param>
        /// <returns></returns>
        public AVLTreeNode Find(int Key) 
        {
            AVLTreeNode current = this.Root;

            do
            {
                if (current.Data == Key) 
                    break;

                current = Key > current.Data ? current.Right : current.Left;
            }while(current != null);
            
            return current;
        }
    }
}