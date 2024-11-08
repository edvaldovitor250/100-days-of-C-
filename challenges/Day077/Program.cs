using System;
using System.Collections.Generic;

public class GerenciamentoConteudo
{
    List<string> titulos = new List<string>();
    List<string> autores = new List<string>();
    List<int> lançamento = new List<int>();

    public void criarArtigos(string t, string a, int l)
    {
        if (t != null && a != null && l != 0)
        {
            titulos.Add(t);
            autores.Add(a);
            lançamento.Add(l);
        }
        else
        {
            Console.WriteLine("Erro: título, autor ou lançamento inválido.");
        }
    }

    public void atualizacaoArtigo(string t, string a, int l)
    {
        int index = titulos.IndexOf(t);

        if (index != -1)
        {
            titulos[index] = t;
            autores[index] = a;
            lançamento[index] = l;
        }
        else
        {
            Console.WriteLine("Erro: Artigo não encontrado.");
        }
    }

    public void publicarArtigo(string t, string a, int l)
    {
        int index = titulos.IndexOf(t);

        if (index != -1)
        {
            if (lançamento[index] >= 2020)
            {
                Console.WriteLine("Artigo publicado com sucesso.");
            }
            else
            {
                Console.WriteLine("Erro: Artigo não pode ser publicado ainda.");
            }
        }
        else
        {
            Console.WriteLine("Erro: Artigo não encontrado.");
        }
    }

    public static void Main(string[] args)
    {
        GerenciamentoConteudo gerenciamento = new GerenciamentoConteudo();

        gerenciamento.criarArtigos("Título 1", "Autor 1", 2023);
        gerenciamento.criarArtigos("Título 2", "Autor 2", 2018);

        gerenciamento.atualizacaoArtigo("Título 1", "Novo Autor 1", 2024);

        gerenciamento.publicarArtigo("Título 1", "Novo Autor 1", 2024);
        gerenciamento.publicarArtigo("Título 2", "Autor 2", 2018);
    }
}
