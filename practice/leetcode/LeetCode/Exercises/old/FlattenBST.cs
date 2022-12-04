namespace Exercises.old;

public class FlattenBST
{
    public TreeNode Flatten(TreeNode root)
    // public void Flatten(TreeNode root)
    {
        FlattenBSTToLinkedList(root);

        return root;
    }

    private void FlattenBSTToLinkedList(TreeNode? rootNode)
    {
        if(rootNode == null) return;
        
        // check if the rootnode has left node if it is not selected yet
        TreeNode? actualNode = null;
        
        if (rootNode.left != null)
        {
            actualNode = rootNode.left;

            while (actualNode.right != null)
            {
                actualNode = actualNode.right;
            }

            TreeNode? tmpNodeForOldRightNode = rootNode.right;
            rootNode.right = rootNode.left;
            rootNode.left = null;
            actualNode.right = tmpNodeForOldRightNode;
            
            FlattenBSTToLinkedList(rootNode.right);
        }
        else
        {
            FlattenBSTToLinkedList(rootNode.right);
        }
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