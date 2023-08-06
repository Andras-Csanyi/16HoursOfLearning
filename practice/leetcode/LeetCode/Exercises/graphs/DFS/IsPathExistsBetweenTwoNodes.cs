namespace Exercises.graphs.DFS;

public class IsPathExistsBetweenTwoNodes
{
    private List<int[]> graph = new List<int[]>();
    private int maxVerticesId;
    private List<int> visitedVertices = new List<int>();

    public bool ValidPath(int n, int[][] edges, int source, int destination)
    {
        maxVerticesId = n;
        foreach (int[] edge in edges)
        {
            graph.Add(new[] { edge[0], edge[1] });
            graph.Add(new[] { edge[1], edge[0] });
        }

        return Dfs(source, destination);
    }

    private bool Dfs(int source, int destination)
    {
        if (source == destination) return true;

        if (source > maxVerticesId)
        {
            throw new Exception("vertices is out of range");
        }

        if (!visitedVertices.Contains(source))
        {
            visitedVertices.Add(source);
            List<int> targetVertices = graph
                .Where(p => p[0] == source).Select(g => g[1]).ToList();
            if (targetVertices.Contains(destination))
            {
                return true;
            }

            foreach (int t in targetVertices)
            {
                bool res = Dfs(t, destination);

                if (res)
                {
                    return true;
                }
            }
        }

        return false;
    }
}