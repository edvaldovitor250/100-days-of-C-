using System;
using System.Collections.Generic;

public class GerencimentoEmpresa
{
    List<string> rotas = new List<string>();
    List<string> veiculos = new List<string>();
    List<string> motoristas = new List<string>();

    public void atualizar(object obj)
    {
        if (obj is string)
        {
            string nome = (string)obj;
            if (rotas.Contains(nome))
            {
                rotas.Remove(nome);
                Console.WriteLine($"Rota {nome} removida.");
            }
            else if (veiculos.Contains(nome))
            {
                veiculos.Remove(nome);
                Console.WriteLine($"Veículo {nome} removido.");
            }
            else if (motoristas.Contains(nome))
            {
                motoristas.Remove(nome);
                Console.WriteLine($"Motorista {nome} removido.");
            }
            else
            {
                Console.WriteLine($"Objeto {nome} não encontrado.");
            }
        }
    }

    public void adicionar(object obj)
    {
        if (obj is string)
        {
            string nome = (string)obj;
            if (!rotas.Contains(nome) && !veiculos.Contains(nome) && !motoristas.Contains(nome))
            {
                rotas.Add(nome); 
                Console.WriteLine($"Objeto {nome} adicionado.");
            }
            else
            {
                Console.WriteLine($"Objeto {nome} já existe.");
            }
        }
    }

    public void remover(object obj)
    {
        if (obj is string)
        {
            string nome = (string)obj;
            if (rotas.Contains(nome))
            {
                rotas.Remove(nome);
            }
            else if (veiculos.Contains(nome))
            {
                veiculos.Remove(nome);
            }
            else if (motoristas.Contains(nome))
            {
                motoristas.Remove(nome);
            }
            else
            {
                Console.WriteLine($"Objeto {nome} não encontrado.");
            }
        }
        else
        {
            Console.WriteLine("Objeto inválido.");
        }
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        GerencimentoEmpresa empresa = new GerencimentoEmpresa();

        empresa.adicionar("Rota A");
        empresa.adicionar("Veículo 1");
        empresa.adicionar("Motorista João");

        empresa.adicionar("Rota A");

        empresa.remover("Veículo 1");
        empresa.remover("Motorista João");

        empresa.remover("Rota B");

        empresa.atualizar("Rota A");

        empresa.atualizar("Veículo 2");

        Console.WriteLine("Operações concluídas.");
    }
}
