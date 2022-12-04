namespace Exercises.graphs.disjointset;

public class ValidTreeDisjointSet
{
    private List<Node> graph = new List<Node>();

    public bool ValidTree(int n, int[][] edges)
    {
        BuildNodes(n);
        BuildGraph(edges);
        return ValidateTree();
    }

    private void BuildNodes(int i)
    {
        for (int j = 0; j < i; j++)
        {
            graph.Add(new Node { Value = j, ParentValue = j });
        }
    }

    public bool ValidateTree()
    {
        if (!HasSingleRoot())
        {
            return false;
        }

        if (HasCycle())
        {
            return false;
        }

        return true;
    }

    public bool HasCycle()
    {
        HashSet<int> distinctValues = new HashSet<int>();
        foreach (Node node in graph)
        {
            if (!distinctValues.Add(node.Value))
            {
                return true;
            }
        }

        return false;
    }

    public bool HasSingleRoot()
    {
        if (graph.Count(n => n.Value == n.ParentValue) != 1)
        {
            return false;
        }

        return true;
    }

    private void BuildGraph(int[][] edges)
    {
        for (int i = 0; i < edges.Length; i++)
        {
            Union(edges[i][0], edges[i][1]);
        }
    }

    public void Union(int parentValue, int value)
    {
        Node? node = graph.FirstOrDefault(p => p.Value == value);
        if (node is null)
        {
            throw new Exception("no such node");
        }

        node.ParentValue = parentValue;
    }

    public class Node
    {
        public int Value { get; set; }
        public int ParentValue { get; set; }
    }
}