namespace DatastructureAlgorithms.Trees
{
    public class TreeNode
    {
        public TreeNode Left;
        public TreeNode Right;
        public int Key;
        public TreeNode(int Key = 0)
        {
            this.Left = this.Right = null;
            this.Key = Key;
        }
    }
}