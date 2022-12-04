namespace Exercises.old;

public class PopulateNextRightPointers
{
    public Node Connect(Node? root)
    {
        Queue<Node> nodeQueue = new Queue<Node>();

        if (root != null)
        {
            nodeQueue.Enqueue(root);

            while (nodeQueue.Any())
            {
                int queueSize = nodeQueue.Count;

                for (int i = 0; i < queueSize; i++)
                {
                    if (nodeQueue.Any())
                    {
                        Node popped = nodeQueue.Dequeue();

                        if (popped.left != null)
                        {
                            nodeQueue.Enqueue(popped.left);
                        }

                        if (popped.right != null)
                        {
                            nodeQueue.Enqueue(popped.right);
                        }

                        if (i < queueSize - 1)
                        {
                            popped.next = nodeQueue.Peek();
                        }
                    }
                }
            }
        }

        return root;
    }


    // Definition for a Node.
    public class Node
    {
        public Node? left;
        public Node? next;
        public Node? right;
        public int val;

        public Node()
        {
        }

        public Node(int _val)
        {
            val = _val;
        }

        public Node(int _val, Node? _left, Node? _right, Node? _next)
        {
            val = _val;
            left = _left;
            right = _right;
            next = _next;
        }
    }
}