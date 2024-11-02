# Day 72

## Desafio:

	Implemente um sistema em C# para gerenciar uma agência de viagens, com funcionalidades para reserva de pacotes, voos e hotéis.

**Resultado:**

```cshap

using System;
using System.Collections.Generic;

public class GerenciamentoViagem
{
    List<string> reservas = new List<string> { "Reserva1", "Reserva2", "Reserva3" };
    List<string> voos = new List<string> { "Voo1", "Voo2", "Voo3" };
    List<string> hoteis = new List<string> { "Hotel1", "Hotel2", "Hotel3" };

    List<List<string>> todasAsListas;

    public GerenciamentoViagem()
    {
        todasAsListas = new List<List<string>> { reservas, voos, hoteis };
    }

    public void ListarReservas()
    {
        foreach (List<string> lista in todasAsListas)
        {
            foreach (string item in lista)
            {
                Console.WriteLine(item);
            }
        }
    }

    public void ReservarPacotes(string r, string v, string h)
    {
        if (reservas.Contains(r) || voos.Contains(v) || hoteis.Contains(h))
        {
            Console.WriteLine("Já existe uma reserva para esse pacote.");
        }
        else
        {
            Console.WriteLine("Pacote reservado com sucesso.");
            reservas.Add(r);
            voos.Add(v);
            hoteis.Add(h);
        }
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        GerenciamentoViagem gerenciamento = new GerenciamentoViagem();
        
        Console.WriteLine("Listando reservas, voos e hotéis iniciais:");
        gerenciamento.ListarReservas();

        Console.WriteLine("\nTentando reservar um novo pacote:");
        gerenciamento.ReservarPacotes("Reserva4", "Voo4", "Hotel4");

        Console.WriteLine("\nListando após a nova reserva:");
        gerenciamento.ListarReservas();

        Console.WriteLine("\nTentando reservar um pacote já existente:");
        gerenciamento.ReservarPacotes("Reserva1", "Voo1", "Hotel1");

        Console.WriteLine("\nListando após tentar uma reserva duplicada:");
        gerenciamento.ListarReservas();
    }
}
