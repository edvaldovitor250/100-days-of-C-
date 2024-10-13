using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Day052
{
    public class GerenciarBiblioteca
    {
        List<string>livros;
        List<DateTime> datas

        public GerenciarBiblioteca(){
            livros = new List<string>();
            datas = new List<DateTime>();
        }

        public void EmprestimoLivro(string livro, DateTime data){
            livros.Add(livro);
            datas.Add(data);
            Console.WriteLine(livro + " emprestado em " + data);
        }

        public void DevolucaoLivro(string livro){
            livros.Add(livro);

            Console.WriteLine(livro + " devolvido.");
        }

        public void ReservarLivro(string livro, DateTime data){

            if(datas.Contains(livro)){
                livros.Add(livro);
                datas.Add(data);
            }
            else{
                Console.WriteLine(livro + "Livro já esta reservado");
            }


    }


    public void ListarLivros()
{
    List<string> livros = new List<string>
    {
        "O Senhor dos Anéis",
        "1984",
        "Dom Quixote",
        "O Hobbit"
    };

    List<DateTime> datas = new List<DateTime>
    {
        new DateTime(1954, 7, 29), 
        new DateTime(1949, 6, 8),  
        new DateTime(1605, 1, 16),
        new DateTime(1937, 9, 21)
    };

    if (livros.Count == datas.Count)
    {
        for (int i = 0; i < livros.Count; i++)
        {
            Console.WriteLine($"Livro: {livros[i]}, Data de Publicação: {datas[i].ToShortDateString()}");
        }
    }
    else
    {
        Console.WriteLine("O número de livros e datas não coincide.");
    }
}

    }
}