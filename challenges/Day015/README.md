# Day 15

## Desafio:

Implemente um programa C# que simule uma fila de banco, com operações de entrada e saída de clientes.

**Resultado:**


```cshap

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Day015
{
    public class FilaBanco
    {
        List<string> entrada = new List<string>();
        List<string> saida = new List<string>();


        public FilaBanco()
        {
            entrada = new List<string>();
            saida = new List<string>();
        }

        public void listarFila(){
            foreach (string entrar in entrada)
            {
                foreach (string saidar in saida)
                {
                    Console.WriteLine(" " + entrar);
                    Console.WriteLine(" " + saidar);
                }                
            }
        }

         
         public void entrarFila(string cliente){
            entrada.Add(cliente);
        }

         public void sairFila(){
            if(saida.Count > 0){
                saida.RemoveAt(0);
            }
        }
    }
}

using Day015;

FilaBanco filaBanco = new FilaBanco();

            filaBanco.entrarFila("Cliente 1");
            filaBanco.entrarFila("Cliente 2");
            filaBanco.entrarFila("Cliente 3");

            Console.WriteLine("Fila de clientes:");
            filaBanco.listarFila();

            filaBanco.sairFila();

            Console.WriteLine("\nFila após a saída de um cliente:");
            filaBanco.listarFila();