namespace Exercises.old;

public class ValidateBST
{
    public bool IsValidBST(TreeNode root)
    {
        return Validate(root, null, null);
    }

    public bool Validate(TreeNode? node, int? lowerBound, int? upperBound)
    {
        if (node == null) return true;

        // left
        if ((lowerBound != null && node.val >= lowerBound)
            || (upperBound != null && node.val <= upperBound))
        {
            return false;
        }

        return Validate(node.left, node.val, upperBound) && Validate(node.right, lowerBound, node.val);
    }
}

public class TreeNode
{
    public TreeNode? left;
    public TreeNode? right;
    public int? val;

    public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
    {
        this.val = val;
        this.left = left;
        this.right = right;
    }
}