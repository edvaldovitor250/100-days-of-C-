# Day 26

## Desafio:

Crie uma classe em C# para representar um sistema de gestão de vendas com operações de adicionar, remover e atualizar informações das vendas.

**Resultado:**

```cshap

  string produtoAdicionado = adicionarProduto("ProdutoA", 100);
        Console.WriteLine("Produto adicionado: " + produtoAdicionado);

        string produtoAtualizado = atualizarValor("ProdutoA", 150);
        Console.WriteLine("Produto atualizado: " + produtoAtualizado);

        string produtoRemovido = removerProduto("ProdutoA");
        Console.WriteLine("Produto removido: " + produtoRemovido);


static string adicionarProduto (string nome, int valor){

    Console.WriteLine ("" + nome);
    Console.WriteLine ("" + valor);
   return nome + " " + valor;
}

static string removerProduto (string nome){
    return nome;
}

static string atualizarValor (string nome, int novoValor){
    return nome + " " + novoValor;
}