using System;
using System.Collections.Generic;

class GrafoEuleriano
{
    private int V;
    private List<int>[] adj;

    public GrafoEuleriano(int V)
    {
        this.V = V;
        adj = new List<int>[V];
        for (int i = 0; i < V; i++)
        {
            adj[i] = new List<int>();
        }
    }

    public void AddAresta(int v, int w)
    {
        adj[v].Add(w);
        adj[w].Add(v);
    }

    public bool TemCaminhoEuleriano()
    {
        int odd = 0;
        for (int i = 0; i < V; i++)
        {
            if (adj[i].Count % 2 != 0)
            {
                odd++;
            }
        }
        return odd == 0 || odd == 2;
    }

    private void DFS(int v, bool[] visitado)
    {
        visitado[v] = true;

        foreach (int i in adj[v])
        {
            if (!visitado[i])
            {
                DFS(i, visitado);
            }
        }
    }

    private bool TodasConectadas()
    {
        bool[] visitado = new bool[V];
        int i;
        for (i = 0; i < V; i++)
        {
            if (adj[i].Count != 0)
            {
                break;
            }
        }

        if (i == V) return true;

        DFS(i, visitado);

        for (i = 0; i < V; i++)
        {
            if (visitado[i] == false && adj[i].Count > 0)
            {
                return false;
            }
        }

        return true;
    }

    public void EncontrarCaminhoEuleriano()
    {
        if (!TemCaminhoEuleriano() || !TodasConectadas())
        {
            Console.WriteLine("O grafo não possui caminho euleriano.");
            return;
        }

        int u = 0;
        for (int i = 0; i < V; i++)
        {
            if (adj[i].Count % 2 != 0)
            {
                u = i;
                break;
            }
        }

        Stack<int> pilha = new Stack<int>();
        List<int> caminhoEuleriano = new List<int>();

        pilha.Push(u);

        while (pilha.Count > 0)
        {
            int v = pilha.Peek();
            if (adj[v].Count == 0)
            {
                caminhoEuleriano.Add(v);
                pilha.Pop();
            }
            else
            {
                int w = adj[v][0];
                adj[v].Remove(w);
                adj[w].Remove(v);
                pilha.Push(w);
            }
        }

        Console.WriteLine("Caminho Euleriano:");
        foreach (int vertice in caminhoEuleriano)
        {
            Console.Write(vertice + " ");
        }
    }
}

class Program
{
    static void Main()
    {
        GrafoEuleriano g = new GrafoEuleriano(5);
        g.AddAresta(0, 1);
        g.AddAresta(0, 2);
        g.AddAresta(1, 2);
        g.AddAresta(1, 3);
        g.AddAresta(3, 4);
        g.AddAresta(2, 3);
        g.AddAresta(2, 4);

        g.EncontrarCaminhoEuleriano();
    }
}
