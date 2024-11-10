using System;
using System.Collections.Generic;

public class GerenciamnetoParque
{
    List<string> ingressos = new List<string>();
    List<string> atracoes = new List<string>();

    public void AdicionarIngresso(string ingresso)
    {
        ingressos.Add(ingresso);
    }

    public void AdicionarAtracoes(string a)
    {
        atracoes.Add(a);
    }

    public void ListarIngressos()
    {
        foreach (var item in ingressos)
        {
            Console.WriteLine(item);
        }
    }

    public void ListarAtracoes()
    {
        foreach (var item in atracoes)
        {
            Console.WriteLine(item);
        }
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        GerenciamnetoParque gerenciador = new GerenciamnetoParque();

        gerenciador.AdicionarIngresso("Ingresso VIP");
        gerenciador.AdicionarIngresso("Ingresso Normal");

        gerenciador.AdicionarAtracoes("Montanha Russa");
        gerenciador.AdicionarAtracoes("Roda Gigante");

        Console.WriteLine("Ingressos Disponíveis:");
        gerenciador.ListarIngressos();

        Console.WriteLine("\nAtrações Disponíveis:");
        gerenciador.ListarAtracoes();
    }
}
