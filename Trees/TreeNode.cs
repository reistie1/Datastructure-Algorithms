namespace DatastructureAlgorithms.Trees
{
    public class TreeNode
    {
        private TreeNode _left;
        private TreeNode _right;
        private int _val;
        public TreeNode(TreeNode left = null, TreeNode right = null, int val = 0)
        {
            this._left = left;
            this._right = right;
            this._val = val;
        }
    }
}