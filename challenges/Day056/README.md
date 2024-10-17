# Day 56

## Desafio:

	Escreva um programa C# que implemente um sistema de chat em tempo real, permitindo a comunicação entre vários usuários.

**Resultado:**

```cshap
using System;
using System.Collections.Generic;

class TransporteRede
{
    private Dictionary<string, Dictionary<string, int>> grafo = new Dictionary<string, Dictionary<string, int>>();

    public void AdicionarRota(string origem, string destino, int distancia)
    {
        if (!grafo.ContainsKey(origem))
        {
            grafo[origem] = new Dictionary<string, int>();
        }

        if (!grafo.ContainsKey(destino))
        {
            grafo[destino] = new Dictionary<string, int>();
        }

        grafo[origem][destino] = distancia;
        grafo[destino][origem] = distancia;  
    }

    public void ExibirRotas()
    {
        foreach (var origem in grafo)
        {
            foreach (var destino in origem.Value)
            {
                Console.WriteLine($"{origem.Key} -> {destino.Key}: {destino.Value} km");
            }
        }
    }

    public void CalcularDistancia(string origem, string destino)
    {
        if (grafo.ContainsKey(origem) && grafo[origem].ContainsKey(destino))
        {
            Console.WriteLine($"A distância entre {origem} e {destino} é {grafo[origem][destino]} km");
        }
        else
        {
            Console.WriteLine("Rota não encontrada.");
        }
    }

    public void OtimizarTrajeto(string origem, string destino)
    {
        var distancias = new Dictionary<string, int>();
        var visitados = new HashSet<string>();
        var caminhoAnterior = new Dictionary<string, string>();

        foreach (var cidade in grafo.Keys)
        {
            distancias[cidade] = int.MaxValue;
        }
        distancias[origem] = 0;

        while (visitados.Count < grafo.Count)
        {
            string cidadeAtual = null;
            int menorDistancia = int.MaxValue;

            foreach (var cidade in distancias.Keys)
            {
                if (!visitados.Contains(cidade) && distancias[cidade] < menorDistancia)
                {
                    menorDistancia = distancias[cidade];
                    cidadeAtual = cidade;
                }
            }

            if (cidadeAtual == null) break;

            visitados.Add(cidadeAtual);

            foreach (var vizinho in grafo[cidadeAtual])
            {
                int novaDistancia = distancias[cidadeAtual] + vizinho.Value;
                if (novaDistancia < distancias[vizinho.Key])
                {
                    distancias[vizinho.Key] = novaDistancia;
                    caminhoAnterior[vizinho.Key] = cidadeAtual;
                }
            }
        }

        if (distancias[destino] == int.MaxValue)
        {
            Console.WriteLine("Não há caminho disponível.");
            return;
        }

        var caminho = new Stack<string>();
        string cidadeAtualCaminho = destino;

        while (cidadeAtualCaminho != origem)
        {
            caminho.Push(cidadeAtualCaminho);
            cidadeAtualCaminho = caminhoAnterior[cidadeAtualCaminho];
        }
        caminho.Push(origem);

        Console.WriteLine($"Caminho otimizado de {origem} para {destino}:");
        while (caminho.Count > 0)
        {
            Console.Write($"{caminho.Pop()} ");
            if (caminho.Count > 0) Console.Write("-> ");
        }
        Console.WriteLine($"\nDistância total: {distancias[destino]} km");
    }
}

class Program
{
    static void Main(string[] args)
    {
        TransporteRede rede = new TransporteRede();
        
        rede.AdicionarRota("A", "B", 5);
        rede.AdicionarRota("B", "C", 4);
        rede.AdicionarRota("A", "C", 7);
        rede.AdicionarRota("C", "D", 2);
        rede.AdicionarRota("D", "E", 6);

        rede.ExibirRotas();
        rede.CalcularDistancia("A", "C");
        rede.OtimizarTrajeto("A", "E");
    }
}
