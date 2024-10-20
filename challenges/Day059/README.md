# Day 59

## Desafio:

	Crie um programa C# que implemente o algoritmo de Prim para encontrar a árvore geradora mínima de um grafo ponderado.

**Resultado:**

```cshap
using System;
using System.Collections.Generic;

class Graph
{
    private int vertices;
    private int[,] graph;

    public Graph(int vertices)
    {
        this.vertices = vertices;
        graph = new int[vertices, vertices];
    }

    public void AddEdge(int source, int destination, int weight)
    {
        graph[source, destination] = weight;
        graph[destination, source] = weight;
    }

    private int MinKey(int[] key, bool[] mstSet)
    {
        int min = int.MaxValue, minIndex = -1;

        for (int v = 0; v < vertices; v++)
            if (mstSet[v] == false && key[v] < min)
            {
                min = key[v];
                minIndex = v;
            }

        return minIndex;
    }

    public void PrimMST()
    {
        int[] parent = new int[vertices];
        int[] key = new int[vertices];
        bool[] mstSet = new bool[vertices];

        for (int i = 0; i < vertices; i++)
        {
            key[i] = int.MaxValue;
            mstSet[i] = false;
        }

        key[0] = 0;
        parent[0] = -1;

        for (int count = 0; count < vertices - 1; count++)
        {
            int u = MinKey(key, mstSet);
            mstSet[u] = true;

            for (int v = 0; v < vertices; v++)
                if (graph[u, v] != 0 && mstSet[v] == false && graph[u, v] < key[v])
                {
                    parent[v] = u;
                    key[v] = graph[u, v];
                }
        }

        PrintMST(parent);
    }

    private void PrintMST(int[] parent)
    {
        Console.WriteLine("Edge \tWeight");
        for (int i = 1; i < vertices; i++)
            Console.WriteLine(parent[i] + " - " + i + "\t" + graph[i, parent[i]]);
    }

    static void Main(string[] args)
    {
        int vertices = 5;
        Graph g = new Graph(vertices);

        g.AddEdge(0, 1, 2);
        g.AddEdge(0, 3, 6);
        g.AddEdge(1, 2, 3);
        g.AddEdge(1, 3, 8);
        g.AddEdge(1, 4, 5);
        g.AddEdge(2, 4, 7);
        g.AddEdge(3, 4, 9);

        g.PrimMST();
    }
}
