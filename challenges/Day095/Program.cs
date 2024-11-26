using System;
using System.Collections.Generic;

public class Eventos
{
    public string Cliente { get; set; }
    public string Fornecedores { get; set; }
    public string Evento { get; set; }
}

public class GerenciamentoEmpresaEventos
{
    private readonly List<Eventos> eventos = new List<Eventos>();

    public void AdicionarEventos(string cliente, string fornecedores, string evento)
    {
        if (string.IsNullOrWhiteSpace(cliente) || string.IsNullOrWhiteSpace(fornecedores) || string.IsNullOrWhiteSpace(evento))
        {
            Console.WriteLine("Erro: Todos os campos devem ser preenchidos.");
            return;
        }

        eventos.Add(new Eventos { Cliente = cliente, Fornecedores = fornecedores, Evento = evento });
        Console.WriteLine($"Evento '{evento}' adicionado com sucesso.");
    }

    public List<Eventos> ListarEventos()
    {
        return eventos;
    }

    public void RemoverEventos(string evento)
    {
        int removidos = eventos.RemoveAll(e => e.Evento.Equals(evento, StringComparison.OrdinalIgnoreCase));
        if (removidos > 0)
        {
            Console.WriteLine($"Evento '{evento}' removido com sucesso.");
        }
        else
        {
            Console.WriteLine($"Erro: Evento '{evento}' não encontrado.");
        }
    }
}

public class Program
{
    public static void Main()
    {
        var gerenciamento = new GerenciamentoEmpresaEventos();
        bool continuar = true;

        while (continuar)
        {
            Console.WriteLine("\n--- Gerenciamento de Eventos ---");
            Console.WriteLine("1. Adicionar Evento");
            Console.WriteLine("2. Listar Eventos");
            Console.WriteLine("3. Remover Evento");
            Console.WriteLine("4. Sair");
            Console.Write("Escolha uma opção: ");
            string opcao = Console.ReadLine();

            switch (opcao)
            {
                case "1":
                    Console.Write("Digite o nome do cliente: ");
                    string cliente = Console.ReadLine();
                    Console.Write("Digite o fornecedor: ");
                    string fornecedor = Console.ReadLine();
                    Console.Write("Digite o nome do evento: ");
                    string evento = Console.ReadLine();
                    gerenciamento.AdicionarEventos(cliente, fornecedor, evento);
                    break;

                case "2":
                    Console.WriteLine("\n--- Lista de Eventos ---");
                    var eventos = gerenciamento.ListarEventos();
                    if (eventos.Count > 0)
                    {
                        foreach (var e in eventos)
                        {
                            Console.WriteLine($"Cliente: {e.Cliente}, Fornecedor: {e.Fornecedores}, Evento: {e.Evento}");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Nenhum evento cadastrado.");
                    }
                    break;

                case "3":
                    Console.Write("Digite o nome do evento a ser removido: ");
                    string eventoRemover = Console.ReadLine();
                    gerenciamento.RemoverEventos(eventoRemover);
                    break;

                case "4":
                    Console.WriteLine("Saindo do sistema...");
                    continuar = false;
                    break;

                default:
                    Console.WriteLine("Opção inválida. Tente novamente.");
                    break;
            }
        }
    }
}
