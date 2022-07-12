using System;
using DatastructureAlgorithms.TreeBases;
using DatastructureAlgorithms.Trees;

namespace DatastructureAlgorithms.BinaryTree
{
    public class BinaryTrees : TreeBase
    {
        //public TreeNode Root;

        public BinaryTrees()
        {
            Root = null;
        }

        public void InsertTreeNode(int Value)
        {
            this.Root = InsertNode(this.Root, Value);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Root"></param>
        /// <param name="Value"></param>
        /// <returns></returns>
        private TreeNode InsertNode(TreeNode Root, int Value)
        {
            if(Root == null)
            {
                Root = new TreeNode(Value);
                return Root;
            }

            if(Value < Root.Key)
            {
                Root.Left = InsertNode(Root.Left, Value);
            }
            else if(Value > Root.Key)
            {
                Root.Right = InsertNode(Root.Right, Value);
            }
            return Root;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Value"></param>
        /// <returns></returns>
        public bool DeleteNode(int Value)
        {
            return DeleteTreeNode(this.Root, Value) == null ? false : true;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="node"></param>
        /// <param name="Value"></param>
        /// <returns></returns>
        private TreeNode DeleteTreeNode(TreeNode node, int Value)
        {
            if(node == null)
            {
                return node;
            }

            if(Value < node.Key)
            {
                node.Right = DeleteTreeNode(node.Left, Value);
            }
            else if(Value > node.Key)
            {
                node.Left = DeleteTreeNode(node.Right, Value);
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
                    TreeNode Min = node.Right;
                    while(Min.Left != null)
                    {
                        Min = Min.Left;
                    }

                    node.Key = Min.Key;
                    node.Right = DeleteTreeNode(node.Right, Min.Key);
                    return node;
                }
            }
            
            return null;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Value"></param>
        /// <returns></returns>
        public bool Search(int Value)
        {
            return SearchTree(this.Root, Value) == null ? false : true;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="node"></param>
        /// <param name="Value"></param>
        /// <returns></returns>
        private TreeNode SearchTree(TreeNode node, int Value)
        {
            if(node.Key == Value || node == null)
            {
                return node;
            }

            if(Value > node.Key)
            {
                return SearchTree(node.Right, Value);
            }
            
            return SearchTree(node.Left, Value);
        }
    }
}