using System;
using System.Collections.Generic;

public class GerenciamentoEsqui
{
    private List<string> pistas = new List<string>();
    private List<string> equipamentos = new List<string>();
    private List<string> aulas = new List<string>();

    public string Adicionar(string item)
    {
        if (item.Contains("pista"))
        {
            pistas.Add(item);
            return "Pista adicionada com sucesso.";
        }
        else if (item.Contains("equipamento"))
        {
            equipamentos.Add(item);
            return "Equipamento adicionado com sucesso.";
        }
        else if (item.Contains("aula"))
        {
            aulas.Add(item);
            return "Aula adicionada com sucesso.";
        }
        else
        {
            return "Item não corresponde a nenhum espaço reservado.";
        }
    }

    public string Remover(string item)
    {
        if (item.Contains("pista") && pistas.Remove(item))
        {
            return "Pista removida com sucesso.";
        }
        else if (item.Contains("equipamento") && equipamentos.Remove(item))
        {
            return "Equipamento removido com sucesso.";
        }
        else if (item.Contains("aula") && aulas.Remove(item))
        {
            return "Aula removida com sucesso.";
        }
        else
        {
            return "Item não encontrado ou não corresponde a nenhum espaço reservado.";
        }
    }

    public string Atualizar(string antigoItem, string novoItem)
    {
        if (Remover(antigoItem).Contains("sucesso"))
        {
            return Adicionar(novoItem);
        }
        else
        {
            return "Atualização falhou. Item antigo não encontrado.";
        }
    }

    public string Listar(string tipo)
    {
        if (tipo == "pista")
        {
            return pistas.Count > 0 ? string.Join(", ", pistas) : "Nenhuma pista encontrada.";
        }
        else if (tipo == "equipamento")
        {
            return equipamentos.Count > 0 ? string.Join(", ", equipamentos) : "Nenhum equipamento encontrado.";
        }
        else if (tipo == "aula")
        {
            return aulas.Count > 0 ? string.Join(", ", aulas) : "Nenhuma aula encontrada.";
        }
        else
        {
            return "Tipo inválido. Use 'pista', 'equipamento' ou 'aula'.";
        }
    }
}

public class Program
{
    public static void Main()
    {
        GerenciamentoEsqui gerenciamento = new GerenciamentoEsqui();

        Console.WriteLine("Bem-vindo ao Gerenciamento de Esqui!");

        while (true)
        {
            Console.WriteLine("\nEscolha uma opção:");
            Console.WriteLine("1 - Adicionar");
            Console.WriteLine("2 - Remover");
            Console.WriteLine("3 - Atualizar");
            Console.WriteLine("4 - Listar");
            Console.WriteLine("5 - Sair");

            Console.Write("Digite sua escolha: ");
            string escolha = Console.ReadLine();

            switch (escolha)
            {
                case "1":
                    Console.Write("Digite o item para adicionar: ");
                    string itemAdicionar = Console.ReadLine();
                    Console.WriteLine(gerenciamento.Adicionar(itemAdicionar));
                    break;

                case "2":
                    Console.Write("Digite o item para remover: ");
                    string itemRemover = Console.ReadLine();
                    Console.WriteLine(gerenciamento.Remover(itemRemover));
                    break;

                case "3":
                    Console.Write("Digite o item antigo: ");
                    string antigoItem = Console.ReadLine();
                    Console.Write("Digite o novo item: ");
                    string novoItem = Console.ReadLine();
                    Console.WriteLine(gerenciamento.Atualizar(antigoItem, novoItem));
                    break;

                case "4":
                    Console.Write("Digite o tipo para listar (pista, equipamento, aula): ");
                    string tipo = Console.ReadLine();
                    Console.WriteLine(gerenciamento.Listar(tipo));
                    break;

                case "5":
                    Console.WriteLine("Encerrando o programa...");
                    return;

                default:
                    Console.WriteLine("Opção inválida. Tente novamente.");
                    break;
            }
        }
    }
}
