# Day 94

## Desafio:

Crie um sistema C# para gerenciar um estúdio de gravação, com funcionalidades para agendamento de sessões, gravação de áudio e produção musical.

**Resultado:**

```cshap
using System;
using System.Collections.Generic;

public class Agendamento
{
    public DateTime DataHora { get; set; }
    public string Gravacao { get; set; }
    public string ProducaoMusical { get; set; }
}

public class GerenciamentoEstudioGravacao
{
    private readonly List<Agendamento> agendamentos = new List<Agendamento>();

    public void AgendarSessao(DateTime dataHora, string gravacao)
    {
        agendamentos.Add(new Agendamento
        {
            DataHora = dataHora,
            Gravacao = gravacao,
            ProducaoMusical = null
        });

        Console.WriteLine($"Gravação '{gravacao}' agendada para {dataHora}.");
    }

    public void AgendarProducaoMusical(DateTime dataHora, string producaoMusical)
    {
        var agendamento = agendamentos.Find(a => a.DataHora == dataHora);

        if (agendamento != null)
        {
            agendamento.ProducaoMusical = producaoMusical;
            Console.WriteLine($"Produção musical '{producaoMusical}' adicionada para {dataHora}.");
        }
        else
        {
            Console.WriteLine($"Data '{dataHora}' não encontrada. Não foi possível agendar a produção musical.");
        }
    }

    public void ListarAgendamentos()
    {
        if (agendamentos.Count == 0)
        {
            Console.WriteLine("Nenhum agendamento encontrado.");
            return;
        }

        Console.WriteLine("\nAgendamentos:");
        foreach (var agendamento in agendamentos)
        {
            Console.WriteLine($"Data: {agendamento.DataHora}, Gravação: {agendamento.Gravacao}, Produção Musical: {agendamento.ProducaoMusical ?? "N/A"}");
        }
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        var estudio = new GerenciamentoEstudioGravacao();

        estudio.AgendarSessao(new DateTime(2024, 11, 21, 14, 0, 0), "Gravação de Voz");
        estudio.AgendarSessao(new DateTime(2024, 11, 22, 16, 0, 0), "Gravação de Instrumentos");

        estudio.AgendarProducaoMusical(new DateTime(2024, 11, 21, 14, 0, 0), "Mixagem de Voz");
        estudio.AgendarProducaoMusical(new DateTime(2024, 11, 23, 10, 0, 0), "Masterização Final"); // Falhará pois a data não existe

        estudio.ListarAgendamentos();
    }
}
