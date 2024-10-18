using System;
using System.Collections.Generic;

class Graph
{
    private int V;
    private List<int>[] adj;

    public Graph(int v)
    {
        V = v;
        adj = new List<int>[v];
        for (int i = 0; i < v; ++i)
            adj[i] = new List<int>();
    }

    public void AddEdge(int v, int w)
    {
        adj[v].Add(w);
    }

    private void DFSUtil(int v, bool[] visited, Stack<int> stack)
    {
        visited[v] = true;
        foreach (int neighbor in adj[v])
        {
            if (!visited[neighbor])
                DFSUtil(neighbor, visited, stack);
        }
        stack.Push(v);
    }

    private Graph GetTranspose()
    {
        Graph g = new Graph(V);
        for (int v = 0; v < V; v++)
        {
            foreach (int neighbor in adj[v])
            {
                g.adj[neighbor].Add(v);
            }
        }
        return g;
    }

    private void DFSUtil(int v, bool[] visited)
    {
        visited[v] = true;
        Console.Write(v + " ");
        foreach (int neighbor in adj[v])
        {
            if (!visited[neighbor])
                DFSUtil(neighbor, visited);
        }
    }

    public void FindSCCs()
    {
        Stack<int> stack = new Stack<int>();

        bool[] visited = new bool[V];
        for (int i = 0; i < V; i++)
        {
            if (!visited[i])
                DFSUtil(i, visited, stack);
        }

        Graph gr = GetTranspose();

        visited = new bool[V];
        while (stack.Count > 0)
        {
            int v = stack.Pop();

            if (!visited[v])
            {
                gr.DFSUtil(v, visited);
                Console.WriteLine();
            }
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        Graph g = new Graph(5);
        g.AddEdge(1, 0);
        g.AddEdge(0, 2);
        g.AddEdge(2, 1);
        g.AddEdge(0, 3);
        g.AddEdge(3, 4);

        Console.WriteLine("Componentes fortemente conectados:");
        g.FindSCCs();
    }
}
