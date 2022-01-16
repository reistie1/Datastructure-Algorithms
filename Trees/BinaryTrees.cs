using System;
using DatastructureAlgorithms.Trees;

namespace DatastructureAlgorithms.BinaryTree
{
    public class BinaryTrees
    {
        public TreeNode root;

        public BinaryTrees()
        {
            root = null;
        }

        public void InOrder()
        {
            InOrderTraversal(this.root);
        }

        public void PreOrder()
        {
            PreOrderTraversal(this.root);
        }

        public void PostOrder()
        {
            PostOrderTraversal(this.root);
        }

        private void PreOrderTraversal(TreeNode node)
        {
            if(node != null)
            {
                Console.WriteLine(node.Key + " ");
                InOrderTraversal(node.Left);
                InOrderTraversal(node.Right);
            } 
        }

        private void PostOrderTraversal(TreeNode node)
        {
            if(node != null)
            {
                InOrderTraversal(node.Left);
                InOrderTraversal(node.Right);
                Console.WriteLine(node.Key + " ");
            } 
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


        public void InsertTreeNode(int val)
        {
            this.root = InsertNode(this.root, val);
        }

        private TreeNode InsertNode(TreeNode root, int val)
        {
            if(root == null)
            {
                root = new TreeNode(val);
                return root;
            }

            if(val < root.Key)
            {
                root.Left = InsertNode(root.Left, val);
            }

            else if(val > root.Key)
            {
                root.Right = InsertNode(root.Right, val);
            }
            return root;
        }

        public bool DeleteNode(int val)
        {
            return DeleteTreeNode(this.root, val) == null ? false : true;
        }

        private TreeNode DeleteTreeNode(TreeNode node, int val)
        {
            if(node == null)
            {
                return node;
            }

            if(val < node.Key)
            {
                node.Right = DeleteTreeNode(node.Left, val);
            }
            else if(val > node.Key)
            {
                node.Left = DeleteTreeNode(node.Right, val);
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

        public bool Search(int val)
        {
            return SearchTree(this.root, val) == null ? false : true;
        }

        private TreeNode SearchTree(TreeNode node, int val)
        {
            if(node.Key == val || node == null)
            {
                return node;
            }

            if(val > node.Key)
            {
                return SearchTree(node.Right, val);
            }
            
            return SearchTree(node.Left, val);
        }
    }
}