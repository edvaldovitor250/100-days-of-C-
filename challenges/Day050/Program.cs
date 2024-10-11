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
