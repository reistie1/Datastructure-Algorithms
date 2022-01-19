namespace DatastructureAlgorithms.AVLTreeNodes
{
    public class AVLTreeNode
    {
        public AVLTreeNode left {get; set;}
        public AVLTreeNode right {get; set;}
        public int data;
        public int height;
        public AVLTreeNode()
        {
            this.data = 0;
            this.right = null;
            this.left = null;
            this.height = 0;
        }

         public AVLTreeNode(int key)
        {
            this.data = key;
            this.right = null;
            this.left = null;
            this.height = 0;
        }
    }
}