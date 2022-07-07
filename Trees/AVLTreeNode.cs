namespace DatastructureAlgorithms.AVLTreeNodes
{
    public class AVLTreeNode
    {
        public AVLTreeNode Left {get; set;}
        public AVLTreeNode Right {get; set;}
        public int Data;
        public int Height;
        public AVLTreeNode()
        {
            this.Data = 0;
            this.Right = null;
            this.Left = null;
            this.Height = 0;
        }

         public AVLTreeNode(int Key)
        {
            this.Data = Key;
            this.Right = null;
            this.Left = null;
            this.Height = 0;
        }
    }
}