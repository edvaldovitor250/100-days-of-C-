using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Day020
{
    public class GerenciamentoProduto
    {
    
        List<string> produtos;
        List<int> precos;

        public GerenciamentoProduto(){
            produtos = new List<string>();
            precos = new List<int>();
        }

        public void AdicionarProduto(string nome, int preco){
            produtos.Add(nome);
            precos.Add(preco);
        }

        public void RemoverProduto(string nome){
            int index = produtos.IndexOf(nome);
            if (index >= 0) {
                produtos.RemoveAt(index);
                precos.RemoveAt(index);
            }
            else {
                Console.WriteLine("Produto não encontrado.");
            }
        }
        
        public void AtualizarPreco(string nome, int novoPreco){
            int index = produtos.IndexOf(nome);
            if (index >= 0) {
                precos[index] = novoPreco;
            }
            else {
                Console.WriteLine("Produto não encontrado.");
            }
        }
        
        public void ListarProdutos(){
            for (int i = 0; i < produtos.Count; i++){
                Console.WriteLine($"{produtos[i]} - {precos[i]}");
            }
            Console.WriteLine("\n");
        }
    }
}