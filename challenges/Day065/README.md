# Day 65

## Desafio:

    Escreva um programa C# que implemente um sistema de gerenciamento de inventário para um supermercado.

**Resultado:**

```cshap

public class GerencimanetoSupermercado {

    List<string> produtos = new List<string>();
    List<int> precos = new List<int>();

    public void AdicionarProduto(string nome, int preco) {
        produtos.Add(nome);
        precos.Add(preco);
    }

    public List<string> Produtos()
    {
        List<string> listaProdutos = new List<string>();
        
        for (int i = 0; i < produtos.Count; i++)
        {
            listaProdutos.Add($"{produtos[i]} - R$ {precos[i]}");
        }
        
        return listaProdutos;
    }
}