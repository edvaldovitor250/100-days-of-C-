# Day 97

## Desafio:

Escreva um programa C# que implemente um sistema de gerenciamento de uma escola de idiomas, permitindo gerenciar turmas, alunos e professores.	

**Resultado:**

```cshap

public class GerenciamentoIdiomas
{
    List<Alunos> alunos = new List<Alunos>();
    List<Professores> professores = new List<Professores>();
    List<Turmas> turmas = new List<Turmas>();

    public void Adicionar(Object obj)
    {
        if(obj is Alunos)
        {
            alunos.Add((Alunos)obj);
        }
        else if(obj is Professores)
        {
            professores.Add((Professores)obj);
        }
        else if(obj is Turmas)
        {
            turmas.Add((Turmas)obj);
        }
    }

    public void Remover(Object obj)
    {
        if(obj is Alunos)
        {
            alunos.Remove((Alunos)obj);
        }
        else if(obj is Professores)
        {
            professores.Remove((Professores)obj);
        }
        else if(obj is Turmas)
        {
            turmas.Remove((Turmas)obj);
        }
    }

    public void Atualizar(Object obj)
    {
        if(obj is Alunos)
        {
            alunos[alunos.IndexOf((Alunos)obj)] = (Alunos)obj;
        }
        else if(obj is Professores)
        {
            professores[professores.IndexOf((Professores)obj)] = (Professores)obj;
        }
        else if(obj is Turmas)
        {
            turmas[turmas.IndexOf((Turmas)obj)] = (Turmas)obj;
        }
    }

    public void Listar()
    {
        Console.WriteLine("Alunos:");
        foreach(var aluno in alunos)
        {
            Console.WriteLine(aluno);
        }

        Console.WriteLine("Professores:");
        foreach(var professor in professores)
        {
            Console.WriteLine(professor);
        }

        Console.WriteLine("Turmas:");
        foreach(var turma in turmas)
        {
            Console.WriteLine(turma);
        }
    }

    
}

public class Alunos
{
    public string Nome { get; set; }
    public int Idade { get; set; }

    public Alunos(string nome, int idade)
    {
        this.Nome = nome;
        this.Idade = idade;
    }
    
    public override string ToString()
    {
        return $"Nome: {Nome}, Idade: {Idade}";
    }
    
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Day097
{
    public class Professores
    {
        public string Nome { get; set; }
        public int Idade { get; set; }

        public Professores(string nome, int idade)
        {
            this.Nome = nome;
            this.Idade = idade;
        }

        public override string ToString()
        {
            return $"Nome: {Nome}, Idade: {Idade}";
        }
    }
} 

public class Turmas
{
    public string Nome { get; set; }
    public int serie { get; set; }
    public string turno { get; set; }

    public Turmas(string nome, int serie, string turno)
    {
        this.Nome = nome;
        this.serie = serie;
        this.turno = turno;
    }

    public override string ToString()
    {
        return $"Nome: {Nome}, Série: {serie}, Turno: {turno}";
    }

    


}