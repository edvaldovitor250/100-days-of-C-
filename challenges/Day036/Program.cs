using System;
using System.Collections.Generic;

public class Edge
{
    public int Source, Destination, Weight;

    public Edge(int source, int destination, int weight)
    {
        Source = source;
        Destination = destination;
        Weight = weight;
    }
}

public class Graph
{
    public int VerticesCount;
    public List<Edge> Edges;

    public Graph(int verticesCount)
    {
        VerticesCount = verticesCount;
        Edges = new List<Edge>();
    }

    public void AddEdge(int source, int destination, int weight)
    {
        Edges.Add(new Edge(source, destination, weight));
    }

    public void BellmanFord(int startVertex)
    {
        int[] distances = new int[VerticesCount];
        for (int i = 0; i < VerticesCount; i++)
        {
            distances[i] = int.MaxValue;
        }
        distances[startVertex] = 0;

        for (int i = 1; i < VerticesCount; i++)
        {
            foreach (var edge in Edges)
            {
                int u = edge.Source;
                int v = edge.Destination;
                int weight = edge.Weight;

                if (distances[u] != int.MaxValue && distances[u] + weight < distances[v])
                {
                    distances[v] = distances[u] + weight;
                }
            }
        }

        foreach (var edge in Edges)
        {
            int u = edge.Source;
            int v = edge.Destination;
            int weight = edge.Weight;

            if (distances[u] != int.MaxValue && distances[u] + weight < distances[v])
            {
                Console.WriteLine("Graph contains a negative-weight cycle");
                return;
            }
        }

        PrintDistances(distances);
    }

    private void PrintDistances(int[] distances)
    {
        Console.WriteLine("Vertex Distance from Source");
        for (int i = 0; i < VerticesCount; i++)
        {
            Console.WriteLine($"{i}\t\t{distances[i]}");
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        int verticesCount = 5;
        Graph graph = new Graph(verticesCount);

        graph.AddEdge(0, 1, -1);
        graph.AddEdge(0, 2, 4);
        graph.AddEdge(1, 2, 3);
        graph.AddEdge(1, 3, 2);
        graph.AddEdge(1, 4, 2);
        graph.AddEdge(3, 2, 5);
        graph.AddEdge(3, 1, 1);
        graph.AddEdge(4, 3, -3);

        graph.BellmanFord(0); 
    }
}
