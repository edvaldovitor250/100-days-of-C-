using System;
using System.Collections.Generic;

public class Edge : IComparable<Edge>
{
    public int Source { get; }
    public int Destination { get; }
    public int Weight { get; }

    public Edge(int source, int destination, int weight)
    {
        Source = source;
        Destination = destination;
        Weight = weight;
    }

    public int CompareTo(Edge other)
    {
        return Weight.CompareTo(other.Weight);
    }
}

public class Graph
{
    public int Vertices { get; }
    public List<Edge> Edges { get; }

    public Graph(int vertices)
    {
        Vertices = vertices;
        Edges = new List<Edge>();
    }

    public void AddEdge(int source, int destination, int weight)
    {
        Edges.Add(new Edge(source, destination, weight));
    }

    public int Find(int[] parent, int vertex)
    {
        if (parent[vertex] != vertex)
        {
            parent[vertex] = Find(parent, parent[vertex]);
        }
        return parent[vertex];
    }

    public void Union(int[] parent, int[] rank, int sourceRoot, int destinationRoot)
    {
        if (rank[sourceRoot] < rank[destinationRoot])
        {
            parent[sourceRoot] = destinationRoot;
        }
        else if (rank[sourceRoot] > rank[destinationRoot])
        {
            parent[destinationRoot] = sourceRoot;
        }
        else
        {
            parent[destinationRoot] = sourceRoot;
            rank[sourceRoot]++;
        }
    }

    public void KruskalMST()
    {
        List<Edge> mst = new List<Edge>();
        Edges.Sort();

        int[] parent = new int[Vertices];
        int[] rank = new int[Vertices];

        for (int i = 0; i < Vertices; i++)
        {
            parent[i] = i;
            rank[i] = 0;
        }

        int edgeCount = 0;
        int index = 0;

        while (edgeCount < Vertices - 1 && index < Edges.Count)
        {
            Edge nextEdge = Edges[index++];
            int sourceRoot = Find(parent, nextEdge.Source);
            int destinationRoot = Find(parent, nextEdge.Destination);

            if (sourceRoot != destinationRoot)
            {
                mst.Add(nextEdge);
                Union(parent, rank, sourceRoot, destinationRoot);
                edgeCount++;
            }
        }

        Console.WriteLine("Arestas na Árvore Geradora Mínima:");
        foreach (Edge edge in mst)
        {
            Console.WriteLine($"{edge.Source} -- {edge.Destination} == {edge.Weight}");
        }
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        Graph graph = new Graph(6);

        graph.AddEdge(0, 1, 4);
        graph.AddEdge(0, 2, 4);
        graph.AddEdge(1, 2, 2);
        graph.AddEdge(1, 3, 5);
        graph.AddEdge(2, 3, 5);
        graph.AddEdge(2, 4, 6);
        graph.AddEdge(3, 4, 2);
        graph.AddEdge(3, 5, 3);
        graph.AddEdge(4, 5, 1);

        graph.KruskalMST();
    }
}
