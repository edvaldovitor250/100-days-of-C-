using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Day050
{
    public class GerenciaProjetos
    {
        List<string> software;
        List<string> versao;

        public GerenciaProjetos(){
            software = new List<string>();
            versao = new List<string>();
        }

        public void AdicionarSoftware(string nome, string versao)
         {
            if (nome == null || versao == null)
            {
                Console.WriteLine("Nome ou versão não podem ser nulos");
            }
            else if (!software.Contains(nome)) 
            {
                software.Add(nome);
                this.versao.Add(versao); 
            }
            else
            {
                Console.WriteLine("Software já existe na lista");
            }
        }
        public void ControlerSotf(string versoes)
         {
            foreach (var item in versao)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("Última versão do software: " + versao.Last());

            Console.WriteLine("Software com versões anteriores à " + versoes + ":");
            foreach (var item in versao.Where(x => x.CompareTo(versoes) < 0))
            {
                Console.WriteLine(item);
            }
        }

        public void HistoricoVersao(){
            foreach (var item in software){
                Console.WriteLine(item.ToString());
            }
        }

        public void Relatorio()
      {
            for (int i = 0; i < software.Count; i++)
            {
                Console.WriteLine("Software: " + software[i]);
                Console.WriteLine("Versão: " + versao[i]);
            }
        }


    }
}