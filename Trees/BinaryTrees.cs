using System;
using DatastructureAlgorithms.TreeBases;
using DatastructureAlgorithms.Trees;

namespace DatastructureAlgorithms.BinaryTree
{
    public class BinaryTrees : TreeBase
    {
        //public TreeNode root;

        public BinaryTrees()
        {
            root = null;
        }

        // /// <summary>
        // /// 
        // /// </summary>
        // public void InOrder()
        // {
        //     InOrderTraversal(this.root);
        // }

        // /// <summary>
        // /// 
        // /// </summary>
        // public void PreOrder()
        // {
        //     PreOrderTraversal(this.root);
        // }

        // /// <summary>
        // /// 
        // /// </summary>
        // public void PostOrder()
        // {
        //     PostOrderTraversal(this.root);
        // }

        // /// <summary>
        // /// 
        // /// </summary>
        // /// <param name="node"></param>
        // private void PreOrderTraversal(TreeNode node)
        // {
        //     if(node != null)
        //     {
        //         Console.WriteLine(node.Key + " ");
        //         InOrderTraversal(node.Left);
        //         InOrderTraversal(node.Right);
        //     } 
        // }

        // /// <summary>
        // /// 
        // /// </summary>
        // /// <param name="node"></param>
        // private void PostOrderTraversal(TreeNode node)
        // {
        //     if(node != null)
        //     {
        //         InOrderTraversal(node.Left);
        //         InOrderTraversal(node.Right);
        //         Console.WriteLine(node.Key + " ");
        //     } 
        // }

        // /// <summary>
        // /// 
        // /// </summary>
        // /// <param name="node"></param>
        // private void InOrderTraversal(TreeNode node)
        // {
        //     if(node != null)
        //     {
        //         InOrderTraversal(node.Left);
        //         Console.WriteLine(node.Key + " ");
        //         InOrderTraversal(node.Right);
        //     }            
        // }


        public void InsertTreeNode(int value)
        {
            this.root = InsertNode(this.root, value);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="root"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        private TreeNode InsertNode(TreeNode root, int value)
        {
            if(root == null)
            {
                root = new TreeNode(value);
                return root;
            }

            if(value < root.Key)
            {
                root.Left = InsertNode(root.Left, value);
            }

            else if(value > root.Key)
            {
                root.Right = InsertNode(root.Right, value);
            }
            return root;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public bool DeleteNode(int value)
        {
            return DeleteTreeNode(this.root, value) == null ? false : true;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="node"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        private TreeNode DeleteTreeNode(TreeNode node, int value)
        {
            if(node == null)
            {
                return node;
            }

            if(value < node.Key)
            {
                node.Right = DeleteTreeNode(node.Left, value);
            }
            else if(value > node.Key)
            {
                node.Left = DeleteTreeNode(node.Right, value);
            }
            else
            {
                if(node.Left == null)
                {
                    return node.Right;
                }
                else if(node.Right == null)
                {
                    return node.Left;
                }
                else
                {
                    TreeNode min = node.Right;
                    while(min.Left != null)
                    {
                        min = min.Left;
                    }

                    node.Key = min.Key;
                    node.Right = DeleteTreeNode(node.Right, min.Key);
                    return node;
                }
            }
            
            return null;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public bool Search(int value)
        {
            return SearchTree(this.root, value) == null ? false : true;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="node"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        private TreeNode SearchTree(TreeNode node, int value)
        {
            if(node.Key == value || node == null)
            {
                return node;
            }

            if(value > node.Key)
            {
                return SearchTree(node.Right, value);
            }
            
            return SearchTree(node.Left, value);
        }
    }
}