# Day 37

## Desafio:

	Escreva um programa C# que simule uma rede social básica, permitindo que os usuários se cadastrem, adicionem amigos e compartilhem mensagens.

**Resultado:**

```cshap

using System;
using System.Collections.Generic;

namespace RedeSocial
{
    public class Usuario
    {
        public string Nome { get; set; }

        private List<string> amigos = new List<string>();
        private List<string> mensagens = new List<string>();

        public Usuario(string nome)
        {
            Nome = nome;
        }

        public void EnviarMensagem(string amigo, string msg)
        {
            if (!amigos.Contains(amigo))
            {
                amigos.Add(amigo);
            }
            mensagens.Add($"{amigo}: {msg}");
            Console.WriteLine($"{Nome} enviou uma mensagem para {amigo}: {msg}");
        }

        public void AdicionarAmigo(string amigo)
        {
            if (!amigos.Contains(amigo))
            {
                amigos.Add(amigo);
                Console.WriteLine($"{Nome} adicionou {amigo} como amigo.");
            }
            else
            {
                Console.WriteLine($"{amigo} já é amigo de {Nome}.");
            }
        }

        public void ExibirAmigos()
        {
            Console.WriteLine($"\nAmigos de {Nome}:");
            foreach (var amigo in amigos)
            {
                Console.WriteLine($"- {amigo}");
            }
        }

        public void ExibirMensagens()
        {
            Console.WriteLine($"\nMensagens enviadas por {Nome}:");
            foreach (var mensagem in mensagens)
            {
                Console.WriteLine($"- {mensagem}");
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Usuario usuario1 = new Usuario("Alice");
            Usuario usuario2 = new Usuario("Bob");

            usuario1.AdicionarAmigo("Bob");
            usuario1.AdicionarAmigo("Charlie");

            usuario2.AdicionarAmigo("Alice");

            usuario1.EnviarMensagem("Bob", "Olá, Bob! Como você está?");
            usuario2.EnviarMensagem("Alice", "Oi, Alice! Tudo bem?");

            usuario1.ExibirAmigos();
            usuario2.ExibirAmigos();

            usuario1.ExibirMensagens();
            usuario2.ExibirMensagens();
        }
    }
}
