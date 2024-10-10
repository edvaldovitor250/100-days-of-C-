using System;
using System.Collections.Generic;

class Program
{
    static int V = 6;

    static bool BFS(int[,] residualGraph, int source, int sink, int[] parent)
    {
        bool[] visited = new bool[V];
        Queue<int> queue = new Queue<int>();

        queue.Enqueue(source);
        visited[source] = true;
        parent[source] = -1;

        while (queue.Count > 0)
        {
            int u = queue.Dequeue();

            for (int v = 0; v < V; v++)
            {
                if (!visited[v] && residualGraph[u, v] > 0)
                {
                    if (v == sink)
                    {
                        parent[v] = u;
                        return true;
                    }
                    queue.Enqueue(v);
                    parent[v] = u;
                    visited[v] = true;
                }
            }
        }
        return false;
    }

    static int FordFulkerson(int[,] graph, int source, int sink)
    {
        int u, v;
        int[,] residualGraph = new int[V, V];

        for (u = 0; u < V; u++)
            for (v = 0; v < V; v++)
                residualGraph[u, v] = graph[u, v];

        int[] parent = new int[V];
        int maxFlow = 0;

        while (BFS(residualGraph, source, sink, parent))
        {
            int pathFlow = int.MaxValue;
            for (v = sink; v != source; v = parent[v])
            {
                u = parent[v];
                pathFlow = Math.Min(pathFlow, residualGraph[u, v]);
            }

            for (v = sink; v != source; v = parent[v])
            {
                u = parent[v];
                residualGraph[u, v] -= pathFlow;
                residualGraph[v, u] += pathFlow;
            }

            maxFlow += pathFlow;
        }

        return maxFlow;
    }

    static void Main()
    {
        int[,] graph = new int[,] {
            { 0, 16, 13, 0, 0, 0 },
            { 0, 0, 10, 12, 0, 0 },
            { 0, 4, 0, 0, 14, 0 },
            { 0, 0, 9, 0, 0, 20 },
            { 0, 0, 0, 7, 0, 4 },
            { 0, 0, 0, 0, 0, 0 }
        };

        Console.WriteLine("O fluxo máximo é " + FordFulkerson(graph, 0, 5));
    }
}
