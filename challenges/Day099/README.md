# Day 99

## Desafio:

Desenvolva um aplicativo em C# que implemente um sistema de gerenciamento de uma fazenda, permitindo gerenciar produção, estoque e vendas de produtos agrícolas.	

**Resultado:**

```cshap


public class SistemaDeProducao
{
    List<string> producoes = new List<string>();
    List<string> estoques = new List<string>();
    List<string> vendas  = new List<string>();

    
    public void Adicionar(string tipo, string item)
    {
        if (tipo.ToLower() == "producao")
        {
            producao.Add(item);
        }
        else if (tipo.ToLower() == "estoque")
        {
            estoque.Add(item);
        }
        else if (tipo.ToLower() == "vendas")
        {
            vendas.Add(item);
        }
    }

    public void Remover(string tipo, string item)
    {
        if (tipo.ToLower() == "producao")
        {
            producao.Remove(item);
        }
        else if (tipo.ToLower() == "estoque")
        {
            estoque.Remove(item);
        }
        else if (tipo.ToLower() == "vendas")
        {
            vendas.Remove(item);
        }
    }

    public void Atualizar(string tipo, string antigo, string novo)
    {
        if (tipo.ToLower() == "producao")
        {
            int index = producao.IndexOf(antigo);
            if (index != -1)
            {
                producao[index] = novo;
            }
        }
        else if (tipo.ToLower() == "estoque")
        {
            int index = estoque.IndexOf(antigo);
            if (index != -1)
            {
                estoque[index] = novo;
            }
        }
        else if (tipo.ToLower() == "vendas")
        {
            int index = vendas.IndexOf(antigo);
            if (index != -1)
            {
                vendas[index] = novo;
            }
        }
    }

    public void Listar()
    {
        Console.WriteLine("Produção:");
        foreach (var item in producao)
        {
            Console.WriteLine(item);
        }

        Console.WriteLine("Estoque:");
        foreach (var item in estoque)
        {
            Console.WriteLine(item);
        }

        Console.WriteLine("Vendas:");
        foreach (var item in vendas)
        {
            Console.WriteLine(item);
        }
    }

}