using System;
using System.Collections.Generic;

class Program
{
    private int Vertices;
    private List<int>[] adj;

    public Program(int v)
    {
        Vertices = v;
        adj = new List<int>[v];
        for (int i = 0; i < v; i++)
            adj[i] = new List<int>();
    }

    public void AddEdge(int v, int w)
    {
        adj[v].Add(w);
    }

    private void TopologicalSortUtil(int v, bool[] visited, Stack<int> stack)
    {
        visited[v] = true;

        foreach (var neighbor in adj[v])
        {
            if (!visited[neighbor])
                TopologicalSortUtil(neighbor, visited, stack);
        }

        stack.Push(v);
    }

    public void TopologicalSort()
    {
        Stack<int> stack = new Stack<int>();
        bool[] visited = new bool[Vertices];
        
        for (int i = 0; i < Vertices; i++)
            if (!visited[i])
                TopologicalSortUtil(i, visited, stack);

        while (stack.Count > 0)
            Console.Write(stack.Pop() + " ");
    }

    static void Main(string[] args)
    {
        Program g = new Program(6);
        g.AddEdge(5, 2);
        g.AddEdge(5, 0);
        g.AddEdge(4, 0);
        g.AddEdge(4, 1);
        g.AddEdge(2, 3);
        g.AddEdge(3, 1);

        g.TopologicalSort();
    }
}
