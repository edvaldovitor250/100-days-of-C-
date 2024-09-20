# Day 29

## Desafio:

Crie uma classe em C# para representar um sistema de gestão de pedidos com operações de adicionar, remover e atualizar informações dos pedidos.

**Resultado:**

```cshap


List<string> nomePedido = new List<string>();
List<int> valorPedido = new List<int>();

adicionarPedido("Produto 1", 100);
adicionarPedido("Produto 2", 200);

listarPedidos();

atualizarPedido("Produto 1", 150);

removerPedido("Produto 2");

listarPedidos();

static void adicionarPedido(string nome, int valor)
{
    nomePedido.Add(nome);
    valorPedido.Add(valor);

    Console.WriteLine("Pedido adicionado com sucesso!");
    Console.WriteLine($"Nome do produto: {nome}");
    Console.WriteLine($"Valor do produto: {valor}");
}

static void removerPedido(string nome)
{
    int index = nomePedido.IndexOf(nome);
    if (index >= 0)
    {
        nomePedido.RemoveAt(index);
        valorPedido.RemoveAt(index);
        Console.WriteLine("Pedido removido com sucesso!");
        Console.WriteLine($"Nome do produto removido: {nome}");
    }
    else
    {
        Console.WriteLine("Pedido não encontrado.");
    }
}

static void atualizarPedido(string nome, int novoValor)
{
    int index = nomePedido.IndexOf(nome);
    if (index >= 0)
    {
        valorPedido[index] = novoValor;
        Console.WriteLine("Pedido atualizado com sucesso!");
        Console.WriteLine($"Nome do produto: {nome}");
        Console.WriteLine($"Novo valor do produto: {novoValor}");
    }
    else
    {
        Console.WriteLine("Pedido não encontrado.");
    }
}

static void listarPedidos()
{
    Console.WriteLine("Pedidos:");
    for (int i = 0; i < nomePedido.Count; i++)
    {
        Console.WriteLine($"Nome do produto: {nomePedido[i]}");
        Console.WriteLine($"Valor do produto: {valorPedido[i]}");
        Console.WriteLine("--------------------");
    }
}