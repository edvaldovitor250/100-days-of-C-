# Day 91

## Desafio:

	Desenvolva um aplicativo em C# que implemente um sistema de gerenciamento de um spa, permitindo gerenciar tratamentos, clientes e agendamentos.

**Resultado:**

```cshap

using System;
using System.Collections.Generic;

public class GerenciamentoSpan<T>
{
    private readonly Dictionary<string, List<T>> categorias = new Dictionary<string, List<T>>
    {
        { "tratamento", new List<T>() },
        { "cliente", new List<T>() },
        { "agendamento", new List<T>() }
    };

    public void Adicionar(T obj, string categoria)
    {
        if (categorias.ContainsKey(categoria.ToLower()))
        {
            categorias[categoria.ToLower()].Add(obj);
        }
        else
        {
            Console.WriteLine($"Categoria inválida! Categorias válidas: {string.Join(", ", categorias.Keys)}");
        }
    }

    public void Remover(T obj, string categoria)
    {
        if (categorias.ContainsKey(categoria.ToLower()))
        {
            categorias[categoria.ToLower()].Remove(obj);
        }
        else
        {
            Console.WriteLine($"Categoria inválida! Categorias válidas: {string.Join(", ", categorias.Keys)}");
        }
    }

    public void Listar()
    {
        foreach (var categoria in categorias)
        {
            Console.WriteLine($"\n{categoria.Key.FirstCharToUpper()}s:");
            categoria.Value.ForEach(item => Console.WriteLine(item));
        }
    }
}

public static class StringExtensions
{
    public static string FirstCharToUpper(this string input) =>
        string.IsNullOrEmpty(input) ? input : char.ToUpper(input[0]) + input.Substring(1);
}

class Program
{
    static void Main(string[] args)
    {
        var gerenciamento = new GerenciamentoSpan<string>();

        gerenciamento.Adicionar("Tratamento Estético", "tratamento");
        gerenciamento.Adicionar("Cliente 1", "cliente");
        gerenciamento.Adicionar("Agendamento para 20/11/2024", "agendamento");
        gerenciamento.Adicionar("Tratamento Capilar", "tratamento");
        gerenciamento.Adicionar("Cliente 2", "cliente");
        gerenciamento.Adicionar("Agendamento para 25/11/2024", "agendamento");

        Console.WriteLine("\nItens após adição:");
        gerenciamento.Listar();

        gerenciamento.Remover("Cliente 1", "cliente");
        gerenciamento.Remover("Agendamento para 20/11/2024", "agendamento");

        Console.WriteLine("\nItens após remoção:");
        gerenciamento.Listar();

        gerenciamento.Adicionar("Tratamento Teste", "invalido");
        gerenciamento.Remover("Cliente Teste", "invalido");
    }
}
