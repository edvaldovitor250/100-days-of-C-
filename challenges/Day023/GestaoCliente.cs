using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Day023
{
    public class GestaoCliente
    {
        List<string> nomeCliente = new List<string>();
        List<int> idadeCliente = new List<int>();

     public   void AddNomeCliente(string nome,int idade){
            nomeCliente.Add(nome);
            idadeCliente.Add(idade);
        }

     public   void RemoverNomeCliente(string nome){
            int index = nomeCliente.IndexOf(nome);
            if(index >= 0){
                nomeCliente.RemoveAt(index);
                idadeCliente.RemoveAt(index);
            }
        }

       public void ListarClientes(){
            for(int i = 0; i < nomeCliente.Count; i++){
                Console.WriteLine($"Nome: {nomeCliente[i]}, Idade: {idadeCliente[i]}");
            }
        }

    public    void atualizar(){
            Console.WriteLine("Qual cliente deseja atualizar?");
            string nome = Console.ReadLine();
            int index = nomeCliente.IndexOf(nome);
            if(index >= 0){
                Console.WriteLine("Digite a nova idade:");
                int novaIdade = int.Parse(Console.ReadLine());
                idadeCliente[index] = novaIdade;
            }
        }
    }
}