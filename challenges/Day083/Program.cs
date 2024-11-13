using System;
using System.Collections.Generic;

public class GerenciamentoCentroConvencoes
{
    List<string> agendas = new List<string>();
    List<string> eventos = new List<string>();

    public void Agendar(object objeto)
    {
        if (objeto is string nome)
        {
            if (eventos.Contains(nome))
            {
                agendas.Add(nome);
                Console.WriteLine($"Agenda {nome} agendada.");
            }
            else if (nome.Contains("Conversao"))
            {
                eventos.Add(nome);
            }
        }
        else if (objeto is int)
        {
            Console.WriteLine("Só pode ser String!");
        }
    }

    public void Remover(object objeto)
    {
        if (objeto is string nome)
        {
            if (agendas.Contains(nome))
            {
                agendas.Remove(nome);
                Console.WriteLine($"Agenda {nome} removida.");
            }
        }
    }

    public void Atualizar(object objeto)
    {
        if (objeto is string nome)
        {
            if (eventos.Contains(nome))
            {
                eventos.Remove(nome);
                Console.WriteLine($"Evento {nome} removido.");
            }
        }
        else if (objeto is int)
        {
            Console.WriteLine("Só pode ser String!");
        }
    }

    public void ListarTudo()
    {
        Console.WriteLine("Agendas:");
        foreach (var agenda in agendas)
        {
            Console.WriteLine(agenda);
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        GerenciamentoCentroConvencoes gerenciamento = new GerenciamentoCentroConvencoes();

        gerenciamento.Agendar("Conversao de Software");
        gerenciamento.Agendar("Conversao de Dados");
        gerenciamento.Agendar("Evento de Tecnologia");

        gerenciamento.Agendar(123);

        gerenciamento.ListarTudo();

        gerenciamento.Remover("Conversao de Software");

        gerenciamento.ListarTudo();

        gerenciamento.Atualizar("Conversao de Dados");

        gerenciamento.ListarTudo();
    }
}
