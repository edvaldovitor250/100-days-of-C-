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