# Day 88

## Desafio:

	Implemente um sistema em C# para gerenciar uma fábrica de alimentos, com funcionalidades para gerenciar produção, estoque e distribuição.

**Resultado:**

```cshap

using System;
using System.Collections.Generic;

public class GerenciamentoFabrica
{
    List<string> producaos = new List<string>();
    List<string> produtos = new List<string>();
    List<int> distribuicao = new List<int>();

    public void Adicionar(object obj)
    {
        if (obj is string str)
        {
            if (str.Contains("produção")) 
            {
                producaos.Add(str);
            }
            else
            {
                produtos.Add(str);
            }
        }
        else if (obj is int number)
        {
            distribuicao.Add(number);
        }
        else
        {
            throw new ArgumentException("Tipo inválido. Apenas string e int são permitidos.");
        }
    }

    public void Remover(object obj)
    {
        if (obj is string str)
        {
            if (str.Contains("produção")) 
            {
                producaos.Remove(str);
            }
            else
            {
                produtos.Remove(str);
            }
        }
        else if (obj is int number)
        {
            distribuicao.Remove(number);
        }
        else
        {
            throw new ArgumentException("Tipo inválido. Apenas string e int são permitidos.");
        }
    }

    public void Atualizar(object obj)
    {
        if (obj is string str)
        {
            if (str.Contains("produção")) 
            {
                if (producaos.Count > 0)
                {
                    producaos[0] = str;
                }
                else
                {
                    throw new InvalidOperationException("Não há itens em 'producaos' para atualizar.");
                }
            }
            else
            {
                if (produtos.Count > 0)
                {
                    produtos[0] = str;
                }
                else
                {
                    throw new InvalidOperationException("Não há itens em 'produtos' para atualizar.");
                }
            }
        }
        else if (obj is int number)
        {
            if (distribuicao.Count > 0)
            {
                distribuicao[0] = number;
            }
            else
            {
                throw new InvalidOperationException("Não há itens em 'distribuicao' para atualizar.");
            }
        }
        else
        {
            throw new ArgumentException("Tipo inválido. Apenas string e int são permitidos.");
        }
    }

    public void Listar()
    {
        Console.WriteLine("Produções:");
        foreach (var item in producaos)
        {
            Console.WriteLine(item);
        }

        Console.WriteLine("Produtos:");
        foreach (var item in produtos)
        {
            Console.WriteLine(item);
        }

        Console.WriteLine("Distribuição:");
        foreach (var item in distribuicao)
        {
            Console.WriteLine(item);
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        GerenciamentoFabrica fabrica = new GerenciamentoFabrica();

        fabrica.Adicionar("produção de carros");
        fabrica.Adicionar("produto novo");
        fabrica.Adicionar(100);
        fabrica.Adicionar(200);

        Console.WriteLine("=== Após adicionar elementos ===");
        fabrica.Listar();

        fabrica.Remover("produção de carros");
        fabrica.Remover(100);

        Console.WriteLine("\n=== Após remover elementos ===");
        fabrica.Listar();

        fabrica.Atualizar("produção de bicicletas"); 
        fabrica.Atualizar("produto atualizado");  
        fabrica.Atualizar(300);                    

        Console.WriteLine("\n=== Após atualizar elementos ===");
        fabrica.Listar();
    }
}
