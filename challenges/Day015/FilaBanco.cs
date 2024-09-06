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