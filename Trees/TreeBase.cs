using System;
using DatastructureAlgorithms.Trees;

namespace DatastructureAlgorithms.TreeBases
{
    public class TreeBase
    {
        public TreeNode root;

        public TreeBase()
        {
            root = null;
        }

        
        /// <summary>
        /// 
        /// </summary>
        public void InOrder()
        {
            InOrderTraversal(this.root);
        }

        /// <summary>
        /// 
        /// </summary>
        public void PreOrder()
        {
            PreOrderTraversal(this.root);
        }

        /// <summary>
        /// 
        /// </summary>
        public void PostOrder()
        {
            PostOrderTraversal(this.root);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="node"></param>
        private void PreOrderTraversal(TreeNode node)
        {
            if(node != null)
            {
                Console.WriteLine(node.Key + " ");
                InOrderTraversal(node.Left);
                InOrderTraversal(node.Right);
            } 
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="node"></param>
        private void PostOrderTraversal(TreeNode node)
        {
            if(node != null)
            {
                InOrderTraversal(node.Left);
                InOrderTraversal(node.Right);
                Console.WriteLine(node.Key + " ");
            } 
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="node"></param>
        private void InOrderTraversal(TreeNode node)
        {
            if(node != null)
            {
                InOrderTraversal(node.Left);
                Console.WriteLine(node.Key + " ");
                InOrderTraversal(node.Right);
            }            
        }
    }
}