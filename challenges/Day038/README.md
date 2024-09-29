# Day 38

## Desafio:

	Desenvolva um aplicativo em C# que resolva o problema das oito rainhas, encontrando todas as soluções válidas para o tabuleiro de xadrez.

**Resultado:**

```cshap


using System;
using System.Collections.Generic;

class OitoRainhas
{
    static int N = 8;

    static bool PosicaoSegura(int[,] tabuleiro, int linha, int coluna)
    {
        for (int i = 0; i < linha; i++)
            if (tabuleiro[i, coluna] == 1)
                return false;

        for (int i = linha, j = coluna; i >= 0 && j >= 0; i--, j--)
            if (tabuleiro[i, j] == 1)
                return false;

        for (int i = linha, j = coluna; i >= 0 && j < N; i--, j++)
            if (tabuleiro[i, j] == 1)
                return false;

        return true;
    }

    static bool ResolverRainhas(int[,] tabuleiro, int linha, List<int[,]> solucoes)
    {
        if (linha >= N)
        {
            int[,] solucao = new int[N, N];
            Array.Copy(tabuleiro, solucao, tabuleiro.Length);
            solucoes.Add(solucao);
            return false;
        }

        for (int coluna = 0; coluna < N; coluna++)
        {
            if (PosicaoSegura(tabuleiro, linha, coluna))
            {
                tabuleiro[linha, coluna] = 1;

                ResolverRainhas(tabuleiro, linha + 1, solucoes);

                tabuleiro[linha, coluna] = 0;
            }
        }

        return false;
    }

    static void ExibirSolucao(int[,] tabuleiro)
    {
        for (int i = 0; i < N; i++)
        {
            for (int j = 0; j < N; j++)
                Console.Write(tabuleiro[i, j] == 1 ? " Q " : " . ");
            Console.WriteLine();
        }
        Console.WriteLine();
    }

    static void Main()
    {
        int[,] tabuleiro = new int[N, N];
        List<int[,]> solucoes = new List<int[,]>();

        ResolverRainhas(tabuleiro, 0, solucoes);

        Console.WriteLine($"Número de soluções encontradas: {solucoes.Count}\n");

        int contador = 1;
        foreach (var solucao in solucoes)
        {
            Console.WriteLine($"Solução {contador}:");
            ExibirSolucao(solucao);
            contador++;
        }
    }
}
