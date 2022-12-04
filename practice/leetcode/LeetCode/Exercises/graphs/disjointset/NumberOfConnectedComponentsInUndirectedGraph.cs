namespace Exercises.graphs.disjointset;

public class NumberOfConnectedComponentsInUndirectedGraph
{
        private int[] graph;
        public int CountComponents(int n, int[][] edges)
        {
            BuildGraph(n, edges);
            return Count();
        }

        private int Count()
        {
            int counter = 0;

            for (int i = 0; i < graph.Length; i++)
            {
                if (i == graph[i])
                {
                    counter++;
                }
            }

            return counter;
        }

        private void BuildGraph(int i, int[][] edges)
        {
            graph = new int[i];
            for (int j = 0; j < i; j++)
            {
                graph[j] = j;
            }

            foreach (int[] ints in edges)
            {
                Union(ints[0], ints[1]);
            }
        }

        private void Union(int first, int second)
        {
            int firstNode = Find(first);
            int secondNode = Find(second);

            graph[second] = first;
        }

        private int Find(int node)
        {
            return graph[node];
        }
}