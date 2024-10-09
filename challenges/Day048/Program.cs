using System;
using System.Collections.Generic;

class Graph
{
    private int vertices;
    private List<int>[] adjList;

    public Graph(int v)
    {
        vertices = v;
        adjList = new List<int>[v];
        for (int i = 0; i < v; i++)
        {
            adjList[i] = new List<int>();
        }
    }

    public void AddEdge(int v, int w)
    {
        adjList[v].Add(w);
        adjList[w].Add(v);
    }

    private bool IsIndependentSet(List<int> subset)
    {
        for (int i = 0; i < subset.Count; i++)
        {
            for (int j = i + 1; j < subset.Count; j++)
            {
                if (adjList[subset[i]].Contains(subset[j]))
                {
                    return false;
                }
            }
        }
        return true;
    }

    public List<int> FindMaximumIndependentSet()
    {
        List<int> maxSet = new List<int>();
        List<int> currentSet = new List<int>();

        FindMaximumIndependentSetUtil(0, currentSet, ref maxSet);
        return maxSet;
    }

    private void FindMaximumIndependentSetUtil(int index, List<int> currentSet, ref List<int> maxSet)
    {
        if (IsIndependentSet(currentSet) && currentSet.Count > maxSet.Count)
        {
            maxSet = new List<int>(currentSet);
        }

        for (int i = index; i < vertices; i++)
        {
            currentSet.Add(i);
            FindMaximumIndependentSetUtil(i + 1, currentSet, ref maxSet);
            currentSet.RemoveAt(currentSet.Count - 1);
        }
    }

    public void PrintSet(List<int> set)
    {
        Console.Write("Conjunto Independente Máximo: { ");
        foreach (var v in set)
        {
            Console.Write(v + " ");
        }
        Console.WriteLine("}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Graph graph = new Graph(6); 

        graph.AddEdge(0, 1);
        graph.AddEdge(1, 2);
        graph.AddEdge(1, 3);
        graph.AddEdge(3, 4);
        graph.AddEdge(4, 5);

        List<int> maxIndependentSet = graph.FindMaximumIndependentSet();
        graph.PrintSet(maxIndependentSet);
    }
}
