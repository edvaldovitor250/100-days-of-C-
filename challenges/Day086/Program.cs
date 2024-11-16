using System;
using System.Collections.Generic;

public class Material
{
    public string Nome { get; set; }
    public Material(string nome)
    {
        Nome = nome;
    }
}

public class Funcionario
{
    public string Nome { get; set; }
    public Funcionario(string nome)
    {
        Nome = nome;
    }
}

public class GerenciamentoConstrutora
{
    HashSet<string> materiais = new HashSet<string>();
    HashSet<string> funcionarios = new HashSet<string>();

    public void Adicionar(object objeto)
    {
        if (objeto is Material material)
        {
            materiais.Add(material.Nome);
        }
        else if (objeto is Funcionario funcionario)
        {
            funcionarios.Add(funcionario.Nome);
        }
    }

    public void Remover(object objeto)
    {
        if (objeto is Material material)
        {
            materiais.Remove(material.Nome);
        }
        else if (objeto is Funcionario funcionario)
        {
            funcionarios.Remove(funcionario.Nome);
        }
    }

    public void ListarMateriais()
    {
        foreach (var material in materiais)
        {
            Console.WriteLine(material);
        }
    }

    public void ListarFuncionarios()
    {
        foreach (var funcionario in funcionarios)
        {
            Console.WriteLine(funcionario);
        }
    }

    public static void Main(string[] args)
    {
        GerenciamentoConstrutora construtora = new GerenciamentoConstrutora();

        Material cimento = new Material("Cimento");
        Material areia = new Material("Areia");
        Funcionario joao = new Funcionario("João");
        Funcionario maria = new Funcionario("Maria");

        construtora.Adicionar(cimento);
        construtora.Adicionar(areia);
        construtora.Adicionar(joao);
        construtora.Adicionar(maria);

        Console.WriteLine("Materiais:");
        construtora.ListarMateriais();

        Console.WriteLine("\nFuncionários:");
        construtora.ListarFuncionarios();

        construtora.Remover(cimento);
        construtora.Remover(joao);

        Console.WriteLine("\nMateriais após remoção:");
        construtora.ListarMateriais();

        Console.WriteLine("\nFuncionários após remoção:");
        construtora.ListarFuncionarios();
    }
}