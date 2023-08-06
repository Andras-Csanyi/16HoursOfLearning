namespace Exercises.graphs.DFS;

public class DAGAllPathsToNode
{
    private List<int[]> edges = new List<int[]>();
    private IList<IList<int>> paths = new List<IList<int>>();

    public IList<IList<int>> AllPathsSourceTarget(int[][] graph)
    {
        int destination = graph.Length - 1;

        for (int i = 0; i < graph.Length; i++)
        {
            if (graph[i].Any())
            {
                for (int j = 0; j < graph[i].Length; j++)
                {
                    edges.Add(new[] { i, graph[i][j] });
                }
            }
        }

        DFS(0, destination, new List<int>());
        return paths;
    }

    private void DFS(int source, int destination, List<int> path)
    {
        path.Add(source);
        List<int> nodesAvailableFromSource = edges.Where(p => p[0] == source)
            .Select(s => s[1]).ToList();

        if (source == destination)
        {
            paths.Add(path.ToList());
        }
        else
        {
            foreach (int i in nodesAvailableFromSource)
            {
                DFS(i, destination, path);
            }
        }

        if (path[^1] != source)
        {
            throw new Exception("asd");
        }

        path.RemoveAt(path.Count - 1);
    }
}