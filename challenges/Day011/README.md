# Day 11

## Desafio:

Crie uma classe em C# para representar um sistema de gestão de estoque com operações de adicionar, remover e atualizar itens.

**Resultado:**


```cshap
using System;
using System.Collections.Generic;

namespace Day011
{
    public class GestaoEstoque
    {
        public List<string> Produto { get; set; }
        public List<int> ProdutoValor { get; set; }

        public GestaoEstoque()
        {
            Produto = new List<string>();
            ProdutoValor = new List<int>();
        }

        public void ListarEstoque()
        {
            Console.WriteLine("Estoque:");
            for (int i = 0; i < Produto.Count; i++)
            {
                Console.WriteLine($"Nome: {Produto[i]}, Valor: {ProdutoValor[i]}");
            }
        }

        public void AdicionarEstoque(string nomeProduto, int valorProduto)
        {
            Produto.Add(nomeProduto);
            ProdutoValor.Add(valorProduto);
            Console.WriteLine($"Produto {nomeProduto} adicionado ao estoque. Valor: {valorProduto}");
        }

        public void RemoverPedido()
        {
            if (Produto.Count == 0)
            {
                Console.WriteLine("Não há produtos no estoque.");
                return;
            }
            Console.Write("Digite o nome do produto que deseja remover: ");
            string nomeRemovido = Console.ReadLine();
            int indiceRemovido = Produto.IndexOf(nomeRemovido);
            if (indiceRemovido == -1)
            {
                Console.WriteLine($"Produto {nomeRemovido} não encontrado.");
                return;
            }
            Produto.RemoveAt(indiceRemovido);
            ProdutoValor.RemoveAt(indiceRemovido);
            Console.WriteLine($"Produto {nomeRemovido} removido do estoque.");
        }

        public void AtualizarProduto()
        {
            if (Produto.Count == 0)
            {
                Console.WriteLine("Não há produtos no estoque.");
                return;
            }
            Console.Write("Digite o nome do produto que deseja atualizar: ");
            string nomeAtualizado = Console.ReadLine();
            int indiceAtualizado = Produto.IndexOf(nomeAtualizado);
            if (indiceAtualizado == -1)
            {
                Console.WriteLine($"Produto {nomeAtualizado} não encontrado.");
                return;
            }
            Console.Write("Digite o novo nome do produto: ");
            string novoNome = Console.ReadLine();
            Console.Write("Digite o novo valor do produto: ");
            int novoValor = Convert.ToInt32(Console.ReadLine());
            Produto[indiceAtualizado] = novoNome;
            ProdutoValor[indiceAtualizado] = novoValor;
            Console.WriteLine($"Produto {nomeAtualizado} atualizado para {novoNome} com valor {novoValor}.");
        }
    }
}

using Day011;

 GestaoEstoque g2 = new GestaoEstoque();

            g2.AdicionarEstoque("Laptop", 3500);
            g2.AdicionarEstoque("Smartphone", 2000);
            g2.AdicionarEstoque("Tablet", 1500);

            g2.ListarEstoque();

            g2.AtualizarProduto();

            g2.ListarEstoque();

            g2.RemoverPedido();

            g2.ListarEstoque();