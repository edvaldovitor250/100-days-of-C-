using System;
using System.Collections.Generic;

namespace ParqueNacional
{
    class Program
    {
        static void Main(string[] args)
        {
            GerenciadorParque gerenciador = new GerenciadorParque();
            gerenciador.Iniciar();
        }
    }

    public class GerenciadorParque
    {
        private List<Trilha> trilhas;
        private List<Visitante> visitantes;
        private List<Conservacao> registrosConservacao;

        public GerenciadorParque()
        {
            trilhas = new List<Trilha>();
            visitantes = new List<Visitante>();
            registrosConservacao = new List<Conservacao>();
        }

        public void Iniciar()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Sistema de Gerenciamento do Parque Nacional");
                Console.WriteLine("1. Gerenciar Trilhas");
                Console.WriteLine("2. Gerenciar Visitantes");
                Console.WriteLine("3. Registrar Conservação");
                Console.WriteLine("4. Sair");
                Console.Write("Escolha uma opção: ");
                string opcao = Console.ReadLine();

                switch (opcao)
                {
                    case "1":
                        GerenciarTrilhas();
                        break;
                    case "2":
                        GerenciarVisitantes();
                        break;
                    case "3":
                        RegistrarConservacao();
                        break;
                    case "4":
                        return;
                    default:
                        Console.WriteLine("Opção inválida. Pressione qualquer tecla para continuar...");
                        Console.ReadKey();
                        break;
                }
            }
        }

        private void GerenciarTrilhas()
        {
            Console.Clear();
            Console.WriteLine("Gerenciamento de Trilhas");
            Console.WriteLine("1. Adicionar Trilha");
            Console.WriteLine("2. Listar Trilhas");
            Console.Write("Escolha uma opção: ");
            string opcao = Console.ReadLine();

            switch (opcao)
            {
                case "1":
                    Console.Write("Nome da trilha: ");
                    string nome = Console.ReadLine();
                    Console.Write("Dificuldade (Fácil, Médio, Difícil): ");
                    string dificuldade = Console.ReadLine();
                    trilhas.Add(new Trilha(nome, dificuldade));
                    Console.WriteLine("Trilha adicionada com sucesso!");
                    break;
                case "2":
                    Console.WriteLine("Lista de Trilhas:");
                    foreach (var trilha in trilhas)
                    {
                        Console.WriteLine($"- {trilha.Nome} (Dificuldade: {trilha.Dificuldade})");
                    }
                    break;
                default:
                    Console.WriteLine("Opção inválida.");
                    break;
            }

            Console.WriteLine("Pressione qualquer tecla para voltar...");
            Console.ReadKey();
        }

        private void GerenciarVisitantes()
        {
            Console.Clear();
            Console.WriteLine("Gerenciamento de Visitantes");
            Console.WriteLine("1. Registrar Visitante");
            Console.WriteLine("2. Listar Visitantes");
            Console.Write("Escolha uma opção: ");
            string opcao = Console.ReadLine();

            switch (opcao)
            {
                case "1":
                    Console.Write("Nome do visitante: ");
                    string nome = Console.ReadLine();
                    Console.Write("Idade do visitante: ");
                    int idade = int.Parse(Console.ReadLine());
                    visitantes.Add(new Visitante(nome, idade));
                    Console.WriteLine("Visitante registrado com sucesso!");
                    break;
                case "2":
                    Console.WriteLine("Lista de Visitantes:");
                    foreach (var visitante in visitantes)
                    {
                        Console.WriteLine($"- {visitante.Nome} (Idade: {visitante.Idade})");
                    }
                    break;
                default:
                    Console.WriteLine("Opção inválida.");
                    break;
            }

            Console.WriteLine("Pressione qualquer tecla para voltar...");
            Console.ReadKey();
        }

        private void RegistrarConservacao()
        {
            Console.Clear();
            Console.WriteLine("Registro de Conservação");
            Console.Write("Descrição da atividade: ");
            string descricao = Console.ReadLine();
            Console.Write("Data da atividade (dd/mm/yyyy): ");
            DateTime data = DateTime.Parse(Console.ReadLine());
            registrosConservacao.Add(new Conservacao(descricao, data));
            Console.WriteLine("Registro de conservação adicionado com sucesso!");

            Console.WriteLine("Pressione qualquer tecla para voltar...");
            Console.ReadKey();
        }
    }

    public class Trilha
    {
        public string Nome { get; set; }
        public string Dificuldade { get; set; }

        public Trilha(string nome, string dificuldade)
        {
            Nome = nome;
            Dificuldade = dificuldade;
        }
    }

    public class Visitante
    {
        public string Nome { get; set; }
        public int Idade { get; set; }

        public Visitante(string nome, int idade)
        {
            Nome = nome;
            Idade = idade;
        }
    }

    public class Conservacao
    {
        public string Descricao { get; set; }
        public DateTime Data { get; set; }

        public Conservacao(string descricao, DateTime data)
        {
            Descricao = descricao;
            Data = data;
        }
    }
}
