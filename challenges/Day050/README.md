# Day 50

## Desafio:

Desenvolva um aplicativo C# que permita ao usuário criar e gerenciar projetos de software, com funcionalidades de controle de versões, histórico de commits e geração de relatórios.

**Resultado:**

```cshap

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

using System;
using Day050;

namespace Day050App
{
    class Program
    {
        static void Main(string[] args)
        {
            GerenciaProjetos gerencia = new GerenciaProjetos();

            gerencia.AdicionarSoftware("Software A", "1.0");
            gerencia.AdicionarSoftware("Software B", "2.1");
            gerencia.AdicionarSoftware("Software A", "1.1");
            gerencia.AdicionarSoftware("Software C", "3.0");

            Console.WriteLine("Histórico de Softwares:");
            gerencia.HistoricoVersao();

            Console.WriteLine("\nControle de versões anteriores à 2.0:");
            gerencia.ControlerSotf("2.0");

            Console.WriteLine("\nRelatório de Software e Versões:");
            gerencia.Relatorio();
        }
    }
}
