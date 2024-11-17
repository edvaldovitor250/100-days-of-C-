# Day 87

## Desafio:

	Desenvolva um aplicativo em C# que implemente um sistema de gerenciamento de um hotel fazenda, permitindo gerenciar reservas, atividades e passeios.

**Resultado:**

```cshap

using System;
using System.Collections.Generic;

public class Program
{
    public static void Main(string[] args)
    {
        GerenciamentoHotel hotel = new GerenciamentoHotel();

        Reserva reserva1 = new Reserva("Quarto Deluxe", "2024-11-20");
        Reserva reserva2 = new Reserva("Suíte Presidencial", "2024-11-25");
        Atividade atividade1 = new Atividade("Spa", 90);
        Atividade atividade2 = new Atividade("Massagem Relaxante", 60);
        Passeio passeio1 = new Passeio("Passeio de barco", "Ilha Tropical");
        Passeio passeio2 = new Passeio("Tour pela cidade", "História local");

        hotel.Adicionar(reserva1);
        hotel.Adicionar(reserva2);
        hotel.Adicionar(atividade1);
        hotel.Adicionar(atividade2);
        hotel.Adicionar(passeio1);
        hotel.Adicionar(passeio2);

        Console.WriteLine("Listando todas as reservas, atividades e passeios:");
        hotel.Listar();

        Console.WriteLine("\nRemovendo uma reserva e um passeio...");
        hotel.Remover(reserva1);
        hotel.Remover(passeio1);

        Console.WriteLine("\nListando após remoção:");
        hotel.Listar();

        Console.WriteLine("\nAtualizando a primeira atividade e passeio...");
        Atividade atividadeAtualizada = new Atividade("Aula de Yoga", 120);
        Passeio passeioAtualizado = new Passeio("Safari", "Floresta Nacional");
        hotel.Atualizar(atividadeAtualizada);
        hotel.Atualizar(passeioAtualizado);

        Console.WriteLine("\nListando após atualização:");
        hotel.Listar();
    }
}

public abstract class Objeto { }

public class Reserva : Objeto
{
    public string TipoQuarto { get; }
    public string Data { get; }

    public Reserva(string tipoQuarto, string data)
    {
        TipoQuarto = tipoQuarto;
        Data = data;
    }

    public override string ToString()
    {
        return $"{TipoQuarto} - {Data}";
    }
}

public class Atividade : Objeto
{
    public string Nome { get; }
    public int Duracao { get; } 

    public Atividade(string nome, int duracao)
    {
        Nome = nome;
        Duracao = duracao;
    }

    public override string GetHashCode()
    {
        return Nome.GetHashCode() ^ Duracao.GetHashCode();
    }

    public override string ToString()
    {
        return $"{Nome} - {Duracao} minutos";
    }
}

public class Passeio : Objeto
{
    public string Nome { get; }
    public string Descricao { get; }

    public Passeio(string nome, string descricao)
    {
        Nome = nome;
        Descricao = descricao;
    }

    public override string ToString()
    {
        return $"{Nome} - {Descricao}";
    }
}
