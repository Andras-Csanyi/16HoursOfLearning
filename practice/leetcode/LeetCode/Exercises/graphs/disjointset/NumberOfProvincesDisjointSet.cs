namespace Exercises.graphs.disjointset;

/// <summary>
///     https://leetcode.com/explore/learn/card/graph/618/disjoint-set/3845/
///     [
///     [1,1,0,0]
///     [1,0,1,0]
///     [1,0,0,1]
///     ]
/// </summary>
public class NumberOfProvincesDisjointSet
{
    private int[] graph;

    public int FindCircleNum(int[][] isConnected)
    {
        int width = isConnected[0].Length;
        int height = isConnected.Length;

        if (width != height)
        {
            throw new Exception("not a matrix");
        }

        graph = new int[width];
        for (int i = 0; i < graph.Length; i++)
        {
            graph[i] = i;
        }

        for (int w = 0; w < width; w++)
        {
            for (int h = 0; h < height; h++)
            {
                if (isConnected[w][h] == 1)
                {
                    if (w != h)
                    {
                        QuickUnion(w, h);
                    }
                }
            }
        }

        return CountDistinctRoots();
    }

    private int CountDistinctRoots()
    {
        SortedSet<int> distinctValues = new SortedSet<int>();
        for (int i = 0; i < graph.Length; i++)
        {
            distinctValues.Add(graph[i]);
        }

        return distinctValues.Count;
    }

    public void QuickUnion(int firstNode, int secondNode)
    {
        int firstNodeVal = QuickFind(firstNode);
        int secondNodeVal = QuickFind(secondNode);

        if (firstNodeVal != secondNodeVal)
        {
            for (int i = 0; i < graph.Length; i++)
            {
                if (graph[i] == secondNodeVal)
                {
                    graph[i] = firstNodeVal;
                }
            }
        }
    }

    public int QuickFind(int node)
    {
        return graph[node];
    }
}