# Day 93

## Desafio:

Escreva um programa C# que implemente um sistema de gerenciamento de uma escola de música, permitindo gerenciar aulas, alunos e professores.

**Resultado:**

```cshap

using System;
using System.Collections.Generic;

public class GerenciamentoEscolaMusica
{
    private readonly List<string> aulas = new List<string>();
    private readonly List<string> alunos = new List<string>();
    private readonly List<string> professores = new List<string>();

    public void Adicionar(string item, string categoria)
    {
        if (string.IsNullOrWhiteSpace(item) || string.IsNullOrWhiteSpace(categoria))
        {
            Console.WriteLine("Item ou categoria inválidos.");
            return;
        }

        switch (categoria.ToLowerInvariant())
        {
            case "aula":
                aulas.Add(item);
                Console.WriteLine($"Aula adicionada: {item}");
                break;
            case "aluno":
                alunos.Add(item);
                Console.WriteLine($"Aluno adicionado: {item}");
                break;
            case "professor":
                professores.Add(item);
                Console.WriteLine($"Professor adicionado: {item}");
                break;
            default:
                Console.WriteLine("Categoria inválida! Use 'aula', 'aluno' ou 'professor'.");
                break;
        }
    }

    public void Remover(string item, string categoria)
    {
        if (string.IsNullOrWhiteSpace(item) || string.IsNullOrWhiteSpace(categoria))
        {
            Console.WriteLine("Item ou categoria inválidos.");
            return;
        }

        switch (categoria.ToLowerInvariant())
        {
            case "aula":
                if (aulas.Remove(item))
                    Console.WriteLine($"Aula removida: {item}");
                else
                    Console.WriteLine($"Aula não encontrada: {item}");
                break;
            case "aluno":
                if (alunos.Remove(item))
                    Console.WriteLine($"Aluno removido: {item}");
                else
                    Console.WriteLine($"Aluno não encontrado: {item}");
                break;
            case "professor":
                if (professores.Remove(item))
                    Console.WriteLine($"Professor removido: {item}");
                else
                    Console.WriteLine($"Professor não encontrado: {item}");
                break;
            default:
                Console.WriteLine("Categoria inválida! Use 'aula', 'aluno' ou 'professor'.");
                break;
        }
    }

    public void Atualizar(string itemAntigo, string itemNovo, string categoria)
    {
        if (string.IsNullOrWhiteSpace(itemAntigo) || string.IsNullOrWhiteSpace(itemNovo) || string.IsNullOrWhiteSpace(categoria))
        {
            Console.WriteLine("Parâmetros inválidos.");
            return;
        }

        switch (categoria.ToLowerInvariant())
        {
            case "aula":
                AtualizarItemNaLista(aulas, itemAntigo, itemNovo, "Aula");
                break;
            case "aluno":
                AtualizarItemNaLista(alunos, itemAntigo, itemNovo, "Aluno");
                break;
            case "professor":
                AtualizarItemNaLista(professores, itemAntigo, itemNovo, "Professor");
                break;
            default:
                Console.WriteLine("Categoria inválida! Use 'aula', 'aluno' ou 'professor'.");
                break;
        }
    }

    private void AtualizarItemNaLista(List<string> lista, string itemAntigo, string itemNovo, string tipo)
    {
        if (lista.Contains(itemAntigo))
        {
            lista[lista.IndexOf(itemAntigo)] = itemNovo;
            Console.WriteLine($"{tipo} atualizado: {itemAntigo} -> {itemNovo}");
        }
        else
        {
            Console.WriteLine($"{tipo} não encontrado: {itemAntigo}");
        }
    }

    public void Listar(string categoria)
    {
        if (string.IsNullOrWhiteSpace(categoria))
        {
            Console.WriteLine("Categoria inválida.");
            return;
        }

        switch (categoria.ToLowerInvariant())
        {
            case "aula":
                ListarItens(aulas, "Aulas");
                break;
            case "aluno":
                ListarItens(alunos, "Alunos");
                break;
            case "professor":
                ListarItens(professores, "Professores");
                break;
            default:
                Console.WriteLine("Categoria inválida! Use 'aula', 'aluno' ou 'professor'.");
                break;
        }
    }

    private void ListarItens(List<string> lista, string titulo)
    {
        Console.WriteLine($"\n{titulo}:");
        if (lista.Count == 0)
        {
            Console.WriteLine($"Nenhum {titulo.ToLower()} encontrado.");
        }
        else
        {
            foreach (var item in lista)
            {
                Console.WriteLine(item);
            }
        }
    }

     static void Main(string[] args)
    {
        var gerenciamento = new GerenciamentoEscolaMusica();

        Console.WriteLine("=== Gerenciamento de Escola de Música ===");

        gerenciamento.Adicionar("Aula de Piano", "aula");
        gerenciamento.Adicionar("Aula de Violão", "aula");
        gerenciamento.Adicionar("João Silva", "aluno");
        gerenciamento.Adicionar("Maria Souza", "aluno");
        gerenciamento.Adicionar("Professor Carlos", "professor");
        gerenciamento.Adicionar("Professor Ana", "professor");

        Console.WriteLine("\n=== Listagem Inicial ===");
        gerenciamento.Listar("aula");
        gerenciamento.Listar("aluno");
        gerenciamento.Listar("professor");

        gerenciamento.Atualizar("Aula de Piano", "Aula de Teclado", "aula");
        gerenciamento.Atualizar("João Silva", "João Oliveira", "aluno");
        gerenciamento.Atualizar("Professor Carlos", "Professor Pedro", "professor");

        Console.WriteLine("\n=== Listagem Após Atualizações ===");
        gerenciamento.Listar("aula");
        gerenciamento.Listar("aluno");
        gerenciamento.Listar("professor");

        gerenciamento.Remover("Aula de Teclado", "aula");
        gerenciamento.Remover("Maria Souza", "aluno");
        gerenciamento.Remover("Professor Ana", "professor");

        Console.WriteLine("\n=== Listagem Após Remoções ===");
        gerenciamento.Listar("aula");
        gerenciamento.Listar("aluno");
        gerenciamento.Listar("professor");

        Console.WriteLine("\n=== Testando Categorias Inválidas ===");
        gerenciamento.Adicionar("Aula de Guitarra", "curso");
        gerenciamento.Remover("Aula de Guitarra", "curso");
        gerenciamento.Listar("curso");
    }
}
