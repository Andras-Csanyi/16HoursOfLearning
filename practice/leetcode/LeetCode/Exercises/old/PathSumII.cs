namespace Exercises.old;

public class PathSumII
{
    private IList<IList<int>> result = new List<IList<int>>();

    public IList<IList<int>> PathSum(TreeNode root, int targetSum)
    {
        PathSummer(root, targetSum, new LinkedList<int>());
        return result;
    }

    public void PathSummer(TreeNode? node, int targetSum, LinkedList<int> path)
    {
        if (node == null)
        {
            return;
        }

        path.AddLast(node.val);
        targetSum -= node.val;

        if (node.left == null && node.right == null)
        {
            if (targetSum == 0)
            {
                result.Add(path.ToArray());
                // result.Add(path);
            }
        }
        else
        {
            PathSummer(node.left, targetSum, path);
            PathSummer(node.right, targetSum, path);
        }

        path.RemoveLast();
    }

    public class TreeNode
    {
        public TreeNode? left;
        public TreeNode? right;
        public int val;

        public TreeNode(int val = 0, TreeNode? left = null, TreeNode? right = null)
        {
            this.val = val;
            this.left = left;
            this.right = right;
        }
    }
}