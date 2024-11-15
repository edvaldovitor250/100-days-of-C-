using System;
using System.Collections.Generic;

public class GerenciarGaleria
{
    List<string> artistas = new List<string>();
    List<string> artes = new List<string>();

    public void adicionar(string nome)
    {
        if (!artistas.Contains(nome))
        {
            artistas.Add(nome);
            Console.WriteLine($"Artista '{nome}' adicionado à galeria.");
        }
        else
        {
            Console.WriteLine($"Artista '{nome}' já existe na lista de artistas.");
        }

        if (!artes.Contains(nome))
        {
            artes.Add(nome);
            Console.WriteLine($"Arte '{nome}' adicionada à galeria.");
        }
        else
        {
            Console.WriteLine($"Arte '{nome}' já existe na lista de artes.");
        }
    }

    public void remover(string nome)
    {
        if (artistas.Contains(nome))
        {
            artistas.Remove(nome);
            Console.WriteLine($"Artista '{nome}' removido da galeria.");
        }
        else
        {
            Console.WriteLine($"Artista '{nome}' não encontrado na galeria.");
        }

        if (artes.Contains(nome))
        {
            artes.Remove(nome);
            Console.WriteLine($"Arte '{nome}' removida da galeria.");
        }
        else
        {
            Console.WriteLine($"Arte '{nome}' não encontrada na galeria.");
        }
    }

    public void atualizar(string nomeAntigo, string nomeNovo)
    {
        if (artistas.Contains(nomeAntigo))
        {
            int index = artistas.IndexOf(nomeAntigo);
            artistas[index] = nomeNovo;
            Console.WriteLine($"Artista '{nomeAntigo}' atualizado para '{nomeNovo}'.");
        }
        else
        {
            Console.WriteLine($"Artista '{nomeAntigo}' não encontrado na galeria.");
        }

        if (artes.Contains(nomeAntigo))
        {
            int index = artes.IndexOf(nomeAntigo);
            artes[index] = nomeNovo;
            Console.WriteLine($"Arte '{nomeAntigo}' atualizada para '{nomeNovo}'.");
        }
        else
        {
            Console.WriteLine($"Arte '{nomeAntigo}' não encontrada na galeria.");
        }
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        GerenciarGaleria galeria = new GerenciarGaleria();

        Console.WriteLine("Adicionando artistas e artes:");
        galeria.adicionar("Artista1");
        galeria.adicionar("Arte1");

        Console.WriteLine("\nTentando adicionar itens duplicados:");
        galeria.adicionar("Artista1");
        galeria.adicionar("Arte1");

        Console.WriteLine("\nRemovendo artistas e artes:");
        galeria.remover("Artista1");
        galeria.remover("Arte1");

        Console.WriteLine("\nTentando remover itens inexistentes:");
        galeria.remover("Artista2");
        galeria.remover("Arte2");

        galeria.adicionar("Artista3");
        galeria.adicionar("Arte3");

        Console.WriteLine("\nAtualizando artistas e artes:");
        galeria.atualizar("Artista3", "NovoArtista3");
        galeria.atualizar("Arte3", "NovaArte3");

        Console.WriteLine("\nTentando atualizar itens inexistentes:");
        galeria.atualizar("ArtistaInexistente", "NovoNome");
    }
}
