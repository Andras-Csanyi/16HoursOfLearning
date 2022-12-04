namespace Exercises.old;

using System.Text;

public class SumNumbersExercise
{
    private int _pathSums = 0;

    public int SumNumbers(TreeNode root)
    {
        TraverseTheTree(root, new StringBuilder());
        return _pathSums;
    }

    private void SumTheNumbers(string number)
    {
        int num = Int32.Parse(number);
        _pathSums += num;
    }

    private void TraverseTheTree(TreeNode? node, StringBuilder builder)
    {
        builder.Append(node.val);

        if (node.left == null && node.right == null)
        {
            SumTheNumbers(builder.ToString());
            builder.Remove(builder.Length - 1, 1);
            return;
        }

        if (node.left != null)
        {
            TraverseTheTree(node.left, builder);
        }

        if (node.right != null)
        {
            TraverseTheTree(node.right, builder);
        }

        builder.Remove(builder.Length - 1, 1);
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