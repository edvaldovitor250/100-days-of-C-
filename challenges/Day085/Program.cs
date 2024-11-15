using System;
using System.Collections.Generic;

public class GerencimentoClube
{
    List<string> socios = new List<string>();
    List<string> atividades = new List<string>();

    public void adicionar(object obj)
    {
        if(obj is string nome)
        {
            if (!socios.Contains(nome))
            {
                socios.Add(nome);
                Console.WriteLine($"Socio {nome} adicionado ao clube.");
            }
            if(!atividades.Contains(nome))
            {
                atividades.Add(nome);
                Console.WriteLine($"Atividade '{nome}' adicionada ao clube.");
            }
        }
    }

    public void remover(object obj)
    {
        if(obj is string nome)
        {
            if (socios.Contains(nome))
            {
                socios.Remove(nome);
                Console.WriteLine($"Socio {nome} removido do clube.");
            }
            if(atividades.Contains(nome))
            {
                atividades.Remove(nome);
                Console.WriteLine($"Atividade '{nome}' removida do clube.");
            }
        }
    }

    public void atualizar(object obj)
    {
        if(obj is string nome)
        {
            if (socios.Contains(nome))
            {
                Console.WriteLine($"Socio {nome} atualizado no clube.");
            }
            if(atividades.Contains(nome))
            {
                Console.WriteLine($"Atividade '{nome}' atualizada no clube.");
            }
        }
    }

    public static void Main(string[] args)
    {
        GerencimentoClube clube = new GerencimentoClube();

        clube.adicionar("João");
        clube.adicionar("Futebol");

        clube.atualizar("João");
        clube.atualizar("Futebol");

        clube.remover("João");
        clube.remover("Futebol");
    }
}