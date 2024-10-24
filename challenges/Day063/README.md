# Day 63

## Desafio:

		Desenvolva um aplicativo em C# que implemente o algoritmo de Dijkstra para encontrar o caminho mais curto em um grafo.

**Resultado:**

```cshap

using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        int[,] graph = {
            { 0, 4, 0, 0, 0, 0, 0, 8, 0 },
            { 4, 0, 8, 0, 0, 0, 0, 11, 0 },
            { 0, 8, 0, 7, 0, 4, 0, 0, 2 },
            { 0, 0, 7, 0, 9, 14, 0, 0, 0 },
            { 0, 0, 0, 9, 0, 10, 0, 0, 0 },
            { 0, 0, 4, 14, 10, 0, 2, 0, 0 },
            { 0, 0, 0, 0, 0, 2, 0, 1, 6 },
            { 8, 11, 0, 0, 0, 0, 1, 0, 7 },
            { 0, 0, 2, 0, 0, 0, 6, 7, 0 }
        };

        Dijkstra(graph, 0);
    }

    static int MinDistance(int[] dist, bool[] sptSet, int verticesCount)
    {
        int min = int.MaxValue, minIndex = -1;

        for (int v = 0; v < verticesCount; v++)
        {
            if (!sptSet[v] && dist[v] <= min)
            {
                min = dist[v];
                minIndex = v;
            }
        }

        return minIndex;
    }

    static void Dijkstra(int[,] graph, int source)
    {
        int verticesCount = graph.GetLength(0);
        int[] dist = new int[verticesCount];
        bool[] sptSet = new bool[verticesCount];

        for (int i = 0; i < verticesCount; i++)
        {
            dist[i] = int.MaxValue;
            sptSet[i] = false;
        }

        dist[source] = 0;

        for (int count = 0; count < verticesCount - 1; count++)
        {
            int u = MinDistance(dist, sptSet, verticesCount);
            sptSet[u] = true;

            for (int v = 0; v < verticesCount; v++)
            {
                if (!sptSet[v] && graph[u, v] != 0 && dist[u] != int.MaxValue && dist[u] + graph[u, v] < dist[v])
                {
                    dist[v] = dist[u] + graph[u, v];
                }
            }
        }

        Print(dist, verticesCount);
    }

    static void Print(int[] dist, int verticesCount)
    {
        Console.WriteLine("Vértice \t Distância da origem");
        for (int i = 0; i < verticesCount; i++)
        {
            Console.WriteLine(i + " \t\t " + dist[i]);
        }
    }
}
