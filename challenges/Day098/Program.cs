using System;
using System.Collections.Generic;

public class GerenciamentoProducao
{
    List<string> producao = new List<string>();
    List<string> estoque = new List<string>();
    List<string> vendas = new List<string>();

    public void Adicionar(string tipo, string item)
    {
        if (tipo.ToLower() == "producao")
        {
            producao.Add(item);
        }
        else if (tipo.ToLower() == "estoque")
        {
            estoque.Add(item);
        }
        else if (tipo.ToLower() == "vendas")
        {
            vendas.Add(item);
        }
    }

    public void Remover(string tipo, string item)
    {
        if (tipo.ToLower() == "producao")
        {
            producao.Remove(item);
        }
        else if (tipo.ToLower() == "estoque")
        {
            estoque.Remove(item);
        }
        else if (tipo.ToLower() == "vendas")
        {
            vendas.Remove(item);
        }
    }

    public void Atualizar(string tipo, string antigo, string novo)
    {
        if (tipo.ToLower() == "producao")
        {
            int index = producao.IndexOf(antigo);
            if (index != -1)
            {
                producao[index] = novo;
            }
        }
        else if (tipo.ToLower() == "estoque")
        {
            int index = estoque.IndexOf(antigo);
            if (index != -1)
            {
                estoque[index] = novo;
            }
        }
        else if (tipo.ToLower() == "vendas")
        {
            int index = vendas.IndexOf(antigo);
            if (index != -1)
            {
                vendas[index] = novo;
            }
        }
    }

    public void Listar()
    {
        Console.WriteLine("Produção:");
        foreach (var item in producao)
        {
            Console.WriteLine(item);
        }

        Console.WriteLine("Estoque:");
        foreach (var item in estoque)
        {
            Console.WriteLine(item);
        }

        Console.WriteLine("Vendas:");
        foreach (var item in vendas)
        {
            Console.WriteLine(item);
        }
    }
}

public class Program
{
    public static void Main()
    {
        GerenciamentoProducao sistema = new GerenciamentoProducao();

        sistema.Adicionar("producao", "Produção Item 1");
        sistema.Adicionar("producao", "Produção Item 2");

        sistema.Adicionar("estoque", "Estoque Item A");
        sistema.Adicionar("estoque", "Estoque Item B");

        sistema.Adicionar("vendas", "Venda Item X");
        sistema.Adicionar("vendas", "Venda Item Y");

        Console.WriteLine("Antes de Remover:");
        sistema.Listar();

        sistema.Remover("producao", "Produção Item 1");
        sistema.Remover("vendas", "Venda Item Y");

        Console.WriteLine("\nApós Remoções:");
        sistema.Listar();

        sistema.Atualizar("producao", "Produção Item 2", "Produção Item 2 - Atualizado");

        Console.WriteLine("\nApós Atualizações:");
        sistema.Listar();
    }
}
