namespace Exercises.old;

public class SameTree
{
    public bool IsSameTree(TreeNode p, TreeNode q)
    {
        return AreTheyTheSame(p, q);
    }

    private bool AreTheyTheSame(TreeNode? theOne, TreeNode? theOther)
    {
        if (theOne == null && theOther == null) return true;

        if ((theOne != null && theOther == null)
            || (theOne == null && theOther != null)
            || (theOne.val != theOther.val))
        {
            return false;
        }

        return AreTheyTheSame(theOne.left, theOther.left) && AreTheyTheSame(theOne.right, theOther.right);
    }


    public class TreeNode
    {
        public TreeNode? left;
        public TreeNode? right;
        public int? val;

        public TreeNode(int val = 0, TreeNode? left = null, TreeNode? right = null)
        {
            this.val = val;
            this.left = left;
            this.right = right;
        }
    }
}