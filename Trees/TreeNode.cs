namespace DatastructureAlgorithms.Trees
{
    public class TreeNode
    {
        public TreeNode _left;
        public TreeNode _right;
        public int _val;
        public TreeNode(TreeNode left = null, TreeNode right = null, int val = 0)
        {
            this._left = left;
            this._right = right;
            this._val = val;
        }
    }
}