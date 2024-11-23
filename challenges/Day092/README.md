# Day 92

## Desafio:

	Implemente um sistema em C# para gerenciar uma empresa de catering, com funcionalidades para gerenciar eventos, cardápios e clientes.

**Resultado:**

```cshap

using System;
using System.Collections.Generic;

public class GerenciamentoCatering
{
    private readonly List<string> eventos = new List<string>();
    private readonly List<string> cardapios = new List<string>();
    private readonly List<string> clientes = new List<string>();

    public void Adicionar(string item, string categoria)
    {
        switch (categoria.ToLower())
        {
            case "evento":
                eventos.Add(item);
                Console.WriteLine($"Evento adicionado: {item}");
                break;
            case "cardápio":
                cardapios.Add(item);
                Console.WriteLine($"Cardápio adicionado: {item}");
                break;
            case "cliente":
                clientes.Add(item);
                Console.WriteLine($"Cliente adicionado: {item}");
                break;
            default:
                Console.WriteLine("Categoria inválida! Use 'evento', 'cardápio' ou 'cliente'.");
                break;
        }
    }

    public void Remover(string item, string categoria)
    {
        switch (categoria.ToLower())
        {
            case "evento":
                if (eventos.Remove(item))
                    Console.WriteLine($"Evento removido: {item}");
                else
                    Console.WriteLine($"Evento não encontrado: {item}");
                break;
            case "cardápio":
                if (cardapios.Remove(item))
                    Console.WriteLine($"Cardápio removido: {item}");
                else
                    Console.WriteLine($"Cardápio não encontrado: {item}");
                break;
            case "cliente":
                if (clientes.Remove(item))
                    Console.WriteLine($"Cliente removido: {item}");
                else
                    Console.WriteLine($"Cliente não encontrado: {item}");
                break;
            default:
                Console.WriteLine("Categoria inválida! Use 'evento', 'cardápio' ou 'cliente'.");
                break;
        }
    }

    public void Atualizar(string itemAntigo, string itemNovo, string categoria)
    {
        switch (categoria.ToLower())
        {
            case "evento":
                AtualizarLista(eventos, itemAntigo, itemNovo, "Evento");
                break;
            case "cardápio":
                AtualizarLista(cardapios, itemAntigo, itemNovo, "Cardápio");
                break;
            case "cliente":
                AtualizarLista(clientes, itemAntigo, itemNovo, "Cliente");
                break;
            default:
                Console.WriteLine("Categoria inválida! Use 'evento', 'cardápio' ou 'cliente'.");
                break;
        }
    }

    public void Listar()
    {
        Console.WriteLine("\n--- Eventos ---");
        eventos.ForEach(e => Console.WriteLine(e));

        Console.WriteLine("\n--- Cardápios ---");
        cardapios.ForEach(c => Console.WriteLine(c));

        Console.WriteLine("\n--- Clientes ---");
        clientes.ForEach(cl => Console.WriteLine(cl));
    }

    private void AtualizarLista(List<string> lista, string itemAntigo, string itemNovo, string categoria)
    {
        int index = lista.IndexOf(itemAntigo);
        if (index != -1)
        {
            lista[index] = itemNovo;
            Console.WriteLine($"{categoria} atualizado: {itemAntigo} -> {itemNovo}");
        }
        else
        {
            Console.WriteLine($"{categoria} não encontrado: {itemAntigo}");
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        var catering = new GerenciamentoCatering();

        catering.Adicionar("Casamento de João e Maria", "evento");
        catering.Adicionar("Festa de Formatura", "evento");
        catering.Adicionar("Buffet Premium", "cardápio");
        catering.Adicionar("Buffet Kids", "cardápio");
        catering.Adicionar("João Silva", "cliente");
        catering.Adicionar("Maria Oliveira", "cliente");

        Console.WriteLine("\nItens após adição:");
        catering.Listar();

        catering.Atualizar("Buffet Premium", "Buffet VIP", "cardápio");
        catering.Atualizar("João Silva", "João Santos", "cliente");

        Console.WriteLine("\nItens após atualização:");
        catering.Listar();

        catering.Remover("Festa de Formatura", "evento");
        catering.Remover("Buffet Kids", "cardápio");

        Console.WriteLine("\nItens após remoção:");
        catering.Listar();
    }
}
