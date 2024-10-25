using System;
using System.Collections.Generic;
using System.Linq;

public class Produto
{
    public int Id { get; set; }
    public string Nome { get; set; }
    public string Tamanho { get; set; }
    public decimal Preco { get; set; }
    public int Quantidade { get; set; }

    public Produto(int id, string nome, string tamanho, decimal preco, int quantidade)
    {
        Id = id;
        Nome = nome;
        Tamanho = tamanho;
        Preco = preco;
        Quantidade = quantidade;
    }

    public override string ToString()
    {
        return $"ID: {Id}, Nome: {Nome}, Tamanho: {Tamanho}, Preço: {Preco:C}, Quantidade: {Quantidade}";
    }
}

public class Estoque
{
    private List<Produto> produtos = new List<Produto>();

    public void AdicionarProduto(Produto produto)
    {
        produtos.Add(produto);
        Console.WriteLine("Produto adicionado com sucesso!");
    }

    public Produto BuscarProduto(int id)
    {
        return produtos.FirstOrDefault(p => p.Id == id);
    }

    public void ExibirEstoque()
    {
        Console.WriteLine("\nEstoque Atual:");
        foreach (var produto in produtos)
        {
            Console.WriteLine(produto);
        }
    }

    public bool AtualizarQuantidade(int id, int quantidade)
    {
        var produto = BuscarProduto(id);
        if (produto != null)
        {
            produto.Quantidade += quantidade;
            return true;
        }
        return false;
    }
}

public class Loja
{
    private Estoque estoque;

    public Loja(Estoque estoque)
    {
        this.estoque = estoque;
    }

    public void ProcessarVenda(int id, int quantidade)
    {
        var produto = estoque.BuscarProduto(id);
        if (produto == null)
        {
            Console.WriteLine("Produto não encontrado.");
            return;
        }

        if (produto.Quantidade >= quantidade)
        {
            produto.Quantidade -= quantidade;
            decimal totalVenda = produto.Preco * quantidade;
            Console.WriteLine($"Venda realizada! Total: {totalVenda:C}");
        }
        else
        {
            Console.WriteLine("Quantidade insuficiente em estoque.");
        }
    }
}

public class Program
{
    static void Main()
    {
        Estoque estoque = new Estoque();
        Loja loja = new Loja(estoque);

        bool sair = false;
        while (!sair)
        {
            Console.WriteLine("\n=== Sistema de Gerenciamento de Loja de Roupas ===");
            Console.WriteLine("1. Adicionar Produto");
            Console.WriteLine("2. Exibir Estoque");
            Console.WriteLine("3. Atualizar Estoque");
            Console.WriteLine("4. Processar Venda");
            Console.WriteLine("5. Sair");
            Console.Write("Escolha uma opção: ");
            int opcao = int.Parse(Console.ReadLine());

            switch (opcao)
            {
                case 1:
                    Console.Write("Digite o ID do produto: ");
                    int id = int.Parse(Console.ReadLine());
                    Console.Write("Digite o nome do produto: ");
                    string nome = Console.ReadLine();
                    Console.Write("Digite o tamanho do produto: ");
                    string tamanho = Console.ReadLine();
                    Console.Write("Digite o preço do produto: ");
                    decimal preco = decimal.Parse(Console.ReadLine());
                    Console.Write("Digite a quantidade em estoque: ");
                    int quantidade = int.Parse(Console.ReadLine());

                    Produto novoProduto = new Produto(id, nome, tamanho, preco, quantidade);
                    estoque.AdicionarProduto(novoProduto);
                    break;

                case 2:
                    estoque.ExibirEstoque();
                    break;

                case 3:
                    Console.Write("Digite o ID do produto para atualizar: ");
                    int idAtualizar = int.Parse(Console.ReadLine());
                    Console.Write("Digite a quantidade a adicionar (ou subtrair): ");
                    int qtdAtualizar = int.Parse(Console.ReadLine());

                    if (estoque.AtualizarQuantidade(idAtualizar, qtdAtualizar))
                        Console.WriteLine("Estoque atualizado com sucesso!");
                    else
                        Console.WriteLine("Produto não encontrado.");
                    break;

                case 4:
                    Console.Write("Digite o ID do produto para venda: ");
                    int idVenda = int.Parse(Console.ReadLine());
                    Console.Write("Digite a quantidade a vender: ");
                    int qtdVenda = int.Parse(Console.ReadLine());

                    loja.ProcessarVenda(idVenda, qtdVenda);
                    break;

                case 5:
                    sair = true;
                    Console.WriteLine("Saindo do sistema...");
                    break;

                default:
                    Console.WriteLine("Opção inválida. Tente novamente.");
                    break;
            }
        }
    }
}
