using System;
using System.Collections.Generic;

public class GerenciarFabrica
{
    private List<string> fabricas = new List<string>();
    private List<string> producoes = new List<string>();
    private List<int> estoques = new List<int>();
    private List<string> logistica = new List<string>();

    public void AdicionarFabrica(string nome)
    {
        fabricas.Add(nome);
        Console.WriteLine($"Fábrica {nome} adicionada.");
    }

    public void RemoverFabrica(string nome)
    {
        if (fabricas.Contains(nome))
        {
            fabricas.Remove(nome);
            Console.WriteLine($"Fábrica {nome} removida.");
        }
        else
        {
            Console.WriteLine($"Fábrica {nome} não encontrada.");
        }
    }
    public void ControlarProducao(string producao, int estoque)
    {
        producoes.Add(producao);
        estoques.Add(estoque);
        Console.WriteLine($"Produção: {producao}, Estoque: {estoque}");

        if (estoque < 10)
        {
            logistica.Add(producao);
            Console.WriteLine($"Produção {producao} adicionada à logística (estoque baixo).");
        }
    }

    public void MostrarEstoques()
    {
        Console.WriteLine("----- Estoques -----");
        for (int i = 0; i < producoes.Count; i++)
        {
            Console.WriteLine($"Produção: {producao[i]}, Estoque: {estoques[i]}");
        }
    }

    public void MostrarLogistica()
    {
        Console.WriteLine("----- Logística -----");
        if (logistica.Count == 0)
        {
            Console.WriteLine("Nenhum produto em logística.");
        }
        else
        {
            foreach (var item in logistica)
            {
                Console.WriteLine($"Produto em logística: {item}");
            }
        }
    }

    // Exibe todas as fábricas cadastradas
    public void MostrarFabricas()
    {
        Console.WriteLine("----- Fábricas -----");
        if (fabricas.Count == 0)
        {
            Console.WriteLine("Nenhuma fábrica cadastrada.");
        }
        else
        {
            foreach (var fabrica in fabricas)
            {
                Console.WriteLine($"Fábrica: {fabrica}");
            }
        }
    }
}

class Program
{
    static void Main()
    {
        GerenciarFabrica gerenciarFabrica = new GerenciarFabrica();

        gerenciarFabrica.AdicionarFabrica("Fábrica A");
        gerenciarFabrica.AdicionarFabrica("Fábrica B");
        gerenciarFabrica.RemoverFabrica("Fábrica B");

        gerenciarFabrica.ControlarProducao("Produto A", 5);
        gerenciarFabrica.ControlarProducao("Produto B", 20);

        gerenciarFabrica.MostrarFabricas();
        gerenciarFabrica.MostrarEstoques();
        gerenciarFabrica.MostrarLogistica();
    }
}
