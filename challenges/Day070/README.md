# Day 70

## Desafio:

	Crie um sistema C# para gerenciar uma academia, com funcionalidades para gerenciar alunos, planos de treino e agendamento de aulas.

**Resultado:**

```cshap

using System;
using System.Collections.Generic;

public class GerenciamentoAcademia
{
    List<string> alunos = new List<string>();
    List<string> treinos = new List<string>();

    public void AdicionarAluno(string nome)
    {
        alunos.Add(nome);
        Console.WriteLine($"Aluno {nome} adicionado.");
    }

    public void AdicionarTreino(string aluno, string treino)
    {
        if (alunos.Contains(aluno))
        {
            treinos.Add(aluno + " - " + treino);
            Console.WriteLine($"Treino '{treino}' adicionado para o aluno {aluno}.");
        }
        else
        {
            Console.WriteLine($"Aluno '{aluno}' não encontrado. Não foi possível adicionar o treino '{treino}'.");
        }
    }

    public void AgendarAulas(string aluno, int data)
    {
        if (alunos.Contains(aluno))
        {
            Console.WriteLine($"{aluno} agendou aula no dia {data}");
        }
        else
        {
            Console.WriteLine($"Aluno '{aluno}' não encontrado. Não foi possível agendar a aula.");
        }
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        GerenciamentoAcademia academia = new GerenciamentoAcademia();

        academia.AdicionarAluno("João");
        academia.AdicionarAluno("Maria");

        academia.AdicionarTreino("João", "Treino de Pernas");
        academia.AdicionarTreino("Maria", "Treino de Braços");
        academia.AdicionarTreino("Pedro", "Treino de Costas"); 

        academia.AgendarAulas("João", 20231101);
        academia.AgendarAulas("Maria", 20231102);
        academia.AgendarAulas("Pedro", 20231103); 
    }
}
