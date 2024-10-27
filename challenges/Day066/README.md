# Day 66

## Desafio:

Crie um sistema C# para gerenciar uma escola, com funcionalidades para gerenciar alunos, professores, e turmas.

**Resultado:**

```cshap

using System;
using System.Collections.Generic;

public class GerenciamentoEscolar 
{
    List<string> alunos = new List<string>();
    List<string> professores = new List<string>();
    List<string> turmas = new List<string>();

    public void ExibirOpcoes()
    {
        Console.WriteLine("\nEscolha uma opção:");
        Console.WriteLine("1: Cadastrar Professor");
        Console.WriteLine("2: Cadastrar Aluno");
        Console.WriteLine("3: Cadastrar Turma");
        Console.WriteLine("4: Listar Professores");
        Console.WriteLine("5: Listar Alunos");
        Console.WriteLine("6: Listar Turmas");
        Console.WriteLine("7: Remover");
        Console.WriteLine("0: Sair");
    }

    public void CadastrarProfessor()
    {
        Console.Write("Digite o nome do Professor: ");
        string nomeProfessor = Console.ReadLine();
        professores.Add(nomeProfessor);
        Console.WriteLine("Professor cadastrado com sucesso!");
    }

    public void CadastrarAluno()
    {
        Console.Write("Digite o nome do Aluno: ");
        string nomeAluno = Console.ReadLine();
        alunos.Add(nomeAluno);
        Console.WriteLine("Aluno cadastrado com sucesso!");
    }

    public void CadastrarTurma()
    {
        Console.Write("Digite o nome da Turma: ");
        string nomeTurma = Console.ReadLine();
        turmas.Add(nomeTurma);
        Console.WriteLine("Turma cadastrada com sucesso!");
    }

    public void ListarProfessores()
    {
        Console.WriteLine("\nProfessores cadastrados:");
        foreach (var professor in professores)
        {
            Console.WriteLine(professor);
        }
    }

    public void ListarAlunos()
    {
        Console.WriteLine("\nAlunos cadastrados:");
        foreach (var aluno in alunos)
        {
            Console.WriteLine(aluno);
        }
    }

    public void ListarTurmas()
    {
        Console.WriteLine("\nTurmas cadastradas:");
        foreach (var turma in turmas)
        {
            Console.WriteLine(turma);
        }
    }

    public void Remover()
    {
        Console.Write("Digite o nome do aluno ou professor para remover: ");
        string nomeRemover = Console.ReadLine();
        if (alunos.Contains(nomeRemover))
        {
            alunos.Remove(nomeRemover);
            Console.WriteLine("Aluno removido com sucesso!");
        }
        else if (professores.Contains(nomeRemover))
        {
            professores.Remove(nomeRemover);
            Console.WriteLine("Professor removido com sucesso!");
        }
        else
        {
            Console.WriteLine("Nome não encontrado.");
        }
    }

    public void Executar()
    {
        int opcao;
        do
        {
            ExibirOpcoes();
            Console.Write("Escolha uma opção: ");
            if (int.TryParse(Console.ReadLine(), out opcao))
            {
                switch (opcao)
                {
                    case 1:
                        CadastrarProfessor();
                        break;
                    case 2:
                        CadastrarAluno();
                        break;
                    case 3:
                        CadastrarTurma();
                        break;
                    case 4:
                        ListarProfessores();
                        break;
                    case 5:
                        ListarAlunos();
                        break;
                    case 6:
                        ListarTurmas();
                        break;
                    case 7:
                        Remover();
                        break;
                    case 0:
                        Console.WriteLine("Saindo...");
                        break;
                    default:
                        Console.WriteLine("Opção inválida. Tente novamente.");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Entrada inválida. Digite um número.");
            }
        } while (opcao != 0);
    }

    public static void Main()
    {
        GerenciamentoEscolar sistema = new GerenciamentoEscolar();
        sistema.Executar();
    }
}
