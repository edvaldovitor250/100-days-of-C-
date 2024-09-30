# Day 39

## Desafio:

	Crie um sistema C# para gerenciar uma loja online, com funcionalidades de adicionar produtos ao carrinho, fazer pedidos e calcular o total da compra.

**Resultado:**

```cshap

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Day039
{
    public class lojaOnline
    {
        List<string> produtos;
        List<int> valors;

        public lojaOnline(){
            produtos = new List<string>();
            valors = new List<int>();
        }

        public void AddProdutos(string produto, int valor){
            produtos.Add(produto);
            valors.Add(valor);
            Console.WriteLine(produto + " " + valor);
        }

        public void calcularTotal(){
            int soma = 0;

            foreach (var item in valors)
            {
              soma += item;
            }
             Console.WriteLine("Valor total dos produtos: " + soma);
        }

    }
}

lojaOnline minhaLoja = new lojaOnline();

            minhaLoja.AddProdutos("Notebook", 2500);
            minhaLoja.AddProdutos("Smartphone", 1500);
            minhaLoja.AddProdutos("Headphone", 300);

            minhaLoja.calcularTotal();