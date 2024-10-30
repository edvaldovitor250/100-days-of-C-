# Day 69

## Desafio:

	Escreva um programa C# que implemente um sistema de gerenciamento de projetos, com funcionalidades para criar, editar e acompanhar o progresso de projetos.

**Resultado:**

```cshap

using System;
using System.Collections.Generic;

public class GerenciamentoProjetos
{
    List<string> projetos = new List<string>();
    List<string> versaos = new List<string>();
    List<string> descricaos = new List<string>();

    public void AdicionarProjeto(string nome, string versao, string descricao)
    {
        projetos.Add(nome);
        versaos.Add(versao);
        descricaos.Add(descricao);
    }

    public void EditarProjeto(int index, string upname, string upversao, string updescricao)
    {
        if (index >= 0 && index < projetos.Count)
        {
            projetos[index] = upname;
            versaos[index] = upversao;
            descricaos[index] = updescricao;
        }
        else
        {
            Console.WriteLine("Índice de projeto inválido.");
        }
    }

    public void VerProgresso()
    {
        Console.WriteLine("Progresso dos projetos:");
        for (int i = 0; i < projetos.Count; i++)
        {
            Console.WriteLine($"{projetos[i]} - Versão: {versaos[i]}, Descrição: {descricaos[i]}");
        }
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        GerenciamentoProjetos gerenciamento = new GerenciamentoProjetos();

        gerenciamento.AdicionarProjeto("Projeto A", "1.0", "Descrição do Projeto A");
        gerenciamento.AdicionarProjeto("Projeto B", "1.1", "Descrição do Projeto B");

        Console.WriteLine("Antes da edição:");
        gerenciamento.VerProgresso();

        gerenciamento.EditarProjeto(0, "Projeto A Editado", "2.0", "Descrição Atualizada do Projeto A");

        Console.WriteLine("\nDepois da edição:");
        gerenciamento.VerProgresso();
    }
}
